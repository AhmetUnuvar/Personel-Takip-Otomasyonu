namespace Otomasyon
{
    partial class MaaşBilgileri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MaaşBilgileri));
            this.personelMaasTakipBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.calisanTakipSistemiDataSet = new Otomasyon.CalisanTakipSistemiDataSet();
            this.personelMaasTakipTableAdapter = new Otomasyon.CalisanTakipSistemiDataSetTableAdapters.personelMaasTakipTableAdapter();
            this.calisanTakipSistemiDataSet1 = new Otomasyon.CalisanTakipSistemiDataSet1();
            this.datagridmaas = new System.Windows.Forms.DataGridView();
            this.personelIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelSoyadiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelMevkiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelMaasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bunifuGradientPanel1 = new Bunifu.UI.WinForms.BunifuGradientPanel();
            this.btnBack = new Bunifu.UI.WinForms.BunifuImageButton();
            this.btnClosem = new Bunifu.UI.WinForms.BunifuImageButton();
            this.btnPersAra = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnClear = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnPersGuncel = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnMaasDelete = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnPersEkle = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txtArama = new DevExpress.XtraEditors.TextEdit();
            this.maasMaastext = new DevExpress.XtraEditors.TextEdit();
            this.maasGoreviText = new DevExpress.XtraEditors.TextEdit();
            this.maasSoyadi = new DevExpress.XtraEditors.TextEdit();
            this.maasAdiText = new DevExpress.XtraEditors.TextEdit();
            this.maasIDtext = new DevExpress.XtraEditors.TextEdit();
            this.maasMaas = new DevExpress.XtraEditors.LabelControl();
            this.maasMevki = new DevExpress.XtraEditors.LabelControl();
            this.maasSoyad = new DevExpress.XtraEditors.LabelControl();
            this.maasAd = new DevExpress.XtraEditors.LabelControl();
            this.MaasID = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.personelMaasTakipBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calisanTakipSistemiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calisanTakipSistemiDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridmaas)).BeginInit();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtArama.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maasMaastext.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maasGoreviText.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maasSoyadi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maasAdiText.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maasIDtext.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // personelMaasTakipBindingSource
            // 
            this.personelMaasTakipBindingSource.DataMember = "personelMaasTakip";
            this.personelMaasTakipBindingSource.DataSource = this.calisanTakipSistemiDataSet;
            // 
            // calisanTakipSistemiDataSet
            // 
            this.calisanTakipSistemiDataSet.DataSetName = "CalisanTakipSistemiDataSet";
            this.calisanTakipSistemiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // personelMaasTakipTableAdapter
            // 
            this.personelMaasTakipTableAdapter.ClearBeforeFill = true;
            // 
            // calisanTakipSistemiDataSet1
            // 
            this.calisanTakipSistemiDataSet1.DataSetName = "CalisanTakipSistemiDataSet1";
            this.calisanTakipSistemiDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // datagridmaas
            // 
            this.datagridmaas.AutoGenerateColumns = false;
            this.datagridmaas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.datagridmaas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridmaas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.personelIDDataGridViewTextBoxColumn,
            this.personelAdiDataGridViewTextBoxColumn,
            this.personelSoyadiDataGridViewTextBoxColumn,
            this.personelMevkiDataGridViewTextBoxColumn,
            this.personelMaasDataGridViewTextBoxColumn});
            this.datagridmaas.DataSource = this.personelMaasTakipBindingSource;
            this.datagridmaas.Location = new System.Drawing.Point(1, -1);
            this.datagridmaas.Name = "datagridmaas";
            this.datagridmaas.RowTemplate.Height = 24;
            this.datagridmaas.Size = new System.Drawing.Size(842, 692);
            this.datagridmaas.TabIndex = 17;
            this.datagridmaas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // personelIDDataGridViewTextBoxColumn
            // 
            this.personelIDDataGridViewTextBoxColumn.DataPropertyName = "PersonelID";
            this.personelIDDataGridViewTextBoxColumn.HeaderText = "PersonelID";
            this.personelIDDataGridViewTextBoxColumn.Name = "personelIDDataGridViewTextBoxColumn";
            // 
            // personelAdiDataGridViewTextBoxColumn
            // 
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
            // personelMevkiDataGridViewTextBoxColumn
            // 
            this.personelMevkiDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.personelMevkiDataGridViewTextBoxColumn.DataPropertyName = "PersonelMevki";
            this.personelMevkiDataGridViewTextBoxColumn.HeaderText = "PersonelMevki";
            this.personelMevkiDataGridViewTextBoxColumn.Name = "personelMevkiDataGridViewTextBoxColumn";
            // 
            // personelMaasDataGridViewTextBoxColumn
            // 
            this.personelMaasDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.personelMaasDataGridViewTextBoxColumn.DataPropertyName = "PersonelMaas";
            this.personelMaasDataGridViewTextBoxColumn.HeaderText = "PersonelMaas";
            this.personelMaasDataGridViewTextBoxColumn.Name = "personelMaasDataGridViewTextBoxColumn";
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.BorderRadius = 1;
            this.bunifuGradientPanel1.Controls.Add(this.btnBack);
            this.bunifuGradientPanel1.Controls.Add(this.btnClosem);
            this.bunifuGradientPanel1.Controls.Add(this.btnPersAra);
            this.bunifuGradientPanel1.Controls.Add(this.btnClear);
            this.bunifuGradientPanel1.Controls.Add(this.btnPersGuncel);
            this.bunifuGradientPanel1.Controls.Add(this.btnMaasDelete);
            this.bunifuGradientPanel1.Controls.Add(this.btnPersEkle);
            this.bunifuGradientPanel1.Controls.Add(this.txtArama);
            this.bunifuGradientPanel1.Controls.Add(this.maasMaastext);
            this.bunifuGradientPanel1.Controls.Add(this.maasGoreviText);
            this.bunifuGradientPanel1.Controls.Add(this.maasSoyadi);
            this.bunifuGradientPanel1.Controls.Add(this.maasAdiText);
            this.bunifuGradientPanel1.Controls.Add(this.maasIDtext);
            this.bunifuGradientPanel1.Controls.Add(this.maasMaas);
            this.bunifuGradientPanel1.Controls.Add(this.maasMevki);
            this.bunifuGradientPanel1.Controls.Add(this.maasSoyad);
            this.bunifuGradientPanel1.Controls.Add(this.maasAd);
            this.bunifuGradientPanel1.Controls.Add(this.MaasID);
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(23)))), ((int)(((byte)(65)))));
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(840, -1);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(456, 692);
            this.bunifuGradientPanel1.TabIndex = 20;
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
            this.btnBack.Location = new System.Drawing.Point(355, 3);
            this.btnBack.Name = "btnBack";
            this.btnBack.Rotation = 0;
            this.btnBack.ShowActiveImage = true;
            this.btnBack.ShowCursorChanges = true;
            this.btnBack.ShowImageBorders = true;
            this.btnBack.ShowSizeMarkers = false;
            this.btnBack.Size = new System.Drawing.Size(46, 48);
            this.btnBack.TabIndex = 13;
            this.btnBack.ToolTipText = "";
            this.btnBack.WaitOnLoad = false;
            this.btnBack.Zoom = 20;
            this.btnBack.ZoomSpeed = 10;
            this.btnBack.Click += new System.EventHandler(this.bunifuImageButton2_Click);
            // 
            // btnClosem
            // 
            this.btnClosem.ActiveImage = null;
            this.btnClosem.AllowAnimations = true;
            this.btnClosem.AllowBuffering = false;
            this.btnClosem.AllowToggling = false;
            this.btnClosem.AllowZooming = true;
            this.btnClosem.AllowZoomingOnFocus = false;
            this.btnClosem.BackColor = System.Drawing.Color.Transparent;
            this.btnClosem.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnClosem.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnClosem.ErrorImage")));
            this.btnClosem.FadeWhenInactive = false;
            this.btnClosem.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnClosem.Image = ((System.Drawing.Image)(resources.GetObject("btnClosem.Image")));
            this.btnClosem.ImageActive = null;
            this.btnClosem.ImageLocation = null;
            this.btnClosem.ImageMargin = 20;
            this.btnClosem.ImageSize = new System.Drawing.Size(26, 28);
            this.btnClosem.ImageZoomSize = new System.Drawing.Size(46, 48);
            this.btnClosem.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnClosem.InitialImage")));
            this.btnClosem.Location = new System.Drawing.Point(407, 3);
            this.btnClosem.Name = "btnClosem";
            this.btnClosem.Rotation = 0;
            this.btnClosem.ShowActiveImage = true;
            this.btnClosem.ShowCursorChanges = true;
            this.btnClosem.ShowImageBorders = true;
            this.btnClosem.ShowSizeMarkers = false;
            this.btnClosem.Size = new System.Drawing.Size(46, 48);
            this.btnClosem.TabIndex = 12;
            this.btnClosem.ToolTipText = "";
            this.btnClosem.WaitOnLoad = false;
            this.btnClosem.Zoom = 20;
            this.btnClosem.ZoomSpeed = 10;
            this.btnClosem.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // btnPersAra
            // 
            this.btnPersAra.ActiveBorderThickness = 1;
            this.btnPersAra.ActiveCornerRadius = 20;
            this.btnPersAra.ActiveFillColor = System.Drawing.Color.White;
            this.btnPersAra.ActiveForecolor = System.Drawing.Color.Transparent;
            this.btnPersAra.ActiveLineColor = System.Drawing.Color.White;
            this.btnPersAra.BackColor = System.Drawing.Color.Transparent;
            this.btnPersAra.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPersAra.BackgroundImage")));
            this.btnPersAra.ButtonText = "Personel Bul";
            this.btnPersAra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPersAra.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPersAra.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnPersAra.IdleBorderThickness = 1;
            this.btnPersAra.IdleCornerRadius = 20;
            this.btnPersAra.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnPersAra.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnPersAra.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnPersAra.Location = new System.Drawing.Point(52, 140);
            this.btnPersAra.Margin = new System.Windows.Forms.Padding(5);
            this.btnPersAra.Name = "btnPersAra";
            this.btnPersAra.Size = new System.Drawing.Size(170, 38);
            this.btnPersAra.TabIndex = 11;
            this.btnPersAra.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPersAra.Click += new System.EventHandler(this.btnPersAra_Click);
            // 
            // btnClear
            // 
            this.btnClear.ActiveBorderThickness = 1;
            this.btnClear.ActiveCornerRadius = 20;
            this.btnClear.ActiveFillColor = System.Drawing.Color.Transparent;
            this.btnClear.ActiveForecolor = System.Drawing.Color.Transparent;
            this.btnClear.ActiveLineColor = System.Drawing.Color.White;
            this.btnClear.BackColor = System.Drawing.Color.Transparent;
            this.btnClear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClear.BackgroundImage")));
            this.btnClear.ButtonText = "Temizle";
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnClear.IdleBorderThickness = 1;
            this.btnClear.IdleCornerRadius = 20;
            this.btnClear.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnClear.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnClear.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnClear.Location = new System.Drawing.Point(251, 553);
            this.btnClear.Margin = new System.Windows.Forms.Padding(5);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(170, 97);
            this.btnClear.TabIndex = 9;
            this.btnClear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnPersGuncel
            // 
            this.btnPersGuncel.ActiveBorderThickness = 1;
            this.btnPersGuncel.ActiveCornerRadius = 20;
            this.btnPersGuncel.ActiveFillColor = System.Drawing.Color.Transparent;
            this.btnPersGuncel.ActiveForecolor = System.Drawing.Color.Transparent;
            this.btnPersGuncel.ActiveLineColor = System.Drawing.Color.White;
            this.btnPersGuncel.BackColor = System.Drawing.Color.Transparent;
            this.btnPersGuncel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPersGuncel.BackgroundImage")));
            this.btnPersGuncel.ButtonText = "Güncelle";
            this.btnPersGuncel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPersGuncel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPersGuncel.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnPersGuncel.IdleBorderThickness = 1;
            this.btnPersGuncel.IdleCornerRadius = 20;
            this.btnPersGuncel.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnPersGuncel.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnPersGuncel.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnPersGuncel.Location = new System.Drawing.Point(71, 553);
            this.btnPersGuncel.Margin = new System.Windows.Forms.Padding(5);
            this.btnPersGuncel.Name = "btnPersGuncel";
            this.btnPersGuncel.Size = new System.Drawing.Size(170, 97);
            this.btnPersGuncel.TabIndex = 8;
            this.btnPersGuncel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPersGuncel.Click += new System.EventHandler(this.btnPersGuncel_Click);
            // 
            // btnMaasDelete
            // 
            this.btnMaasDelete.ActiveBorderThickness = 1;
            this.btnMaasDelete.ActiveCornerRadius = 20;
            this.btnMaasDelete.ActiveFillColor = System.Drawing.Color.Transparent;
            this.btnMaasDelete.ActiveForecolor = System.Drawing.Color.Transparent;
            this.btnMaasDelete.ActiveLineColor = System.Drawing.Color.White;
            this.btnMaasDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnMaasDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMaasDelete.BackgroundImage")));
            this.btnMaasDelete.ButtonText = "Sil";
            this.btnMaasDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaasDelete.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaasDelete.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnMaasDelete.IdleBorderThickness = 1;
            this.btnMaasDelete.IdleCornerRadius = 20;
            this.btnMaasDelete.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnMaasDelete.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnMaasDelete.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnMaasDelete.Location = new System.Drawing.Point(251, 446);
            this.btnMaasDelete.Margin = new System.Windows.Forms.Padding(5);
            this.btnMaasDelete.Name = "btnMaasDelete";
            this.btnMaasDelete.Size = new System.Drawing.Size(170, 97);
            this.btnMaasDelete.TabIndex = 7;
            this.btnMaasDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnMaasDelete.Click += new System.EventHandler(this.btnMaasDelete_Click);
            // 
            // btnPersEkle
            // 
            this.btnPersEkle.ActiveBorderThickness = 1;
            this.btnPersEkle.ActiveCornerRadius = 20;
            this.btnPersEkle.ActiveFillColor = System.Drawing.Color.Transparent;
            this.btnPersEkle.ActiveForecolor = System.Drawing.Color.Transparent;
            this.btnPersEkle.ActiveLineColor = System.Drawing.Color.White;
            this.btnPersEkle.BackColor = System.Drawing.Color.Transparent;
            this.btnPersEkle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPersEkle.BackgroundImage")));
            this.btnPersEkle.ButtonText = "Ekle";
            this.btnPersEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPersEkle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPersEkle.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnPersEkle.IdleBorderThickness = 1;
            this.btnPersEkle.IdleCornerRadius = 20;
            this.btnPersEkle.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnPersEkle.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnPersEkle.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnPersEkle.Location = new System.Drawing.Point(71, 446);
            this.btnPersEkle.Margin = new System.Windows.Forms.Padding(5);
            this.btnPersEkle.Name = "btnPersEkle";
            this.btnPersEkle.Size = new System.Drawing.Size(170, 97);
            this.btnPersEkle.TabIndex = 6;
            this.btnPersEkle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPersEkle.Click += new System.EventHandler(this.btnPersEkle_Click);
            // 
            // txtArama
            // 
            this.txtArama.Location = new System.Drawing.Point(230, 146);
            this.txtArama.Name = "txtArama";
            this.txtArama.Size = new System.Drawing.Size(181, 22);
            this.txtArama.TabIndex = 10;
            // 
            // maasMaastext
            // 
            this.maasMaastext.Location = new System.Drawing.Point(215, 380);
            this.maasMaastext.Name = "maasMaastext";
            this.maasMaastext.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.maasMaastext.Properties.Appearance.Options.UseFont = true;
            this.maasMaastext.Size = new System.Drawing.Size(196, 24);
            this.maasMaastext.TabIndex = 5;
            // 
            // maasGoreviText
            // 
            this.maasGoreviText.Location = new System.Drawing.Point(215, 339);
            this.maasGoreviText.Name = "maasGoreviText";
            this.maasGoreviText.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.maasGoreviText.Properties.Appearance.Options.UseFont = true;
            this.maasGoreviText.Size = new System.Drawing.Size(196, 24);
            this.maasGoreviText.TabIndex = 4;
            // 
            // maasSoyadi
            // 
            this.maasSoyadi.Location = new System.Drawing.Point(215, 301);
            this.maasSoyadi.Name = "maasSoyadi";
            this.maasSoyadi.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.maasSoyadi.Properties.Appearance.Options.UseFont = true;
            this.maasSoyadi.Size = new System.Drawing.Size(196, 24);
            this.maasSoyadi.TabIndex = 3;
            // 
            // maasAdiText
            // 
            this.maasAdiText.Location = new System.Drawing.Point(215, 259);
            this.maasAdiText.Name = "maasAdiText";
            this.maasAdiText.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.maasAdiText.Properties.Appearance.Options.UseFont = true;
            this.maasAdiText.Size = new System.Drawing.Size(196, 24);
            this.maasAdiText.TabIndex = 2;
            // 
            // maasIDtext
            // 
            this.maasIDtext.Location = new System.Drawing.Point(215, 219);
            this.maasIDtext.Name = "maasIDtext";
            this.maasIDtext.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.maasIDtext.Properties.Appearance.Options.UseFont = true;
            this.maasIDtext.Size = new System.Drawing.Size(196, 24);
            this.maasIDtext.TabIndex = 1;
            // 
            // maasMaas
            // 
            this.maasMaas.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.maasMaas.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.maasMaas.Appearance.Options.UseFont = true;
            this.maasMaas.Appearance.Options.UseForeColor = true;
            this.maasMaas.Location = new System.Drawing.Point(130, 380);
            this.maasMaas.Name = "maasMaas";
            this.maasMaas.Size = new System.Drawing.Size(58, 22);
            this.maasMaas.TabIndex = 14;
            this.maasMaas.Text = "Maaş : ";
            // 
            // maasMevki
            // 
            this.maasMevki.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.maasMevki.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.maasMevki.Appearance.Options.UseFont = true;
            this.maasMevki.Appearance.Options.UseForeColor = true;
            this.maasMevki.Location = new System.Drawing.Point(120, 339);
            this.maasMevki.Name = "maasMevki";
            this.maasMevki.Size = new System.Drawing.Size(68, 22);
            this.maasMevki.TabIndex = 12;
            this.maasMevki.Text = "Görevi : ";
            // 
            // maasSoyad
            // 
            this.maasSoyad.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.maasSoyad.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.maasSoyad.Appearance.Options.UseFont = true;
            this.maasSoyad.Appearance.Options.UseForeColor = true;
            this.maasSoyad.Location = new System.Drawing.Point(52, 301);
            this.maasSoyad.Name = "maasSoyad";
            this.maasSoyad.Size = new System.Drawing.Size(136, 22);
            this.maasSoyad.TabIndex = 10;
            this.maasSoyad.Text = "Personel Soyadı :";
            // 
            // maasAd
            // 
            this.maasAd.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.maasAd.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.maasAd.Appearance.Options.UseFont = true;
            this.maasAd.Appearance.Options.UseForeColor = true;
            this.maasAd.Location = new System.Drawing.Point(79, 259);
            this.maasAd.Name = "maasAd";
            this.maasAd.Size = new System.Drawing.Size(109, 22);
            this.maasAd.TabIndex = 8;
            this.maasAd.Text = "Personel Adı :";
            // 
            // MaasID
            // 
            this.MaasID.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.MaasID.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.MaasID.Appearance.Options.UseFont = true;
            this.MaasID.Appearance.Options.UseForeColor = true;
            this.MaasID.Location = new System.Drawing.Point(85, 219);
            this.MaasID.Name = "MaasID";
            this.MaasID.Size = new System.Drawing.Size(103, 22);
            this.MaasID.TabIndex = 6;
            this.MaasID.Text = "Personel ID :";
            // 
            // MaaşBilgileri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(1293, 688);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Controls.Add(this.datagridmaas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MaaşBilgileri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personel Maaş Bilgileri";
            this.Load += new System.EventHandler(this.MaaşBilgileri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.personelMaasTakipBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calisanTakipSistemiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calisanTakipSistemiDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridmaas)).EndInit();
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtArama.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maasMaastext.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maasGoreviText.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maasSoyadi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maasAdiText.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maasIDtext.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private CalisanTakipSistemiDataSet calisanTakipSistemiDataSet;
        private System.Windows.Forms.BindingSource personelMaasTakipBindingSource;
        private CalisanTakipSistemiDataSetTableAdapters.personelMaasTakipTableAdapter personelMaasTakipTableAdapter;
        private CalisanTakipSistemiDataSet1 calisanTakipSistemiDataSet1;
        private System.Windows.Forms.DataGridView datagridmaas;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelSoyadiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelMevkiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelMaasDataGridViewTextBoxColumn;
        private Bunifu.UI.WinForms.BunifuGradientPanel bunifuGradientPanel1;
        private DevExpress.XtraEditors.TextEdit txtArama;
        private DevExpress.XtraEditors.TextEdit maasMaastext;
        private DevExpress.XtraEditors.TextEdit maasGoreviText;
        private DevExpress.XtraEditors.TextEdit maasSoyadi;
        private DevExpress.XtraEditors.TextEdit maasAdiText;
        private DevExpress.XtraEditors.TextEdit maasIDtext;
        private DevExpress.XtraEditors.LabelControl maasMaas;
        private DevExpress.XtraEditors.LabelControl maasMevki;
        private DevExpress.XtraEditors.LabelControl maasSoyad;
        private DevExpress.XtraEditors.LabelControl maasAd;
        private DevExpress.XtraEditors.LabelControl MaasID;
        private Bunifu.Framework.UI.BunifuThinButton2 btnPersEkle;
        private Bunifu.Framework.UI.BunifuThinButton2 btnMaasDelete;
        private Bunifu.Framework.UI.BunifuThinButton2 btnPersGuncel;
        private Bunifu.Framework.UI.BunifuThinButton2 btnClear;
        private Bunifu.Framework.UI.BunifuThinButton2 btnPersAra;
        private Bunifu.UI.WinForms.BunifuImageButton btnClosem;
        private Bunifu.UI.WinForms.BunifuImageButton btnBack;
    }
}