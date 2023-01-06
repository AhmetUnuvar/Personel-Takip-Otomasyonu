namespace Otomasyon
{
    partial class ProjeSayfasi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjeSayfasi));
            this.datagridProje = new System.Windows.Forms.DataGridView();
            this.personelIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelSoyadiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projeAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projedekiGoreviDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projeTakipBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.calisanTakipSistemiDataSet4 = new Otomasyon.CalisanTakipSistemiDataSet4();
            this.projeTakipTableAdapter = new Otomasyon.CalisanTakipSistemiDataSet4TableAdapters.projeTakipTableAdapter();
            this.bunifuGradientPanel1 = new Bunifu.UI.WinForms.BunifuGradientPanel();
            this.btnBack = new Bunifu.UI.WinForms.BunifuImageButton();
            this.btnClose = new Bunifu.UI.WinForms.BunifuImageButton();
            this.btnTemizleProje = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnPersonelGuncelleProje = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnPersonelCıkarproje = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnProjeEkle = new Bunifu.Framework.UI.BunifuThinButton2();
            this.projeAdiprojetxt = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.personelIDProjetxt = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.personelGorevProjetxt = new DevExpress.XtraEditors.TextEdit();
            this.personelSoyadProjetxt = new DevExpress.XtraEditors.TextEdit();
            this.personeladProjetxt = new DevExpress.XtraEditors.TextEdit();
            this.personelsoyadinfo = new DevExpress.XtraEditors.LabelControl();
            this.personelgorevinfo = new DevExpress.XtraEditors.LabelControl();
            this.personeladinfo = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.datagridProje)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projeTakipBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calisanTakipSistemiDataSet4)).BeginInit();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projeAdiprojetxt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelIDProjetxt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelGorevProjetxt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelSoyadProjetxt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personeladProjetxt.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // datagridProje
            // 
            this.datagridProje.AutoGenerateColumns = false;
            this.datagridProje.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.datagridProje.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridProje.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.personelIDDataGridViewTextBoxColumn,
            this.personelAdiDataGridViewTextBoxColumn,
            this.personelSoyadiDataGridViewTextBoxColumn,
            this.projeAdiDataGridViewTextBoxColumn,
            this.projedekiGoreviDataGridViewTextBoxColumn});
            this.datagridProje.DataSource = this.projeTakipBindingSource;
            this.datagridProje.Location = new System.Drawing.Point(-2, 0);
            this.datagridProje.Name = "datagridProje";
            this.datagridProje.RowTemplate.Height = 24;
            this.datagridProje.Size = new System.Drawing.Size(950, 693);
            this.datagridProje.TabIndex = 59;
            this.datagridProje.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridProje_CellClick);
            // 
            // personelIDDataGridViewTextBoxColumn
            // 
            this.personelIDDataGridViewTextBoxColumn.DataPropertyName = "PersonelID";
            this.personelIDDataGridViewTextBoxColumn.HeaderText = "PersonelID";
            this.personelIDDataGridViewTextBoxColumn.Name = "personelIDDataGridViewTextBoxColumn";
            // 
            // personelAdiDataGridViewTextBoxColumn
            // 
            this.personelAdiDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.personelAdiDataGridViewTextBoxColumn.DataPropertyName = "PersonelAdi";
            this.personelAdiDataGridViewTextBoxColumn.HeaderText = "PersonelAdi";
            this.personelAdiDataGridViewTextBoxColumn.Name = "personelAdiDataGridViewTextBoxColumn";
            // 
            // personelSoyadiDataGridViewTextBoxColumn
            // 
            this.personelSoyadiDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.personelSoyadiDataGridViewTextBoxColumn.DataPropertyName = "PersonelSoyadi";
            this.personelSoyadiDataGridViewTextBoxColumn.HeaderText = "PersonelSoyadi";
            this.personelSoyadiDataGridViewTextBoxColumn.Name = "personelSoyadiDataGridViewTextBoxColumn";
            // 
            // projeAdiDataGridViewTextBoxColumn
            // 
            this.projeAdiDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.projeAdiDataGridViewTextBoxColumn.DataPropertyName = "ProjeAdi";
            this.projeAdiDataGridViewTextBoxColumn.HeaderText = "ProjeAdi";
            this.projeAdiDataGridViewTextBoxColumn.Name = "projeAdiDataGridViewTextBoxColumn";
            // 
            // projedekiGoreviDataGridViewTextBoxColumn
            // 
            this.projedekiGoreviDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.projedekiGoreviDataGridViewTextBoxColumn.DataPropertyName = "ProjedekiGorevi";
            this.projedekiGoreviDataGridViewTextBoxColumn.HeaderText = "ProjedekiGorevi";
            this.projedekiGoreviDataGridViewTextBoxColumn.Name = "projedekiGoreviDataGridViewTextBoxColumn";
            // 
            // projeTakipBindingSource
            // 
            this.projeTakipBindingSource.DataMember = "projeTakip";
            this.projeTakipBindingSource.DataSource = this.calisanTakipSistemiDataSet4;
            // 
            // calisanTakipSistemiDataSet4
            // 
            this.calisanTakipSistemiDataSet4.DataSetName = "CalisanTakipSistemiDataSet4";
            this.calisanTakipSistemiDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // projeTakipTableAdapter
            // 
            this.projeTakipTableAdapter.ClearBeforeFill = true;
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.BorderRadius = 1;
            this.bunifuGradientPanel1.Controls.Add(this.btnBack);
            this.bunifuGradientPanel1.Controls.Add(this.btnClose);
            this.bunifuGradientPanel1.Controls.Add(this.btnTemizleProje);
            this.bunifuGradientPanel1.Controls.Add(this.btnPersonelGuncelleProje);
            this.bunifuGradientPanel1.Controls.Add(this.btnPersonelCıkarproje);
            this.bunifuGradientPanel1.Controls.Add(this.btnProjeEkle);
            this.bunifuGradientPanel1.Controls.Add(this.projeAdiprojetxt);
            this.bunifuGradientPanel1.Controls.Add(this.labelControl2);
            this.bunifuGradientPanel1.Controls.Add(this.personelIDProjetxt);
            this.bunifuGradientPanel1.Controls.Add(this.labelControl1);
            this.bunifuGradientPanel1.Controls.Add(this.personelGorevProjetxt);
            this.bunifuGradientPanel1.Controls.Add(this.personelSoyadProjetxt);
            this.bunifuGradientPanel1.Controls.Add(this.personeladProjetxt);
            this.bunifuGradientPanel1.Controls.Add(this.personelsoyadinfo);
            this.bunifuGradientPanel1.Controls.Add(this.personelgorevinfo);
            this.bunifuGradientPanel1.Controls.Add(this.personeladinfo);
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(23)))), ((int)(((byte)(65)))));
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(945, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(492, 693);
            this.bunifuGradientPanel1.TabIndex = 65;
            // 
            // btnBack
            // 
            this.btnBack.ActiveImage = null;
            this.btnBack.AllowAnimations = true;
            this.btnBack.AllowBuffering = false;
            this.btnBack.AllowToggling = false;
            this.btnBack.AllowZooming = true;
            this.btnBack.AllowZoomingOnFocus = false;
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnBack.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnBack.ErrorImage")));
            this.btnBack.FadeWhenInactive = false;
            this.btnBack.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.ImageActive = null;
            this.btnBack.ImageLocation = null;
            this.btnBack.ImageMargin = 20;
            this.btnBack.ImageSize = new System.Drawing.Size(26, 28);
            this.btnBack.ImageZoomSize = new System.Drawing.Size(46, 48);
            this.btnBack.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnBack.InitialImage")));
            this.btnBack.Location = new System.Drawing.Point(372, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Rotation = 0;
            this.btnBack.ShowActiveImage = true;
            this.btnBack.ShowCursorChanges = true;
            this.btnBack.ShowImageBorders = true;
            this.btnBack.ShowSizeMarkers = false;
            this.btnBack.Size = new System.Drawing.Size(46, 48);
            this.btnBack.TabIndex = 11;
            this.btnBack.ToolTipText = "";
            this.btnBack.WaitOnLoad = false;
            this.btnBack.Zoom = 20;
            this.btnBack.ZoomSpeed = 10;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnClose
            // 
            this.btnClose.ActiveImage = null;
            this.btnClose.AllowAnimations = true;
            this.btnClose.AllowBuffering = false;
            this.btnClose.AllowToggling = false;
            this.btnClose.AllowZooming = true;
            this.btnClose.AllowZoomingOnFocus = false;
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnClose.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnClose.ErrorImage")));
            this.btnClose.FadeWhenInactive = false;
            this.btnClose.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageActive = null;
            this.btnClose.ImageLocation = null;
            this.btnClose.ImageMargin = 20;
            this.btnClose.ImageSize = new System.Drawing.Size(26, 28);
            this.btnClose.ImageZoomSize = new System.Drawing.Size(46, 48);
            this.btnClose.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnClose.InitialImage")));
            this.btnClose.Location = new System.Drawing.Point(433, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Rotation = 0;
            this.btnClose.ShowActiveImage = true;
            this.btnClose.ShowCursorChanges = true;
            this.btnClose.ShowImageBorders = true;
            this.btnClose.ShowSizeMarkers = false;
            this.btnClose.Size = new System.Drawing.Size(46, 48);
            this.btnClose.TabIndex = 10;
            this.btnClose.ToolTipText = "";
            this.btnClose.WaitOnLoad = false;
            this.btnClose.Zoom = 20;
            this.btnClose.ZoomSpeed = 10;
            this.btnClose.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // btnTemizleProje
            // 
            this.btnTemizleProje.ActiveBorderThickness = 1;
            this.btnTemizleProje.ActiveCornerRadius = 20;
            this.btnTemizleProje.ActiveFillColor = System.Drawing.Color.Transparent;
            this.btnTemizleProje.ActiveForecolor = System.Drawing.Color.Transparent;
            this.btnTemizleProje.ActiveLineColor = System.Drawing.Color.White;
            this.btnTemizleProje.BackColor = System.Drawing.Color.Transparent;
            this.btnTemizleProje.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTemizleProje.BackgroundImage")));
            this.btnTemizleProje.ButtonText = "Temizle";
            this.btnTemizleProje.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTemizleProje.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTemizleProje.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnTemizleProje.IdleBorderThickness = 1;
            this.btnTemizleProje.IdleCornerRadius = 20;
            this.btnTemizleProje.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnTemizleProje.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnTemizleProje.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnTemizleProje.Location = new System.Drawing.Point(269, 496);
            this.btnTemizleProje.Margin = new System.Windows.Forms.Padding(5);
            this.btnTemizleProje.Name = "btnTemizleProje";
            this.btnTemizleProje.Size = new System.Drawing.Size(211, 95);
            this.btnTemizleProje.TabIndex = 9;
            this.btnTemizleProje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnTemizleProje.Click += new System.EventHandler(this.bunifuThinButton23_Click);
            // 
            // btnPersonelGuncelleProje
            // 
            this.btnPersonelGuncelleProje.ActiveBorderThickness = 1;
            this.btnPersonelGuncelleProje.ActiveCornerRadius = 20;
            this.btnPersonelGuncelleProje.ActiveFillColor = System.Drawing.Color.Transparent;
            this.btnPersonelGuncelleProje.ActiveForecolor = System.Drawing.Color.Transparent;
            this.btnPersonelGuncelleProje.ActiveLineColor = System.Drawing.Color.White;
            this.btnPersonelGuncelleProje.BackColor = System.Drawing.Color.Transparent;
            this.btnPersonelGuncelleProje.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPersonelGuncelleProje.BackgroundImage")));
            this.btnPersonelGuncelleProje.ButtonText = "Projedeki Personeli Güncelle";
            this.btnPersonelGuncelleProje.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPersonelGuncelleProje.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPersonelGuncelleProje.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnPersonelGuncelleProje.IdleBorderThickness = 1;
            this.btnPersonelGuncelleProje.IdleCornerRadius = 20;
            this.btnPersonelGuncelleProje.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnPersonelGuncelleProje.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnPersonelGuncelleProje.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnPersonelGuncelleProje.Location = new System.Drawing.Point(28, 496);
            this.btnPersonelGuncelleProje.Margin = new System.Windows.Forms.Padding(5);
            this.btnPersonelGuncelleProje.Name = "btnPersonelGuncelleProje";
            this.btnPersonelGuncelleProje.Size = new System.Drawing.Size(211, 95);
            this.btnPersonelGuncelleProje.TabIndex = 8;
            this.btnPersonelGuncelleProje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPersonelGuncelleProje.Click += new System.EventHandler(this.bunifuThinButton22_Click);
            // 
            // btnPersonelCıkarproje
            // 
            this.btnPersonelCıkarproje.ActiveBorderThickness = 1;
            this.btnPersonelCıkarproje.ActiveCornerRadius = 20;
            this.btnPersonelCıkarproje.ActiveFillColor = System.Drawing.Color.Transparent;
            this.btnPersonelCıkarproje.ActiveForecolor = System.Drawing.Color.Transparent;
            this.btnPersonelCıkarproje.ActiveLineColor = System.Drawing.Color.White;
            this.btnPersonelCıkarproje.BackColor = System.Drawing.Color.Transparent;
            this.btnPersonelCıkarproje.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPersonelCıkarproje.BackgroundImage")));
            this.btnPersonelCıkarproje.ButtonText = "Projeden Personel Çıkar";
            this.btnPersonelCıkarproje.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPersonelCıkarproje.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPersonelCıkarproje.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnPersonelCıkarproje.IdleBorderThickness = 1;
            this.btnPersonelCıkarproje.IdleCornerRadius = 20;
            this.btnPersonelCıkarproje.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnPersonelCıkarproje.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnPersonelCıkarproje.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnPersonelCıkarproje.Location = new System.Drawing.Point(269, 367);
            this.btnPersonelCıkarproje.Margin = new System.Windows.Forms.Padding(5);
            this.btnPersonelCıkarproje.Name = "btnPersonelCıkarproje";
            this.btnPersonelCıkarproje.Size = new System.Drawing.Size(211, 95);
            this.btnPersonelCıkarproje.TabIndex = 7;
            this.btnPersonelCıkarproje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPersonelCıkarproje.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // btnProjeEkle
            // 
            this.btnProjeEkle.ActiveBorderThickness = 1;
            this.btnProjeEkle.ActiveCornerRadius = 20;
            this.btnProjeEkle.ActiveFillColor = System.Drawing.Color.Transparent;
            this.btnProjeEkle.ActiveForecolor = System.Drawing.Color.Transparent;
            this.btnProjeEkle.ActiveLineColor = System.Drawing.Color.White;
            this.btnProjeEkle.BackColor = System.Drawing.Color.Transparent;
            this.btnProjeEkle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnProjeEkle.BackgroundImage")));
            this.btnProjeEkle.ButtonText = "Projeye Personel Ekle";
            this.btnProjeEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProjeEkle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProjeEkle.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnProjeEkle.IdleBorderThickness = 1;
            this.btnProjeEkle.IdleCornerRadius = 20;
            this.btnProjeEkle.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnProjeEkle.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnProjeEkle.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnProjeEkle.Location = new System.Drawing.Point(28, 367);
            this.btnProjeEkle.Margin = new System.Windows.Forms.Padding(5);
            this.btnProjeEkle.Name = "btnProjeEkle";
            this.btnProjeEkle.Size = new System.Drawing.Size(211, 95);
            this.btnProjeEkle.TabIndex = 6;
            this.btnProjeEkle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnProjeEkle.Click += new System.EventHandler(this.btnProjeEkle_Click);
            // 
            // projeAdiprojetxt
            // 
            this.projeAdiprojetxt.Location = new System.Drawing.Point(178, 256);
            this.projeAdiprojetxt.Name = "projeAdiprojetxt";
            this.projeAdiprojetxt.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.projeAdiprojetxt.Properties.Appearance.Options.UseFont = true;
            this.projeAdiprojetxt.Size = new System.Drawing.Size(183, 24);
            this.projeAdiprojetxt.TabIndex = 4;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(71, 258);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(89, 22);
            this.labelControl2.TabIndex = 76;
            this.labelControl2.Text = "Proje Adı : ";
            // 
            // personelIDProjetxt
            // 
            this.personelIDProjetxt.Location = new System.Drawing.Point(178, 128);
            this.personelIDProjetxt.Name = "personelIDProjetxt";
            this.personelIDProjetxt.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.personelIDProjetxt.Properties.Appearance.Options.UseFont = true;
            this.personelIDProjetxt.Size = new System.Drawing.Size(183, 24);
            this.personelIDProjetxt.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(51, 128);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(109, 22);
            this.labelControl1.TabIndex = 74;
            this.labelControl1.Text = "Personel ID : ";
            // 
            // personelGorevProjetxt
            // 
            this.personelGorevProjetxt.Location = new System.Drawing.Point(178, 301);
            this.personelGorevProjetxt.Name = "personelGorevProjetxt";
            this.personelGorevProjetxt.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.personelGorevProjetxt.Properties.Appearance.Options.UseFont = true;
            this.personelGorevProjetxt.Size = new System.Drawing.Size(183, 24);
            this.personelGorevProjetxt.TabIndex = 5;
            // 
            // personelSoyadProjetxt
            // 
            this.personelSoyadProjetxt.Location = new System.Drawing.Point(178, 212);
            this.personelSoyadProjetxt.Name = "personelSoyadProjetxt";
            this.personelSoyadProjetxt.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.personelSoyadProjetxt.Properties.Appearance.Options.UseFont = true;
            this.personelSoyadProjetxt.Size = new System.Drawing.Size(183, 24);
            this.personelSoyadProjetxt.TabIndex = 3;
            // 
            // personeladProjetxt
            // 
            this.personeladProjetxt.Location = new System.Drawing.Point(178, 173);
            this.personeladProjetxt.Name = "personeladProjetxt";
            this.personeladProjetxt.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.personeladProjetxt.Properties.Appearance.Options.UseFont = true;
            this.personeladProjetxt.Size = new System.Drawing.Size(183, 24);
            this.personeladProjetxt.TabIndex = 2;
            // 
            // personelsoyadinfo
            // 
            this.personelsoyadinfo.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.personelsoyadinfo.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.personelsoyadinfo.Appearance.Options.UseFont = true;
            this.personelsoyadinfo.Appearance.Options.UseForeColor = true;
            this.personelsoyadinfo.Location = new System.Drawing.Point(28, 212);
            this.personelsoyadinfo.Name = "personelsoyadinfo";
            this.personelsoyadinfo.Size = new System.Drawing.Size(132, 22);
            this.personelsoyadinfo.TabIndex = 70;
            this.personelsoyadinfo.Text = "Personel Soyad :";
            // 
            // personelgorevinfo
            // 
            this.personelgorevinfo.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.personelgorevinfo.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.personelgorevinfo.Appearance.Options.UseFont = true;
            this.personelgorevinfo.Appearance.Options.UseForeColor = true;
            this.personelgorevinfo.Location = new System.Drawing.Point(92, 304);
            this.personelgorevinfo.Name = "personelgorevinfo";
            this.personelgorevinfo.Size = new System.Drawing.Size(68, 22);
            this.personelgorevinfo.TabIndex = 69;
            this.personelgorevinfo.Text = "Görevi : ";
            // 
            // personeladinfo
            // 
            this.personeladinfo.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.personeladinfo.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.personeladinfo.Appearance.Options.UseFont = true;
            this.personeladinfo.Appearance.Options.UseForeColor = true;
            this.personeladinfo.Location = new System.Drawing.Point(55, 173);
            this.personeladinfo.Name = "personeladinfo";
            this.personeladinfo.Size = new System.Drawing.Size(105, 22);
            this.personeladinfo.TabIndex = 68;
            this.personeladinfo.Text = "Personel Ad :";
            // 
            // ProjeSayfasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(1437, 693);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Controls.Add(this.datagridProje);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProjeSayfasi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProjeSayfasi";
            this.Load += new System.EventHandler(this.ProjeSayfasi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridProje)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projeTakipBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calisanTakipSistemiDataSet4)).EndInit();
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projeAdiprojetxt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelIDProjetxt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelGorevProjetxt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelSoyadProjetxt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personeladProjetxt.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView datagridProje;
        private CalisanTakipSistemiDataSet4 calisanTakipSistemiDataSet4;
        private System.Windows.Forms.BindingSource projeTakipBindingSource;
        private CalisanTakipSistemiDataSet4TableAdapters.projeTakipTableAdapter projeTakipTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelSoyadiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn projeAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn projedekiGoreviDataGridViewTextBoxColumn;
        private Bunifu.UI.WinForms.BunifuGradientPanel bunifuGradientPanel1;
        private DevExpress.XtraEditors.TextEdit projeAdiprojetxt;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit personelIDProjetxt;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit personelGorevProjetxt;
        private DevExpress.XtraEditors.TextEdit personelSoyadProjetxt;
        private DevExpress.XtraEditors.TextEdit personeladProjetxt;
        private DevExpress.XtraEditors.LabelControl personelsoyadinfo;
        private DevExpress.XtraEditors.LabelControl personelgorevinfo;
        private DevExpress.XtraEditors.LabelControl personeladinfo;
        private Bunifu.Framework.UI.BunifuThinButton2 btnProjeEkle;
        private Bunifu.Framework.UI.BunifuThinButton2 btnPersonelCıkarproje;
        private Bunifu.Framework.UI.BunifuThinButton2 btnPersonelGuncelleProje;
        private Bunifu.Framework.UI.BunifuThinButton2 btnTemizleProje;
        private Bunifu.UI.WinForms.BunifuImageButton btnClose;
        private Bunifu.UI.WinForms.BunifuImageButton btnBack;
    }
}