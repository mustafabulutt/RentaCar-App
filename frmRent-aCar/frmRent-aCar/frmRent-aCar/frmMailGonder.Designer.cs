namespace frmRent_aCar
{
    partial class frmMailGonder
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtHedefMail = new DevExpress.XtraEditors.TextEdit();
            this.txtBaslik = new DevExpress.XtraEditors.TextEdit();
            this.gpIleti = new DevExpress.XtraEditors.GroupControl();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.txtMesaj = new System.Windows.Forms.TextBox();
            this.btnGönder = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtHedefMail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBaslik.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gpIleti)).BeginInit();
            this.gpIleti.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.gpIleti);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(313, 258);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Mail Gönderme";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(7, 29);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(66, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "HEDEF MAİL :";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(32, 55);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(41, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "BAŞLIK :";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(34, 81);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(39, 13);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "MESAJ :";
            // 
            // txtHedefMail
            // 
            this.txtHedefMail.Location = new System.Drawing.Point(79, 26);
            this.txtHedefMail.Name = "txtHedefMail";
            this.txtHedefMail.Size = new System.Drawing.Size(199, 20);
            this.txtHedefMail.TabIndex = 3;
            // 
            // txtBaslik
            // 
            this.txtBaslik.Location = new System.Drawing.Point(79, 52);
            this.txtBaslik.Name = "txtBaslik";
            this.txtBaslik.Size = new System.Drawing.Size(199, 20);
            this.txtBaslik.TabIndex = 4;
            // 
            // gpIleti
            // 
            this.gpIleti.Controls.Add(this.btnGönder);
            this.gpIleti.Controls.Add(this.txtMesaj);
            this.gpIleti.Controls.Add(this.labelControl3);
            this.gpIleti.Controls.Add(this.labelControl1);
            this.gpIleti.Controls.Add(this.txtBaslik);
            this.gpIleti.Controls.Add(this.labelControl2);
            this.gpIleti.Controls.Add(this.txtHedefMail);
            this.gpIleti.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpIleti.Location = new System.Drawing.Point(2, 20);
            this.gpIleti.Name = "gpIleti";
            this.gpIleti.Size = new System.Drawing.Size(309, 236);
            this.gpIleti.TabIndex = 6;
            this.gpIleti.Text = "İLETİ";
            // 
            // txtMesaj
            // 
            this.txtMesaj.Location = new System.Drawing.Point(80, 81);
            this.txtMesaj.Multiline = true;
            this.txtMesaj.Name = "txtMesaj";
            this.txtMesaj.Size = new System.Drawing.Size(198, 106);
            this.txtMesaj.TabIndex = 5;
            // 
            // btnGönder
            // 
            this.btnGönder.Location = new System.Drawing.Point(80, 193);
            this.btnGönder.Name = "btnGönder";
            this.btnGönder.Size = new System.Drawing.Size(198, 23);
            this.btnGönder.TabIndex = 6;
            this.btnGönder.Text = "GÖNDER";
            this.btnGönder.Click += new System.EventHandler(this.btnGönder_Click);
            // 
            // frmMailGonder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 258);
            this.Controls.Add(this.groupControl1);
            this.Name = "frmMailGonder";
            this.Text = "frmMailGonder";
            this.Load += new System.EventHandler(this.frmMailGonder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtHedefMail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBaslik.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gpIleti)).EndInit();
            this.gpIleti.ResumeLayout(false);
            this.gpIleti.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl gpIleti;
        private DevExpress.XtraEditors.SimpleButton btnGönder;
        private System.Windows.Forms.TextBox txtMesaj;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtBaslik;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtHedefMail;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
    }
}