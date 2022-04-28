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
    public partial class frmSoruSor : Form
    {
        public frmSoruSor()
        {
            InitializeComponent();
        }

        public string kullaniciadi;
        sqlBaglantisi bgl = new sqlBaglantisi();

        private void frmSoruSor_Load(object sender, EventArgs e)
        {

            SqlCommand komut2 = new SqlCommand("Select IsyeriAdi From Tbl_Isyeri", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();

            while (dr2.Read())
            {
                cmbxIsYeriSecimi.Items.Add(dr2[0]);

            }

            bgl.baglanti().Close();

        }

        private void btnSoru_Click(object sender, EventArgs e)
        {
           

            try
            {

                SqlCommand komut1 = new SqlCommand("insert into Tbl_Sorular(KullaniciAd,IsYeriAd,SoruMetni) values (@p1, @p2,@p3)", bgl.baglanti());
                komut1.Parameters.AddWithValue("@p1", txtKullaniciAd.Text);
                komut1.Parameters.AddWithValue("@p2", cmbxIsYeriSecimi.Text);
                komut1.Parameters.AddWithValue("@p3", rtxtbxSoru.Text);

               

                if (komut1.ExecuteNonQuery() > 0)
                {

                    //komut1.CommandText = "SELECT IsYeriAd FROM Tbl_Sorular WHERE SoruMetni=@p3 ";
                 
                    MessageBox.Show("Sorunuz kaydedildi. En kısa sürede dönüş yapılacaktır.");
                    cmbxIsYeriSecimi.Text = "";
                    rtxtbxSoru.Text = "";

                }
            }
            catch (SqlException excep)
            {
                MessageBox.Show(excep.Message);
            }
            bgl.baglanti().Close();
        }

        private void btnOnceki_Click(object sender, EventArgs e)
        {
            frmNormalKullaniciEkrani fr = new frmNormalKullaniciEkrani();
            fr.Show();
            this.Hide();

        
        }
    }
}

 

