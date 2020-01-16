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

namespace frmRent_aCar
{
  public partial class frmAracListe : DevExpress.XtraEditors.XtraForm
  {
    public frmAracListe()
    {
      InitializeComponent();
    }
    SqlConnection baglanti = new SqlConnection(Properties.Settings.Default.DbConStr);
    SqlDataAdapter da = new SqlDataAdapter();
    DataTable dt = new DataTable();
        bool kirada = false;
    private void panelControl1_Paint(object sender, PaintEventArgs e)
    {

    }

    private void gcListe_Click(object sender, EventArgs e)
    {

    }

    private void frmAracListe_Load(object sender, EventArgs e)
    {
     try
        {
        if (baglanti.State == ConnectionState.Closed)
          baglanti.Open();

        using (da.SelectCommand= new SqlCommand (@"Select AracID, AracTanim, AracPlaka ,  Renk ,YakitTuru, KasaTipi ,UretimYili From Arac Order by AracTanim ASC", baglanti))
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

    private void btnKapat_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void btnEkle_Click(object sender, EventArgs e)
    {
      frmAracListeDetay frmAracListeDetay = new frmAracListeDetay("-1");
      if (frmAracListeDetay.ShowDialog() == DialogResult.OK)
      {
        dt.Clear();
        da.Fill(dt);
      }
    }

    private void btnSil_Click(object sender, EventArgs e)
    {
      try
      {
        if (XtraMessageBox.Show("Seçili Aracı silmek istediğinize emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
          return;

        using (SqlCommand cmd = new SqlCommand(@"Delete From Arac Where AracID=@AracID", baglanti))
        {
          cmd.Parameters.Add("@AracID", SqlDbType.Int).Value = gvListe.GetFocusedRowCellDisplayText(colAracID);
          cmd.ExecuteNonQuery();
        }
        XtraMessageBox.Show("Silme işlemi başarılı");
        dt.Clear();
        da.Fill(dt);
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
      frmAracListeDetay frmAracListeDetay = new frmAracListeDetay(gvListe.GetFocusedRowCellDisplayText(colAracID));
      if (frmAracListeDetay.ShowDialog()==DialogResult.OK)
      {
        dt.Clear();
        da.Fill(dt);
        gvListe.FocusedRowHandle = seciliSatirIndisi;
      }
    }
  }
}