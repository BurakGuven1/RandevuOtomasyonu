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
    public partial class frmIsYeriIslemleri : Form
    {
        public frmIsYeriIslemleri()
        {
            InitializeComponent();
        }

        sqlBaglantisi bgl = new sqlBaglantisi();

        private void frmIsYeriIslemleri_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From tbl_IsYeri", bgl.baglanti());
            da.Fill(dt);
            dgvIsYeri.DataSource = dt;
            
        }

        private void btnIsYeriEkle_Click(object sender, EventArgs e)
        {
            
            frmIsyeriEkleme fr = new frmIsyeriEkleme();
            fr.Show();
            this.Hide();
        }

        private void btnIsYeriSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut1 = new SqlCommand("Delete From tbl_IsYeri Where IsyeriAdi=@p1", bgl.baglanti());
            komut1.Parameters.AddWithValue("@p1",txtIsyeriAd.Text);
            komut1.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("İş yeri silindi");
        }

        private void dgvIsYeri_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            int secilen = dgvIsYeri.SelectedCells[0].RowIndex;
            txtIsyeriAdres.Text = dgvIsYeri.Rows[secilen].Cells[3].Value.ToString();
            txtIsyeriAd.Text = dgvIsYeri.Rows[secilen].Cells[2].Value.ToString();
        }

        private void btnIsYeriGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut2 = new SqlCommand("Update tbl_IsYeri set IsyeriAdres=@p1  Where  IsyeriAdi=@p2", bgl.baglanti());
            komut2.Parameters.AddWithValue("@p1", txtIsyeriAdres.Text);
            komut2.Parameters.AddWithValue("@p2", txtIsyeriAd.Text);
            komut2.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("İş yeri güncellendi");
        }

        private void btnIsyeriOnceki_Click(object sender, EventArgs e)
        {
            frmGenelAdminEkrani fr = new frmGenelAdminEkrani();
            fr.Show();
            this.Hide();
        }

        private void btnKategoriIslemleri_Click(object sender, EventArgs e)
        {
            frmKategoriPaneli fr = new frmKategoriPaneli();
            fr.Show();
            this.Hide();
        }
    }
}
