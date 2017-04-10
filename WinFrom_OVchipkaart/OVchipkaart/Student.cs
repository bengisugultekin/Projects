using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OVchipkaart
{
    class Student : Card
    {
        public string schoolName { get; set; }

        public override void Pass()
        {
            MessageBox.Show("Charge: €1 \t Balance: " + (credit - 1));
            credit -= 1;
        }

        public override string ToString()
        {
            return id + "\t" + credit + "\t" + schoolName + "\t" + cardType;
        }
    }
}
