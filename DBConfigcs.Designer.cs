namespace KUZEY
{
    partial class DBConfigcs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DBConfigcs));
            this.txtSunucu = new System.Windows.Forms.TextBox();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.txtVt = new System.Windows.Forms.TextBox();
            this.DBConfigcslayoutControl1ConvertedLayout = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.textBox1item = new DevExpress.XtraLayout.LayoutControlItem();
            this.textBox98item = new DevExpress.XtraLayout.LayoutControlItem();
            this.textBox99item = new DevExpress.XtraLayout.LayoutControlItem();
            this.textBox100item = new DevExpress.XtraLayout.LayoutControlItem();
            this.ConfigButtonitem = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.DBConfigcslayoutControl1ConvertedLayout)).BeginInit();
            this.DBConfigcslayoutControl1ConvertedLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox1item)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox98item)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox99item)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox100item)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConfigButtonitem)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSunucu
            // 
            this.txtSunucu.Location = new System.Drawing.Point(79, 12);
            this.txtSunucu.Name = "txtSunucu";
            this.txtSunucu.Size = new System.Drawing.Size(249, 20);
            this.txtSunucu.TabIndex = 1;
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Location = new System.Drawing.Point(79, 60);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(249, 20);
            this.txtKullaniciAdi.TabIndex = 3;
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(79, 84);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(249, 20);
            this.txtSifre.TabIndex = 5;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.Appearance.Options.UseFont = true;
            this.btnKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ConfigButton.ImageOptions.Image")));
            this.btnKaydet.Location = new System.Drawing.Point(12, 108);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(316, 36);
            this.btnKaydet.StyleController = this.DBConfigcslayoutControl1ConvertedLayout;
            this.btnKaydet.TabIndex = 62;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // txtVt
            // 
            this.txtVt.Location = new System.Drawing.Point(79, 36);
            this.txtVt.Name = "txtVt";
            this.txtVt.Size = new System.Drawing.Size(249, 20);
            this.txtVt.TabIndex = 64;
            // 
            // DBConfigcslayoutControl1ConvertedLayout
            // 
            this.DBConfigcslayoutControl1ConvertedLayout.Controls.Add(this.txtVt);
            this.DBConfigcslayoutControl1ConvertedLayout.Controls.Add(this.txtSifre);
            this.DBConfigcslayoutControl1ConvertedLayout.Controls.Add(this.txtKullaniciAdi);
            this.DBConfigcslayoutControl1ConvertedLayout.Controls.Add(this.txtSunucu);
            this.DBConfigcslayoutControl1ConvertedLayout.Controls.Add(this.btnKaydet);
            this.DBConfigcslayoutControl1ConvertedLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DBConfigcslayoutControl1ConvertedLayout.Location = new System.Drawing.Point(0, 0);
            this.DBConfigcslayoutControl1ConvertedLayout.Name = "DBConfigcslayoutControl1ConvertedLayout";
            this.DBConfigcslayoutControl1ConvertedLayout.Root = this.layoutControlGroup1;
            this.DBConfigcslayoutControl1ConvertedLayout.Size = new System.Drawing.Size(340, 156);
            this.DBConfigcslayoutControl1ConvertedLayout.TabIndex = 65;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.textBox1item,
            this.textBox98item,
            this.textBox99item,
            this.textBox100item,
            this.ConfigButtonitem});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(340, 156);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // textBox1item
            // 
            this.textBox1item.Control = this.txtVt;
            this.textBox1item.Location = new System.Drawing.Point(0, 24);
            this.textBox1item.Name = "textBox1item";
            this.textBox1item.Size = new System.Drawing.Size(320, 24);
            this.textBox1item.Text = "Veri Tabanı";
            this.textBox1item.TextLocation = DevExpress.Utils.Locations.Left;
            this.textBox1item.TextSize = new System.Drawing.Size(55, 13);
            // 
            // textBox98item
            // 
            this.textBox98item.Control = this.txtSifre;
            this.textBox98item.Location = new System.Drawing.Point(0, 72);
            this.textBox98item.Name = "textBox98item";
            this.textBox98item.Size = new System.Drawing.Size(320, 24);
            this.textBox98item.Text = "Şifre";
            this.textBox98item.TextLocation = DevExpress.Utils.Locations.Left;
            this.textBox98item.TextSize = new System.Drawing.Size(55, 13);
            // 
            // textBox99item
            // 
            this.textBox99item.Control = this.txtKullaniciAdi;
            this.textBox99item.Location = new System.Drawing.Point(0, 48);
            this.textBox99item.Name = "textBox99item";
            this.textBox99item.Size = new System.Drawing.Size(320, 24);
            this.textBox99item.Text = "Kullanıcı Adı";
            this.textBox99item.TextLocation = DevExpress.Utils.Locations.Left;
            this.textBox99item.TextSize = new System.Drawing.Size(55, 13);
            // 
            // textBox100item
            // 
            this.textBox100item.Control = this.txtSunucu;
            this.textBox100item.Location = new System.Drawing.Point(0, 0);
            this.textBox100item.Name = "textBox100item";
            this.textBox100item.Size = new System.Drawing.Size(320, 24);
            this.textBox100item.Text = "Sunucu";
            this.textBox100item.TextLocation = DevExpress.Utils.Locations.Left;
            this.textBox100item.TextSize = new System.Drawing.Size(55, 13);
            // 
            // ConfigButtonitem
            // 
            this.ConfigButtonitem.Control = this.btnKaydet;
            this.ConfigButtonitem.Location = new System.Drawing.Point(0, 96);
            this.ConfigButtonitem.Name = "ConfigButtonitem";
            this.ConfigButtonitem.Size = new System.Drawing.Size(320, 40);
            this.ConfigButtonitem.TextSize = new System.Drawing.Size(0, 0);
            this.ConfigButtonitem.TextVisible = false;
            // 
            // DBConfigcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 156);
            this.Controls.Add(this.DBConfigcslayoutControl1ConvertedLayout);
            this.Name = "DBConfigcs";
            this.Text = "DBConfigcs";
            this.Load += new System.EventHandler(this.DBConfigcs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DBConfigcslayoutControl1ConvertedLayout)).EndInit();
            this.DBConfigcslayoutControl1ConvertedLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox1item)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox98item)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox99item)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox100item)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConfigButtonitem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtSunucu;
        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.TextBox txtSifre;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private System.Windows.Forms.TextBox txtVt;
        private DevExpress.XtraLayout.LayoutControl DBConfigcslayoutControl1ConvertedLayout;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem textBox1item;
        private DevExpress.XtraLayout.LayoutControlItem textBox98item;
        private DevExpress.XtraLayout.LayoutControlItem textBox99item;
        private DevExpress.XtraLayout.LayoutControlItem textBox100item;
        private DevExpress.XtraLayout.LayoutControlItem ConfigButtonitem;
    }
}