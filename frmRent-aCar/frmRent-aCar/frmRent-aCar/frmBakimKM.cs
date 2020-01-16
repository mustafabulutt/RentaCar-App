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
  public partial class frmBakimKM : DevExpress.XtraEditors.XtraForm
  {
    public frmBakimKM()
    {
      InitializeComponent();
    }
    SqlConnection baglanti = new SqlConnection(Properties.Settings.Default.DbConStr);
    SqlDataAdapter daBakim = new SqlDataAdapter();
    DataTable dtBakim = new DataTable();


    private void frmBakimKM_Load(object sender, EventArgs e)
    {
      try
      {
        if (baglanti.State == ConnectionState.Closed)
          baglanti.Open();

        using (daBakim.SelectCommand = new SqlCommand(@"SELECT     AracPlaka,   AracID, AracTanim, GelecekBakimKM
FROM            dbo.Arac", baglanti))
        {
          dtBakim.Clear();
          daBakim.Fill(dtBakim);
          gcListe.DataSource = dtBakim;
        }


      }
      catch (Exception hata)
      {

        XtraMessageBox.Show(hata.Message);
      }



    }

    private void btnDegistir_Click(object sender, EventArgs e)
    {
      if (gvListe.FocusedRowHandle < 0)
        return;
      int seciliSatirIndisi = gvListe.FocusedRowHandle;
      frmBakimKMDetay frmBakimKMDetay = new frmBakimKMDetay(gvListe.GetFocusedRowCellDisplayText("AracID"));
      if (frmBakimKMDetay.ShowDialog() == DialogResult.OK)
      {
        dtBakim.Clear();
        daBakim.Fill(dtBakim);
      }
      gvListe.FocusedRowHandle = seciliSatirIndisi;
    }
  }
}