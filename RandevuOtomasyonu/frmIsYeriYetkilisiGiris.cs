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
    public partial class frmIsYeriYetkilisiGiris : Form
    {
        public frmIsYeriYetkilisiGiris()
        {
            InitializeComponent();
        }

        sqlBaglantisi bgl = new sqlBaglantisi();

        private void btnIsYeriYetkilisiGiris_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * From Tbl_IsyeriYetkilileri Where YetkiliKullaniciAdi= @p1 and YetkiliSifre = @p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",txtIsYeriKullaniciAd.Text);
            komut.Parameters.AddWithValue("@p2",txtIsYeriYetkilisiSifre.Text);
            SqlDataReader dr = komut.ExecuteReader();

            if (dr.Read())
            {
                //eğer dr komutunu doğru okuyorsa frmHastaDetaya gitsin
                frmIsYeriYetkilisiEkrani fr = new frmIsYeriYetkilisiEkrani();
                fr.kullanici_adi = txtIsYeriKullaniciAd.Text;
                fr.Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("Hatalı kullanıcı adı veya şifre girdiniz yeniden deneyiniz.");
            }

            bgl.baglanti().Close();

        }

        private void linklblUyeOl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            frmIsYeriYetkilisiKayit fr = new frmIsYeriYetkilisiKayit();
            fr.Show();


        }
    }
}
