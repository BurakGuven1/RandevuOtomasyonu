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
    public partial class frmGenelAdminGiris : Form
    {
        public frmGenelAdminGiris()
        {
            InitializeComponent();
        }

        sqlBaglantisi bgl = new sqlBaglantisi();

        private void btnGenelAdminGiris_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * From tbl_GenelAdmin Where KullaniciAdi =@p1 and KullaniciSifre= @p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtGenelAdminKullaniciAd.Text);
            komut.Parameters.AddWithValue("@p2", txtGenelAdminSifre.Text);
            SqlDataReader dr = komut.ExecuteReader();

            if (dr.Read())
            {
                //eğer dr komutunu doğru okuyorsa frmHastaDetaya gitsin
                frmGenelAdminEkrani fr = new frmGenelAdminEkrani();
              
                fr.Kullaniciadi = txtGenelAdminKullaniciAd.Text;
                fr.Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("Hatalı kullanıcı adı veya şifre girdiniz yeniden deneyiniz.");
            }

            bgl.baglanti().Close();
        }
    }
}
