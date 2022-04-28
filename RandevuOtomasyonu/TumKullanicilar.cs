using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RandevuOtomasyonu
{
    public abstract  class TumKullanicilar
    {
        public string Isim { get; set; }
        public string KullaniciAdi { get; set; }
        public string Email { get; set; }
        public string AdSoyad { get; set; } //emin değilim bundan
        public string Adres { get; set; }
        public ulong TelefonNumarasi { get; set; }
    }
}