using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Water_Bill_Payment
{
    public partial class AccountInfo : Form
    {
        public AccountInfo(Account account)
        {
            InitializeComponent();
            textBoxAccountNumber.Text = account.accountNumber.ToString();
            textBoxPaidAmount.Text = account.currCharges.ToString(); //tıkladığımın current charge ı lazım !?BUG
            
            textBoxTotalAmountPaid.Text = account.totalAmountPaid.ToString();

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            FormRegistration formR = new FormRegistration();
            formR.Show();
            Hide();
        }
    }
}
