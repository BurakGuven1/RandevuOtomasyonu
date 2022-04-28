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
    public partial class frmNormalKullaniciEkrani : Form
    {
        public frmNormalKullaniciEkrani()
        {
            InitializeComponent();
        }

        public string kullaniciadi;
        sqlBaglantisi bgl = new sqlBaglantisi();

        
        private void frmNormalKullaniciEkrani_Load(object sender, EventArgs e)
        {

            lblNormalKullaniciAdi.Text = kullaniciadi;

            SqlCommand komut = new SqlCommand("Select NormalKullaniciKullaniciAdi From tbl_NormalKullanici Where NormalKullaniciAdiSoyadi = @p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", lblNormalKullaniciAdi.Text);
            SqlDataReader dr = komut.ExecuteReader();

            while (dr.Read())
            {
                //dr komutu çalıştığı müddetçe
                lblNormalKullaniciAdi.Text = dr[0] + " " + dr[1];
                
            }

            bgl.baglanti().Close();

       
           


            //İş yeri çekme
            SqlCommand komut2 = new SqlCommand("Select IsyeriAdi From Tbl_Isyeri", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();

            while (dr2.Read())
            {
                cmbxIsYeriSecimi.Items.Add(dr2[0]);
                
            }

            bgl.baglanti().Close();



        }

        private void lnklblBilgiDuzenle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmNormalKullaniciBilgiDuzenle fr = new frmNormalKullaniciBilgiDuzenle();
            fr.Show();
            this.Hide();
        }
    }
}
