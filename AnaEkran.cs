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

namespace KUZEY
{
    public partial class AnaEkran : DevExpress.XtraEditors.XtraForm
    {
        public AnaEkran()
        {
            InitializeComponent();
        }

       

        private void VeriEkleButton_Click_1(object sender, EventArgs e)
        {

            //  VeriGiris datainput = new VeriGiris();
            //datainput.Show();
            //this.Hide();
            //VeriEkle input = new VeriEkle();
            //input.Show();
            //this.Hide();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            FirmaEkle frm = new FirmaEkle(false);
            frm.Show();
            this.Hide();
        }
    }
}