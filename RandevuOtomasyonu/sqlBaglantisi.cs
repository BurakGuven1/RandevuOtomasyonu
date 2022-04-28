using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace RandevuOtomasyonu
{
    class sqlBaglantisi
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-1JV6DUF;Initial Catalog=Proje;Integrated Security=True ");
            baglan.Open();
            return baglan;

            //SqlConnection: sınıf
            //baglanti: metod
            //baglan: sqlconnection sınıfından türetilen ve benim bağlantı adresimi tutan nesne
        }
        public SqlCommand komut { get; set; }
        public SqlDataAdapter da { get; set; }
        public SqlDataReader sqlDataReader { get; set; }
        public string Sorgu { get; set; }




    }
}
