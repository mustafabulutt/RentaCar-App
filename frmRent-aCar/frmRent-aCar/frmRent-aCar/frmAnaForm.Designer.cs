namespace frmRent_aCar
{
  partial class frmAnaForm
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAnaForm));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnAracListe = new DevExpress.XtraBars.BarButtonItem();
            this.btnMusteriler = new DevExpress.XtraBars.BarButtonItem();
            this.btnSozlesme = new DevExpress.XtraBars.BarButtonItem();
            this.btnBakımKM = new DevExpress.XtraBars.BarButtonItem();
            this.btnKaskoTakip = new DevExpress.XtraBars.BarButtonItem();
            this.btnSigortaTakip = new DevExpress.XtraBars.BarButtonItem();
            this.btnAracKiralama = new DevExpress.XtraBars.BarButtonItem();
            this.btnMailGonder = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.ımageList2 = new System.Windows.Forms.ImageList(this.components);
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.btnAracListe,
            this.btnMusteriler,
            this.btnSozlesme,
            this.btnBakımKM,
            this.btnKaskoTakip,
            this.btnSigortaTakip,
            this.btnAracKiralama,
            this.btnMailGonder});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 9;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.Size = new System.Drawing.Size(893, 143);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // btnAracListe
            // 
            this.btnAracListe.Caption = "ARAÇLAR";
            this.btnAracListe.Id = 1;
            this.btnAracListe.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            this.btnAracListe.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAracListe.ImageOptions.Image")));
            this.btnAracListe.Name = "btnAracListe";
            this.btnAracListe.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnAracListe.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAracListe_ItemClick);
            // 
            // btnMusteriler
            // 
            this.btnMusteriler.Caption = "MÜŞTERİLER";
            this.btnMusteriler.Id = 2;
            this.btnMusteriler.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnMusteriler.ImageOptions.Image")));
            this.btnMusteriler.Name = "btnMusteriler";
            this.btnMusteriler.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnMusteriler.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnMusteriKayit_ItemClick);
            // 
            // btnSozlesme
            // 
            this.btnSozlesme.Caption = "SÖZLEŞME";
            this.btnSozlesme.Id = 3;
            this.btnSozlesme.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSozlesme.ImageOptions.Image")));
            this.btnSozlesme.Name = "btnSozlesme";
            this.btnSozlesme.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnSozlesme.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSozlesme_ItemClick);
            // 
            // btnBakımKM
            // 
            this.btnBakımKM.Caption = "BAKIM KM\'LERİ";
            this.btnBakımKM.Id = 4;
            this.btnBakımKM.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBakımKM.ImageOptions.Image")));
            this.btnBakımKM.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnBakımKM.ImageOptions.LargeImage")));
            this.btnBakımKM.Name = "btnBakımKM";
            this.btnBakımKM.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBakımKM_ItemClick);
            // 
            // btnKaskoTakip
            // 
            this.btnKaskoTakip.Caption = "Kasko Takip";
            this.btnKaskoTakip.Id = 5;
            this.btnKaskoTakip.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKaskoTakip.ImageOptions.Image")));
            this.btnKaskoTakip.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnKaskoTakip.ImageOptions.LargeImage")));
            this.btnKaskoTakip.Name = "btnKaskoTakip";
            this.btnKaskoTakip.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnKaskoTakip_ItemClick);
            // 
            // btnSigortaTakip
            // 
            this.btnSigortaTakip.Caption = "SİGORTA TAKİP";
            this.btnSigortaTakip.Id = 6;
            this.btnSigortaTakip.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSigortaTakip.ImageOptions.Image")));
            this.btnSigortaTakip.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSigortaTakip.ImageOptions.LargeImage")));
            this.btnSigortaTakip.Name = "btnSigortaTakip";
            this.btnSigortaTakip.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSigortaTakip_ItemClick);
            // 
            // btnAracKiralama
            // 
            this.btnAracKiralama.Caption = "ARAÇ KİRALAMA";
            this.btnAracKiralama.Id = 7;
            this.btnAracKiralama.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAracKiralama.ImageOptions.Image")));
            this.btnAracKiralama.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnAracKiralama.ImageOptions.LargeImage")));
            this.btnAracKiralama.Name = "btnAracKiralama";
            this.btnAracKiralama.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAracKiralama_ItemClick);
            // 
            // btnMailGonder
            // 
            this.btnMailGonder.Caption = "POSTA GÖNDER";
            this.btnMailGonder.Id = 8;
            this.btnMailGonder.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnMailGonder.ImageOptions.Image")));
            this.btnMailGonder.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnMailGonder.ImageOptions.LargeImage")));
            this.btnMailGonder.Name = "btnMailGonder";
            this.btnMailGonder.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnMailGonder_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "ANA SAYFA";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnAracListe);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnMusteriler);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnSozlesme);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnBakımKM);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnKaskoTakip);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnSigortaTakip);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnMailGonder);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnAracKiralama);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 483);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(893, 31);
            // 
            // ımageList1
            // 
            this.ımageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ımageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // ımageList2
            // 
            this.ımageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ımageList2.ImageSize = new System.Drawing.Size(16, 16);
            this.ımageList2.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // frmAnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Stretch;
            this.BackgroundImageStore = global::frmRent_aCar.Properties.Resources.havalimani_rent_a_car;
            this.ClientSize = new System.Drawing.Size(893, 514);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Glow;
            this.IsMdiContainer = true;
            this.Name = "frmAnaForm";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "frmAnaForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmAnaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
    private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
    private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
    private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
    private DevExpress.XtraBars.BarButtonItem btnAracListe;
    private DevExpress.XtraBars.BarButtonItem btnMusteriler;
    private DevExpress.XtraBars.BarButtonItem btnSozlesme;
    private DevExpress.XtraBars.BarButtonItem btnBakımKM;
    private System.Windows.Forms.ImageList ımageList1;
    private System.Windows.Forms.ImageList ımageList2;
    private DevExpress.XtraBars.BarButtonItem btnKaskoTakip;
    private DevExpress.XtraBars.BarButtonItem btnSigortaTakip;
        private DevExpress.XtraBars.BarButtonItem btnAracKiralama;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.BarButtonItem btnMailGonder;
    }
}