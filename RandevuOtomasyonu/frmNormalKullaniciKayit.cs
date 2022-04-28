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
    public partial class frmNormalKullaniciKayit : Form
    {
        public frmNormalKullaniciKayit()
        {
            InitializeComponent();
        }

        sqlBaglantisi bgl = new sqlBaglantisi(); // sqlBaglantisindan bgl diye bir nesne türettim bu 
                                                 //sqlBaglanti sınıfındaki bağlantı metoduna ulaşıcam

        private void btnNormalKullaniciKayıt_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into tbl_NormalKullanicilar (NormalKullaniciAdiSoyadi,NormalKullaniciEmail,NormalKullaniciTelNo,NormalKullaniciAdres,NormalKullaniciKullaniciAdi,NormalKullaniciSifre) values ( @p1,@p2,@p3,@p4,@p5,@p6)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",txtNormalKullaniciAdSoyad.Text);
            komut.Parameters.AddWithValue("@p2", txtEmail.Text);
            komut.Parameters.AddWithValue("@p3", mskdtxtTelNo.Text);
            komut.Parameters.AddWithValue("@p4", txtKullaniciAdres.Text);
            komut.Parameters.AddWithValue("@p5",txtKullaniciAd.Text);
            komut.Parameters.AddWithValue("@p6", txtSifre.Text);
            komut.ExecuteNonQuery();

            bgl.baglanti().Close(); //bağlantı hemen kapatılamıyor  sınıf içindek metoda ulaşıp kapatıyoruz
            MessageBox.Show("Kaydınız gerçekleşmiştir. Şifreniz:" + txtSifre.Text, "Bilgi",
                         MessageBoxButtons.OK, MessageBoxIcon.Information);




        }
    }
}
