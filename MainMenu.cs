using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;

namespace KUZEY
{
    public partial class MainMenu : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void barButtonItem16_ItemClick(object sender, ItemClickEventArgs e)
        {

        }
        FirmaEkle frm1;
        private void FirmaListeleButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (frm1 == null || frm1.IsDisposed)
            {

                frm1 = new FirmaEkle(false);
                frm1.MdiParent = this;
                frm1.Show();
            }
        }
        VeriEkle frm2;
        private void VeriListeleButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (frm2 == null)
            {
                frm2 = new VeriEkle(0);
                frm2.MdiParent = this;
                frm2.Show();
            }

        }

        private void VeriEkleButton_ItemClick(object sender, ItemClickEventArgs e)
        {

        }
        VeriListele frm3;
        private void barButtonItem10_ItemClick(object sender, ItemClickEventArgs e)
        {

            if (frm3 == null || frm3.IsDisposed)
            {
                frm3 = new VeriListele(0);
                frm3.MdiParent = this;
                frm3.Show();
            }
        }
        VeriEkle frm4;
        private void barButtonItem19_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (frm4 == null || frm4.IsDisposed)
            {
                frm4 = new VeriEkle(0);
                frm4.MdiParent = this;
                frm4.Show();
            }
        }
        /*ExcelAktar frm5;
        private void EcxelAktarımButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            if(frm5 == null || frm5.IsDisposed)
            {
                frm5 = new ExcelAktar();
                frm5.MdiParent = this;
                frm5.Show();
            }
        }*/
        VeriExcelAktar frm10;
        private void barButtonItem10_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            if (frm10 == null || frm10.IsDisposed)
            {
                frm10 = new VeriExcelAktar();
                frm10.MdiParent = this;
                frm10.Show();
            }
        }
        FirmaExcelAktar frm15;
        private void EcxelAktarımButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (frm15 == null || frm15.IsDisposed)
            {
                frm15 = new FirmaExcelAktar();
                frm15.MdiParent = this;
                frm15.Show();
            }

        }

        private void barButtonItem21_ItemClick(object sender, ItemClickEventArgs e)
        {
            KullaniciForm kullaniciForm = new KullaniciForm();
            kullaniciForm.Show();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            if (Ortak.kullanici == null)
            {
                rpgAyarlar.Visible = true;
                rpgFirmalar.Visible = false;
                rpgOnaylama.Visible = false;
                rpgVeriGirisi.Visible = false;
                rbgMuhasebe.Visible = false;
                rbgRapor.Visible = false;
            }
            else if (Ortak.kullanici.YetkiTip == 1) //Kullanıcı
            {
                rpgAyarlar.Visible = true;
                rpgFirmalar.Visible = true;
                rpgOnaylama.Visible = false;
                rpgVeriGirisi.Visible = true;
                rbgMuhasebe.Visible = false;
                rbgRapor.Visible = false;
            }
            else if (Ortak.kullanici.YetkiTip == 2) //Kontrol
            {
                rpgAyarlar.Visible = true;
                rpgFirmalar.Visible = true;
                rpgOnaylama.Visible = true;
                rpgVeriGirisi.Visible = true;
                rbgMuhasebe.Visible = false;
                rbgRapor.Visible = false;
            }
            else if (Ortak.kullanici.YetkiTip == 3) //Muhasebe
            {
                rpgAyarlar.Visible = true;
                rpgFirmalar.Visible = true;
                rpgOnaylama.Visible = true;
                rpgVeriGirisi.Visible = true;
                rbgMuhasebe.Visible = true;
                rbgRapor.Visible = true;
            }
            else if (Ortak.kullanici.YetkiTip == 4) //Yönetici
            {
                rpgAyarlar.Visible = true;
                rpgFirmalar.Visible = true;
                rpgOnaylama.Visible = true;
                rpgVeriGirisi.Visible = true;
                rbgMuhasebe.Visible = true;
                rbgRapor.Visible = true;
            }
        }

        private void barButtonItem22_ItemClick(object sender, ItemClickEventArgs e) //Kontrol Button
        {
            VeriListele vl = new VeriListele(1);
            vl.MdiParent = this;
            vl.Show();
        }

        private void barButtonItem23_ItemClick(object sender, ItemClickEventArgs e) //Muhasebe Button
        {
            VeriListele vl = new VeriListele(2);
            vl.MdiParent = this;
            vl.Show();
        }

        private void btnVeriler_ItemClick(object sender, ItemClickEventArgs e)
        {
            VeriListele vl = new VeriListele(3);
            vl.MdiParent = this;
            vl.Show();
        }

        private void barButtonItem20_ItemClick(object sender, ItemClickEventArgs e)
        {
            DBConfigcs vtayar = new DBConfigcs();
            //vtayar.MdiParent = this;
            vtayar.Show();
        }
    }
}