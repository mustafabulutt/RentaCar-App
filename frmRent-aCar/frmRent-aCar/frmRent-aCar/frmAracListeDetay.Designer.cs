namespace frmRent_aCar
{
  partial class frmAracListeDetay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAracListeDetay));
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtEklenecekArac = new DevExpress.XtraEditors.TextEdit();
            this.btnEkle = new DevExpress.XtraEditors.SimpleButton();
            this.btnIptal = new DevExpress.XtraEditors.SimpleButton();
            this.txtAracPlaka = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtUretimYili = new DevExpress.XtraEditors.TextEdit();
            this.cmbYakitTipi = new System.Windows.Forms.ComboBox();
            this.cmbKasaTipi = new System.Windows.Forms.ComboBox();
            this.txtRenk = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEklenecekArac.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAracPlaka.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtUretimYili.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRenk.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(4, 39);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(93, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "EKLENECEK ARAÇ :";
            this.labelControl2.Click += new System.EventHandler(this.labelControl2_Click);
            // 
            // txtEklenecekArac
            // 
            this.txtEklenecekArac.Location = new System.Drawing.Point(107, 36);
            this.txtEklenecekArac.Name = "txtEklenecekArac";
            this.txtEklenecekArac.Size = new System.Drawing.Size(100, 20);
            this.txtEklenecekArac.TabIndex = 2;
            this.txtEklenecekArac.EditValueChanged += new System.EventHandler(this.txtEklenecekArac_EditValueChanged);
            // 
            // btnEkle
            // 
            this.btnEkle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEkle.ImageOptions.Image")));
            this.btnEkle.Location = new System.Drawing.Point(5, 205);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(93, 23);
            this.btnEkle.TabIndex = 3;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnIptal
            // 
            this.btnIptal.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnIptal.ImageOptions.Image")));
            this.btnIptal.Location = new System.Drawing.Point(114, 205);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(93, 23);
            this.btnIptal.TabIndex = 4;
            this.btnIptal.Text = "İPTAL";
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // txtAracPlaka
            // 
            this.txtAracPlaka.Location = new System.Drawing.Point(107, 62);
            this.txtAracPlaka.Name = "txtAracPlaka";
            this.txtAracPlaka.Size = new System.Drawing.Size(100, 20);
            this.txtAracPlaka.TabIndex = 5;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(28, 65);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(69, 13);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "ARAÇ PLAKA :";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(25, 93);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(72, 13);
            this.labelControl4.TabIndex = 7;
            this.labelControl4.Text = "ÜRETİM YILLI :";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(64, 182);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(33, 13);
            this.labelControl5.TabIndex = 8;
            this.labelControl5.Text = "RENK :";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(38, 125);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(59, 13);
            this.labelControl6.TabIndex = 9;
            this.labelControl6.Text = "YAKIT TİPİ :";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(41, 154);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(56, 13);
            this.labelControl7.TabIndex = 10;
            this.labelControl7.Text = "KASA TİPİ :";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txtRenk);
            this.groupControl1.Controls.Add(this.cmbKasaTipi);
            this.groupControl1.Controls.Add(this.cmbYakitTipi);
            this.groupControl1.Controls.Add(this.txtUretimYili);
            this.groupControl1.Controls.Add(this.txtEklenecekArac);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.btnEkle);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.btnIptal);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.txtAracPlaka);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(220, 238);
            this.groupControl1.TabIndex = 11;
            this.groupControl1.Text = "ARAÇ EKLEME ";
            // 
            // txtUretimYili
            // 
            this.txtUretimYili.Location = new System.Drawing.Point(107, 90);
            this.txtUretimYili.Name = "txtUretimYili";
            this.txtUretimYili.Size = new System.Drawing.Size(100, 20);
            this.txtUretimYili.TabIndex = 11;
            // 
            // cmbYakitTipi
            // 
            this.cmbYakitTipi.FormattingEnabled = true;
            this.cmbYakitTipi.Location = new System.Drawing.Point(107, 122);
            this.cmbYakitTipi.Name = "cmbYakitTipi";
            this.cmbYakitTipi.Size = new System.Drawing.Size(100, 21);
            this.cmbYakitTipi.TabIndex = 12;
            this.cmbYakitTipi.ValueMember = "YakıtTuru";
            this.cmbYakitTipi.SelectedIndexChanged += new System.EventHandler(this.cmbYakitTipi_SelectedIndexChanged);
            // 
            // cmbKasaTipi
            // 
            this.cmbKasaTipi.FormattingEnabled = true;
            this.cmbKasaTipi.Location = new System.Drawing.Point(107, 151);
            this.cmbKasaTipi.Name = "cmbKasaTipi";
            this.cmbKasaTipi.Size = new System.Drawing.Size(100, 21);
            this.cmbKasaTipi.TabIndex = 13;
            this.cmbKasaTipi.ValueMember = "KasaTipi";
            // 
            // txtRenk
            // 
            this.txtRenk.Location = new System.Drawing.Point(107, 179);
            this.txtRenk.Name = "txtRenk";
            this.txtRenk.Size = new System.Drawing.Size(100, 20);
            this.txtRenk.TabIndex = 14;
            // 
            // frmAracListeDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(220, 238);
            this.ControlBox = false;
            this.Controls.Add(this.groupControl1);
            this.Name = "frmAracListeDetay";
            this.Text = "frmAracListeDetay";
            this.Load += new System.EventHandler(this.frmAracListeDetay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtEklenecekArac.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAracPlaka.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtUretimYili.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRenk.Properties)).EndInit();
            this.ResumeLayout(false);

    }

    #endregion
    private DevExpress.XtraEditors.LabelControl labelControl2;
    private DevExpress.XtraEditors.TextEdit txtEklenecekArac;
    private DevExpress.XtraEditors.SimpleButton btnEkle;
    private DevExpress.XtraEditors.SimpleButton btnIptal;
        private DevExpress.XtraEditors.TextEdit txtAracPlaka;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit txtRenk;
        private System.Windows.Forms.ComboBox cmbKasaTipi;
        private System.Windows.Forms.ComboBox cmbYakitTipi;
        private DevExpress.XtraEditors.TextEdit txtUretimYili;
    }
}