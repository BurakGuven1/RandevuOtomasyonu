using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace RandevuOtomasyonu
{
    public partial class frmIsYeriYetkilisiRapor : Form
    {
        public frmIsYeriYetkilisiRapor()
        {
            InitializeComponent();
        }

        sqlBaglantisi bgl = new sqlBaglantisi();

        private void frmIsYeriYetkilisiRapor_Load(object sender, EventArgs e)
        {

            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("Select * From viewIsYeriYetkili", bgl.baglanti());
                da.Fill(dt);
                dgvIsYeriYetkilisiRapor.DataSource = dt;
                bgl.baglanti().Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        
    }
}
