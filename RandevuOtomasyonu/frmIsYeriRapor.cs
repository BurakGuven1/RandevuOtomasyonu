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
    public partial class frmIsYeriRapor : Form
    {
        public frmIsYeriRapor()
        {
            InitializeComponent();
        }

        sqlBaglantisi bgl = new sqlBaglantisi();


        private void frmIsYeriRapor_Load(object sender, EventArgs e)
        {

            try
            {

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("Select * From viewIsyeri", bgl.baglanti());
                da.Fill(dt);
                dgvIsyeriRapor.DataSource = dt;
                bgl.baglanti().Close();


            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
    }
}
