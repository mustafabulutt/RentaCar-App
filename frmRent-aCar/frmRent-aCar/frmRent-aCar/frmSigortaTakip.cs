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
  public partial class frmSigortaTakip : DevExpress.XtraEditors.XtraForm
  {
    public frmSigortaTakip()
    {
      InitializeComponent();
    }
    SqlConnection baglanti = new SqlConnection(Properties.Settings.Default.DbConStr);
    SqlDataAdapter daSigorta = new SqlDataAdapter();
    DataTable dtSigorta = new DataTable();

    private void frmSigortaTakip_Load(object sender, EventArgs e)
    {
try
        {
        if (baglanti.State == ConnectionState.Closed)
          baglanti.Open();
        using (daSigorta.SelectCommand = new SqlCommand(@"SELECT       AracPlaka, AracID, AracTanim, SigortaBitisTarihi
FROM            dbo.Arac", baglanti))
{
          dtSigorta.Clear();
          daSigorta.Fill(dtSigorta);
          gcListe.DataSource = dtSigorta; 
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
      frmSigortaTakipDetay frmSigortaTakipDetay = new frmSigortaTakipDetay(gvListe.GetFocusedRowCellDisplayText("AracID"));
      if (frmSigortaTakipDetay.ShowDialog() == DialogResult.OK)
      {
        dtSigorta.Clear();
        daSigorta.Fill(dtSigorta);
      }
      gvListe.FocusedRowHandle = seciliSatirIndisi;
    }
  }
}