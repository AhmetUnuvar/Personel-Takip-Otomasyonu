namespace Otomasyon
{
    partial class GirisForm
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GirisForm));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.bunifuGradientPanel1 = new Bunifu.UI.WinForms.BunifuGradientPanel();
            this.pictureEdit4 = new DevExpress.XtraEditors.PictureEdit();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.buntxtgiriskullanıcı = new Bunifu.UI.WinForms.BunifuTextBox();
            this.bunifuTextBoxsifre = new Bunifu.UI.WinForms.BunifuTextBox();
            this.admingirisbtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuImageButton1 = new Bunifu.UI.WinForms.BunifuImageButton();
            this.pictureEdit5 = new DevExpress.XtraEditors.PictureEdit();
            this.pictureEdit2 = new DevExpress.XtraEditors.PictureEdit();
            this.giristarihsaat = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit5.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Century Gothic", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(48, 426);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(390, 52);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Size Verilen Kullanıcı Adı  ve Şifrenizle\r\n                     Giriş Yapınız";
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.BorderRadius = 1;
            this.bunifuGradientPanel1.Controls.Add(this.pictureEdit4);
            this.bunifuGradientPanel1.Controls.Add(this.pictureEdit1);
            this.bunifuGradientPanel1.Controls.Add(this.labelControl1);
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(23)))), ((int)(((byte)(65)))));
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, -1);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(465, 520);
            this.bunifuGradientPanel1.TabIndex = 10;
            this.bunifuGradientPanel1.Click += new System.EventHandler(this.bunifuGradientPanel1_Click);
            // 
            // pictureEdit4
            // 
            this.pictureEdit4.EditValue = ((object)(resources.GetObject("pictureEdit4.EditValue")));
            this.pictureEdit4.Location = new System.Drawing.Point(0, 426);
            this.pictureEdit4.Name = "pictureEdit4";
            this.pictureEdit4.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit4.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit4.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit4.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit4.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit4.Size = new System.Drawing.Size(42, 45);
            this.pictureEdit4.TabIndex = 3;
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(166, 62);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit1.Size = new System.Drawing.Size(109, 109);
            this.pictureEdit1.TabIndex = 1;
            // 
            // buntxtgiriskullanıcı
            // 
            this.buntxtgiriskullanıcı.AcceptsReturn = false;
            this.buntxtgiriskullanıcı.AcceptsTab = false;
            this.buntxtgiriskullanıcı.AnimationSpeed = 200;
            this.buntxtgiriskullanıcı.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.buntxtgiriskullanıcı.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.buntxtgiriskullanıcı.AutoSizeHeight = true;
            this.buntxtgiriskullanıcı.BackColor = System.Drawing.Color.Transparent;
            this.buntxtgiriskullanıcı.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buntxtgiriskullanıcı.BackgroundImage")));
            this.buntxtgiriskullanıcı.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.buntxtgiriskullanıcı.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.buntxtgiriskullanıcı.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.buntxtgiriskullanıcı.BorderColorIdle = System.Drawing.Color.Silver;
            this.buntxtgiriskullanıcı.BorderRadius = 1;
            this.buntxtgiriskullanıcı.BorderThickness = 1;
            this.buntxtgiriskullanıcı.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.buntxtgiriskullanıcı.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.buntxtgiriskullanıcı.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.buntxtgiriskullanıcı.DefaultText = "";
            this.buntxtgiriskullanıcı.FillColor = System.Drawing.Color.White;
            this.buntxtgiriskullanıcı.HideSelection = true;
            this.buntxtgiriskullanıcı.IconLeft = null;
            this.buntxtgiriskullanıcı.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.buntxtgiriskullanıcı.IconPadding = 10;
            this.buntxtgiriskullanıcı.IconRight = null;
            this.buntxtgiriskullanıcı.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.buntxtgiriskullanıcı.Lines = new string[0];
            this.buntxtgiriskullanıcı.Location = new System.Drawing.Point(639, 127);
            this.buntxtgiriskullanıcı.MaxLength = 32767;
            this.buntxtgiriskullanıcı.MinimumSize = new System.Drawing.Size(1, 1);
            this.buntxtgiriskullanıcı.Modified = false;
            this.buntxtgiriskullanıcı.Multiline = false;
            this.buntxtgiriskullanıcı.Name = "buntxtgiriskullanıcı";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.buntxtgiriskullanıcı.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.buntxtgiriskullanıcı.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.buntxtgiriskullanıcı.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.buntxtgiriskullanıcı.OnIdleState = stateProperties4;
            this.buntxtgiriskullanıcı.Padding = new System.Windows.Forms.Padding(3);
            this.buntxtgiriskullanıcı.PasswordChar = '\0';
            this.buntxtgiriskullanıcı.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.buntxtgiriskullanıcı.PlaceholderText = "Enter text";
            this.buntxtgiriskullanıcı.ReadOnly = false;
            this.buntxtgiriskullanıcı.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.buntxtgiriskullanıcı.SelectedText = "";
            this.buntxtgiriskullanıcı.SelectionLength = 0;
            this.buntxtgiriskullanıcı.SelectionStart = 0;
            this.buntxtgiriskullanıcı.ShortcutsEnabled = true;
            this.buntxtgiriskullanıcı.Size = new System.Drawing.Size(327, 43);
            this.buntxtgiriskullanıcı.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.buntxtgiriskullanıcı.TabIndex = 11;
            this.buntxtgiriskullanıcı.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.buntxtgiriskullanıcı.TextMarginBottom = 0;
            this.buntxtgiriskullanıcı.TextMarginLeft = 3;
            this.buntxtgiriskullanıcı.TextMarginTop = 1;
            this.buntxtgiriskullanıcı.TextPlaceholder = "Enter text";
            this.buntxtgiriskullanıcı.UseSystemPasswordChar = false;
            this.buntxtgiriskullanıcı.WordWrap = true;
            // 
            // bunifuTextBoxsifre
            // 
            this.bunifuTextBoxsifre.AcceptsReturn = false;
            this.bunifuTextBoxsifre.AcceptsTab = false;
            this.bunifuTextBoxsifre.AnimationSpeed = 200;
            this.bunifuTextBoxsifre.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.bunifuTextBoxsifre.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.bunifuTextBoxsifre.AutoSizeHeight = true;
            this.bunifuTextBoxsifre.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTextBoxsifre.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuTextBoxsifre.BackgroundImage")));
            this.bunifuTextBoxsifre.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.bunifuTextBoxsifre.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuTextBoxsifre.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bunifuTextBoxsifre.BorderColorIdle = System.Drawing.Color.Silver;
            this.bunifuTextBoxsifre.BorderRadius = 1;
            this.bunifuTextBoxsifre.BorderThickness = 1;
            this.bunifuTextBoxsifre.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.bunifuTextBoxsifre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTextBoxsifre.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.bunifuTextBoxsifre.DefaultText = "";
            this.bunifuTextBoxsifre.FillColor = System.Drawing.Color.White;
            this.bunifuTextBoxsifre.HideSelection = true;
            this.bunifuTextBoxsifre.IconLeft = null;
            this.bunifuTextBoxsifre.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTextBoxsifre.IconPadding = 10;
            this.bunifuTextBoxsifre.IconRight = null;
            this.bunifuTextBoxsifre.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTextBoxsifre.Lines = new string[0];
            this.bunifuTextBoxsifre.Location = new System.Drawing.Point(639, 198);
            this.bunifuTextBoxsifre.MaxLength = 32767;
            this.bunifuTextBoxsifre.MinimumSize = new System.Drawing.Size(1, 1);
            this.bunifuTextBoxsifre.Modified = false;
            this.bunifuTextBoxsifre.Multiline = true;
            this.bunifuTextBoxsifre.Name = "bunifuTextBoxsifre";
            stateProperties5.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.bunifuTextBoxsifre.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.bunifuTextBoxsifre.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.bunifuTextBoxsifre.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.Silver;
            stateProperties8.FillColor = System.Drawing.Color.White;
            stateProperties8.ForeColor = System.Drawing.Color.Empty;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.bunifuTextBoxsifre.OnIdleState = stateProperties8;
            this.bunifuTextBoxsifre.Padding = new System.Windows.Forms.Padding(3);
            this.bunifuTextBoxsifre.PasswordChar = '*';
            this.bunifuTextBoxsifre.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.bunifuTextBoxsifre.PlaceholderText = "Enter text";
            this.bunifuTextBoxsifre.ReadOnly = false;
            this.bunifuTextBoxsifre.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.bunifuTextBoxsifre.SelectedText = "";
            this.bunifuTextBoxsifre.SelectionLength = 0;
            this.bunifuTextBoxsifre.SelectionStart = 0;
            this.bunifuTextBoxsifre.ShortcutsEnabled = true;
            this.bunifuTextBoxsifre.Size = new System.Drawing.Size(327, 43);
            this.bunifuTextBoxsifre.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.bunifuTextBoxsifre.TabIndex = 12;
            this.bunifuTextBoxsifre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bunifuTextBoxsifre.TextMarginBottom = 0;
            this.bunifuTextBoxsifre.TextMarginLeft = 3;
            this.bunifuTextBoxsifre.TextMarginTop = 1;
            this.bunifuTextBoxsifre.TextPlaceholder = "Enter text";
            this.bunifuTextBoxsifre.UseSystemPasswordChar = false;
            this.bunifuTextBoxsifre.WordWrap = true;
            // 
            // admingirisbtn
            // 
            this.admingirisbtn.ActiveBorderThickness = 1;
            this.admingirisbtn.ActiveCornerRadius = 20;
            this.admingirisbtn.ActiveFillColor = System.Drawing.Color.White;
            this.admingirisbtn.ActiveForecolor = System.Drawing.Color.Transparent;
            this.admingirisbtn.ActiveLineColor = System.Drawing.Color.White;
            this.admingirisbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.admingirisbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("admingirisbtn.BackgroundImage")));
            this.admingirisbtn.ButtonText = "Admin Giriş";
            this.admingirisbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.admingirisbtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admingirisbtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.admingirisbtn.IdleBorderThickness = 1;
            this.admingirisbtn.IdleCornerRadius = 20;
            this.admingirisbtn.IdleFillColor = System.Drawing.Color.Transparent;
            this.admingirisbtn.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.admingirisbtn.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.admingirisbtn.Location = new System.Drawing.Point(663, 262);
            this.admingirisbtn.Margin = new System.Windows.Forms.Padding(5);
            this.admingirisbtn.Name = "admingirisbtn";
            this.admingirisbtn.Size = new System.Drawing.Size(290, 41);
            this.admingirisbtn.TabIndex = 13;
            this.admingirisbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.admingirisbtn.Click += new System.EventHandler(this.admingirisbtn_Click);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.ActiveImage = null;
            this.bunifuImageButton1.AllowAnimations = true;
            this.bunifuImageButton1.AllowBuffering = false;
            this.bunifuImageButton1.AllowToggling = false;
            this.bunifuImageButton1.AllowZooming = true;
            this.bunifuImageButton1.AllowZoomingOnFocus = false;
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuImageButton1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.ErrorImage")));
            this.bunifuImageButton1.FadeWhenInactive = false;
            this.bunifuImageButton1.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.ImageLocation = null;
            this.bunifuImageButton1.ImageMargin = 20;
            this.bunifuImageButton1.ImageSize = new System.Drawing.Size(26, 28);
            this.bunifuImageButton1.ImageZoomSize = new System.Drawing.Size(46, 48);
            this.bunifuImageButton1.InitialImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.InitialImage")));
            this.bunifuImageButton1.Location = new System.Drawing.Point(971, -1);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Rotation = 0;
            this.bunifuImageButton1.ShowActiveImage = true;
            this.bunifuImageButton1.ShowCursorChanges = true;
            this.bunifuImageButton1.ShowImageBorders = true;
            this.bunifuImageButton1.ShowSizeMarkers = false;
            this.bunifuImageButton1.Size = new System.Drawing.Size(46, 48);
            this.bunifuImageButton1.TabIndex = 20;
            this.bunifuImageButton1.ToolTipText = "";
            this.bunifuImageButton1.WaitOnLoad = false;
            this.bunifuImageButton1.Zoom = 20;
            this.bunifuImageButton1.ZoomSpeed = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // pictureEdit5
            // 
            this.pictureEdit5.EditValue = ((object)(resources.GetObject("pictureEdit5.EditValue")));
            this.pictureEdit5.Location = new System.Drawing.Point(560, 127);
            this.pictureEdit5.Name = "pictureEdit5";
            this.pictureEdit5.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit5.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit5.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit5.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit5.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit5.Size = new System.Drawing.Size(44, 43);
            this.pictureEdit5.TabIndex = 24;
            // 
            // pictureEdit2
            // 
            this.pictureEdit2.EditValue = ((object)(resources.GetObject("pictureEdit2.EditValue")));
            this.pictureEdit2.Location = new System.Drawing.Point(560, 198);
            this.pictureEdit2.Name = "pictureEdit2";
            this.pictureEdit2.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit2.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit2.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit2.Size = new System.Drawing.Size(44, 43);
            this.pictureEdit2.TabIndex = 25;
            // 
            // giristarihsaat
            // 
            this.giristarihsaat.AutoSize = true;
            this.giristarihsaat.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.giristarihsaat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.giristarihsaat.Location = new System.Drawing.Point(499, 466);
            this.giristarihsaat.Name = "giristarihsaat";
            this.giristarihsaat.Size = new System.Drawing.Size(84, 28);
            this.giristarihsaat.TabIndex = 4;
            this.giristarihsaat.Text = "label1";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // GirisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(1029, 522);
            this.Controls.Add(this.giristarihsaat);
            this.Controls.Add(this.pictureEdit2);
            this.Controls.Add(this.pictureEdit5);
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.admingirisbtn);
            this.Controls.Add(this.bunifuTextBoxsifre);
            this.Controls.Add(this.buntxtgiriskullanıcı);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GirisForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş Paneli";
            this.Load += new System.EventHandler(this.GirisForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit5.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private Bunifu.UI.WinForms.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.UI.WinForms.BunifuTextBox buntxtgiriskullanıcı;
        private Bunifu.UI.WinForms.BunifuTextBox bunifuTextBoxsifre;
        private Bunifu.Framework.UI.BunifuThinButton2 admingirisbtn;
        private Bunifu.UI.WinForms.BunifuImageButton bunifuImageButton1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit4;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit5;
        private DevExpress.XtraEditors.PictureEdit pictureEdit2;
        private System.Windows.Forms.Label giristarihsaat;
        private System.Windows.Forms.Timer timer1;
    }
}

