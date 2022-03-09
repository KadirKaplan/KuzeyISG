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
    public partial class den : DevExpress.XtraEditors.XtraForm
    {
        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-6J7IQ9A; Initial Catalog=KUZEY; User Id=sa; password=Mimax2323362;");
        public den()
        {
            InitializeComponent();
            baglan.Open();
        }
        
        private void den_Load(object sender, EventArgs e)
        {
           
                
        }
        
        
        private void simpleButton1_Click(object sender, EventArgs e)
        {
           
            
            SqlCommand den = new SqlCommand("insert into tarih(tarih)values(@Tarih)",baglan);
            den.Parameters.AddWithValue("@Tarih", Convert.ToDateTime(dateEdit1.EditValue));
            den.ExecuteNonQuery();
            baglan.Close();
        }
    }
}