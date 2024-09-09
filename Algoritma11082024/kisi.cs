using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritma11082024
{
    class kisi
    {
        
        private string ad, soyad, telno;

        public kisi(string Ad, string Soyad, string telNo)
        {
            this.ad = Ad;
            this.soyad = Soyad;
            this.telno = telNo;
        }
        public void kisiBilgisiBas()
        {
            Console.WriteLine(ad + " " + soyad + " " + telno);
        }
        
    }
}
