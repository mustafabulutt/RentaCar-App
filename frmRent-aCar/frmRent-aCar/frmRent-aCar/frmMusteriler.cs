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
  public partial class frmMusteriler : DevExpress.XtraEditors.XtraForm
  {
    public frmMusteriler()
    {
      InitializeComponent();
    }
    SqlConnection baglanti = new SqlConnection(Properties.Settings.Default.DbConStr);
    SqlDataAdapter daMusteri = new SqlDataAdapter();
    DataTable dtMusteri = new DataTable();
    bool yeniKayit = false;

    private void frmMusteriler_Load(object sender, EventArgs e)
    {
      try
      {
        if (baglanti.State == ConnectionState.Closed)
          baglanti.Open();

        using (daMusteri.SelectCommand = new SqlCommand(@"SELECT        MusteriID, MusteriTc , MusteriAdSoyad, MusteriTelefon, MusteriAdres, MusteriEhliyetNo, MusteriYas
FROM            dbo.Musteri", baglanti))
        {
          dtMusteri.Clear();
          daMusteri.Fill(dtMusteri);
          gcListe.DataSource = dtMusteri;
        }

      }
      catch (Exception hata)
      {

        XtraMessageBox.Show(hata.Message);
      }



    }


    private void btnAra_Click(object sender, EventArgs e)
    {

    }



    private void lkpMusteriBul_EditValueChanged(object sender, EventArgs e)
    {

    }

    private void btnKapat_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void simpleButton6_Click(object sender, EventArgs e)
    {
      if (baglanti.State == ConnectionState.Closed)
        baglanti.Open();

      using (daMusteri.SelectCommand = new SqlCommand(@"SELECT        MusteriID, MusteriAdSoyad,MusteriTc , MusteriTelefon, MusteriAdres, MusteriEhliyetNo, MusteriYas
FROM            dbo.Musteri", baglanti))
      {

        dtMusteri.Clear();
        daMusteri.Fill(dtMusteri);
      }
    }

    private void labelControl1_Click(object sender, EventArgs e)
    {

    }

    private void textEdit1_EditValueChanged(object sender, EventArgs e)
    {

    }

    private void btnEkle_Click(object sender, EventArgs e)
    {
      frmMusterilerDetay frmMusterilerDetay = new frmMusterilerDetay("-1");
      if (frmMusterilerDetay.ShowDialog() == DialogResult.OK)
      {
        dtMusteri.Clear();
        daMusteri.Fill(dtMusteri);
      }


    }

    private void btnSil_Click(object sender, EventArgs e)
    {
      try
      {
        if (gvListe.FocusedRowHandle < 0)
          return;

        if (XtraMessageBox.Show("Seçili satırı silmek istediğinize emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
          return;

        using (SqlCommand cmd = new SqlCommand(@"Delete From Musteri Where MusteriID=@MusteriID", baglanti))
        {
          cmd.Parameters.Add("@MusteriID", SqlDbType.Int).Value = gvListe.GetFocusedRowCellDisplayText(colMusteriID);
          cmd.ExecuteNonQuery();
        }
        XtraMessageBox.Show("Silme işlemi başarılı");
        simpleButton6_Click(null, null);
        
      }
      catch (Exception hata)
      {

        XtraMessageBox.Show(hata.Message);
      }
    }

    private void btnDegistir_Click(object sender, EventArgs e)
    {

    }

    private void btnKaydet_Click(object sender, EventArgs e)
    {
      try
      {

      }
      catch (Exception hata)
      {

        XtraMessageBox.Show(hata.Message);
      }
    }
  }
}