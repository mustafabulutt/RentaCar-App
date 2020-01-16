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
    public partial class frmKullaniciGiris : DevExpress.XtraEditors.XtraForm
    {
        public frmKullaniciGiris()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(Properties.Settings.Default.DbConStr);
        public string girisYapanKullanici = "";

        private void labelControl2_Click(object sender, EventArgs e)
        {

        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtKullaniciKodu.Text))
                {
                    MessageBox.Show("Kullanici Kodu Boş Geçilemez");
                    txtKullaniciKodu.Focus();
                }

                if (string.IsNullOrWhiteSpace(txtKullaniciSifre.Text))
                {
                    MessageBox.Show("Kullanici Sifre Boş Geçilemez");
                    txtKullaniciSifre.Focus();
                    return;
                }
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();
                using (SqlCommand cmd = new SqlCommand(@"Select KullaniciID, KullaniciAdSoyad From Kullanici Where KullaniciKodu=@KullaniciKodu AND KullaniciSifre=@KullaniciSifre", baglanti))
                {
                    cmd.Parameters.Add("@KullaniciKodu", SqlDbType.NVarChar).Value = txtKullaniciKodu.Text;
                    cmd.Parameters.Add("@KullaniciSifre", SqlDbType.NVarChar).Value = txtKullaniciSifre.Text;
                    using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleResult))
                    {
                        if (dr.Read())
                        {
                            girisYapanKullanici = dr["KullaniciAdSoyad"].ToString();
                        }
                    }

                    if (girisYapanKullanici == "")
                    {
                        MessageBox.Show("Kullanıcı Kodu veya şifre hatalı");
                        return;
                    }
                    if (girisYapanKullanici!="")
                    {
                        frmAracListe n = new frmAracListe();
                        n.lblGirisYapanKullanici.Text = girisYapanKullanici;
                    }
                    frmAnaForm frmAnaForm = new frmAnaForm();
                    frmAnaForm.FormClosing += FrmAnaForm_FormClosing;
                    this.Hide();
                    frmAnaForm.Show();

                   
                }
            }
            catch (Exception hata)
            {

                MessageBox.Show(hata.Message);
            }
        }
            private void FrmAnaForm_FormClosing(object sender, FormClosingEventArgs e)
        {
          
            this.Dispose();
        }

        private void frmKullaniciGiris_Load(object sender, EventArgs e)
        {

        }
    }
    
}