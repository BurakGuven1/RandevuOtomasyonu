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
    public partial class frmRandevuRapor : Form
    {
        public frmRandevuRapor()
        {
            InitializeComponent();
        }

        sqlBaglantisi bgl = new sqlBaglantisi();

        private void frmRandevuRapor_Load(object sender, EventArgs e)
        {

            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("Select * From viewRandevu", bgl.baglanti());
                da.Fill(dt);
                dgvRandevuRapor.DataSource = dt;
                bgl.baglanti().Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
