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
  public partial class frmBakimKMDetay : DevExpress.XtraEditors.XtraForm
  {
    public frmBakimKMDetay(string AracID)
    {
      InitializeComponent();
      _AracID = AracID;
    }
    string _AracID = "-1";
    SqlConnection baglanti = new SqlConnection(Properties.Settings.Default.DbConStr);


    private void frmBakimKMDetay_Load(object sender, EventArgs e)
    {
      try
      {
        if (baglanti.State==ConnectionState.Closed)
        {
          baglanti.Open();
        }
        using (SqlCommand cmd = new SqlCommand(@"SELECT        AracID, AracTanim, GelecekBakimKM
FROM            dbo.Arac Where AracID=@AracID",baglanti))
        {
          cmd.Parameters.Add("@AracID", SqlDbType.Int).Value = _AracID;
          using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleResult))
          {
            if (dr.Read())
            {
              txtGelecekBakimKM.Text = dr["GelecekBakimKM"].ToString();
            }
          }

        }

        
      }
      catch (Exception hata)
      {

        XtraMessageBox.Show(hata.Message);
      }
    }

    private void btnKaydet_Click(object sender, EventArgs e)
    {
      try
      {
        if (string.IsNullOrWhiteSpace(txtGelecekBakimKM.Text))
        {
          MessageBox.Show("Gelecek Bakim KM  Boş Geçilemez, Lütfen KM Giriniz");
          txtGelecekBakimKM.Focus();
          return;
        }
        if (baglanti.State == ConnectionState.Closed)
          baglanti.Open();
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = baglanti;
        cmd.CommandType = CommandType.Text;
        if (_AracID == "-1")
        {
          cmd.CommandText = @"Insert Into Arac(GelecekBakimKM) values (@GelecekBakimKM)";
        }
        else
        {
          cmd.CommandText = @"Update Arac SET GelecekBakimKM=@GelecekBakimKM Where AracID=@AracID";
          cmd.Parameters.Add("AracID", SqlDbType.Int).Value = _AracID;
        }
        cmd.Parameters.Add("@GelecekBakimKM", SqlDbType.NVarChar).Value =txtGelecekBakimKM.Text;
        cmd.ExecuteNonQuery();
        XtraMessageBox.Show("Kaydetme İşlemi Başarılı");
        this.DialogResult = DialogResult.OK;
      }
      catch (Exception hata)
      {

        MessageBox.Show(hata.Message);
      }
    }

    private void btnIptal_Click(object sender, EventArgs e)
    {
      this.Close();
    }
  }
}