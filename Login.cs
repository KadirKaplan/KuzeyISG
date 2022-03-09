using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Filtering.Templates;
using System.Security.Cryptography.X509Certificates;

namespace KUZEY
{
    public partial class Login : DevExpress.XtraBars.ToolbarForm.ToolbarForm
    {
        public Login()
        {
            InitializeComponent();
            Ortak.ConfigDoldur();
        }


        // 




        private void GirisButton_Click_1(object sender, EventArgs e)
        {
            string kadi = kullaniciAdi.Text;
            string sifree = SifreText.Text;

            if (kadi == "kuzey" && sifree == "3232")
            {

                MainMenu main = new MainMenu();
                this.Hide();
                main.ShowDialog();
                this.Close();
            }
            else if (kadi == "" || sifree == "")
            {
                MessageBox.Show("Kullanıcı adı veya şifre boş bırakılamaz. ");
            }
            else
            {
                KUZEYEntities model = new KUZEYEntities(Ortak.conStr);
                Kullanicilar kullanici = model.Kullanicilar.Where(a => a.KullaniciAd == kadi && a.KullaniciSifre == sifree && a.Aktif == true).FirstOrDefault();
                if (kullanici != null)
                {
                    Ortak.kullanici = kullanici;
                    MainMenu main = new MainMenu();
                    this.Hide();
                    main.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya şifre hatalı");
                }

            }


        }
        private void CikisButton_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                GirisButton.PerformClick();
            }
        }


    }
}