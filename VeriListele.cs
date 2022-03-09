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
using System.Diagnostics;
using DevExpress.XtraGrid.Views.Grid;

namespace KUZEY
{
    public partial class VeriListele : DevExpress.XtraEditors.XtraForm
    {
        public VeriListele(int islemTip)
        {
            InitializeComponent();
            dtBas.Text = DateTime.Now.AddMonths(-1).ToShortDateString();
            dtSon.Text = DateTime.Now.AddHours(23).AddMinutes(59).AddSeconds(59).ToShortDateString();
            if (Ortak.kullanici.YetkiTip == 1) //Kullanıcı
            {
                btnKontrol.Enabled = false;
                btnMuhasebe.Enabled = false;
                VeriEkleSilButton.Enabled = false;
            }
            if (Ortak.kullanici.YetkiTip == 2) //Kontrol
            {
                btnMuhasebe.Enabled = false;
            }
            islemTuru = islemTip;
        }
        int islemTuru = 0;
        //SqlConnection baglan = new Ortak().baglantiOlustur();
        KUZEYEntities model = new KUZEYEntities(Ortak.conStr);
        private void VeriGoruntule()
        {
            DateTime tarih1 = DateTime.Parse(dtBas.Text);
            DateTime tarih2 = DateTime.Parse(dtSon.Text);
            if (Ortak.kullanici.YetkiTip == 1)
            {
                dgVeriler.DataSource = model.Islemler.Where(a => (a.KontrolTarihi == null && (a.Kontrol == null || a.Kontrol == ""))
                && (txtAranan.Text == string.Empty ? 1 == 1 : (a.Firmaid.ToUpper().Contains(txtAranan.Text.ToUpper()) || a.Ekleyen.ToUpper().Contains(txtAranan.Text.ToUpper())))
                && tarih1 <= a.Tarih && tarih2 >= a.Tarih
                ).ToList();
            }
            else if (Ortak.kullanici.YetkiTip == 2)
            {
                dgVeriler.DataSource = model.Islemler.Where(a => (a.MuhTarihi == null && (a.Muhasebelestiren == null || a.Muhasebelestiren == ""))
                && (islemTuru != 1 ? 1 == 1 : (a.KontrolTarihi == null && (a.Kontrol == null || a.Kontrol == "")))
                && (txtAranan.Text == string.Empty ? 1 == 1 : (a.Firmaid.ToUpper().Contains(txtAranan.Text.ToUpper()) || a.Ekleyen.ToUpper().Contains(txtAranan.Text.ToUpper())))
                && tarih1 <= a.Tarih && tarih2 >= a.Tarih).ToList();
            }
            else
            {
                dgVeriler.DataSource = model.Islemler.Where(a => (txtAranan.Text == string.Empty ? 1 == 1 : (a.Firmaid.ToUpper().Contains(txtAranan.Text.ToUpper()) || a.Ekleyen.ToUpper().Contains(txtAranan.Text.ToUpper())))
                && (islemTuru != 2 ? 1 == 1 : (a.MuhTarihi == null && (a.Muhasebelestiren == null || a.Muhasebelestiren == "")))
                && tarih1 <= a.Tarih && tarih2 >= a.Tarih).ToList();
            }

            //listView35.Items.Clear();
            //baglan.Open();
            //SqlCommand komut = new SqlCommand("Select * from Islemler", baglan);
            //SqlDataReader oku = komut.ExecuteReader();

            //while (oku.Read())

            //{

            //    ListViewItem ekle = new ListViewItem();
            //    ekle.Text = oku["id"].ToString();
            //    ekle.SubItems.Add(oku["Firmaid"].ToString());
            //    ekle.SubItems.Add(oku["Tarih"].ToString());
            //    ekle.SubItems.Add(oku["FirmaPersonel"].ToString());
            //    ekle.SubItems.Add(oku["ACGrafi"].ToString());
            //    ekle.SubItems.Add(oku["Odyo"].ToString());
            //    ekle.SubItems.Add(oku["SFT"].ToString());
            //    ekle.SubItems.Add(oku["EKG"].ToString());
            //    ekle.SubItems.Add(oku["Hemogram"].ToString());
            //    ekle.SubItems.Add(oku["Biyokimya"].ToString());
            //    ekle.SubItems.Add(oku["Burun"].ToString());

            //    ekle.SubItems.Add(oku["Bogaz"].ToString());
            //    ekle.SubItems.Add(oku["Gaita"].ToString());
            //    ekle.SubItems.Add(oku["Tetanoz"].ToString());
            //    ekle.SubItems.Add(oku["KanGrubu"].ToString());
            //    ekle.SubItems.Add(oku["Hepatit"].ToString());
            //    ekle.SubItems.Add(oku["Portor"].ToString());
            //    ekle.SubItems.Add(oku["Idrar"].ToString());
            //    ekle.SubItems.Add(oku["Aciklama"].ToString());
            //    ekle.SubItems.Add(oku["Nakit"].ToString());
            //    ekle.SubItems.Add(oku["Pos"].ToString());

            //    ekle.SubItems.Add(oku["Ekleyen"].ToString());
            //    ekle.SubItems.Add(oku["EklemeTarihi"].ToString());
            //    ekle.SubItems.Add(oku["Kontrol"].ToString());
            //    ekle.SubItems.Add(oku["KontrolTarihi"].ToString());
            //    ekle.SubItems.Add(oku["Muhasebelestiren"].ToString());

            //    ekle.SubItems.Add(oku["MuhTarihi"].ToString());
            //    ekle.SubItems.Add(oku["FaturaTarihi"].ToString());
            //    ekle.SubItems.Add(oku["FaturaNo"].ToString());
            //    listView35.Items.Add(ekle);

            //}

            //baglan.Close();
        }

