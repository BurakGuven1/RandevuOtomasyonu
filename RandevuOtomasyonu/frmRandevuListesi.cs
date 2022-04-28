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
    public partial class frmRandevuListesi : Form
    {
        public frmRandevuListesi()
        {
            InitializeComponent();
        }

        public string kullaniciadi;
        sqlBaglantisi bgl = new sqlBaglantisi();

        private void frmRandevuListesi_Load(object sender, EventArgs e)
        {

            //Randevu Geçmişi
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Randevu", bgl.baglanti());
            da.Fill(dt);
            dgvRandevuListesi.DataSource = dt;
           
        }
    }
}
