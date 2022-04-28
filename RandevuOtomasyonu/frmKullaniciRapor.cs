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
    public partial class frmKullaniciRapor : Form
    {
        public frmKullaniciRapor()
        {
            InitializeComponent();
        }


        sqlBaglantisi bgl = new sqlBaglantisi();


        private void frmKullaniciRapor_Load(object sender, EventArgs e)
        {
            try
            {

                KullaniciListeleme();
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }


        private void KullaniciListeleme()
        {
            try
            {

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("Select * From viewKullanici", bgl.baglanti());
                da.Fill(dt);
                dgvKullaniciRapor.DataSource = dt;
                bgl.baglanti().Close();


            }
            catch (Exception ex)
            {

                throw ex;
            }

        }





    }
}
