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
    public partial class Bill : Form
    {
        Account updatedAccount = new Account();

        public Bill(Account account)
        {
            InitializeComponent();
            textBoxAccountNo.Text = account.accountNumber.ToString();
            textBoxPrevRead.Text = account.prevRead.ToString();
            textBoxCurrRead.Text = account.currRead.ToString();
            textBoxUsage.Text = account.usage.ToString();
            //textBoxPrevBalance.Text = account.prevBalance.ToString(); //!!!!!
            textBoxCurrCharges.Text = account.currCharges.ToString();

            updatedAccount = account;
        }

        private void buttonPay_Click(object sender, EventArgs e)
        {
           
            DialogResult result = MessageBox.Show("Total Due Upon Receipt: € " + updatedAccount.currCharges +  "\nDo you want to pay?", "Check Out", MessageBoxButtons.OKCancel);

            if (result == DialogResult.OK)
            {
                
                updatedAccount.totalAmountPaid += updatedAccount.currCharges;

                updatedAccount.paymentList.Add(updatedAccount);

                updatedAccount.currCharges = 0;

                FormRegistration backToRegistration = new FormRegistration(updatedAccount);

                textBoxCurrCharges.Text = "Paid";

                

            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormRegistration formR = new FormRegistration();
            formR.Show();
        }
    }
}
