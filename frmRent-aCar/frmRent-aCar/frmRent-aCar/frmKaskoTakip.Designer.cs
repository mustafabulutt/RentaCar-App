namespace frmRent_aCar
{
  partial class frmKaskoTakip
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKaskoTakip));
            DevExpress.XtraGrid.GridFormatRule gridFormatRule1 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleExpression formatConditionRuleExpression1 = new DevExpress.XtraEditors.FormatConditionRuleExpression();
            this.colKaskoBitisTarihi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnDegistir = new DevExpress.XtraEditors.SimpleButton();
            this.gcListe = new DevExpress.XtraGrid.GridControl();
            this.gvListe = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colAracID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAracTanim = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAracPlaka = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gcListe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvListe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // colKaskoBitisTarihi
            // 
            this.colKaskoBitisTarihi.Caption = "KaskoBitisTarihi";
            this.colKaskoBitisTarihi.FieldName = "KaskoBitisTarihi";
            this.colKaskoBitisTarihi.Name = "colKaskoBitisTarihi";
            this.colKaskoBitisTarihi.Visible = true;
            this.colKaskoBitisTarihi.VisibleIndex = 1;
            // 
            // btnDegistir
            // 
            this.btnDegistir.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDegistir.ImageOptions.Image")));
            this.btnDegistir.Location = new System.Drawing.Point(5, 0);
            this.btnDegistir.Name = "btnDegistir";
            this.btnDegistir.Size = new System.Drawing.Size(86, 25);
            this.btnDegistir.TabIndex = 0;
            this.btnDegistir.Text = "DEĞİŞTİR";
            this.btnDegistir.Click += new System.EventHandler(this.btnDegistir_Click);
            // 
            // gcListe
            // 
            this.gcListe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcListe.Location = new System.Drawing.Point(0, 0);
            this.gcListe.MainView = this.gvListe;
            this.gcListe.Name = "gcListe";
            this.gcListe.Size = new System.Drawing.Size(618, 314);
            this.gcListe.TabIndex = 1;
            this.gcListe.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvListe});
            // 
            // gvListe
            // 
            this.gvListe.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAracID,
            this.colAracTanim,
            this.colKaskoBitisTarihi,
            this.colAracPlaka});
            this.gvListe.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            gridFormatRule1.ApplyToRow = true;
            gridFormatRule1.Column = this.colKaskoBitisTarihi;
            gridFormatRule1.Name = "NewFormatRule";
            formatConditionRuleExpression1.Expression = "LocalDateTimeYesterday() = [KaskoBitisTarihi] Or Today() = [KaskoBitisTarihi] Or " +
    "LocalDateTimeNow() = [KaskoBitisTarihi]";
            formatConditionRuleExpression1.PredefinedName = "Red Fill, Red Text";
            gridFormatRule1.Rule = formatConditionRuleExpression1;
            this.gvListe.FormatRules.Add(gridFormatRule1);
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
            this.colAracPlaka.VisibleIndex = 2;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnDegistir);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 289);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(618, 25);
            this.panelControl1.TabIndex = 2;
            // 
            // frmKaskoTakip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 314);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.gcListe);
            this.Name = "frmKaskoTakip";
            this.Text = "frmKaskoTakip";
            this.Load += new System.EventHandler(this.frmKaskoTakip_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcListe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvListe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

    }

    #endregion

    private DevExpress.XtraEditors.SimpleButton btnDegistir;
    private DevExpress.XtraGrid.GridControl gcListe;
    private DevExpress.XtraGrid.Views.Grid.GridView gvListe;
    private DevExpress.XtraGrid.Columns.GridColumn colAracID;
    private DevExpress.XtraGrid.Columns.GridColumn colAracTanim;
    private DevExpress.XtraGrid.Columns.GridColumn colKaskoBitisTarihi;
        private DevExpress.XtraGrid.Columns.GridColumn colAracPlaka;
        private DevExpress.XtraEditors.PanelControl panelControl1;
    }
}