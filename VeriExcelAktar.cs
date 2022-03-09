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
using DevExpress.DashboardWin.Design;
using System.Diagnostics;

namespace KUZEY
{
    public partial class VeriExcelAktar : DevExpress.XtraEditors.XtraForm
    {
        public VeriExcelAktar()
        {
            InitializeComponent();
        }
        //SqlConnection baglan = new Ortak().baglantiOlustur();
        KUZEYEntities model = new KUZEYEntities(Ortak.conStr);
        void Listele()
        {
            //SqlDataAdapter da = new SqlDataAdapter("Select * from Islemler", baglan);
            //DataTable dt = new DataTable();
            //da.Fill(dt);
            List<Islemler> islemler = model.Islemler.ToList();
            gridControl2.DataSource = islemler;
        }

        private void VeriExcelAktar_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void ExcelAktarButton_Click(object sender, EventArgs e)
        {
            string path = "Veriler.xlsx";
            gridControl2.ExportToXlsx(path);
            // Open the created XLSX file with the default application.
            Process.Start(path);
        }
    }
}