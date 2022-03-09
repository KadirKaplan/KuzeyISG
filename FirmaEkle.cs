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

namespace KUZEY
{
    public partial class FirmaEkle : DevExpress.XtraEditors.XtraForm
    {
        List<OdemeTip> odemeTipleri = new List<OdemeTip>();
        bool firmasec;
        public FirmaEkle( bool firmaSec)
        {
            InitializeComponent();
            
            odemeTipleri.Add(new OdemeTip { Id = 1, OdemeTipi = "Nakit" });
            odemeTipleri.Add(new OdemeTip { Id = 2, OdemeTipi = "Kredi Kartı" });
            odemeTipleri.Add(new OdemeTip { Id = 3, OdemeTipi = "Firma Ödeme" });
            cmbOdemeTipi.Properties.DataSource = odemeTipleri;
            cmbOdemeTipi.Properties.DisplayMember = "OdemeTipi";
            cmbOdemeTipi.Properties.ValueMember = "Id";
            cmbOdemeTipi.Properties.NullText = "Seçiniz";
            firmasec = firmaSec;
            if (firmaSec)
            {
                txtAdres.Hide();
                txtAnlasma.Hide();
                txtFirmaAdi.Hide();
                txtGsm.Hide();
                txtIl.Hide();
                txtIlce.Hide();
                txtMail.Hide();
                txtTelefon.Hide();
                txtYetkili.Hide();
                cmbOdemeTipi.Hide();
                FirmaEkleKaydetButton.Hide();
                FirmaEkleSilButton.Hide();
                FirmaEkleGörüntüleButton.Hide();
            }
        }
        class OdemeTip
        {
            public int Id { get; set; }
            public string OdemeTipi { get; set; }
        }

        private void FirmaEkleCikisButton_Click(object sender, EventArgs e)
        {
            this.Close();

        }


        //SqlConnection baglan = new Ortak().baglantiOlustur();
        KUZEYEntities model = new KUZEYEntities(Ortak.conStr);
        Firma secilenFirma;
        private void firmaEkle()
        {
            OdemeTip odemeTipi = cmbOdemeTipi.GetSelectedDataRow() as OdemeTip;
            if (Id==0)
            {
                Firma firma = new Firma();
                firma.FirmaAdi = txtFirmaAdi.Text;
                firma.FirmaAdres = txtAdres.Text;
                firma.FirmaAnlasma = txtAnlasma.Text;
                firma.FirmaGSM = txtGsm.Text;
                firma.FirmaIl = txtIl.Text;
                firma.FirmaIlce = txtIlce.Text;
                firma.FirmaMail = txtMail.Text;
                if (odemeTipi != null) firma.FirmaOdemeTip = odemeTipi.Id;
                firma.FirmaTelefon = txtTelefon.Text;
                firma.FirmaIlgili = txtYetkili.Text;
                model.Firma.Add(firma);
                model.SaveChanges();
                Id = 0;
            }
            else
            {
                Firma firma=model.Firma.Where(a => a.Id == Id).FirstOrDefault();
                firma.FirmaAdi = txtFirmaAdi.Text;
                firma.FirmaAdres = txtAdres.Text;
                firma.FirmaAnlasma = txtAnlasma.Text;
                firma.FirmaGSM = txtGsm.Text;
                firma.FirmaIl = txtIl.Text;
                firma.FirmaIlce = txtIlce.Text;
                firma.FirmaMail = txtMail.Text;
                if (odemeTipi != null) firma.FirmaOdemeTip = odemeTipi.Id;
                firma.FirmaTelefon = txtTelefon.Text;
                firma.FirmaIlgili = txtYetkili.Text;
                model.Firma.Add(firma);
                model.Entry(firma).State = System.Data.Entity.EntityState.Modified;
                model.SaveChanges();
                Id = 0;

            }
            //SqlCommand komut = new SqlCommand("insert into Firma(FirmaAdi,FirmaAdres,FirmaTelefon,FirmaIlgili,FirmaMail,FirmaGSM,FirmaIl,FirmaIlce,FirmaAnlasma,FirmaOdemeTip) values ('" + txtFirmaAdi.Text.ToString() + "','" + txtAdres.Text.ToString() + "','" + txtTelefon.Text.ToString() + "','" + txtYetkili.Text.ToString() + "','" + txtMail.Text.ToString() + "','" + txtGsm.Text.ToString() + "','" + txtIl.Text.ToString() + "','" + txtIlce.Text.ToString() + "','" + txtAnlasma.Text.ToString() + "','" + (odemeTipi==null?"NULL":odemeTipi.Id.ToString()) + "')", baglan) ;
            //komut.ExecuteNonQuery();
            //baglan.Close();
            firmaGörüntüle();
            txtFirmaAdi.Text = "";
            txtAdres.Clear();
            txtTelefon.Clear();
            txtYetkili.Clear();
            txtMail.Clear();
            txtGsm.Clear();
            txtIl.Clear();
            txtIlce.Clear();
            txtAnlasma.Clear();
            //baglan.Close();
        }
        private void firmaGörüntüle()
        {
            List<Firma> firmaListe= model.Firma.ToList();
            listView1.DataSource = firmaListe;
            //listView1.Items.Clear();
            //baglan.Open();
            //SqlCommand komut = new SqlCommand("Select * from Firma", baglan);
            //SqlDataReader oku = komut.ExecuteReader();

            //while(oku.Read())

            //{
                
            //    ListViewItem ekle = new ListViewItem();
            //    ekle.Text = oku["Id"].ToString();
            //    ekle.SubItems.Add(oku["FirmaAdi"].ToString());
            //    ekle.SubItems.Add(oku["FirmaAdres"].ToString());
            //    ekle.SubItems.Add(oku["FirmaTelefon"].ToString());
            //    ekle.SubItems.Add(oku["FirmaIlgili"].ToString());
            //    ekle.SubItems.Add(oku["FirmaMail"].ToString());
            //    ekle.SubItems.Add(oku["FirmaGSM"].ToString());
            //    ekle.SubItems.Add(oku["FirmaIl"].ToString());
            //    ekle.SubItems.Add(oku["FirmaIlce"].ToString());
            //    ekle.SubItems.Add(oku["FirmaAnlasma"].ToString());
            //    ekle.SubItems.Add(oku["FirmaOdemeTip"].ToString());
                
            //    listView1.Items.Add(ekle);
                
            //}
            
            //baglan.Close();
        }
        private void FirmaEkleGeriButton_Click(object sender, EventArgs e)
        {
           MainMenu ana = new MainMenu();
            ana.Show();
            this.Hide();
            ana.Close();
            
        }

        

