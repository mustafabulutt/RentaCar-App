using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace frmRent_aCar
{
  public partial class frmAnaForm : DevExpress.XtraBars.Ribbon.RibbonForm
  {
    public frmAnaForm()
    {
      InitializeComponent();
    }
    void FormAcMdiForm(Form gelenForm)
    {
      bool formVar = false;
      foreach (var item in this.MdiChildren)
      {
        if (gelenForm.Name == item.Name)
        {
          formVar = true;
          item.Activate();
          break;
        }
      }
      if (!formVar)
      {
        gelenForm.MdiParent = this;
        gelenForm.Show();
      }
    }
    private void btnAracListe_ItemClick(object sender, ItemClickEventArgs e)
    {
      frmAracListe frmAracListe = new frmAracListe();
      FormAcMdiForm(frmAracListe); 
    }

    private void btnMusteriKayit_ItemClick(object sender, ItemClickEventArgs e)
    {
      frmMusteriler frmMusteriler = new frmMusteriler();
      FormAcMdiForm(frmMusteriler);
    }

    private void btnSozlesme_ItemClick(object sender, ItemClickEventArgs e)
    {
      frmSozlesme frmSozlesme = new frmSozlesme();
      FormAcMdiForm(frmSozlesme);
    }

    private void btnBakımKM_ItemClick(object sender, ItemClickEventArgs e)
    {
      frmBakimKM frmBakimKM = new frmBakimKM();
      FormAcMdiForm(frmBakimKM);
    }

    private void btnKaskoTakip_ItemClick(object sender, ItemClickEventArgs e)
    {
      frmKaskoTakip frmKaskoTakip = new frmKaskoTakip();
      FormAcMdiForm(frmKaskoTakip);
    }

    private void frmAnaForm_Load(object sender, EventArgs e)
    {
          
    }

    private void btnSigortaTakip_ItemClick(object sender, ItemClickEventArgs e)
    {
      frmSigortaTakip frmSigortaTakip = new frmSigortaTakip();
      FormAcMdiForm(frmSigortaTakip);
    }

        private void btnAracKiralama_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmAracKiralama frmAracKiralama = new frmAracKiralama();
            FormAcMdiForm(frmAracKiralama);
        }

        private void btnMailGonder_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmMailGonder frmMailGonder = new frmMailGonder();
            FormAcMdiForm(frmMailGonder);
        }
    }
}