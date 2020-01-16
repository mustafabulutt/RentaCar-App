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
  public partial class frmKaskoTakipDetay : DevExpress.XtraEditors.XtraForm
  {
    public frmKaskoTakipDetay(string AracID)
    {
      InitializeComponent();
      _AracID = AracID;
    }
    string _AracID = "-1";
    SqlConnection baglanti = new SqlConnection(Properties.Settings.Default.DbConStr);
    private void frmKaskoTakipDetay_Load(object sender, EventArgs e)
    {
      try
      {
        if (baglanti.State == ConnectionState.Closed) ;
        baglanti.Open();
        using (SqlCommand cmd = new SqlCommand(@"SELECT        AracID, AracTanim, KaskoBitisTarihi
FROM            dbo.Arac Where AracID=@AracID", baglanti))
        {
          cmd.Parameters.Add("@AracID", SqlDbType.Int).Value = _AracID;
          using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleResult))
          {
            if (dr.Read())
            {
              dateEdit1.Text = dr["KaskoBitisTarihi"].ToString();
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
        if (baglanti.State == ConnectionState.Closed)
          baglanti.Open();
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = baglanti;
        cmd.CommandType = CommandType.Text;
        if (_AracID == "-1")
        {
          cmd.CommandText = @"Insert Into Arac(KaskoBitisTarihi) values (@KaskoBitisTarihi)";
        }
        else
        {
          cmd.CommandText = @"Update Arac SET KaskoBitisTarihi=@KaskoBitisTarihi Where AracID=@AracID";
          cmd.Parameters.Add("AracID", SqlDbType.Int).Value = _AracID;
        }
        cmd.Parameters.Add("@KaskoBitisTarihi", SqlDbType.DateTime).Value = dateEdit1.DateTime;
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