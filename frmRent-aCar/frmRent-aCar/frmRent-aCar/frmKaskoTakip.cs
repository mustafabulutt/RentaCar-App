using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;

namespace frmRent_aCar
{
  public partial class frmKaskoTakip : DevExpress.XtraEditors.XtraForm
  {
    public frmKaskoTakip()
    {
      InitializeComponent();
    }
    SqlConnection baglanti = new SqlConnection(Properties.Settings.Default.DbConStr);
    SqlDataAdapter daKaskoTakip = new SqlDataAdapter();
    DataTable dtKaskoTakip = new DataTable();
    private void frmKaskoTakip_Load(object sender, EventArgs e)
    {
      try
      {
        if (baglanti.State == ConnectionState.Closed)
          baglanti.Open();

        using (daKaskoTakip.SelectCommand = new SqlCommand(@"SELECT      AracPlaka,  AracID, AracTanim, KaskoBitisTarihi
FROM            dbo.Arac", baglanti))
        {
          dtKaskoTakip.Clear();
          daKaskoTakip.Fill(dtKaskoTakip);
          gcListe.DataSource = dtKaskoTakip;
        }

       

      }
      catch (Exception hata)
      {

        MessageBox.Show(hata.Message);
      }
    }

    private void btnDegistir_Click(object sender, EventArgs e)
    {
      if (gvListe.FocusedRowHandle < 0)
        return;
      int seciliSatirIndisi = gvListe.FocusedRowHandle;
      frmKaskoTakipDetay frmKaskoTakipDetay = new frmKaskoTakipDetay(gvListe.GetFocusedRowCellDisplayText("AracID"));
      if (frmKaskoTakipDetay.ShowDialog() == DialogResult.OK)
      {
        dtKaskoTakip.Clear();
        daKaskoTakip.Fill(dtKaskoTakip);
      }
      gvListe.FocusedRowHandle = seciliSatirIndisi;
    }
  }
}