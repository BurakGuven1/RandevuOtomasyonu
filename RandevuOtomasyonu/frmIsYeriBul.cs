using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb; //Access kütüphanesi
using System.Data.SqlClient;

namespace RandevuOtomasyonu
{
    public partial class frmIsYeriBul : Form
    {
        public frmIsYeriBul()
        {
            InitializeComponent();
        }
        sqlBaglantisi bgl = new sqlBaglantisi();
        SqlCommand komut = new SqlCommand();

        private void txtIsYeriBul_TextChanged(object sender, EventArgs e)
        {
            if (txtIsYeriBul.Text.Trim() == "")
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_IsYeri", bgl.baglanti());
                da.Fill(dt);
                dgvIsYeriBul.DataSource = dt;
            }
            else
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(" Select * From Tbl_IsYeri Where IsyeriAdi Like'" + txtIsYeriBul.Text + "%'", bgl.baglanti());
                da.Fill(dt);  
                dgvIsYeriBul.DataSource = dt;

            }
        }

        private void frmIsYeriBul_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_IsYeri", bgl.baglanti());
            da.Fill(dt);
            dgvIsYeriBul.DataSource = dt;
        }

        private void btnIsyeriOnceki_Click(object sender, EventArgs e)
        {
            frmNormalKullaniciEkrani fr = new frmNormalKullaniciEkrani();
            fr.Show();
            this.Hide();
        }
    }
}
