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
namespace KUZEY
{
    public partial class VeriEkle : DevExpress.XtraEditors.XtraForm
    {
        public VeriEkle(int? islemTip)
        {
            InitializeComponent();
            txtPos.Text = "0";
            txtNakit.Text = "0";
            dtTarih.EditValue = DateTime.Now;
            dtEklenmeTarihi.EditValue = DateTime.Now;
            if (islemTip != null)
            {
                islemTuru = islemTip.Value;
            }
            if (islemTuru == 2)
            {
                lytFaturaNo.ContentVisible = true;
                lytFaturaTarihi.ContentVisible = true;
            }
        }
        int islemTuru = 0;
        public Islemler islem;
        private void VeriEkle_Load(object sender, EventArgs e)
        {
            if (islem != null)
            {
                if (islem.ACGrafi == "X")
                {
                    cbxACevet.Checked = true;
                }

                //Odyo
                if (islem.Odyo == "X")
                {
                    cbxOdyoEvet.Checked = true;
                    //Odyo = "X";
                }

                //SFT
                if (islem.SFT == "X")
                {
                    cbxSFTEvet.Checked = true;
                    //SFT = "X";
                }

                //EKG
                if (islem.EKG == "X") ;
                {
                    cbxEKGEvet.Checked = true;
                }
                //Hemogram
                if (islem.Hemogram == "X")
                {
                    cbxHemogramEvet.Checked = true;
                    Hemogram = "X";
                }
                //Biyokimya
                if (islem.Biyokimya == "X")
                {
                    cbxBiyokimyaEvet.Checked = true;
                    Biyokimya = "X";
                }
                //Burun
                if (islem.Burun == "X")
                {
                    cbxBurunEvet.Checked = true;
                }
                //Bogaz
                if (islem.Bogaz == "X")
                {
                    cbxBogazEvet.Checked = true;
                }

                //Gaita
                if (islem.Gaita == "X")
                {
                    cbxGaitaEvet.Checked = true;
                }

                //Tetanoz
                if (islem.Tetanoz == "X")
                {
                    cbxTetanozEvet.Checked = true;
                }

                //Hepatit
                if (islem.Hepatit == "X")
                {
                    cbxHepaitEvet.Checked = true;
                }

                //portor
                if (islem.Portor == "X")
                {
                    cbxPortorEvet.Checked = true;
                }

                //idrar
                if (islem.Idrar == "X")
                {
                    cbxIdrarEvet.Checked = true;
                }
                txtFirmaAdi.Text = islem.Firmaid;
                dtTarih.EditValue = islem.Tarih.ToString();
                txtPersonel.Text = islem.FirmaPersonel;
                txtAciklama.Text = islem.Aciklama;
                txtNakit.Text = islem.Nakit.ToString();
                txtPos.Text = islem.Pos.ToString();
                txtEkleyen.Text = islem.Ekleyen;
                dtEklenmeTarihi.EditValue = islem.EklemeTarihi.ToString();
            }
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GeriButton2_Click(object sender, EventArgs e)
        {
            MainMenu main = new MainMenu();
            main.Show();
            this.Hide();
        }

        //SqlConnection baglan = new Ortak().baglantiOlustur();
        KUZEYEntities model = new KUZEYEntities(Ortak.conStr);
        string AC, Odyo, SFT, EKG, Hemogram, Biyokimya, Burun, Bogaz, Gaita, Tetanoz, Hepatit, Portor, Idrar;

        private void txtFirmaAdi_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            FirmaEkle firmaEkle = new FirmaEkle(true);
            firmaEkle.ShowDialog();
            if (!string.IsNullOrEmpty(gelenFirma))
            {
                txtFirmaAdi.Text = gelenFirma;
            }
        }

