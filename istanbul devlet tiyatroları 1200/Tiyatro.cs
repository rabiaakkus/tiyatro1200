using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace istanbul_devlet_tiyatroları_1200
{
    internal class Tiyatro
    {
       public int ıd {  get; set; }
        public string oyunAdı { get; set; }
        public string oyunyeri {  get; set; }
        public DateTime tarih {  get; set; }
        public int sure { get; set; }
        public int fiyat {  get; set; }
        public bool muzikal{ get; set; }
        public Tiyatro(int ıd,string oyunAdı,string oyunYeri,DateTime tarih,int sure,int fiyat,bool muzikal) 
        {
            ıd = ıd;
            oyunAdı = oyunYeri;
            tarih = tarih;
            sure = sure;
            fiyat = fiyat;
        }

    }
}
