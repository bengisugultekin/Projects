using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KafeSiparis_SINAV
{
    class Siparis
    {
        public string siparisAdi { get; set; }

        public int adet { get; set; }

        public double adetCarpıUcret { get; set; }


        public double ucret
        {
            get
            {
                if (siparisAdi == "Kuru Fasülye")
                {
                    return 5;
                }
                else if (siparisAdi == "Tavuklu Pilav")
                {
                    return 6;
                }
                else if (siparisAdi == "Kaşarlı Tost")
                {
                    return 4;
                }
                else if (siparisAdi == "Lazanya")
                {
                    return 2;
                }
                else if (siparisAdi == "Su")
                {
                    return 1;
                }
                else if (siparisAdi == "Kola")
                {
                    return 2;
                }
                else if (siparisAdi == "Limonata")
                {
                    return 3;
                }
                else if (siparisAdi == "Çay")
                {
                    return 1.5;
                }
                else if (siparisAdi == "Kahve")
                {
                    return 5;
                }

                return 0;                
            }            
        }

        public override string ToString()
        {
            return siparisAdi + "   " + adet + " adet";
        }
    }
}
