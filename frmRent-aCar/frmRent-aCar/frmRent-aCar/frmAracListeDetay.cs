using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Configuration;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraScheduler;

namespace frmRent_aCar
{
    public partial class frmAracListeDetay : DevExpress.XtraEditors.XtraForm
    {
        public frmAracListeDetay(string AracID)
        {
            InitializeComponent();
            _AracID = AracID;
        }

        string _AracID = "-1";
        SqlConnection baglanti = new SqlConnection(Properties.Settings.Default.DbConStr);


        private void labelControl2_Click(object sender, EventArgs e)
        {

        }

        private void frmAracListeDetay_Load(object sender, EventArgs e)
        {
            cmbKasaTipi.Items.Add("SEDAN");
            cmbKasaTipi.Items.Add("HatchBack");
            cmbYakitTipi.Items.Add("BENZİN");
            cmbYakitTipi.Items.Add("DİZEL");
            cmbYakitTipi.Items.Add("LPG");
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                }
                if (_AracID != "-1")
                {
                    using (SqlCommand cmd = new SqlCommand(@"Select AracTanim, AracPlaka , Renk ,YakitTuru, KasaTipi, UretimYili From Arac Where AracID=@AracID", baglanti))
                    {
                        cmd.Parameters.Add("@AracID", SqlDbType.Int).Value = _AracID;
                        using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleResult))
                        {
                            if (dr.Read())
                            {
                                txtEklenecekArac.Text = dr["AracTanim"].ToString();
                                txtAracPlaka.Text = dr["AracPlaka"].ToString();
                                txtRenk.Text = dr["Renk"].ToString();
                                txtUretimYili.Text = dr["UretimYili"].ToString();
                                cmbYakitTipi.Text = dr["YakitTuru"].ToString();
                                cmbKasaTipi.Text = dr["KasaTipi"].ToString();
                            }

                        }
                    }
                }
            }
            catch (Exception hata)
            {

                XtraMessageBox.Show(hata.Message);
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtEklenecekArac.Text))
                {
                    XtraMessageBox.Show("Eklenecek Araç Boş Geçilemez");
                    txtEklenecekArac.Focus();
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtAracPlaka.Text))
                {
                    XtraMessageBox.Show("Araç Plakası Boş Geçilemez");
                    txtAracPlaka.Focus();
                    return;
                }
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();

                if (string.IsNullOrWhiteSpace(txtUretimYili.Text))
                {
                    MessageBox.Show("Üretim Yılı Boş Geçilemez");
                    txtUretimYili.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtRenk.Text))
                {
                    MessageBox.Show("Araç Rengi Boş Geçilemez");
                    txtRenk.Focus();
                }

                if (string.IsNullOrWhiteSpace(cmbKasaTipi.Text))
                {
                    MessageBox.Show("Kasa Tipi Boş Geçilemez");
                    cmbKasaTipi.Focus();
                    return;
                }
                if (String.IsNullOrWhiteSpace(cmbYakitTipi.Text))
                {
                    MessageBox.Show("Yakit Tipi Boş Geçilemez");
                    cmbYakitTipi.Focus();
                    return;
                }

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = baglanti;
                cmd.CommandType = CommandType.Text;
                if (_AracID == "-1")
                {
                    cmd.CommandText = @"Insert Into Arac(AracTanim,AracPlaka,UretimYili,KasaTipi,YakitTuru,Renk) values (@AracTanim,@AracPlaka,@UretimYili,@KasaTipi,@YakitTuru,@Renk)";
                }
                else
                {
                    cmd.CommandText = @"Update Arac SET AracTanim=@AracTanim,AracPlaka=@AracPlaka,UretimYili=@UretimYili,KasaTipi=@KasaTipi,YakitTuru=@YakitTuru,Renk=@Renk Where AracID=@AracID";
                    cmd.Parameters.Add("AracID", SqlDbType.Int).Value = _AracID;

                }
                cmd.Parameters.Add("@AracTanim", SqlDbType.NVarChar).Value = txtEklenecekArac.Text;
                cmd.Parameters.Add("@AracPlaka", SqlDbType.NVarChar).Value = txtAracPlaka.Text;
                cmd.Parameters.Add("@Renk", SqlDbType.NVarChar).Value = txtRenk.Text;
                cmd.Parameters.Add("@UretimYili", SqlDbType.NVarChar).Value = txtUretimYili.Text;
                cmd.Parameters.Add("@KasaTipi", SqlDbType.NVarChar).Value = cmbKasaTipi.Text;
                cmd.Parameters.Add("@YakitTuru", SqlDbType.NVarChar).Value = cmbYakitTipi.Text;





                cmd.ExecuteNonQuery();
                XtraMessageBox.Show("Kaydetme İşlemi Başarılı");
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception hata)
            {

                XtraMessageBox.Show(hata.Message);
            }
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void txtEklenecekArac_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void cmbYakitTipi_SelectedIndexChanged(object sender, EventArgs e)
        {
          

        }
    }
}