        private void FirmaEkleKaydetButton_Click(object sender, EventArgs e)
        {
            if(txtFirmaAdi.Text!="")
            {
                firmaEkle();
            }
            else
            {
                MessageBox.Show("Firma adı boş bırakılamaz");
            }
            
            
        }

        private void FirmaEkleGörüntüleButton_Click(object sender, EventArgs e)
        {
            firmaGörüntüle();
            
        }

        int Id =0;
        private void FirmaEkleSilButton_Click(object sender, EventArgs e)
        {
            //baglan.Open();
            //SqlCommand komut = new SqlCommand("Delete from Firma Where Id=(" + Id + ")", baglan);
            //komut.ExecuteNonQuery();
            //baglan.Close();
            Firma firma = listView1.SelectedRows[0].DataBoundItem as Firma;
            if (firma != null)
            {
                //model.Firma.Remove(secilenFirma);
                model.Set<Firma>().Attach(firma);
                model.Set<Firma>().Remove(firma);
                model.SaveChanges();
                firmaGörüntüle();
                txtFirmaAdi.Text="";
                txtAdres.Clear();
                txtTelefon.Clear();
                txtYetkili.Clear();
                txtMail.Clear();
                txtGsm.Clear();
                txtIl.Clear();
                txtIlce.Clear();
                txtAnlasma.Clear();
            }
            
        }


        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (!firmasec)
            {
                Firma firma = (Firma)listView1.SelectedRows[0].DataBoundItem;
                Id = firma.Id;
                txtFirmaAdi.Text = firma.FirmaAdi;
                txtAdres.Text = firma.FirmaAdres;
                txtTelefon.Text = firma.FirmaTelefon;
                txtYetkili.Text = firma.FirmaIlgili;
                txtMail.Text = firma.FirmaMail;
                txtGsm.Text = firma.FirmaGSM;
                txtIl.Text = firma.FirmaIl;
                txtIlce.Text = firma.FirmaIlce;
                txtAnlasma.Text = firma.FirmaAnlasma;
                cmbOdemeTipi.EditValue = firma.FirmaOdemeTip;
            }
            else
            {
                Firma firma = (Firma)listView1.SelectedRows[0].DataBoundItem;
                VeriEkle.gelenFirma = firma.FirmaAdi;
                this.Close();
            }

            //Id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);

            //txtFirmaAdi.Text = listView1.SelectedItems[0].SubItems[1].Text;
            //txtAdres.Text = listView1.SelectedItems[0].SubItems[2].Text;
            //txtTelefon.Text = listView1.SelectedItems[0].SubItems[3].Text;
            //txtYetkili.Text = listView1.SelectedItems[0].SubItems[4].Text;
            //txtMail.Text = listView1.SelectedItems[0].SubItems[5].Text;
            //txtGsm.Text = listView1.SelectedItems[0].SubItems[6].Text;
            //txtIl.Text = listView1.SelectedItems[0].SubItems[7].Text;
            //txtIlce.Text = listView1.SelectedItems[0].SubItems[8].Text;
            //txtAnlasma.Text = listView1.SelectedItems[0].SubItems[9].Text;
            //cmbOdemeTipi.EditValue = int.Parse(listView1.SelectedItems[0].SubItems[10].Text);

        }
        

        private void FirmaEkle_Load(object sender, EventArgs e)
        {
            firmaGörüntüle();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}