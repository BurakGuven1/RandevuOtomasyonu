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
    public partial class frmKategoriIslemleri : Form
    {
        public frmKategoriIslemleri()
        {
            InitializeComponent();
        }

        sqlBaglantisi bgl = new sqlBaglantisi();

        public void temizle()
        {
            txtKategoriId.Clear();
            txtKategoriAd.Clear();
          
        }

        private void frmKategoriIslemleri_Load(object sender, EventArgs e)
        {

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("Select * From tbl_Kategori", bgl.baglanti());
                da.Fill(dt);
               dgvKategoriPaneli.DataSource = dt;
              
            
        }

        private void btnKategoriEkle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into tbl_Kategori (KategoriId, KategoriAd) values (@p1,@p2)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtKategoriId.Text);
            komut.Parameters.AddWithValue("@p2", txtKategoriAd.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kategori eklendi");
        }


        private void dgvKategoriPaneli_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dgvKategoriPaneli.SelectedCells[0].RowIndex;
            txtKategoriId.Text = dgvKategoriPaneli.Rows[secilen].Cells[0].Value.ToString();
            txtKategoriAd.Text = dgvKategoriPaneli.Rows[secilen].Cells[1].Value.ToString();
        }

        private void btnKategoriGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update tbl_Kategori set KategoriAd=@p1 Where KategoriId=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtKategoriAd.Text);
            komut.Parameters.AddWithValue("@p2", txtKategoriId.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kategori güncellendi");
        }

        private void btnKategoriSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete From tbl_Kategori  Where KategoriId=@b1", bgl.baglanti());
            komut.Parameters.AddWithValue("@b1", txtKategoriId.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kategori  silindi");
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            DialogResult cikis = new DialogResult();

            cikis = MessageBox.Show("Çıkmak istediğinize  Emin Misiniz ?", "Uyarı", MessageBoxButtons.YesNo);
            if (cikis == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
            }
        }

        private void btnIsyeriOnceki_Click(object sender, EventArgs e)
        {
            frmIsYeriIslemleri fr = new frmIsYeriIslemleri();
            fr.Show();
            this.Hide();
        }
    }
}
