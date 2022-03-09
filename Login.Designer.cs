namespace KUZEY
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.kullaniciAdi = new DevExpress.XtraEditors.TextEdit();
            this.SifreText = new DevExpress.XtraEditors.TextEdit();
            this.toolbarFormManager1 = new DevExpress.XtraBars.ToolbarForm.ToolbarFormManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.toolbarFormControl1 = new DevExpress.XtraBars.ToolbarForm.ToolbarFormControl();
            this.toolbarFormManager2 = new DevExpress.XtraBars.ToolbarForm.ToolbarFormManager(this.components);
            this.barDockControl1 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl2 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl3 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl4 = new DevExpress.XtraBars.BarDockControl();
            this.GirisButton = new DevExpress.XtraEditors.SimpleButton();
            this.CikisButton = new DevExpress.XtraEditors.SimpleButton();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.kullaniciAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SifreText.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolbarFormManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolbarFormControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolbarFormManager2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(24, 160);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(67, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Kullanıcı Adı";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(24, 192);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(26, 13);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Şifre";
            // 
            // kullaniciAdi
            // 
            this.kullaniciAdi.Location = new System.Drawing.Point(97, 157);
            this.kullaniciAdi.Name = "kullaniciAdi";
            this.kullaniciAdi.Size = new System.Drawing.Size(202, 20);
            this.kullaniciAdi.TabIndex = 0;
            this.kullaniciAdi.TabIndexChanged += new System.EventHandler(this.CikisButton_Click);
            // 
            // SifreText
            // 
            this.SifreText.Location = new System.Drawing.Point(97, 189);
            this.SifreText.Name = "SifreText";
            this.SifreText.Properties.UseSystemPasswordChar = true;
            this.SifreText.Size = new System.Drawing.Size(202, 20);
            this.SifreText.TabIndex = 1;
            // 
            // toolbarFormManager1
            // 
            this.toolbarFormManager1.DockControls.Add(this.barDockControlTop);
            this.toolbarFormManager1.DockControls.Add(this.barDockControlBottom);
            this.toolbarFormManager1.DockControls.Add(this.barDockControlLeft);
            this.toolbarFormManager1.DockControls.Add(this.barDockControlRight);
            this.toolbarFormManager1.Form = this;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 31);
            this.barDockControlTop.Manager = this.toolbarFormManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(340, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 304);
            this.barDockControlBottom.Manager = this.toolbarFormManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(340, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 31);
            this.barDockControlLeft.Manager = this.toolbarFormManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 273);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(340, 31);
            this.barDockControlRight.Manager = this.toolbarFormManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 273);
            // 
            // toolbarFormControl1
            // 
            this.toolbarFormControl1.Location = new System.Drawing.Point(0, 0);
            this.toolbarFormControl1.Manager = this.toolbarFormManager2;
            this.toolbarFormControl1.Name = "toolbarFormControl1";
            this.toolbarFormControl1.Size = new System.Drawing.Size(340, 31);
            this.toolbarFormControl1.TabIndex = 7;
            this.toolbarFormControl1.TabStop = false;
            this.toolbarFormControl1.ToolbarForm = this;
            // 
            // toolbarFormManager2
            // 
            this.toolbarFormManager2.DockControls.Add(this.barDockControl1);
            this.toolbarFormManager2.DockControls.Add(this.barDockControl2);
            this.toolbarFormManager2.DockControls.Add(this.barDockControl3);
            this.toolbarFormManager2.DockControls.Add(this.barDockControl4);
            this.toolbarFormManager2.Form = this;
            // 
            // barDockControl1
            // 
            this.barDockControl1.CausesValidation = false;
            this.barDockControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControl1.Location = new System.Drawing.Point(0, 31);
            this.barDockControl1.Manager = this.toolbarFormManager2;
            this.barDockControl1.Size = new System.Drawing.Size(340, 0);
            // 
            // barDockControl2
            // 
            this.barDockControl2.CausesValidation = false;
            this.barDockControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControl2.Location = new System.Drawing.Point(0, 304);
            this.barDockControl2.Manager = this.toolbarFormManager2;
            this.barDockControl2.Size = new System.Drawing.Size(340, 0);
            // 
            // barDockControl3
            // 
            this.barDockControl3.CausesValidation = false;
            this.barDockControl3.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControl3.Location = new System.Drawing.Point(0, 31);
            this.barDockControl3.Manager = this.toolbarFormManager2;
            this.barDockControl3.Size = new System.Drawing.Size(0, 273);
            // 
            // barDockControl4
            // 
            this.barDockControl4.CausesValidation = false;
            this.barDockControl4.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl4.Location = new System.Drawing.Point(340, 31);
            this.barDockControl4.Manager = this.toolbarFormManager2;
            this.barDockControl4.Size = new System.Drawing.Size(0, 273);
            // 
            // GirisButton
            // 
            this.GirisButton.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GirisButton.Appearance.Options.UseFont = true;
            this.GirisButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("GirisButton.ImageOptions.Image")));
            this.GirisButton.Location = new System.Drawing.Point(97, 231);
            this.GirisButton.Name = "GirisButton";
            this.GirisButton.Size = new System.Drawing.Size(86, 37);
            this.GirisButton.TabIndex = 2;
            this.GirisButton.Text = "Giriş";
            this.GirisButton.Click += new System.EventHandler(this.GirisButton_Click_1);
            // 
            // CikisButton
            // 
            this.CikisButton.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CikisButton.Appearance.Options.UseFont = true;
            this.CikisButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("CikisButton.ImageOptions.Image")));
            this.CikisButton.Location = new System.Drawing.Point(213, 231);
            this.CikisButton.Name = "CikisButton";
            this.CikisButton.Size = new System.Drawing.Size(86, 37);
            this.CikisButton.TabIndex = 3;
            this.CikisButton.Text = "Çıkış";
            this.CikisButton.Click += new System.EventHandler(this.CikisButton_Click);
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(26, 41);
            this.pictureEdit1.MenuManager = this.toolbarFormManager1;
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Properties.InitialImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("pictureEdit1.Properties.InitialImageOptions.Image")));
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Size = new System.Drawing.Size(275, 96);
            this.pictureEdit1.TabIndex = 17;
            // 
            // Login
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 304);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.CikisButton);
            this.Controls.Add(this.GirisButton);
            this.Controls.Add(this.SifreText);
            this.Controls.Add(this.kullaniciAdi);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Controls.Add(this.barDockControl3);
            this.Controls.Add(this.barDockControl4);
            this.Controls.Add(this.barDockControl2);
            this.Controls.Add(this.barDockControl1);
            this.Controls.Add(this.toolbarFormControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.KeyPreview = true;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KUZEY İŞ SAĞLIĞI VE GÜVENLİĞİ";
            this.ToolbarFormControl = this.toolbarFormControl1;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Login_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.kullaniciAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SifreText.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolbarFormManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolbarFormControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolbarFormManager2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit kullaniciAdi;
        private DevExpress.XtraEditors.TextEdit SifreText;
        private DevExpress.XtraBars.ToolbarForm.ToolbarFormManager toolbarFormManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.ToolbarForm.ToolbarFormControl toolbarFormControl1;
        private DevExpress.XtraBars.ToolbarForm.ToolbarFormManager toolbarFormManager2;
        private DevExpress.XtraBars.BarDockControl barDockControl1;
        private DevExpress.XtraBars.BarDockControl barDockControl2;
        private DevExpress.XtraBars.BarDockControl barDockControl3;
        private DevExpress.XtraBars.BarDockControl barDockControl4;
        private DevExpress.XtraEditors.SimpleButton CikisButton;
        private DevExpress.XtraEditors.SimpleButton GirisButton;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
    }
}