        private void txtFirmaAdi_EditValueChanged(object sender, EventArgs e)
        {

        }
        public static string gelenFirma;
        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void VeriEKleKaydet()
        {
            //baglan.Open();
            //ACGrafi
            if (cbxACevet.Checked == true)
            {
                AC = "X";
            }

            else
            {
                AC = "";
            }
            //Odyo
            if (cbxOdyoEvet.Checked == true)
            {
                Odyo = "X";
            }

            else
            {
                Odyo = "";
            }
            //SFT
            if (cbxSFTEvet.Checked == true)
            {
                SFT = "X";
            }

            else
            {
                SFT = "";
            }
            //EKG
            if (cbxEKGEvet.Checked == true)
            {
                EKG = "X";
            }

            else
            {
                EKG = "";
            }
            //Hemogram
            if (cbxHemogramEvet.Checked == true)
            {
                Hemogram = "X";
            }

            else
            {
                Hemogram = "";
            }
            //Biyokimya
            if (cbxBiyokimyaEvet.Checked == true)
            {
                Biyokimya = "X";
            }

            else
            {
                Biyokimya = "";
            }
            //Burun
            if (cbxBurunEvet.Checked == true)
            {
                Burun = "X";
            }

            else
            {
                Burun = "";
            }
            //Bogaz
            if (cbxBogazEvet.Checked == true)
            {
                Bogaz = "X";
            }

            else
            {
                Bogaz = "";
            }
            //Gaita
            if (cbxGaitaEvet.Checked == true)
            {
                Gaita = "X";
            }

            else
            {
                Gaita = "";
            }
            //Tetanoz
            if (cbxTetanozEvet.Checked == true)
            {
                Tetanoz = "X";
            }

            else
            {
                Tetanoz = "";
            }
            //Hepatit
            if (cbxHepaitEvet.Checked == true)
            {
                Hepatit = "X";
            }

            else
            {
                Hepatit = "";
            }
            //portor
            if (cbxPortorEvet.Checked == true)
            {
                Portor = "X";
            }

            else
            {
                Portor = "";
            }
            //idrar
            if (cbxIdrarEvet.Checked == true)
            {
                Idrar = "X";
            }

            else
            {
                Idrar = "";
            }

            decimal nakit = 0;
            decimal.TryParse(txtNakit.Text, out nakit);
            decimal pos = 0;
            decimal.TryParse(txtPos.Text, out nakit);
            if (islem == null)
            {
                Islemler islemler = new Islemler();
                islemler.Firmaid = txtFirmaAdi.Text;
                islemler.Tarih = Convert.ToDateTime(dtTarih.EditValue);
                islemler.FirmaPersonel = txtPersonel.Text;
                islemler.ACGrafi = AC;
                islemler.Odyo = Odyo;
                islemler.SFT = SFT;
                islemler.EKG = EKG;
                islemler.Hemogram = Hemogram;
                islemler.Biyokimya = Biyokimya;
                islemler.Burun = Burun;
                islemler.Bogaz = Bogaz;
                islemler.Gaita = Gaita;
                islemler.Tetanoz = Tetanoz;
                islemler.KanGrubu = comboBox1.Text;
                islemler.Hepatit = Hepatit;
                islemler.Portor = Portor;
                islemler.Idrar = Idrar;
                islemler.Aciklama = txtAciklama.Text;
                islemler.Nakit = nakit;
                islemler.Pos = pos;
                islemler.Ekleyen = Ortak.kullanici.KullaniciAd;
                islemler.EklemeTarihi = Convert.ToDateTime(dtEklenmeTarihi.EditValue);
                model.Islemler.Add(islemler);
                model.SaveChanges();
            }
            else
            {
                islem.Firmaid = txtFirmaAdi.Text;
                islem.Tarih = Convert.ToDateTime(dtTarih.EditValue);
                islem.FirmaPersonel = txtPersonel.Text;
                islem.ACGrafi = AC;
                islem.Odyo = Odyo;
                islem.SFT = SFT;
                islem.EKG = EKG;
                islem.Hemogram = Hemogram;
                islem.Biyokimya = Biyokimya;
                islem.Burun = Burun;
                islem.Bogaz = Bogaz;
                islem.Gaita = Gaita;
                islem.Tetanoz = Tetanoz;
                islem.KanGrubu = comboBox1.Text;
                islem.Hepatit = Hepatit;
                islem.Portor = Portor;
                islem.Idrar = Idrar;
                islem.Aciklama = txtAciklama.Text;
                islem.Nakit = nakit;
                islem.Pos = pos;
                if (this.islemTuru == 0)
                {
                    islem.Ekleyen = Ortak.kullanici.KullaniciAd;
                    islem.EklemeTarihi = Convert.ToDateTime(dtEklenmeTarihi.EditValue);
                }
                else if (this.islemTuru == 1)
                {
                    islem.Kontrol = Ortak.kullanici.KullaniciAd;
                    islem.KontrolTarihi = DateTime.Now;
                }
                else if (this.islemTuru == 2)
                {
                    islem.Muhasebelestiren = Ortak.kullanici.KullaniciAd;
                    islem.MuhTarihi = DateTime.Now;
                    islem.FaturaNo = txtFaturaNo.Text;
                    islem.FaturaTarihi = DateTime.Parse(dtFaturaTarihi.Text);
                }
                model.Islemler.Add(islem);
                model.Entry(islem).State = System.Data.Entity.EntityState.Modified;
                model.SaveChanges();
                islem = null;
            }

            txtEkleyen.Text = "";
            txtFirmaAdi.Text = "";
            txtNakit.Text = "";
            txtPersonel.Text = "";
            txtPos.Text = "";
            txtAciklama.Text = "";
            //komut.Parameters.AddWithValue("@EklemeTarihi", Convert.ToDateTime(dateEdit4.EditValue));
            //komut.Parameters.AddWithValue("@Kontrol", textBox15.Text);
            //komut.Parameters.AddWithValue("@KontrolTarihi", Convert.ToDateTime(dateEdit2.EditValue));
            //komut.Parameters.AddWithValue("@Muhasebelestiren", textBox13.Text);

            //komut.Parameters.AddWithValue("@MuhTarihi", Convert.ToDateTime(dateEdit3.EditValue));
            //komut.Parameters.AddWithValue("@FaturaTarihi", Convert.ToDateTime(dateEdit5.EditValue));
            //komut.Parameters.AddWithValue("@FaturaNo", textBox20.Text);

            //SqlCommand komut = model.Database.SqlQuery("insert into Islemler(Firmaid,Tarih,FirmaPersonel,ACGrafi,Odyo,SFT,EKG,Hemogram,Biyokimya,Burun,Bogaz,Gaita,Tetanoz,KanGrubu,Hepatit,Portor,Idrar,Aciklama,Nakit,Pos,Ekleyen,EklemeTarihi,Kontrol,KontrolTarihi,Muhasebelestiren,MuhTarihi,FaturaTarihi,FaturaNo) values " +
            //                                                       "(@Firmaid,@Tarih,@FirmaPersonel,@ACGrafi,@Odyo,@SFT,@EKG,@Hemogram,@Biyokimya,@Burun,@Bogaz,@Gaita,@Tetanoz,@KanGrubu,@Hepatit,@Portor,@Idrar,@Aciklama,@Nakit,@Pos,@Ekleyen,@EklemeTarihi,@Kontrol,@KontrolTarihi,@Muhasebelestiren,@MuhTarihi,@FaturaTarihi,@FaturaNo)");


            // komut.Parameters.AddWithValue("@Firmaid", textBox1.Text);

            // komut.Parameters.AddWithValue("@Tarih", Convert.ToDateTime(dateEdit1.EditValue));

            // komut.Parameters.AddWithValue("@FirmaPersonel", textBox7.Text);

            // komut.Parameters.AddWithValue("@ACGrafi", AC);

            // komut.Parameters.AddWithValue("@Odyo", Odyo);
            // komut.Parameters.AddWithValue("@SFT", SFT);
            // komut.Parameters.AddWithValue("@EKG", EKG);
            // komut.Parameters.AddWithValue("@Hemogram", Hemogram);

            // komut.Parameters.AddWithValue("@Biyokimya", Biyokimya);
            // komut.Parameters.AddWithValue("@Burun", Burun);
            // komut.Parameters.AddWithValue("@Bogaz", Bogaz);
            // komut.Parameters.AddWithValue("@Gaita", Gaita);
            //komut.Parameters.AddWithValue("@Tetanoz", Tetanoz);
            //komut.Parameters.AddWithValue("@KanGrubu", comboBox1.Text);
            //komut.Parameters.AddWithValue("@Hepatit", Hepatit);
            //komut.Parameters.AddWithValue("@Portor", Portor);
            //komut.Parameters.AddWithValue("@Idrar", Idrar);


            //komut.Parameters.AddWithValue("@Aciklama", textBox2.Text);
            //komut.Parameters.AddWithValue("@Nakit", textBox4.Text);
            //komut.Parameters.AddWithValue("@Pos", textBox18.Text);
            //komut.Parameters.AddWithValue("@Ekleyen", textBox17.Text);


            //model.Database.
            //komut.ExecuteNonQuery();

            //baglan.Close();


        }
        private void KaydetButton_Click(object sender, EventArgs e)
        {
            if (txtFirmaAdi.Text != "")
            {
                VeriEKleKaydet();
                if (islemTuru > 0)
                {
                    this.Close();
                }
                MessageBox.Show("Ekleme işlemi başarılı");
            }
            else
            {
                MessageBox.Show("Firma adı boş bırakılamaz");
            }

            /* VeriEKleKaydet();
             MessageBox.Show("Ekleme işlemi başarılı");*/
        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}