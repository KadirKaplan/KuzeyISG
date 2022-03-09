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
    public partial class FirmaExcelAktar : DevExpress.XtraEditors.XtraForm
    {
        public FirmaExcelAktar()
        {
            InitializeComponent();
        }
        //SqlConnection baglan = new Ortak().baglantiOlustur();
        KUZEYEntities model = new KUZEYEntities(Ortak.conStr);
        void Listele()
        {
            //SqlDataAdapter da = new SqlDataAdapter("Select * from Firma", baglan);
            //DataTable dt = new DataTable();
            //da.Fill(dt);
            List<Firma> firmaListesi = model.Firma.ToList();
            gridControl1.DataSource = firmaListesi;
        }

        private void FirmaExcelAktar_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void ExcelAktarButton_Click(object sender, EventArgs e)
        {
            string path = "Firmalar.xlsx";
            gridControl1.ExportToXlsx(path);
            // Open the created XLSX file with the default application.
            Process.Start(path);
        }
    }
}