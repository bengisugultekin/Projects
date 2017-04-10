using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_WinForm
{
    public partial class calculator : Form
    {
        //Enter a basınca eşittir olsun !!?? -> olmadı hala !!! 
        //sayılara ve + - ye basınca çıksın  -> bişiler yaptım ama olmadı hala !!!
        //Üssünü alma 
        //Modunu alma
        //Enum kullan  
        //, + - * = / de kontrol: boşken koyamasin -> OK
        //Eşittirden sonra +,- falan basınca tekrar kendini ekliyordu -> OK
        //Şeklini güzelleştir -> OK
        //icon koy -> OK
        //backspace ekle -> OK
        //Bilgdeki gibi üstte minik yazdıkları çıksın -> OK
        //TO DO:  , koyunca 0 koysun -> OK
        //default 0 olsun _> OK
        //human readable scientific değil olsun yani tostrign yaparken cnvert et
        //8** yapınca 64 bulsun
        //

        public calculator()
        {
            InitializeComponent();
        }

        double number1;
        double number2;

        string operation = "";
        bool isThereAnyInput = true;

        private void ButtonClick(object sender, EventArgs e)
        {
            Button numberButtons = sender as Button;

            if (result.Text == "0" )
            {
                result.Clear();
            }

            if (isThereAnyInput)
            {
                result.Text += numberButtons.Text;

            }
            else
            {
                result.Text = numberButtons.Text;

                isThereAnyInput = true;
            }
            label1.Focus();
        }


        private void AddButtonClick(object sender, EventArgs e)
        {

            if (result.Text != "")
            {

                if (operation == "")
                {
                    number1 = Convert.ToDouble(result.Text);

                    result.Clear();

                    showNumbersTextBox.Text += number1.ToString();
                }
                else
                {
                    calculate();
                }

                showNumbersTextBox.Text += " " + buttonAdd.Text + " ";
            }

            operation = "+";
            label1.Focus();

        }

        private void MinusButtonClick(object sender, EventArgs e)
        {
            if (result.Text != "")
            {

                if (operation == "")
                {
                    number1 = Convert.ToDouble(result.Text);

                    result.Clear();

                    showNumbersTextBox.Text = number1.ToString();
                }
                else
                {
                    calculate();
                }

                showNumbersTextBox.Text += " " + buttonSubstraction.Text + " ";
            }
            operation = "-";
            label1.Focus();

        }

        private void MultiplyButtonClick(object sender, EventArgs e)
        {
            if (result.Text != "")
            {

                if (operation == "")
                {
                    number1 = Convert.ToDouble(result.Text);
                    result.Clear();
                    showNumbersTextBox.Text = number1.ToString();

                }
                else
                {
                    calculate();
                }

                showNumbersTextBox.Text += " " + buttonProduct.Text + " ";
            }
            operation = "*";
            label1.Focus();

        }

        private void DivisionButtonClick(object sender, EventArgs e)
        {
            if (result.Text != "")
            {

                if (operation == "")
                {
                    number1 = Convert.ToDouble(result.Text);
                    result.Clear();
                    showNumbersTextBox.Text = number1.ToString();

                }
                else
                {
                    calculate();
                }

                showNumbersTextBox.Text += " " + buttonDivision.Text + " ";
            }
            operation = "/";
            label1.Focus();
        }

        private void EqualButtonClick(object sender, EventArgs e)
        {

            if (result.Text != "")
            {
                calculate();
            }
            operation = "";
            showNumbersTextBox.Clear();

        }

        private void ClearEntryButtonClick(object sender, EventArgs e)
        {
            result.Text = "0";

            label1.Focus();

        }

        private void ClearButtonClick(object sender, EventArgs e)
        {
            result.Text = "0";

            showNumbersTextBox.Clear();
            number1 = 0;
            number2 = 0;
            operation = "";
            label1.Focus();

        }


        private void backspaceButton_Click(object sender, EventArgs e)
        {
            char[] charArray = result.Text.ToCharArray();
            result.Clear();

            for (int i = 0; i < charArray.Length - 1; i++)
            {
                result.Text += charArray[i].ToString();
            }

            label1.Focus();
        }

        private void CommaButtonClick(object sender, System.EventArgs e)
        {
            if (result.Text != "")
            {
                result.Text += buttonComma.Text;
            }

            label1.Focus();
        }


        public void calculate()
        {
            number2 = Convert.ToDouble(result.Text);
            showNumbersTextBox.Text += number2.ToString();

            switch (operation)
            {
                case "+":

                    number1 += number2;

                    break;

                case "-":

                    number1 -= number2;
                    break;

                case "*":

                    number1 *= number2;
                    break;

                case "/":

                    number1 /= number2;
                    break;

                default:
                    break;
            }

            result.Text = number1.ToString();
            isThereAnyInput = false;
        }

        private void calculator_Load(object sender, EventArgs e)
        {

        }

        private void calculator_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar.ToString())
            {
                case "0":
                    buttonZero.PerformClick();
                    break;
                case "1":
                    buttonOne.PerformClick();
                    break;
                case "2":
                    buttonTwo.PerformClick();
                    break;
                case "3":
                    buttonThree.PerformClick();
                    break;
                case "4":
                    buttonFour.PerformClick();
                    break;
                case "5":
                    buttonFive.PerformClick();
                    break;
                case "6":
                    buttonSix.PerformClick();
                    break;
                case "7":
                    buttonSeven.PerformClick();
                    break;
                case "8":
                    buttonEight.PerformClick();
                    break;
                case "9":
                    buttonNine.PerformClick();
                    break;
                case "+":
                    buttonAdd.PerformClick();
                    break;
                case "-":
                    buttonSubstraction.PerformClick();
                    break;
                case "*":
                    buttonProduct.PerformClick();
                    break;
                case "/":
                    buttonDivision.PerformClick();
                    break;
                case "=":
                    buttonEqual.PerformClick();
                    break;
                case ",":
                    buttonComma.PerformClick();
                    break;
                default:
                    break;
            }
        }



    }
}

//Button ramiz = (Button)sender;

//MessageBox.Show(numberButtons.Text + " e bastın.");

//ikincisayi = Convert.ToInt32(numberButtons.Text);

//label1.Text = numberButtons.Text;
//label1.Text = number + ikincisayi + "";

//char[] characters = "this is a test".ToCharArray();