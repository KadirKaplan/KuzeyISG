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
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace KUZEY
{
    public partial class DBConfigcs : DevExpress.XtraEditors.XtraForm
    {
        public DBConfigcs()
        {
            InitializeComponent();
        }

        
        private void DBConfigcs_Load(object sender, EventArgs e)
        {
            try
            {
                string vtBilgiStr = dosyadanOku();
                Ortak.Baglanti baglanti = Newtonsoft.Json.JsonConvert.DeserializeObject<Ortak.Baglanti>(vtBilgiStr);
                txtKullaniciAdi.Text = baglanti.username;
                txtSifre.Text = baglanti.parola;
                txtSunucu.Text = baglanti.sunucuAdres;
                txtVt.Text = baglanti.VeritabaniAdi;
            }
            catch (Exception)
            {

            }
            
        }

        private void SifreLabel_Click(object sender, EventArgs e)
        {

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Ortak.Baglanti baglanti = new Ortak.Baglanti();
            baglanti.parola = txtSifre.Text;
            baglanti.sunucuAdres = txtSunucu.Text;
            baglanti.username = txtKullaniciAdi.Text;
            baglanti.VeritabaniAdi = txtVt.Text;
            string vtBilgiStr = Newtonsoft.Json.JsonConvert.SerializeObject(baglanti, Newtonsoft.Json.Formatting.Indented);
            dosyayaYaz(vtBilgiStr);
        }
        private void dosyayaYaz(string veri)
        {
            string dosyaYolu = AppDomain.CurrentDomain.BaseDirectory;
            string dosya_yolu = dosyaYolu+ "config.config";
            //İşlem yapacağımız dosyanın yolunu belirtiyoruz.
            FileStream fs = new FileStream(dosya_yolu, FileMode.OpenOrCreate, FileAccess.Write);
            //Bir file stream nesnesi oluşturuyoruz. 1.parametre dosya yolunu,
            //2.parametre dosya varsa açılacağını yoksa oluşturulacağını belirtir,
            //3.parametre dosyaya erişimin veri yazmak için olacağını gösterir.
            StreamWriter sw = new StreamWriter(fs);
            //Yazma işlemi için bir StreamWriter nesnesi oluşturduk.
            
            //Dosyaya ekleyeceğimiz iki satırlık yazıyı WriteLine() metodu ile yazacağız.
            sw.Flush();
            //Veriyi tampon bölgeden dosyaya aktardık.
            sw.Close();
            fs.Close();
            //İşimiz bitince kullandığımız nesneleri iade ettik.
        }
        public string dosyadanOku()
        {
            string dosyaYolu = AppDomain.CurrentDomain.BaseDirectory;
            string dosya_yolu = dosyaYolu + "config.config";
            //Okuma işlem yapacağımız dosyanın yolunu belirtiyoruz.
            FileStream fs = new FileStream(dosya_yolu, FileMode.Open, FileAccess.Read);
            //Bir file stream nesnesi oluşturuyoruz. 1.parametre dosya yolunu,
            //2.parametre dosyanın açılacağını,
            //3.parametre dosyaya erişimin veri okumak için olacağını gösterir.
            StreamReader sw = new StreamReader(fs);
            //Okuma işlemi için bir StreamReader nesnesi oluşturduk.
            string yazi = sw.ReadLine();
            string yazilar = yazi;
            while (yazi != null)
            {
                Console.WriteLine(yazi);
                yazi = sw.ReadLine();
                yazilar += yazi;
            }
            //Satır satır okuma işlemini gerçekleştirdik ve ekrana yazdırdık
            //Son satır okunduktan sonra okuma işlemini bitirdik
            sw.Close();
            fs.Close();
            //İşimiz bitince kullandığımız nesneleri iade ettik.
            return yazilar;
        }
    }
}