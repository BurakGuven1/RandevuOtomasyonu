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
    public partial class frmSoruCevapRapor : Form
    {
        public frmSoruCevapRapor()
        {
            InitializeComponent();
        }

        sqlBaglantisi bgl = new sqlBaglantisi();

        private void frmSoruCevapRapor_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("Select * From viewSorular", bgl.baglanti());
                da.Fill(dt);
                dgvSoruCevap.DataSource = dt;
                bgl.baglanti().Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
