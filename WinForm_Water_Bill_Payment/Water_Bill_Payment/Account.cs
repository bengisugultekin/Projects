using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Water_Bill_Payment
{
    public class Account
    {
        public int accountNumber { get; set; }
        public string accountType;
        public int prevRead { get; set; }
        public int currRead { get; set; }
        public int usage { get; set; }
        public double prevBalance { get; set; } //ödenemiş borç varsa
        public double currCharges { get; set; }
        public double totalAmountPaid { get; set; }

        public List<Account> paymentList = new List<Account>();


        public double calculateCurrCharges( int usage, string accountType)
        {
            if (accountType == "Home") //home
            {
                return usage * 0.3;
            }
            else
            {
                return usage * 0.5;
            }
        }

        public override string ToString()
        {
            return accountNumber.ToString() + "\t" + accountType;
        }
    }
}
