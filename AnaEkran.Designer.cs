namespace KUZEY
{
    partial class AnaEkran
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaEkran));
            this.VeriEkleButton = new DevExpress.XtraEditors.SimpleButton();
            this.MuhButton = new DevExpress.XtraEditors.SimpleButton();
            this.RaporButton = new DevExpress.XtraEditors.SimpleButton();
            this.OnayButton = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // VeriEkleButton
            // 
            this.VeriEkleButton.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.VeriEkleButton.Appearance.Options.UseFont = true;
            this.VeriEkleButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("VeriEkleButton.ImageOptions.Image")));
            this.VeriEkleButton.Location = new System.Drawing.Point(12, 12);
            this.VeriEkleButton.Name = "VeriEkleButton";
            this.VeriEkleButton.Size = new System.Drawing.Size(148, 71);
            this.VeriEkleButton.TabIndex = 0;
            this.VeriEkleButton.Text = "Veri Girişi";
            this.VeriEkleButton.Click += new System.EventHandler(this.VeriEkleButton_Click_1);
            // 
            // MuhButton
            // 
            this.MuhButton.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MuhButton.Appearance.Options.UseFont = true;
            this.MuhButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("MuhButton.ImageOptions.Image")));
            this.MuhButton.Location = new System.Drawing.Point(12, 113);
            this.MuhButton.Name = "MuhButton";
            this.MuhButton.Size = new System.Drawing.Size(148, 71);
            this.MuhButton.TabIndex = 0;
            this.MuhButton.Text = "Muhasebe";
            // 
            // RaporButton
            // 
            this.RaporButton.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.RaporButton.Appearance.Options.UseFont = true;
            this.RaporButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("RaporButton.ImageOptions.Image")));
            this.RaporButton.Location = new System.Drawing.Point(12, 217);
            this.RaporButton.Name = "RaporButton";
            this.RaporButton.Size = new System.Drawing.Size(148, 71);
            this.RaporButton.TabIndex = 0;
            this.RaporButton.Text = "Rapor";
            // 
            // OnayButton
            // 
            this.OnayButton.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.OnayButton.Appearance.Options.UseFont = true;
            this.OnayButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("OnayButton.ImageOptions.Image")));
            this.OnayButton.Location = new System.Drawing.Point(192, 113);
            this.OnayButton.Name = "OnayButton";
            this.OnayButton.Size = new System.Drawing.Size(148, 71);
            this.OnayButton.TabIndex = 0;
            this.OnayButton.Text = "Onaylama";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(192, 12);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(148, 71);
            this.simpleButton1.TabIndex = 1;
            this.simpleButton1.Text = "Firma Ekle";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // AnaEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 668);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.OnayButton);
            this.Controls.Add(this.RaporButton);
            this.Controls.Add(this.MuhButton);
            this.Controls.Add(this.VeriEkleButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "AnaEkran";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AnaEkran";
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton VeriEkleButton;
        private DevExpress.XtraEditors.SimpleButton MuhButton;
        private DevExpress.XtraEditors.SimpleButton RaporButton;
        private DevExpress.XtraEditors.SimpleButton OnayButton;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}