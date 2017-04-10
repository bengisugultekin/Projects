using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OVchipkaart
{
    public enum PassengerType
    {
        Default,
        Student,
        Discounted,
    }

    public class Card
    {
        public PassengerType cardType { get; set; } 

        public int id { get; set; }

        private double _credit;

        public double credit
        {
            get { return _credit; }
            set
            {
                if (value < 0)
                {
                    MessageBox.Show("Do not have enough credit.");
                }
                else
                {
                    _credit = value;
                }

            }
        }


        public virtual void Pass()
        {
            MessageBox.Show("Charge: €3 \t Balance: " + (credit - 3));
            credit -= 3;
        }

        public override string ToString()
        {
            return id + "\t" + credit + "\t" + "-" + "\t" + cardType;
        }



    }
}
