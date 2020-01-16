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

namespace frmRent_aCar
{
    public partial class frmMusterilerDetay : DevExpress.XtraEditors.XtraForm
    {
        public frmMusterilerDetay(string MusteriID)
        {
            InitializeComponent();
            _MusteriID = MusteriID;
        }
        string _MusteriID = "-1";
        SqlConnection baglanti = new SqlConnection(Properties.Settings.Default.DbConStr);

        private void frmMusterilerDetay_Load(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                }
                if (_MusteriID != "-1")
                {
                    using (SqlCommand cmd = new SqlCommand(@"SELECT     MusteriTc=@MusteriTc   MusteriID=@MusteriID, MusteriAdSoyad=@MusteriAdSoyad, MusteriTelefon=@MusteriTelefon, MusteriAdres=@MusteriAdres, MusteriEhliyetNo=@MusteriEhliyetNo, MusteriYas=@MusteriYas
FROM            dbo.Musteri", baglanti))
                    {
                        cmd.Parameters.Add("@MusteriID", SqlDbType.Int).Value = _MusteriID;
                        using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleResult))
                        {
                            if (dr.Read())
                            {
                                txtAdres.Text = dr["MusteriAdres"].ToString();
                                txtTelefon.Text = dr["MusteriTelefon"].ToString();
                                txtEhliyetNo.Text = dr["MusteriEhliyetNo"].ToString();
                                txtYas.Text = dr["MusteriYas"].ToString();
                                txtAdSoyad.Text = dr["MusteriAdSoyad"].ToString();
                                txtMusteriTc.Text = dr["txtMusteriTc"].ToString();
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
                if (string.IsNullOrWhiteSpace(txtAdres.Text))
                {
                    MessageBox.Show("ADRES BOŞ GEÇİLEMEZ");
                    txtAdres.Focus();
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtAdSoyad.Text))
                {
                    MessageBox.Show("AD SOYAD BOŞ GEÇİLEMEZ");
                    txtAdSoyad.Focus();
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtEhliyetNo.Text))
                {
                    MessageBox.Show("EHLİYET NO BOŞ GEÇİLEMEZ");
                    txtEhliyetNo.Focus();
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtTelefon.Text))
                {
                    MessageBox.Show("TELEFON BOŞ GEÇİLEMEZ");
                    txtTelefon.Focus();
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtMusteriTc.Text))
                {
                    MessageBox.Show("Müşteri tc kimlik numarası boş geçilemez");
                    txtMusteriTc.Focus();
                    return;
                }
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = baglanti;
                cmd.CommandType = CommandType.Text;

                if (_MusteriID == "-1")
                {
                    cmd.CommandText = @"Insert Into Musteri(MusteriYas, MusteriEhliyetNo, MusteriTc,MusteriAdres, MusteriTelefon, MusteriAdSoyad) values(@MusteriYas, @MusteriEhliyetNo, @MusteriTc, @MusteriAdres, @MusteriTelefon, @MusteriAdSoyad )";
                }
                else
                {
                    cmd.CommandText = @"Update Musteri SET MusteriYas=@MusteriYas,MusteriTc=@MusteriTc , MusteriEhliyetNo=@MusteriEhliyetNo, MusteriAdres=@MusteriAdres, MusteriTelefon=@MusteriTelefon,MusteriAdSoyad=@MusteriAdSoyad  Where MarkaID=@MarkaID";
                    cmd.Parameters.Add("@MusteriID", SqlDbType.Int).Value = _MusteriID;
                }
                cmd.Parameters.Add("@MusteriYas", SqlDbType.NVarChar).Value = txtYas.Text;
                cmd.Parameters.Add("@MusteriEhliyetNo", SqlDbType.NVarChar).Value = txtEhliyetNo.Text;
                cmd.Parameters.Add("@MusteriAdres", SqlDbType.NVarChar).Value = txtAdres.Text;
                cmd.Parameters.Add("@MusteriTelefon", SqlDbType.NVarChar).Value = txtTelefon.Text;
                cmd.Parameters.Add("@MusteriAdSoyad", SqlDbType.NVarChar).Value = txtAdSoyad.Text;
                cmd.Parameters.Add("@MusteriTc", SqlDbType.NVarChar).Value = txtMusteriTc.Text;
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
    }
}