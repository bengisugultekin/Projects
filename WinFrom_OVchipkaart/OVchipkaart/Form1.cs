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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public Form1(Card passenger)
        {
            InitializeComponent();
        }

        Student student = new Student();
        Card _default = new Card();
        Discounted discounted = new Discounted();

        static List<Card> permanentList = new List<Card>();

        int cardID = 1;

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (radioButtonStudent.Checked == true)
            {               
                
                student.credit = double.Parse(textBoxCredit.Text);
                student.schoolName = textBoxSchoolName.Text;
                student.cardType = PassengerType.Student;
                student.id = cardID;

                cardID++;

                listBoxPassengers.Items.Add(student);
                permanentList.Add(student);

            }
            else if (radioButtonDefault.Checked == true)
            {
                _default.credit = double.Parse(textBoxCredit.Text);
                _default.cardType = PassengerType.Default;
                _default.id = cardID;

                cardID++;

                listBoxPassengers.Items.Add(_default);
                permanentList.Add(_default);
            }

            else if (radioButtonDiscounted.Checked == true)
            {
                discounted.credit = double.Parse(textBoxCredit.Text);
                discounted.cardType = PassengerType.Discounted;
                discounted.id = cardID;

                cardID++;

                listBoxPassengers.Items.Add(discounted);
                permanentList.Add(discounted);
               
            }

            textBoxCredit.Clear();
            textBoxSchoolName.Clear();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBoxSchoolName.Enabled = false;

            foreach (var item in permanentList)
            {
                listBoxPassengers.Items.Add(item);
            }
        }

        private void radioButtonStudent_CheckedChanged(object sender, EventArgs e)
        {
            textBoxSchoolName.Enabled = radioButtonStudent.Checked == true ? true : false;
        }

        private void listBoxPassengers_DoubleClick(object sender, EventArgs e)
        {
            Card passenger = (Card)listBoxPassengers.SelectedItem;

            if ((passenger.cardType == PassengerType.Default) && (passenger.credit - 3 >= 0))
            {
                listBoxPassengers.Items.RemoveAt(listBoxPassengers.SelectedIndex);
               
                passenger.Pass();

                listBoxPassengers.Items.Add(passenger);

            }
            else if ((passenger.cardType == PassengerType.Discounted) && (passenger.credit - 2 >= 0))
            {
                listBoxPassengers.Items.RemoveAt(listBoxPassengers.SelectedIndex);

                discounted = (Discounted)passenger;
                discounted.Pass();

                listBoxPassengers.Items.Add(discounted);
            }
            else if ((passenger.cardType == PassengerType.Student) && (passenger.credit - 1 >= 0))
            {
                listBoxPassengers.Items.RemoveAt(listBoxPassengers.SelectedIndex);

                student = (Student)passenger;
                student.Pass();

                listBoxPassengers.Items.Add(student);
            }
            else
            {
                MessageBox.Show("not enough credit.");

                DialogResult result = MessageBox.Show("Do you want to load credit?", "Warning", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    Form2 form2 = new Form2(passenger); //burada yolcuyu form2 ye göndermen gerekiyor !!!!!
                    form2.Show();
                    this.Hide();
                }
            }
        }
    }
}
