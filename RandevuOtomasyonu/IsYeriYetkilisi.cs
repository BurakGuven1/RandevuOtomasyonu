using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace RandevuOtomasyonu
{
   public class IsYeriYetkilisi : Kisi
    {

        public int YetkiliId { get; set; }
        public string YetkiliDogumTarihi { get; set; }
        public string YetkiliTC { get; set; }
        public int IsyeriId { get; set; }
        // public Boolean YetkiOnay { get; set; } SOR!


        sqlBaglantisi bgl = new sqlBaglantisi();

        





    }
}
