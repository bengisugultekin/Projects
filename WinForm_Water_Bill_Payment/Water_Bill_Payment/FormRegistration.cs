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
    public partial class FormRegistration : Form
    {
        public FormRegistration()
        {
            InitializeComponent();
        }

        public FormRegistration(Account accountPaid)
        {
            InitializeComponent();
            
            allPaidAccounts.Add(accountPaid);    

            
        }

        static List<Account> allPaidAccounts = new List<Account>();
        static List<Account> allAccounts = new List<Account>();

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Account account = new Account();
            account.accountNumber = int.Parse(textBoxAccountNo.Text);            
            account.accountType = radioButtonHome.Checked == true ? "Home" : "Organization";

            account.prevRead = int.Parse(textBoxPrevRead.Text);
            account.currRead = int.Parse(textBoxCurrRead.Text);
            account.usage = account.currRead - account.prevRead;

            account.currCharges = account.calculateCurrCharges(account.usage, account.accountType);

            var result = allAccounts.FirstOrDefault(x => x.accountNumber == account.accountNumber);

            if (result == null) //aynı accounttan yok
            {
                listBoxAccounts.Items.Add(account);
                allAccounts.Add(account);

            }
            else //aynı accounttan var -> güncelle
            {
                result.prevRead = int.Parse(textBoxPrevRead.Text);
                result.usage = result.currRead - result.prevRead;
                result.currCharges = result.calculateCurrCharges(result.usage, result.accountType);
            }

        }

        private void listBoxAccounts_DoubleClick(object sender, EventArgs e)
        {
            Bill billingInfoForm = new Bill((Account)listBoxAccounts.SelectedItem);

            billingInfoForm.Show();

            this.Hide();
        }

        private void FormRegistration_Load(object sender, EventArgs e)
        {
            foreach (var item in allAccounts)
            {
                listBoxAccounts.Items.Add(item);
            }

            foreach (var item in allPaidAccounts)
            {
                listBoxPaid.Items.Add(item);
            }
        }

        private void listBoxPaid_DoubleClick(object sender, EventArgs e)
        {
            AccountInfo accountInfoForm = new AccountInfo((Account)listBoxPaid.SelectedItem);
                           
            this.Hide();
            accountInfoForm.Show();

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
