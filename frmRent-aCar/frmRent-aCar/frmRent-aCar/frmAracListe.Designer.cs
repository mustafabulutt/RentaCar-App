namespace frmRent_aCar
{
  partial class frmAracListe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAracListe));
            this.gcListe = new DevExpress.XtraGrid.GridControl();
            this.gvListe = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colAracID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAracTanim = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAracPlaka = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUretimYili = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKasaTipi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYakitTuru = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRenk = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKiradaOlanArac = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.lblGirisYapanKullanici = new System.Windows.Forms.Label();
            this.btnDegistir = new DevExpress.XtraEditors.SimpleButton();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnEkle = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gcListe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvListe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gcListe
            // 
            this.gcListe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcListe.Location = new System.Drawing.Point(0, 0);
            this.gcListe.MainView = this.gvListe;
            this.gcListe.Name = "gcListe";
            this.gcListe.Size = new System.Drawing.Size(775, 240);
            this.gcListe.TabIndex = 0;
            this.gcListe.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvListe});
            this.gcListe.Click += new System.EventHandler(this.gcListe_Click);
            // 
            // gvListe
            // 
            this.gvListe.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAracID,
            this.colAracTanim,
            this.colAracPlaka,
            this.colUretimYili,
            this.colKasaTipi,
            this.colYakitTuru,
            this.colRenk,
            this.colKiradaOlanArac});
            this.gvListe.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gvListe.GridControl = this.gcListe;
            this.gvListe.Name = "gvListe";
            this.gvListe.OptionsBehavior.AllowIncrementalSearch = true;
            this.gvListe.OptionsBehavior.Editable = false;
            this.gvListe.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gvListe.OptionsSelection.EnableAppearanceFocusedRow = false;
            this.gvListe.OptionsView.EnableAppearanceEvenRow = true;
            this.gvListe.OptionsView.EnableAppearanceOddRow = true;
            this.gvListe.OptionsView.ShowAutoFilterRow = true;
            this.gvListe.OptionsView.ShowFooter = true;
            // 
            // colAracID
            // 
            this.colAracID.Caption = "AracID";
            this.colAracID.FieldName = "AracID";
            this.colAracID.Name = "colAracID";
            // 
            // colAracTanim
            // 
            this.colAracTanim.Caption = "AracTanim";
            this.colAracTanim.FieldName = "AracTanim";
            this.colAracTanim.Name = "colAracTanim";
            this.colAracTanim.Visible = true;
            this.colAracTanim.VisibleIndex = 0;
            // 
            // colAracPlaka
            // 
            this.colAracPlaka.Caption = "AracPlaka";
            this.colAracPlaka.FieldName = "AracPlaka";
            this.colAracPlaka.Name = "colAracPlaka";
            this.colAracPlaka.Visible = true;
            this.colAracPlaka.VisibleIndex = 1;
            // 
            // colUretimYili
            // 
            this.colUretimYili.Caption = "UretimYili";
            this.colUretimYili.FieldName = "UretimYili";
            this.colUretimYili.Name = "colUretimYili";
            this.colUretimYili.Visible = true;
            this.colUretimYili.VisibleIndex = 2;
            // 
            // colKasaTipi
            // 
            this.colKasaTipi.Caption = "KasaTipi";
            this.colKasaTipi.FieldName = "KasaTipi";
            this.colKasaTipi.Name = "colKasaTipi";
            this.colKasaTipi.Visible = true;
            this.colKasaTipi.VisibleIndex = 3;
            // 
            // colYakitTuru
            // 
            this.colYakitTuru.Caption = "YakitTuru";
            this.colYakitTuru.FieldName = "YakitTuru";
            this.colYakitTuru.Name = "colYakitTuru";
            this.colYakitTuru.Visible = true;
            this.colYakitTuru.VisibleIndex = 4;
            // 
            // colRenk
            // 
            this.colRenk.Caption = "Renk";
            this.colRenk.FieldName = "Renk";
            this.colRenk.Name = "colRenk";
            this.colRenk.Visible = true;
            this.colRenk.VisibleIndex = 5;
            // 
            // colKiradaOlanArac
            // 
            this.colKiradaOlanArac.Caption = "KiradaOlanArac";
            this.colKiradaOlanArac.FieldName = "KiradaOlanArac";
            this.colKiradaOlanArac.Name = "colKiradaOlanArac";
            this.colKiradaOlanArac.Visible = true;
            this.colKiradaOlanArac.VisibleIndex = 6;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.lblGirisYapanKullanici);
            this.panelControl1.Controls.Add(this.btnDegistir);
            this.panelControl1.Controls.Add(this.btnSil);
            this.panelControl1.Controls.Add(this.btnEkle);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(775, 35);
            this.panelControl1.TabIndex = 1;
            this.panelControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.panelControl1_Paint);
            // 
            // lblGirisYapanKullanici
            // 
            this.lblGirisYapanKullanici.AutoSize = true;
            this.lblGirisYapanKullanici.ForeColor = System.Drawing.Color.Red;
            this.lblGirisYapanKullanici.Location = new System.Drawing.Point(337, 11);
            this.lblGirisYapanKullanici.Name = "lblGirisYapanKullanici";
            this.lblGirisYapanKullanici.Size = new System.Drawing.Size(35, 13);
            this.lblGirisYapanKullanici.TabIndex = 4;
            this.lblGirisYapanKullanici.Text = "label1";
            // 
            // btnDegistir
            // 
            this.btnDegistir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnDegistir.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDegistir.ImageOptions.Image")));
            this.btnDegistir.Location = new System.Drawing.Point(175, 6);
            this.btnDegistir.Name = "btnDegistir";
            this.btnDegistir.Size = new System.Drawing.Size(75, 23);
            this.btnDegistir.TabIndex = 2;
            this.btnDegistir.Text = "DEĞİŞTİR";
            this.btnDegistir.Click += new System.EventHandler(this.btnDegistir_Click);
            // 
            // btnSil
            // 
            this.btnSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSil.ImageOptions.Image")));
            this.btnSil.Location = new System.Drawing.Point(94, 6);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 1;
            this.btnSil.Text = "SİL";
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnEkle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEkle.ImageOptions.Image")));
            this.btnEkle.Location = new System.Drawing.Point(13, 6);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 0;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // frmAracListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 240);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.gcListe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAracListe";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.ShowMdiChildCaptionInParentTitle = true;
            this.Text = "frmAracListe";
            this.Load += new System.EventHandler(this.frmAracListe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcListe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvListe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.ResumeLayout(false);

    }

    #endregion

    private DevExpress.XtraGrid.GridControl gcListe;
    private DevExpress.XtraGrid.Views.Grid.GridView gvListe;
    private DevExpress.XtraEditors.PanelControl panelControl1;
    private DevExpress.XtraEditors.SimpleButton btnDegistir;
    private DevExpress.XtraEditors.SimpleButton btnSil;
    private DevExpress.XtraEditors.SimpleButton btnEkle;
    private DevExpress.XtraGrid.Columns.GridColumn colAracID;
    private DevExpress.XtraGrid.Columns.GridColumn colAracTanim;
        private DevExpress.XtraGrid.Columns.GridColumn colAracPlaka;
        private DevExpress.XtraGrid.Columns.GridColumn colUretimYili;
        private DevExpress.XtraGrid.Columns.GridColumn colKasaTipi;
        private DevExpress.XtraGrid.Columns.GridColumn colYakitTuru;
        private DevExpress.XtraGrid.Columns.GridColumn colRenk;
        private DevExpress.XtraGrid.Columns.GridColumn colKiradaOlanArac;
        public System.Windows.Forms.Label lblGirisYapanKullanici;
    }
}