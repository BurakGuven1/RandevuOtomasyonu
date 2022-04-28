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
   public class IsYeriYetkiliTanimlama
    {

        public IsYeri isYeri { get; set; }
        public IsYeriYetkilisi isYeriYetkilisi { get; set; }
        public byte TanimlamaDurum { get; set; }
        

        sqlBaglantisi bgl = new sqlBaglantisi();


        public void tanımla()
        {
            SqlCommand komut = new SqlCommand("Update Tbl_IsYeri set YetkiliId=@p1,YetkiliTanimlamaDurum=@p2 where IsyeriId=@p3",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", isYeriYetkilisi.YetkiliId);
            komut.Parameters.AddWithValue("@p2", 1);
            komut.Parameters.AddWithValue("@p3", isYeri.IsYeriId); 
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
         

        }

    }
}
