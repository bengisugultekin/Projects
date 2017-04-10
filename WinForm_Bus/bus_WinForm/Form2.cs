using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bus_WinForm
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            
        }


        private void buttonCancel_Click(object sender, EventArgs e)
        {


            this.Hide();
        }
        
        public string gender;
        public int seatNumber = 100;
        public string busName;
        public static string[] travegoChosenSeat = new string[48]; //static yaptım oldu
        public static string[] travegoGender = new string[48];

        private void radioButtonMale_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Male";
        }

        private void radioButtonFemale_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Female";
        }

        Form1 form1 = new Form1();
        
        private void buttonSave_Click(object sender, EventArgs e)
        {
            //burda kaldın !!! otobüs tipine göre kayıt al !!!
            //if ( form1.labelBusTypeName.Text == "Mercedes Travego")
            //{
                if (seatNumber % 2 == 0) //çift
                {
                    int previous = seatNumber - 1;
                    if (travegoChosenSeat[previous] != null)
                    {
                        travegoGender[seatNumber] = gender;

                        if (travegoGender[previous] == travegoGender[seatNumber])
                        {
                            travegoChosenSeat[seatNumber] = textBoxNameSurname.Text;

                        }
                        else
                        {
                            MessageBox.Show("You cannot choose this seat due to your gender. Please choose another one.");

                        }
                    }
                    else
                    {
                        travegoChosenSeat[seatNumber] = textBoxNameSurname.Text;
                        travegoGender[seatNumber] = gender;

                    }
                }
                else //tek 
                {
                    int next = seatNumber + 1;
                    if (travegoChosenSeat[next] != null)
                    {
                        travegoGender[seatNumber] = gender;

                        if (travegoGender[next] == travegoGender[seatNumber])
                        {
                            travegoChosenSeat[seatNumber] = textBoxNameSurname.Text;

                        }
                        else
                        {
                            MessageBox.Show("You cannot choose this seat due to your gender. Please choose another one.");

                        }
                    }
                    else
                    {
                        travegoChosenSeat[seatNumber] = textBoxNameSurname.Text;
                        travegoGender[seatNumber] = gender;

                    }
                }
        //    }
            
            this.Hide();

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (travegoChosenSeat[seatNumber] != null)
            {
                textBoxNameSurname.Text = travegoChosenSeat[seatNumber] + "  -> This seat is taken.";

            }
        }




    }
}
