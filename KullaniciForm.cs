using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KUZEY
{
    public partial class KullaniciForm : Form
    {
        public KullaniciForm()
        {
            InitializeComponent();
        }
        KUZEYEntities model = new KUZEYEntities(Ortak.conStr);
        VW_KULLANICI secilenKullanici;
        private void KullaniciForm_Load(object sender, EventArgs e)
        {
            List<Sbt_YetkiTip> yetkiler = model.Sbt_YetkiTip.ToList();
            cmbYetki.Properties.DataSource = yetkiler;
            cmbYetki.Properties.DisplayMember = "Yetki";
            cmbYetki.Properties.ValueMember = "ID";
            cmbYetki.Properties.NullText = "Seçiniz";
            kullaniciListele();
        }

        private void dgKullanicilar_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            VW_KULLANICI kullanici = (VW_KULLANICI)dgKullanicilar.SelectedRows[0].DataBoundItem;
            if (kullanici != null)
            {
                secilenKullanici = kullanici;
                txtKullaniciAdi.Text = kullanici.KullaniciAd;
                txtSifre.Text = kullanici.KullaniciSifre;
                cmbYetki.EditValue = kullanici.YetkiTip;
                tglAktif.IsOn = kullanici.Aktif == null ? false : kullanici.Aktif.Value;
            }
        }

        private void kullaniciListele()
        {
            model = new KUZEYEntities(Ortak.conStr);
            List<VW_KULLANICI> kullanicilar = model.VW_KULLANICI.ToList();
            dgKullanicilar.DataSource = kullanicilar;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (kaydetBoslukKontrol())
            {
                Sbt_YetkiTip yetki = cmbYetki.GetSelectedDataRow() as Sbt_YetkiTip;
                if (secilenKullanici == null)
                {
                    Kullanicilar varMi = model.Kullanicilar.Where(a => a.KullaniciAd == txtKullaniciAdi.Text && a.KullaniciSifre == txtSifre.Text).FirstOrDefault();
                    if (varMi == null)
                    {

                        Kullanicilar kullanici = new Kullanicilar();
                        kullanici.Aktif = tglAktif.IsOn;
                        kullanici.KullaniciAd = txtKullaniciAdi.Text;
                        kullanici.KullaniciSifre = txtSifre.Text;
                        kullanici.YetkiTip = yetki.ID;
                        model.Kullanicilar.Add(kullanici);
                        model.SaveChanges();
                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı daha önce eklenmiş.");
                    }
                }
                else
                {
                    Kullanicilar varMi = model.Kullanicilar.Where(a => a.KullaniciAd == txtKullaniciAdi.Text && a.KullaniciSifre == txtSifre.Text).FirstOrDefault();
                    Kullanicilar kullanici= model.Kullanicilar.Where(a => a.Id == secilenKullanici.Id).FirstOrDefault();
                    if (varMi == null || kullanici.Id==varMi.Id)
                    {
                        kullanici.Aktif = tglAktif.IsOn;
                        kullanici.KullaniciAd = txtKullaniciAdi.Text;
                        kullanici.KullaniciSifre = txtSifre.Text;
                        kullanici.YetkiTip = yetki.ID;
                        //string secilenKullaniciStr = Newtonsoft.Json.JsonConvert.SerializeObject(secilenKullanici, Newtonsoft.Json.Formatting.Indented);
                        //Kullanicilar kullanici = Newtonsoft.Json.JsonConvert.DeserializeObject<Kullanicilar>(secilenKullaniciStr);
                        model.Kullanicilar.Add(kullanici);
                        model.Entry(kullanici).State = System.Data.Entity.EntityState.Modified;
                        model.SaveChanges();
                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı adı şifre daha önce kullanılmış.");
                    }
                }
                tglAktif.IsOn = false;
                txtKullaniciAdi.Text = "";
                txtSifre.Text = "";
                secilenKullanici = null;
                kullaniciListele();
            }
        }
        private bool kaydetBoslukKontrol()
        {
            bool sonuc = false;
            var yetki = cmbYetki.GetSelectedDataRow();
            if (string.IsNullOrEmpty(txtKullaniciAdi.Text))
            {
                MessageBox.Show("Kullanıcı adı boş bırakılamaz.");
            }
            else if (string.IsNullOrEmpty(txtSifre.Text))
            {
                MessageBox.Show("Şifre boş bırakılamaz.");
            }
            else if (yetki == null)
            {
                MessageBox.Show("Yetki seçmelisiniz.");
            }
            else
            {
                sonuc = true;
            }
            return sonuc;
        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            VW_KULLANICI secilenKullanici = (VW_KULLANICI)dgKullanicilar.SelectedRows[0].DataBoundItem;
            if (secilenKullanici != null)
            {
                Kullanicilar kullanici = model.Kullanicilar.Where(a => a.Id == secilenKullanici.Id).FirstOrDefault();
                model.Set<Kullanicilar>().Attach(kullanici);
                model.Set<Kullanicilar>().Remove(kullanici);
                model.SaveChanges();
                kullaniciListele();
            }
        }
    }
}
