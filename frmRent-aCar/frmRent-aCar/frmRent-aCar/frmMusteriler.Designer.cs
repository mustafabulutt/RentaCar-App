namespace frmRent_aCar
{
  partial class frmMusteriler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMusteriler));
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btnYenile = new DevExpress.XtraEditors.SimpleButton();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnEkle = new DevExpress.XtraEditors.SimpleButton();
            this.gcListe = new DevExpress.XtraGrid.GridControl();
            this.gvListe = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMusteriID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMusteriAdSoyad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMusteriTelefon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMusteriAdres = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMusteriEhliyetNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMusteriYas = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMusteriTc = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcListe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvListe)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.btnYenile);
            this.panelControl2.Controls.Add(this.btnSil);
            this.panelControl2.Controls.Add(this.btnEkle);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl2.Location = new System.Drawing.Point(0, 321);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(490, 38);
            this.panelControl2.TabIndex = 1;
            // 
            // btnYenile
            // 
            this.btnYenile.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnYenile.ImageOptions.Image")));
            this.btnYenile.Location = new System.Drawing.Point(410, 10);
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.Size = new System.Drawing.Size(75, 23);
            this.btnYenile.TabIndex = 5;
            this.btnYenile.Text = "YENİLE";
            this.btnYenile.Visible = false;
            this.btnYenile.Click += new System.EventHandler(this.simpleButton6_Click);
            // 
            // btnSil
            // 
            this.btnSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSil.ImageOptions.Image")));
            this.btnSil.Location = new System.Drawing.Point(86, 10);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 1;
            this.btnSil.Text = "SİL";
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEkle.ImageOptions.Image")));
            this.btnEkle.Location = new System.Drawing.Point(5, 10);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 0;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // gcListe
            // 
            this.gcListe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcListe.Location = new System.Drawing.Point(0, 0);
            this.gcListe.MainView = this.gvListe;
            this.gcListe.Name = "gcListe";
            this.gcListe.Size = new System.Drawing.Size(490, 321);
            this.gcListe.TabIndex = 2;
            this.gcListe.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvListe});
            // 
            // gvListe
            // 
            this.gvListe.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMusteriID,
            this.colMusteriAdSoyad,
            this.colMusteriTelefon,
            this.colMusteriAdres,
            this.colMusteriEhliyetNo,
            this.colMusteriYas,
            this.colMusteriTc});
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
            // colMusteriID
            // 
            this.colMusteriID.Caption = "MusteriID";
            this.colMusteriID.FieldName = "MusteriID";
            this.colMusteriID.Name = "colMusteriID";
            // 
            // colMusteriAdSoyad
            // 
            this.colMusteriAdSoyad.Caption = "MusteriAdSoyad";
            this.colMusteriAdSoyad.FieldName = "MusteriAdSoyad";
            this.colMusteriAdSoyad.Name = "colMusteriAdSoyad";
            this.colMusteriAdSoyad.Visible = true;
            this.colMusteriAdSoyad.VisibleIndex = 0;
            // 
            // colMusteriTelefon
            // 
            this.colMusteriTelefon.Caption = "MusteriTelefon";
            this.colMusteriTelefon.FieldName = "MusteriTelefon";
            this.colMusteriTelefon.Name = "colMusteriTelefon";
            this.colMusteriTelefon.Visible = true;
            this.colMusteriTelefon.VisibleIndex = 1;
            // 
            // colMusteriAdres
            // 
            this.colMusteriAdres.Caption = "MusteriAdres";
            this.colMusteriAdres.FieldName = "MusteriAdres";
            this.colMusteriAdres.Name = "colMusteriAdres";
            this.colMusteriAdres.Visible = true;
            this.colMusteriAdres.VisibleIndex = 2;
            // 
            // colMusteriEhliyetNo
            // 
            this.colMusteriEhliyetNo.Caption = "MusteriEhliyetNo";
            this.colMusteriEhliyetNo.FieldName = "MusteriEhliyetNo";
            this.colMusteriEhliyetNo.Name = "colMusteriEhliyetNo";
            this.colMusteriEhliyetNo.Visible = true;
            this.colMusteriEhliyetNo.VisibleIndex = 3;
            // 
            // colMusteriYas
            // 
            this.colMusteriYas.Caption = "MusteriYas";
            this.colMusteriYas.FieldName = "MusteriYas";
            this.colMusteriYas.Name = "colMusteriYas";
            this.colMusteriYas.Visible = true;
            this.colMusteriYas.VisibleIndex = 4;
            // 
            // colMusteriTc
            // 
            this.colMusteriTc.Caption = "MusteriTc";
            this.colMusteriTc.FieldName = "MusteriTc";
            this.colMusteriTc.Name = "colMusteriTc";
            this.colMusteriTc.Visible = true;
            this.colMusteriTc.VisibleIndex = 5;
            // 
            // frmMusteriler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 359);
            this.Controls.Add(this.gcListe);
            this.Controls.Add(this.panelControl2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMusteriler";
            this.Text = "frmMusteriler";
            this.Load += new System.EventHandler(this.frmMusteriler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcListe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvListe)).EndInit();
            this.ResumeLayout(false);

    }

    #endregion
    private DevExpress.XtraEditors.PanelControl panelControl2;
    private DevExpress.XtraGrid.GridControl gcListe;
    private DevExpress.XtraGrid.Views.Grid.GridView gvListe;
    private DevExpress.XtraGrid.Columns.GridColumn colMusteriID;
    private DevExpress.XtraGrid.Columns.GridColumn colMusteriAdSoyad;
    private DevExpress.XtraGrid.Columns.GridColumn colMusteriTelefon;
    private DevExpress.XtraGrid.Columns.GridColumn colMusteriAdres;
    private DevExpress.XtraGrid.Columns.GridColumn colMusteriEhliyetNo;
    private DevExpress.XtraGrid.Columns.GridColumn colMusteriYas;
    private DevExpress.XtraEditors.SimpleButton btnYenile;
    private DevExpress.XtraEditors.SimpleButton btnSil;
    private DevExpress.XtraEditors.SimpleButton btnEkle;
        private DevExpress.XtraGrid.Columns.GridColumn colMusteriTc;
    }
}