using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandevuOtomasyonu
{
    public class SoruCevap
    {
        public int SoruId { get; set; }
        public string SoruMetni { get; set; }
        public string CevapMetni { get; set; }

        
        //SqlCommand komut;
        //SqlDataReader DataReader;
        SqlDataAdapter DataAdapter;
        DataTable dataTable = new DataTable();

        sqlBaglantisi bgl = new sqlBaglantisi();

        public DataTable Raporla()
        {
          
            DataAdapter = new SqlDataAdapter("select SoruMetni, CevapMetni from Tbl_Sorular", bgl.baglanti());
            DataAdapter.Fill(dataTable);
            bgl.baglanti().Close();
            return dataTable;
        }


    }

   

}