        private void VeriSil(object sender, EventArgs e)
        {



        }
        private void VeriEkleGörüntüleButton_Click(object sender, EventArgs e)
        {
            VeriGoruntule();
        }
        int id = 0;
        private object textBox1;
        private object dateEdit1;

        private void VeriEkleSilButton_Click(object sender, EventArgs e)
        {
            //baglan.Open();
            //SqlCommand komut = new SqlCommand("Delete from Islemler Where id=(" + id + ")", baglan);
            //komut.ExecuteNonQuery();
            //baglan.Close();

            //Islemler islem = dgVeriler.FocusedView as Islemler;
            Islemler islem = dgVeriler.SelectedRows[0].DataBoundItem as Islemler;
            if (islem != null)
            {
                model.Database.ExecuteSqlCommand("Delete from Islemler Where id=(" + islem.id + ")");
                model.SaveChanges();

                VeriGoruntule();
            }

        }

        private void listView35_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //id = int.Parse(listView35.SelectedItems[0].SubItems[0].Text);

            //textBox1 = listView35.SelectedItems[0].SubItems[0].Text;
            //dateEdit1 = listView35.SelectedItems[0].SubItems[1].Text;
            /*  textBox5.Text = listView1.SelectedItems[0].SubItems[2].Text;
              textBox4.Text = listView1.SelectedItems[0].SubItems[3].Text;
              textBox3.Text = listView1.SelectedItems[0].SubItems[4].Text;
              textBox2.Text = listView1.SelectedItems[0].SubItems[5].Text;
              textBox1.Text = listView1.SelectedItems[0].SubItems[6].Text;
              textBox11.Text = listView1.SelectedItems[0].SubItems[7].Text;
              textBox10.Text = listView1.SelectedItems[0].SubItems[8].Text;
              textBox9.Text = listView1.SelectedItems[0].SubItems[9].Text;
              textBox8.Text = listView1.SelectedItems[0].SubItems[10].Text;*/

        }

        private void VeriEkleGüncdelleButton_Click(object sender, EventArgs e)
        {
            VeriEkle ve = new VeriEkle(0); //Ekleme-Güncelleme
            ve.islem = dgVeriler.SelectedRows[0].DataBoundItem as Islemler;
            ve.Show();
        }


        private void dgVeriler_Click_1(object sender, EventArgs e)
        {

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (dgVeriler.SelectedRows.Count > 0)
            {
                VeriEkle ve = new VeriEkle(2); //Muhasebe
                ve.islem = dgVeriler.SelectedRows[0].DataBoundItem as Islemler;
                ve.Show();
            }
        }

        private void btnKontrol_Click(object sender, EventArgs e)
        {
            if (dgVeriler.SelectedRows.Count > 0)
            {
                VeriEkle ve = new VeriEkle(1); //Kontrol
                ve.islem = dgVeriler.SelectedRows[0].DataBoundItem as Islemler;
                ve.Show();
            }

        }
    }
}