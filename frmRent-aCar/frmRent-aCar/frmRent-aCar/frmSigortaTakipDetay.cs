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
  public partial class frmSigortaTakipDetay : DevExpress.XtraEditors.XtraForm
  {
    public frmSigortaTakipDetay(string AracID)
    {
      InitializeComponent();
      _AracID = AracID;
    }
    string _AracID = "-1";
    SqlConnection baglanti = new SqlConnection(Properties.Settings.Default.DbConStr);
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
          cmd.CommandText = @"Insert Into Arac(SigortaBitisTarihi) values (@SigortaBitisTarihi)";
        }
        else
        {
          cmd.CommandText = @"Update Arac SET SigortaBitisTarihi=@SigortaBitisTarihi Where AracID=@AracID";
          cmd.Parameters.Add("AracID", SqlDbType.Int).Value = _AracID;
        }
        cmd.Parameters.Add("@SigortaBitisTarihi", SqlDbType.DateTime).Value = dateEdit1.DateTime;
        cmd.ExecuteNonQuery();
        XtraMessageBox.Show("Kaydetme İşlemi Başarılı");
        this.DialogResult = DialogResult.OK;
      }
      catch (Exception hata)
      {

        MessageBox.Show(hata.Message);
      }


    }
    private void frmSigortaTakipDetay_Load(object sender, EventArgs e)
    {
      try
      {
        if (baglanti.State == ConnectionState.Closed)
          baglanti.Open();
        using (SqlCommand cmd = new SqlCommand(@"SELECT        AracID, AracTanim, SigortaBitisTarihi
FROM            dbo.Arac Where AracID=@AracID ", baglanti))
        {
          cmd.Parameters.Add("@AracID", SqlDbType.Int).Value = _AracID;
          using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleResult))
          {
            if (dr.Read())
            {
              dateEdit1.Text = dr["SigortaBitisTarihi"].ToString();
            }
          }
        }
      }
      catch (Exception hata)
      {

        XtraMessageBox.Show(hata.Message);
      }
    }

    private void btnIptal_Click(object sender, EventArgs e)
    {
      this.Close();
    }
  }
}