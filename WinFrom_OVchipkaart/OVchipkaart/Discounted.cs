using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace OVchipkaart
{
    class Discounted : Card
    {
        public override void Pass()
        {
            MessageBox.Show("Charge: €2 \t Balance: " + (credit - 2));
            credit -= 2;
        }
        
    }
}
