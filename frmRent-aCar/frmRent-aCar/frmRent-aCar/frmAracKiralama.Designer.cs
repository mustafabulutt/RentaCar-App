namespace frmRent_aCar
{
    partial class frmAracKiralama
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAracKiralama));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.lkpAracPlaka = new DevExpress.XtraEditors.LookUpEdit();
            this.aracBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._Rent_aCarDataSet = new frmRent_aCar._Rent_aCarDataSet();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.txtKmHakki = new System.Windows.Forms.TextBox();
            this.txtUcret = new System.Windows.Forms.TextBox();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.deAlisTarihi = new DevExpress.XtraEditors.DateEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtVerisKm = new System.Windows.Forms.TextBox();
            this.deVerisTarihi = new DevExpress.XtraEditors.DateEdit();
            this.lkpTcKimlik = new DevExpress.XtraEditors.LookUpEdit();
            this.musteriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._Rent_aCarDataSet1 = new frmRent_aCar._Rent_aCarDataSet1();
            this.btnKirala = new DevExpress.XtraEditors.SimpleButton();
            this.aracTableAdapter = new frmRent_aCar._Rent_aCarDataSetTableAdapters.AracTableAdapter();
            this.musteriTableAdapter = new frmRent_aCar._Rent_aCarDataSet1TableAdapters.MusteriTableAdapter();
            this.gcListe = new DevExpress.XtraGrid.GridControl();
            this.gvListe = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colKiraID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTcKimlik = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAracPlaka = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVerisTarihi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAlisTarihi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVerisKm = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUcret = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKmHakki = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkpAracPlaka.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aracBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._Rent_aCarDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deAlisTarihi.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deAlisTarihi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deVerisTarihi.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deVerisTarihi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpTcKimlik.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._Rent_aCarDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcListe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvListe)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnSil);
            this.groupControl1.Controls.Add(this.lkpAracPlaka);
            this.groupControl1.Controls.Add(this.btnKirala);
            this.groupControl1.Controls.Add(this.labelControl9);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.txtKmHakki);
            this.groupControl1.Controls.Add(this.txtUcret);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.deAlisTarihi);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.txtVerisKm);
            this.groupControl1.Controls.Add(this.deVerisTarihi);
            this.groupControl1.Controls.Add(this.lkpTcKimlik);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(220, 299);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Araç Kiralama İşlemi";
            // 
            // lkpAracPlaka
            // 
            this.lkpAracPlaka.Location = new System.Drawing.Point(94, 51);
            this.lkpAracPlaka.Name = "lkpAracPlaka";
            this.lkpAracPlaka.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkpAracPlaka.Properties.DataSource = this.aracBindingSource;
            this.lkpAracPlaka.Properties.DisplayMember = "AracPlaka";
            this.lkpAracPlaka.Properties.NullText = "SEÇİNİZ!";
            this.lkpAracPlaka.Properties.ValueMember = "AracPlaka";
            this.lkpAracPlaka.Size = new System.Drawing.Size(121, 20);
            this.lkpAracPlaka.TabIndex = 19;
            // 
            // aracBindingSource
            // 
            this.aracBindingSource.DataMember = "Arac";
            this.aracBindingSource.DataSource = this._Rent_aCarDataSet;
            // 
            // _Rent_aCarDataSet
            // 
            this._Rent_aCarDataSet.DataSetName = "_Rent_aCarDataSet";
            this._Rent_aCarDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(5, 217);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(40, 13);
            this.labelControl9.TabIndex = 17;
            this.labelControl9.Text = "..........";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(5, 188);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(54, 13);
            this.labelControl8.TabIndex = 16;
            this.labelControl8.Text = "KM HAKKI :";
            // 
            // txtKmHakki
            // 
            this.txtKmHakki.Location = new System.Drawing.Point(94, 185);
            this.txtKmHakki.Name = "txtKmHakki";
            this.txtKmHakki.Size = new System.Drawing.Size(121, 21);
            this.txtKmHakki.TabIndex = 15;
            // 
            // txtUcret
            // 
            this.txtUcret.Location = new System.Drawing.Point(94, 158);
            this.txtUcret.Name = "txtUcret";
            this.txtUcret.Size = new System.Drawing.Size(121, 21);
            this.txtUcret.TabIndex = 14;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(5, 161);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(40, 13);
            this.labelControl7.TabIndex = 13;
            this.labelControl7.Text = "ÜCRET :";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(5, 106);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(67, 13);
            this.labelControl5.TabIndex = 9;
            this.labelControl5.Text = "ALIŞ TARİHİ :";
            // 
            // deAlisTarihi
            // 
            this.deAlisTarihi.EditValue = null;
            this.deAlisTarihi.Location = new System.Drawing.Point(94, 103);
            this.deAlisTarihi.Name = "deAlisTarihi";
            this.deAlisTarihi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deAlisTarihi.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deAlisTarihi.Size = new System.Drawing.Size(121, 20);
            this.deAlisTarihi.TabIndex = 8;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(5, 134);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(53, 13);
            this.labelControl4.TabIndex = 7;
            this.labelControl4.Text = "VERİŞ KM :";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(5, 80);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(74, 13);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "VERİŞ TARİHİ :";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(5, 53);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(69, 13);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "ARAC PLAKA :";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(5, 26);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(56, 13);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "TC KİMLİK :";
            // 
            // txtVerisKm
            // 
            this.txtVerisKm.Location = new System.Drawing.Point(94, 131);
            this.txtVerisKm.Name = "txtVerisKm";
            this.txtVerisKm.Size = new System.Drawing.Size(121, 21);
            this.txtVerisKm.TabIndex = 3;
            // 
            // deVerisTarihi
            // 
            this.deVerisTarihi.EditValue = null;
            this.deVerisTarihi.Location = new System.Drawing.Point(94, 77);
            this.deVerisTarihi.Name = "deVerisTarihi";
            this.deVerisTarihi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deVerisTarihi.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deVerisTarihi.Size = new System.Drawing.Size(121, 20);
            this.deVerisTarihi.TabIndex = 2;
            // 
            // lkpTcKimlik
            // 
            this.lkpTcKimlik.Location = new System.Drawing.Point(94, 23);
            this.lkpTcKimlik.Name = "lkpTcKimlik";
            this.lkpTcKimlik.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkpTcKimlik.Properties.DataSource = this.musteriBindingSource;
            this.lkpTcKimlik.Properties.DisplayMember = "MusteriTc";
            this.lkpTcKimlik.Properties.NullText = "SEÇİNİZ!";
            this.lkpTcKimlik.Properties.ValueMember = "MusteriTc";
            this.lkpTcKimlik.Size = new System.Drawing.Size(121, 20);
            this.lkpTcKimlik.TabIndex = 18;
            // 
            // musteriBindingSource
            // 
            this.musteriBindingSource.DataMember = "Musteri";
            this.musteriBindingSource.DataSource = this._Rent_aCarDataSet1;
            // 
            // _Rent_aCarDataSet1
            // 
            this._Rent_aCarDataSet1.DataSetName = "_Rent_aCarDataSet1";
            this._Rent_aCarDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnKirala
            // 
            this.btnKirala.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKirala.ImageOptions.Image")));
            this.btnKirala.Location = new System.Drawing.Point(94, 212);
            this.btnKirala.Name = "btnKirala";
            this.btnKirala.Size = new System.Drawing.Size(126, 23);
            this.btnKirala.TabIndex = 2;
            this.btnKirala.Text = "KİRALA";
            this.btnKirala.Click += new System.EventHandler(this.btnKirala_Click);
            // 
            // aracTableAdapter
            // 
            this.aracTableAdapter.ClearBeforeFill = true;
            // 
            // musteriTableAdapter
            // 
            this.musteriTableAdapter.ClearBeforeFill = true;
            // 
            // gcListe
            // 
            this.gcListe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcListe.Location = new System.Drawing.Point(220, 0);
            this.gcListe.MainView = this.gvListe;
            this.gcListe.Name = "gcListe";
            this.gcListe.Size = new System.Drawing.Size(499, 299);
            this.gcListe.TabIndex = 3;
            this.gcListe.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvListe});
            // 
            // gvListe
            // 
            this.gvListe.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colKiraID,
            this.colTcKimlik,
            this.colAracPlaka,
            this.colVerisTarihi,
            this.colAlisTarihi,
            this.colVerisKm,
            this.colUcret,
            this.colKmHakki});
            this.gvListe.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
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
            // colKiraID
            // 
            this.colKiraID.Caption = "KiraID";
            this.colKiraID.FieldName = "KiraID";
            this.colKiraID.Name = "colKiraID";
            // 
            // colTcKimlik
            // 
            this.colTcKimlik.Caption = "TcKimlik";
            this.colTcKimlik.FieldName = "TcKimlik";
            this.colTcKimlik.Name = "colTcKimlik";
            this.colTcKimlik.Visible = true;
            this.colTcKimlik.VisibleIndex = 0;
            // 
            // colAracPlaka
            // 
            this.colAracPlaka.Caption = "AracPlaka";
            this.colAracPlaka.FieldName = "AracPlaka";
            this.colAracPlaka.Name = "colAracPlaka";
            this.colAracPlaka.Visible = true;
            this.colAracPlaka.VisibleIndex = 1;
            // 
            // colVerisTarihi
            // 
            this.colVerisTarihi.Caption = "VerisTarihi";
            this.colVerisTarihi.FieldName = "VerisTarihi";
            this.colVerisTarihi.Name = "colVerisTarihi";
            this.colVerisTarihi.Visible = true;
            this.colVerisTarihi.VisibleIndex = 2;
            // 
            // colAlisTarihi
            // 
            this.colAlisTarihi.Caption = "AlisTarihi";
            this.colAlisTarihi.FieldName = "AlisTarihi";
            this.colAlisTarihi.Name = "colAlisTarihi";
            this.colAlisTarihi.Visible = true;
            this.colAlisTarihi.VisibleIndex = 3;
            // 
            // colVerisKm
            // 
            this.colVerisKm.Caption = "VerisKm";
            this.colVerisKm.FieldName = "VerisKm";
            this.colVerisKm.Name = "colVerisKm";
            this.colVerisKm.Visible = true;
            this.colVerisKm.VisibleIndex = 4;
            // 
            // colUcret
            // 
            this.colUcret.Caption = "Ucret";
            this.colUcret.FieldName = "Ucret";
            this.colUcret.Name = "colUcret";
            this.colUcret.Visible = true;
            this.colUcret.VisibleIndex = 5;
            // 
            // colKmHakki
            // 
            this.colKmHakki.Caption = "KmHakki";
            this.colKmHakki.FieldName = "KmHakki";
            this.colKmHakki.Name = "colKmHakki";
            this.colKmHakki.Visible = true;
            this.colKmHakki.VisibleIndex = 6;
            // 
            // btnSil
            // 
            this.btnSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSil.ImageOptions.Image")));
            this.btnSil.Location = new System.Drawing.Point(94, 241);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(126, 23);
            this.btnSil.TabIndex = 20;
            this.btnSil.Text = " KİRADAN KALDIR";
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // frmAracKiralama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 299);
            this.Controls.Add(this.gcListe);
            this.Controls.Add(this.groupControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAracKiralama";
            this.Text = "frmAracKiralama";
            this.Load += new System.EventHandler(this.frmAracKiralama_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkpAracPlaka.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aracBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._Rent_aCarDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deAlisTarihi.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deAlisTarihi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deVerisTarihi.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deVerisTarihi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpTcKimlik.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._Rent_aCarDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcListe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvListe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private System.Windows.Forms.TextBox txtKmHakki;
        private System.Windows.Forms.TextBox txtUcret;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.DateEdit deAlisTarihi;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.TextBox txtVerisKm;
        private DevExpress.XtraEditors.DateEdit deVerisTarihi;
        private DevExpress.XtraEditors.SimpleButton btnKirala;
        private _Rent_aCarDataSet _Rent_aCarDataSet;
        private System.Windows.Forms.BindingSource aracBindingSource;
        private _Rent_aCarDataSetTableAdapters.AracTableAdapter aracTableAdapter;
        private DevExpress.XtraEditors.LookUpEdit lkpAracPlaka;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private _Rent_aCarDataSet1 _Rent_aCarDataSet1;
        private System.Windows.Forms.BindingSource musteriBindingSource;
        private _Rent_aCarDataSet1TableAdapters.MusteriTableAdapter musteriTableAdapter;
        private DevExpress.XtraEditors.LookUpEdit lkpTcKimlik;
        private DevExpress.XtraGrid.GridControl gcListe;
        private DevExpress.XtraGrid.Views.Grid.GridView gvListe;
        private DevExpress.XtraGrid.Columns.GridColumn colKiraID;
        private DevExpress.XtraGrid.Columns.GridColumn colTcKimlik;
        private DevExpress.XtraGrid.Columns.GridColumn colAracPlaka;
        private DevExpress.XtraGrid.Columns.GridColumn colVerisTarihi;
        private DevExpress.XtraGrid.Columns.GridColumn colAlisTarihi;
        private DevExpress.XtraGrid.Columns.GridColumn colVerisKm;
        private DevExpress.XtraGrid.Columns.GridColumn colUcret;
        private DevExpress.XtraGrid.Columns.GridColumn colKmHakki;
        private DevExpress.XtraEditors.SimpleButton btnSil;
    }
}