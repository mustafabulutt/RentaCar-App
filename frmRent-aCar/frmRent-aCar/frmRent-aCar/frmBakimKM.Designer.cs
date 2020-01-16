namespace frmRent_aCar
{
  partial class frmBakimKM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBakimKM));
            this.gcListe = new DevExpress.XtraGrid.GridControl();
            this.gvListe = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colAracID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAracTanim = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGelecekBakimKM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnDegistir = new DevExpress.XtraEditors.SimpleButton();
            this.colAracPlaka = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.gcListe.Size = new System.Drawing.Size(850, 422);
            this.gcListe.TabIndex = 0;
            this.gcListe.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvListe});
            // 
            // gvListe
            // 
            this.gvListe.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAracID,
            this.colAracTanim,
            this.colGelecekBakimKM,
            this.colAracPlaka});
            this.gvListe.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gvListe.GridControl = this.gcListe;
            this.gvListe.Name = "gvListe";
            this.gvListe.OptionsBehavior.AllowIncrementalSearch = true;
            this.gvListe.OptionsBehavior.Editable = false;
            this.gvListe.OptionsSelection.EnableAppearanceFocusedCell = false;
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
            // colGelecekBakimKM
            // 
            this.colGelecekBakimKM.Caption = "GelecekBakimKM";
            this.colGelecekBakimKM.FieldName = "GelecekBakimKM";
            this.colGelecekBakimKM.Name = "colGelecekBakimKM";
            this.colGelecekBakimKM.Visible = true;
            this.colGelecekBakimKM.VisibleIndex = 1;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnDegistir);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 394);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(850, 28);
            this.panelControl1.TabIndex = 1;
            // 
            // btnDegistir
            // 
            this.btnDegistir.AutoSize = true;
            this.btnDegistir.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDegistir.ImageOptions.Image")));
            this.btnDegistir.Location = new System.Drawing.Point(5, 5);
            this.btnDegistir.Name = "btnDegistir";
            this.btnDegistir.Size = new System.Drawing.Size(75, 22);
            this.btnDegistir.TabIndex = 0;
            this.btnDegistir.Text = "DEĞİŞTİR";
            this.btnDegistir.Click += new System.EventHandler(this.btnDegistir_Click);
            // 
            // colAracPlaka
            // 
            this.colAracPlaka.Caption = "AracPlaka";
            this.colAracPlaka.FieldName = "AracPlaka";
            this.colAracPlaka.Name = "colAracPlaka";
            this.colAracPlaka.Visible = true;
            this.colAracPlaka.VisibleIndex = 2;
            // 
            // frmBakimKM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 422);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.gcListe);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBakimKM";
            this.Text = "frmBakimKM";
            this.Load += new System.EventHandler(this.frmBakimKM_Load);
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
    private DevExpress.XtraGrid.Columns.GridColumn colAracID;
    private DevExpress.XtraGrid.Columns.GridColumn colAracTanim;
    private DevExpress.XtraGrid.Columns.GridColumn colGelecekBakimKM;
    private DevExpress.XtraEditors.PanelControl panelControl1;
    private DevExpress.XtraEditors.SimpleButton btnDegistir;
        private DevExpress.XtraGrid.Columns.GridColumn colAracPlaka;
    }
}