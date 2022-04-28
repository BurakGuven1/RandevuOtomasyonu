using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace RandevuOtomasyonu
{
   public class NormalKullanici : Kisi
    {
        public int KullaniciId { get; set; }
        //public string sonGirisSaati { get; set; } SOR!
        public int IsyeriId { get; set; }

    }
}
