using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KafeSiparis_SINAV
{
    class Masa
    {
        public double toplamTutar { get; set; }
        
        public List<Siparis> siparisler = new List<Siparis>();

        public Masa()
        {
            siparisler = new List<Siparis>();
        }

        

    }
}
