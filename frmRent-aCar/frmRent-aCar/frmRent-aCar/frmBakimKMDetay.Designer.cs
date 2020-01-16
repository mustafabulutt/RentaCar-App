namespace frmRent_aCar
{
  partial class frmBakimKMDetay
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBakimKMDetay));
      this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
      this.txtGelecekBakimKM = new DevExpress.XtraEditors.TextEdit();
      this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
      this.btnIptal = new DevExpress.XtraEditors.SimpleButton();
      this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
      ((System.ComponentModel.ISupportInitialize)(this.txtGelecekBakimKM.Properties)).BeginInit();
      this.SuspendLayout();
      // 
      // labelControl1
      // 
      this.labelControl1.Location = new System.Drawing.Point(28, 39);
      this.labelControl1.Name = "labelControl1";
      this.labelControl1.Size = new System.Drawing.Size(91, 13);
      this.labelControl1.TabIndex = 0;
      this.labelControl1.Text = "Gelecek Bakım KM :";
      // 
      // txtGelecekBakimKM
      // 
      this.txtGelecekBakimKM.Location = new System.Drawing.Point(120, 36);
      this.txtGelecekBakimKM.Name = "txtGelecekBakimKM";
      this.txtGelecekBakimKM.Size = new System.Drawing.Size(100, 20);
      this.txtGelecekBakimKM.TabIndex = 1;
      // 
      // btnKaydet
      // 
      this.btnKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKaydet.ImageOptions.Image")));
      this.btnKaydet.Location = new System.Drawing.Point(28, 71);
      this.btnKaydet.Name = "btnKaydet";
      this.btnKaydet.Size = new System.Drawing.Size(91, 23);
      this.btnKaydet.TabIndex = 2;
      this.btnKaydet.Text = "KAYDET";
      this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
      // 
      // btnIptal
      // 
      this.btnIptal.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnIptal.ImageOptions.Image")));
      this.btnIptal.Location = new System.Drawing.Point(125, 71);
      this.btnIptal.Name = "btnIptal";
      this.btnIptal.Size = new System.Drawing.Size(95, 23);
      this.btnIptal.TabIndex = 3;
      this.btnIptal.Text = "İPTAL";
      this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
      // 
      // labelControl2
      // 
      this.labelControl2.Appearance.Font = new System.Drawing.Font("Imprint MT Shadow", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelControl2.Appearance.Options.UseFont = true;
      this.labelControl2.Location = new System.Drawing.Point(37, 12);
      this.labelControl2.Name = "labelControl2";
      this.labelControl2.Size = new System.Drawing.Size(173, 18);
      this.labelControl2.TabIndex = 4;
      this.labelControl2.Text = "BAKIM KM EKLEME ";
      // 
      // frmBakimKMDetay
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(253, 104);
      this.Controls.Add(this.labelControl2);
      this.Controls.Add(this.btnIptal);
      this.Controls.Add(this.btnKaydet);
      this.Controls.Add(this.txtGelecekBakimKM);
      this.Controls.Add(this.labelControl1);
      this.Name = "frmBakimKMDetay";
      this.Text = "frmBakimKMDetay";
      this.Load += new System.EventHandler(this.frmBakimKMDetay_Load);
      ((System.ComponentModel.ISupportInitialize)(this.txtGelecekBakimKM.Properties)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private DevExpress.XtraEditors.LabelControl labelControl1;
    private DevExpress.XtraEditors.TextEdit txtGelecekBakimKM;
    private DevExpress.XtraEditors.SimpleButton btnKaydet;
    private DevExpress.XtraEditors.SimpleButton btnIptal;
    private DevExpress.XtraEditors.LabelControl labelControl2;
  }
}