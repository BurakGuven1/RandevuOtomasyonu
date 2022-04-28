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
    public partial class frmIsyeriEkleme : Form
    {
        public frmIsyeriEkleme()
        {
            InitializeComponent();
        }

        sqlBaglantisi bgl = new sqlBaglantisi();

        private void btnIsYeriEkle_Click(object sender, EventArgs e)
        {
           

            SqlCommand komut1 = new SqlCommand("insert into Tbl_IsYeri (KategoriId, IsyeriAdi, IsyeriAdres, IsyeriTelNo, YetkiliId, KategoriAdi, YetkiliAdi) values (@p2,@p3,@p4,@p5,@p6,@p7,@p8)" , bgl.baglanti());
            komut1.Parameters.AddWithValue("@p2", txtIsYeriKategoriId.Text);
            komut1.Parameters.AddWithValue("@p3", txtIsYeriAdi.Text);
            komut1.Parameters.AddWithValue("@p4", txtIsYeriAdres.Text);
            komut1.Parameters.AddWithValue("@p5", mskdtxtIsYeriTelNo.Text);
            komut1.Parameters.AddWithValue("@p6", txtIsYeriYetkiliId.Text);
            komut1.Parameters.AddWithValue("@p7", txtIsYeriKategoriAdi.Text);
            komut1.Parameters.AddWithValue("@p8", txtIsYeriYetkilisiAdi.Text);
            komut1.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("İş yeri eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtIsYeriKategoriId.Focus();

        }
    }
}
