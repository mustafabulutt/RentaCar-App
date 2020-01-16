namespace frmRent_aCar
{
  partial class frmKaskoTakipDetay
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKaskoTakipDetay));
      this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
      this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
      this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
      this.btnIptal = new DevExpress.XtraEditors.SimpleButton();
      this.dateEdit1 = new DevExpress.XtraEditors.DateEdit();
      ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).BeginInit();
      this.SuspendLayout();
      // 
      // labelControl1
      // 
      this.labelControl1.Appearance.Font = new System.Drawing.Font("Snap ITC", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelControl1.Appearance.Options.UseFont = true;
      this.labelControl1.Location = new System.Drawing.Point(12, 9);
      this.labelControl1.Name = "labelControl1";
      this.labelControl1.Size = new System.Drawing.Size(264, 22);
      this.labelControl1.TabIndex = 4;
      this.labelControl1.Text = "ARAÇ KASKO BİLGİLERİ";
      // 
      // labelControl2
      // 
      this.labelControl2.Location = new System.Drawing.Point(30, 40);
      this.labelControl2.Name = "labelControl2";
      this.labelControl2.Size = new System.Drawing.Size(107, 13);
      this.labelControl2.TabIndex = 0;
      this.labelControl2.Text = "KASKO BİTİŞ TARİHİ :";
      // 
      // btnKaydet
      // 
      this.btnKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKaydet.ImageOptions.Image")));
      this.btnKaydet.Location = new System.Drawing.Point(30, 63);
      this.btnKaydet.Name = "btnKaydet";
      this.btnKaydet.Size = new System.Drawing.Size(107, 23);
      this.btnKaydet.TabIndex = 2;
      this.btnKaydet.Text = "KAYDET";
      this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
      // 
      // btnIptal
      // 
      this.btnIptal.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnIptal.ImageOptions.Image")));
      this.btnIptal.Location = new System.Drawing.Point(143, 63);
      this.btnIptal.Name = "btnIptal";
      this.btnIptal.Size = new System.Drawing.Size(107, 23);
      this.btnIptal.TabIndex = 3;
      this.btnIptal.Text = "İPTAL";
      this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
      // 
      // dateEdit1
      // 
      this.dateEdit1.EditValue = null;
      this.dateEdit1.Location = new System.Drawing.Point(143, 37);
      this.dateEdit1.Name = "dateEdit1";
      this.dateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.dateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.dateEdit1.Size = new System.Drawing.Size(107, 20);
      this.dateEdit1.TabIndex = 5;
      // 
      // frmKaskoTakipDetay
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(281, 103);
      this.Controls.Add(this.dateEdit1);
      this.Controls.Add(this.btnIptal);
      this.Controls.Add(this.btnKaydet);
      this.Controls.Add(this.labelControl2);
      this.Controls.Add(this.labelControl1);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "frmKaskoTakipDetay";
      this.Text = "frmKaskoTakipDetay";
      this.Load += new System.EventHandler(this.frmKaskoTakipDetay_Load);
      ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private DevExpress.XtraEditors.LabelControl labelControl1;
    private DevExpress.XtraEditors.LabelControl labelControl2;
    private DevExpress.XtraEditors.SimpleButton btnKaydet;
    private DevExpress.XtraEditors.SimpleButton btnIptal;
    private DevExpress.XtraEditors.DateEdit dateEdit1;
  }
}