using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;



namespace RandevuOtomasyonu
{
    public class IsYeri
    {
        public int IsYeriId { get; set; }
        public string IsyeriAd { get; set; }
        public Kategori kategori { get; set; }
        public string Adres { get; set; }
        public string TelefonNumarasi { get; set; }


        sqlBaglantisi bgl = new sqlBaglantisi();

    }
}