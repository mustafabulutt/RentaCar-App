using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace frmRent_aCar
{
    public partial class frmAracKiralama : DevExpress.XtraEditors.XtraForm
    {
        public frmAracKiralama()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(Properties.Settings.Default.DbConStr);
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();
        
            
        private void frmAracKiralama_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_Rent_aCarDataSet1.Musteri' table. You can move, or remove it, as needed.
            this.musteriTableAdapter.Fill(this._Rent_aCarDataSet1.Musteri);
            // TODO: This line of code loads data into the '_Rent_aCarDataSet.Arac' table. You can move, or remove it, as needed.
            this.aracTableAdapter.Fill(this._Rent_aCarDataSet.Arac);
            labelControl9.Text = DateTime.Now.ToShortDateString();

            try
            {
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();

                using (da.SelectCommand = new SqlCommand(@" SELECT        KiraID, TcKimlik, AracPlaka, VerisTarihi, AlisTarihi, VerisKm, Ucret, KmHakki
FROM            dbo.AracKira", baglanti))
                {
                    dt.Clear();
                    da.Fill(dt);
                    gcListe.DataSource = dt;
                }

            }
            catch (Exception hata)
            {

                XtraMessageBox.Show(hata.Message);
                
            }
        }

        private void btnKirala_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (string.IsNullOrWhiteSpace(txtKmHakki.Text))
                {
                    XtraMessageBox.Show("KM HAKKI BOŞ GEÇİLEMEZ");
                    txtKmHakki.Focus();
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtUcret.Text))
                {
                    XtraMessageBox.Show("KİRALAMA ÜCRETİ BOŞ GEÇİLEMEZ");
                    txtUcret.Focus();
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtVerisKm.Text))
                {
                    XtraMessageBox.Show("VERİŞ KM BOŞ GEÇİLEMEZ");
                    txtVerisKm.Focus();
                    return;
                }
                if (string.IsNullOrWhiteSpace(lkpAracPlaka.Text))
                {
                    XtraMessageBox.Show("ARAÇ PLAKA BOŞ GEÇİLEMEZ");
                    lkpAracPlaka.Focus();
                    return;
                }
                if (string.IsNullOrWhiteSpace(lkpTcKimlik.Text))
                {
                    XtraMessageBox.Show("TC KİMLİK NUMARASI BOŞ GEÇİLEMEZ");
                    lkpTcKimlik.Focus();
                    return;
                }
                if (string.IsNullOrWhiteSpace(deAlisTarihi.Text))
                {
                    XtraMessageBox.Show("ALIŞ TARİHİ BOŞ GEÇİLEMEZ");
                    deAlisTarihi.Focus();
                    return;
                }
                if (string.IsNullOrWhiteSpace(deVerisTarihi.Text))
                {
                    MessageBox.Show("VERİŞ TARİHİ BOŞ GEÇİLEMEZ");
                    deVerisTarihi.Focus();
                    return;
                }

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = baglanti;
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = @"Insert Into AracKira( TcKimlik, AracPlaka, VerisTarihi, AlisTarihi, VerisKm, Ucret, KmHakki) values ( @TcKimlik, @AracPlaka, @VerisTarihi, @AlisTarihi, @VerisKm, @Ucret, @KmHakki)";

                cmd.Parameters.Add("@TcKimlik", SqlDbType.NVarChar).Value = lkpTcKimlik.Text;
                cmd.Parameters.Add("@AracPlaka", SqlDbType.NVarChar).Value = lkpAracPlaka.Text;
                cmd.Parameters.Add("@VerisTarihi", SqlDbType.DateTime).Value = deVerisTarihi.Text;
                cmd.Parameters.Add("@AlisTarihi", SqlDbType.DateTime).Value = deAlisTarihi.Text;
                cmd.Parameters.Add("@VerisKm", SqlDbType.NVarChar).Value = txtVerisKm.Text;
                cmd.Parameters.Add("@Ucret", SqlDbType.Int).Value = txtUcret.Text;
                cmd.Parameters.Add("@KmHakki", SqlDbType.NVarChar).Value = txtKmHakki.Text;

                cmd.ExecuteNonQuery();
                XtraMessageBox.Show("ARAÇ KİRALAMA İŞLEMİ BAŞARIYLA KAYDEDİLMİŞTİR");
                this.DialogResult = DialogResult.OK;
                txtKmHakki.Text = "";
                txtUcret.Text = "";
                txtVerisKm.Text = "";
                deAlisTarihi.Text = "";
                deVerisTarihi.Text = "";


                dt.Clear();
                da.Fill(dt);




            }
            catch (Exception hata)
            {

                MessageBox.Show(hata.Message);
            }
            
        }

        private void gridLookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (XtraMessageBox.Show("Seçili Aracı silmek istediğinize emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
                    return;

                using (SqlCommand cmd = new SqlCommand(@"Delete From AracKira Where KiraID=@KiraID", baglanti))
                {
                    cmd.Parameters.Add("@KiraID", SqlDbType.Int).Value = gvListe.GetFocusedRowCellDisplayText(colKiraID);
                    cmd.ExecuteNonQuery();
                }
                XtraMessageBox.Show("Araç Kiradan Kaldırıldı");
                dt.Clear();
                da.Fill(dt);
            }
            catch (Exception hata)
            {

                MessageBox.Show(hata.Message);
            }
        }
    }
    
}