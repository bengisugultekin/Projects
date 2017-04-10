using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OVchipkaart
{
    public partial class Form2 : Form
    {
        Card _passenger = new Card();

        public Form2(Card passenger)
        {
            InitializeComponent();

            _passenger = passenger; //gelen yolcunun bilgilerini aldıınn
        }
                

        private void buttonOK_Click(object sender, EventArgs e)
        {
            _passenger.credit += int.Parse(textBoxCreditLoad.Text);

            Form1 form1 = new Form1(_passenger); //şimdi de yükleme yapan yolcuyu form1 e geri göndemrek zorundasın
            form1.Show();
            this.Hide();
        }
    }
}
