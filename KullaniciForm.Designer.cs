namespace KUZEY
{
    partial class KullaniciForm
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
            this.txtKullaniciAdi = new DevExpress.XtraEditors.TextEdit();
            this.txtSifre = new DevExpress.XtraEditors.TextEdit();
            this.tglAktif = new DevExpress.XtraEditors.ToggleSwitch();
            this.cmbYetki = new DevExpress.XtraEditors.LookUpEdit();
            this.dgKullanicilar = new System.Windows.Forms.DataGridView();
            this.KullaniciFormlayoutControl1ConvertedLayout = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.cmbYetkiitem = new DevExpress.XtraLayout.LayoutControlItem();
            this.tglAktifitem = new DevExpress.XtraLayout.LayoutControlItem();
            this.txtSifreitem = new DevExpress.XtraLayout.LayoutControlItem();
            this.txtKullaniciAdiitem = new DevExpress.XtraLayout.LayoutControlItem();
            this.dgKullanicilaritem = new DevExpress.XtraLayout.LayoutControlItem();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnVazgec = new DevExpress.XtraEditors.SimpleButton();
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.btnVazgecitem = new DevExpress.XtraLayout.LayoutControlItem();
            this.btnKaydetitem = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.txtKullaniciAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSifre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tglAktif.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbYetki.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgKullanicilar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KullaniciFormlayoutControl1ConvertedLayout)).BeginInit();
            this.KullaniciFormlayoutControl1ConvertedLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbYetkiitem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tglAktifitem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSifreitem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKullaniciAdiitem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgKullanicilaritem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVazgecitem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnKaydetitem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Location = new System.Drawing.Point(79, 12);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(122, 20);
            this.txtKullaniciAdi.StyleController = this.KullaniciFormlayoutControl1ConvertedLayout;
            this.txtKullaniciAdi.TabIndex = 0;
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(272, 12);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(114, 20);
            this.txtSifre.StyleController = this.KullaniciFormlayoutControl1ConvertedLayout;
            this.txtSifre.TabIndex = 1;
            // 
            // tglAktif
            // 
            this.tglAktif.Location = new System.Drawing.Point(272, 37);
            this.tglAktif.Name = "tglAktif";
            this.tglAktif.Properties.OffText = "Off";
            this.tglAktif.Properties.OnText = "On";
            this.tglAktif.Size = new System.Drawing.Size(114, 18);
            this.tglAktif.StyleController = this.KullaniciFormlayoutControl1ConvertedLayout;
            this.tglAktif.TabIndex = 3;
            // 
            // cmbYetki
            // 
            this.cmbYetki.Location = new System.Drawing.Point(79, 36);
            this.cmbYetki.Name = "cmbYetki";
            this.cmbYetki.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbYetki.Size = new System.Drawing.Size(122, 20);
            this.cmbYetki.StyleController = this.KullaniciFormlayoutControl1ConvertedLayout;
            this.cmbYetki.TabIndex = 6;
            // 
            // dgKullanicilar
            // 
            this.dgKullanicilar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgKullanicilar.Location = new System.Drawing.Point(12, 100);
            this.dgKullanicilar.Name = "dgKullanicilar";
            this.dgKullanicilar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgKullanicilar.Size = new System.Drawing.Size(374, 339);
            this.dgKullanicilar.TabIndex = 11;
            this.dgKullanicilar.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgKullanicilar_MouseDoubleClick);
            // 
            // KullaniciFormlayoutControl1ConvertedLayout
            // 
            this.KullaniciFormlayoutControl1ConvertedLayout.Controls.Add(this.btnSil);
            this.KullaniciFormlayoutControl1ConvertedLayout.Controls.Add(this.cmbYetki);
            this.KullaniciFormlayoutControl1ConvertedLayout.Controls.Add(this.tglAktif);
            this.KullaniciFormlayoutControl1ConvertedLayout.Controls.Add(this.txtSifre);
            this.KullaniciFormlayoutControl1ConvertedLayout.Controls.Add(this.txtKullaniciAdi);
            this.KullaniciFormlayoutControl1ConvertedLayout.Controls.Add(this.dgKullanicilar);
            this.KullaniciFormlayoutControl1ConvertedLayout.Controls.Add(this.btnVazgec);
            this.KullaniciFormlayoutControl1ConvertedLayout.Controls.Add(this.btnKaydet);
            this.KullaniciFormlayoutControl1ConvertedLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.KullaniciFormlayoutControl1ConvertedLayout.Location = new System.Drawing.Point(0, 0);
            this.KullaniciFormlayoutControl1ConvertedLayout.Name = "KullaniciFormlayoutControl1ConvertedLayout";
            this.KullaniciFormlayoutControl1ConvertedLayout.Root = this.layoutControlGroup1;
            this.KullaniciFormlayoutControl1ConvertedLayout.Size = new System.Drawing.Size(398, 451);
            this.KullaniciFormlayoutControl1ConvertedLayout.TabIndex = 12;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.cmbYetkiitem,
            this.tglAktifitem,
            this.txtSifreitem,
            this.txtKullaniciAdiitem,
            this.dgKullanicilaritem,
            this.btnVazgecitem,
            this.btnKaydetitem,
            this.layoutControlItem1});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(398, 451);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // cmbYetkiitem
            // 
            this.cmbYetkiitem.Control = this.cmbYetki;
            this.cmbYetkiitem.Location = new System.Drawing.Point(0, 24);
            this.cmbYetkiitem.Name = "cmbYetkiitem";
            this.cmbYetkiitem.Size = new System.Drawing.Size(193, 24);
            this.cmbYetkiitem.Text = "Yetki";
            this.cmbYetkiitem.TextLocation = DevExpress.Utils.Locations.Left;
            this.cmbYetkiitem.TextSize = new System.Drawing.Size(55, 13);
            // 
            // tglAktifitem
            // 
            this.tglAktifitem.Control = this.tglAktif;
            this.tglAktifitem.Location = new System.Drawing.Point(193, 24);
            this.tglAktifitem.Name = "tglAktifitem";
            this.tglAktifitem.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 3, 3);
            this.tglAktifitem.Size = new System.Drawing.Size(185, 24);
            this.tglAktifitem.Text = "Aktif";
            this.tglAktifitem.TextLocation = DevExpress.Utils.Locations.Left;
            this.tglAktifitem.TextSize = new System.Drawing.Size(55, 13);
            // 
            // txtSifreitem
            // 
            this.txtSifreitem.Control = this.txtSifre;
            this.txtSifreitem.Location = new System.Drawing.Point(193, 0);
            this.txtSifreitem.Name = "txtSifreitem";
            this.txtSifreitem.Size = new System.Drawing.Size(185, 24);
            this.txtSifreitem.Text = "Şifre";
            this.txtSifreitem.TextLocation = DevExpress.Utils.Locations.Left;
            this.txtSifreitem.TextSize = new System.Drawing.Size(55, 13);
            // 
            // txtKullaniciAdiitem
            // 
            this.txtKullaniciAdiitem.Control = this.txtKullaniciAdi;
            this.txtKullaniciAdiitem.Location = new System.Drawing.Point(0, 0);
            this.txtKullaniciAdiitem.Name = "txtKullaniciAdiitem";
            this.txtKullaniciAdiitem.Size = new System.Drawing.Size(193, 24);
            this.txtKullaniciAdiitem.Text = "Kullanıcı Adı";
            this.txtKullaniciAdiitem.TextLocation = DevExpress.Utils.Locations.Left;
            this.txtKullaniciAdiitem.TextSize = new System.Drawing.Size(55, 13);
            // 
            // dgKullanicilaritem
            // 
            this.dgKullanicilaritem.Control = this.dgKullanicilar;
            this.dgKullanicilaritem.Location = new System.Drawing.Point(0, 88);
            this.dgKullanicilaritem.Name = "dgKullanicilaritem";
            this.dgKullanicilaritem.Size = new System.Drawing.Size(378, 343);
            this.dgKullanicilaritem.TextSize = new System.Drawing.Size(0, 0);
            this.dgKullanicilaritem.TextVisible = false;
            // 
            // btnSil
            // 
            this.btnSil.ImageOptions.Image = global::KUZEY.Properties.Resources.trash_32x32;
            this.btnSil.Location = new System.Drawing.Point(132, 60);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(109, 36);
            this.btnSil.StyleController = this.KullaniciFormlayoutControl1ConvertedLayout;
            this.btnSil.TabIndex = 12;
            this.btnSil.Text = "Sil";
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnVazgec
            // 
            this.btnVazgec.ImageOptions.Image = global::KUZEY.Properties.Resources.cancel_32x32;
            this.btnVazgec.Location = new System.Drawing.Point(245, 60);
            this.btnVazgec.Name = "btnVazgec";
            this.btnVazgec.Size = new System.Drawing.Size(141, 36);
            this.btnVazgec.StyleController = this.KullaniciFormlayoutControl1ConvertedLayout;
            this.btnVazgec.TabIndex = 10;
            this.btnVazgec.Text = "Vazgeç";
            this.btnVazgec.Click += new System.EventHandler(this.btnVazgec_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.ImageOptions.Image = global::KUZEY.Properties.Resources.save_32x32;
            this.btnKaydet.Location = new System.Drawing.Point(12, 60);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(116, 36);
            this.btnKaydet.StyleController = this.KullaniciFormlayoutControl1ConvertedLayout;
            this.btnKaydet.TabIndex = 9;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnVazgecitem
            // 
            this.btnVazgecitem.Control = this.btnVazgec;
            this.btnVazgecitem.Location = new System.Drawing.Point(233, 48);
            this.btnVazgecitem.Name = "btnVazgecitem";
            this.btnVazgecitem.Size = new System.Drawing.Size(145, 40);
            this.btnVazgecitem.TextSize = new System.Drawing.Size(0, 0);
            this.btnVazgecitem.TextVisible = false;
            // 
            // btnKaydetitem
            // 
            this.btnKaydetitem.Control = this.btnKaydet;
            this.btnKaydetitem.Location = new System.Drawing.Point(0, 48);
            this.btnKaydetitem.Name = "btnKaydetitem";
            this.btnKaydetitem.Size = new System.Drawing.Size(120, 40);
            this.btnKaydetitem.TextSize = new System.Drawing.Size(0, 0);
            this.btnKaydetitem.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.btnSil;
            this.layoutControlItem1.Location = new System.Drawing.Point(120, 48);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(113, 40);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // KullaniciForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 451);
            this.Controls.Add(this.KullaniciFormlayoutControl1ConvertedLayout);
            this.Name = "KullaniciForm";
            this.Text = "Kullanıcılar";
            this.Load += new System.EventHandler(this.KullaniciForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtKullaniciAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSifre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tglAktif.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbYetki.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgKullanicilar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KullaniciFormlayoutControl1ConvertedLayout)).EndInit();
            this.KullaniciFormlayoutControl1ConvertedLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbYetkiitem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tglAktifitem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSifreitem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKullaniciAdiitem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgKullanicilaritem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVazgecitem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnKaydetitem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtKullaniciAdi;
        private DevExpress.XtraEditors.TextEdit txtSifre;
        private DevExpress.XtraEditors.ToggleSwitch tglAktif;
        private DevExpress.XtraEditors.LookUpEdit cmbYetki;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private DevExpress.XtraEditors.SimpleButton btnVazgec;
        private System.Windows.Forms.DataGridView dgKullanicilar;
        private DevExpress.XtraLayout.LayoutControl KullaniciFormlayoutControl1ConvertedLayout;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem cmbYetkiitem;
        private DevExpress.XtraLayout.LayoutControlItem tglAktifitem;
        private DevExpress.XtraLayout.LayoutControlItem txtSifreitem;
        private DevExpress.XtraLayout.LayoutControlItem txtKullaniciAdiitem;
        private DevExpress.XtraLayout.LayoutControlItem dgKullanicilaritem;
        private DevExpress.XtraLayout.LayoutControlItem btnVazgecitem;
        private DevExpress.XtraLayout.LayoutControlItem btnKaydetitem;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
    }
}