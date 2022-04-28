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
    public partial class frmRandevuAl : Form
    {
        public frmRandevuAl()
        {
            InitializeComponent();
        }

        sqlBaglantisi bgl = new sqlBaglantisi();

        private void RandevuZamanIndexKontrol(int deger)
        {
            if ((rbtn1.TabIndex - 2) == deger)
                rbtn1.Enabled = false;

            else if ((rbtn2.TabIndex - 2) == deger)
                rbtn2.Enabled = false;
            else if ((rbtn3.TabIndex - 2) == deger)
                rbtn3.Enabled = false;
            else if ((rbtn4.TabIndex - 2) == deger)
                rbtn4.Enabled = false;
            else if ((rbtn5.TabIndex - 2) == deger)
                rbtn5.Enabled = false;
            else if ((rbtn6.TabIndex - 2) == deger)
                rbtn6.Enabled = false;
            else if ((rbtn7.TabIndex - 2) == deger)
                rbtn7.Enabled = false;
            else if ((rbtn8.TabIndex - 2) == deger)
                rbtn8.Enabled = false;
        }


        private void dateTimePickerTarih_ValueChanged(object sender, EventArgs e)
        {

            //todo:
          
        }

        int ID;

        public string IsYeriAdi { get; private set; }
        public static string Veri { get; private set; }

        private void RandevuZamanKontrol()
        {
            bgl.baglanti().Open();
            string sorgu = "Select IsyeriId from Tbl_IsYeri Where İsim'" + IsYeriAdi + "'";
            SqlCommand komut = new SqlCommand(sorgu, bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {

                ID = Convert.ToInt32(dr[0]);

            }

            bgl.baglanti().Close();

            bgl.baglanti().Open();
            MessageBox.Show(dateTimePickerTarih.Value.ToShortDateString());
            SqlCommand komut1 = new SqlCommand("Select RandevuSaat from Tbl_Randevular where IsYeriId '" + ID + "' AND RandevuTarih='" + dateTimePickerTarih.Value + "'", bgl.baglanti());
            SqlDataReader dr1 = komut.ExecuteReader();
            while (dr1.Read())
            {
                RandevuZamanIndexKontrol(Convert.ToInt32(dr1[0]));
            }

            bgl.baglanti().Close();



        }

        private void RandevuAl(int index)
        {

            SqlCommand komut = new SqlCommand("insert into Tbl_Randevular values(@p1,@p2,@p3,@p4,@p5)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", ID);
            komut.Parameters.AddWithValue("@p2", txtKullaniciAd.Text);
            komut.Parameters.AddWithValue("@p3", dateTimePickerTarih.Value);
            komut.Parameters.AddWithValue("@p4", index);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();



        }

        private void RandevuOlustur(int index)
        {
            bool IsyeriKontrol = false;
            bool ZamanKontrol = false;
            bgl.baglanti().Open();
            SqlCommand komut = new SqlCommand("Select IsYeriId,RandevuSaat From Tbl_Randevular Where KullaniciAd='", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();

            while (dr.Read())
            {
                if (ID == Convert.ToInt32(dr[0]))
                {
                    IsyeriKontrol = true;
                }
                    
                
                else if (index == Convert.ToInt32(dr[1]))
                {
                    ZamanKontrol = true;
                }
                  

            }

            bgl.baglanti().Close();

            if (IsyeriKontrol)
                lblUyarı.Text = "Seçmiş olduğunuz iş yerinde bu tarihte randevu oluşturmuşsunuz!";
            else if (ZamanKontrol)
                lblUyarı.Text = "Bu tarih ve zamanda başka bir iş yerinde randevu almışsınız.";
            else
                RandevuAl( index);
        }

        private void btnAl_Click(object sender, EventArgs e)
        {
            int index = -1;

            if (grpbxRandevu.Visible == false)
               lblUyarı.Text= "İş yerini seçiniz";
            else if (Convert.ToDateTime(dateTimePickerTarih.Value.ToString()) < Convert.ToDateTime(DateTime.Now.ToLongTimeString()))
                lblUyarı.Text = "Tarih seçiniz";
            else if (rbtn1.Checked == false && rbtn2.Checked == false && rbtn3.Checked == false && rbtn4.Checked == false && rbtn5.Checked == false && rbtn6.Checked == false && rbtn7.Checked == false && rbtn8.Checked == false)
                lblUyarı.Text = "Zaman seçiniz";

            else
            {

                if (rbtn1.Checked == true)
                    index = 0;
                else if (rbtn2.Checked == true)
                    index = 1;
                else if (rbtn3.Checked == true)
                    index = 2;
                else if (rbtn4.Checked == true)
                    index = 3;
                else if (rbtn4.Checked == true)
                    index = 3;
                else if (rbtn5.Checked == true)
                    index = 4;
                else if (rbtn6.Checked == true)
                    index = 5;
                else if (rbtn7.Checked == true)
                    index = 6;
                else if (rbtn8.Checked == true)
                    index = 7;

               

                SqlCommand komut = new SqlCommand("insert into Tbl_Randevular values(@p1,@p2,@p3,@p4)", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", ID);
                komut.Parameters.AddWithValue("@p2", txtKullaniciAd.Text);
                komut.Parameters.AddWithValue("@p3", dateTimePickerTarih.Value);
                komut.Parameters.AddWithValue("@p4", index);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();


                if (komut.ExecuteNonQuery() > 0)
                {

                    komut.CommandText = "SELECT RandevuId FROM tbl_Randevular WHERE RandevuTarih=@p2 AND RandevuSaat=@p3";
                    

                    MessageBox.Show("Randevunuz alındı");
                   
                }
                else

                    MessageBox.Show("Bir hata oluştu, yeniden deneyiniz!");

                bgl.baglanti().Close();
            }


        }

        

        private void frmRandevuAl_Load(object sender, EventArgs e)
        {


            SqlCommand komut2 = new SqlCommand("Select IsyeriAdi From Tbl_Isyeri", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();

            while (dr2.Read())
            {
                cmbxIsYeriSecimi.Items.Add(dr2[0]);

            }

            bgl.baglanti().Close();
        }

        
    }
}
