using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IZSU_FormsApp_DB.DataLayer.Model
{
    public class AboneTuru
    {
        public int AboneTuruID { get; set; }

        public string AboneTuruAd { get; set; }

        public override string ToString()
        {
            return AboneTuruAd;
        }
    }
}
