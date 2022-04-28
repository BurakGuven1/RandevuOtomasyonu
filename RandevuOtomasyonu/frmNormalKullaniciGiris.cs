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
    public partial class frmNormalKullaniciGiris : Form
    {
        public frmNormalKullaniciGiris()
        {
            InitializeComponent();
        }

        sqlBaglantisi bgl = new sqlBaglantisi();

        private void linklblUyeOl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmNormalKullaniciKayit fr = new frmNormalKullaniciKayit();
            fr.Show();

        }

        private void btnNormalKullaniciGiris_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * From tbl_NormalKullanici Where NormalKullaniciKullaniciAdi =@p1 and NormalKullaniciSifre= @p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtKullaniciAdi.Text);
            komut.Parameters.AddWithValue("@p2", txtSifre.Text);
            SqlDataReader dr = komut.ExecuteReader();

            if (dr.Read())
            {
                //eğer dr komutunu doğru okuyorsa frmHastaDetaya gitsin
                frmNormalKullaniciEkrani fr = new frmNormalKullaniciEkrani();
                fr.kullaniciadi = txtKullaniciAdi.Text;
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
