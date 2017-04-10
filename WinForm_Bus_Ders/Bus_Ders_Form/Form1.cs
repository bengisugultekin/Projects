using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bus_Ders_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CBoxOtobusTuru_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (CBoxOtobusTuru.SelectedItem.ToString() == "Travego")
            {
                #region KoltukarTravego

                panelTravego.Visible = true;
                panelSetra.Visible = false;

                int counter = 1;
                for (int i = 0; i < 12; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if ((j != 2 || i == 11) && (i != 5 || j < 2))
                        {
                            Button btn = new Button();
                            btn.Click += Button_Click;
                            btn.Width = 30;
                            btn.Height = 30;
                            btn.Text = counter.ToString();
                            btn.BackColor = Color.FromArgb(135, 144, 180);
                            btn.Left = btn.Width * j;
                            btn.Top = btn.Height * i;
                            panelTravego.Controls.Add(btn);

                            counter++;
                        }
                    }

                }

                #endregion
            }
            else
            {
                #region KoltukarSetra

                panelSetra.Visible = true;
                panelTravego.Visible = false;

                int counter = 1;
                for (int i = 0; i < 14; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if ((j != 2 || i == 13) && (i != 7 || j < 2))
                        {
                            Button btn = new Button();
                            btn.Click += Button_Click;
                            btn.Width = 30;
                            btn.Height = 30;
                            btn.Text = counter.ToString();
                            btn.BackColor = Color.FromArgb(135, 144, 180);
                            btn.Left = btn.Width * j;
                            btn.Top = btn.Height * i;
                            panelSetra.Controls.Add(btn);

                            counter++;
                        }
                    }

                }
                #endregion
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button secilenKoltuk = sender as Button;
            labelKoltukNo.Text = secilenKoltuk.Text;
            labelOtobusTuru.Text = CBoxOtobusTuru.SelectedItem.ToString();

            #region KayıtlıYolcuVarsaBilgileriniGetirme
            if (labelOtobusTuru.Text == "Travego")
            {
                string yolcu = travegoYolcularIsim[int.Parse(secilenKoltuk.Text) - 1];
                if (yolcu != "")
                {
                    TxtYolcuIsim.Text = yolcu;

                    string cinsiyet = travegoYolcularCinsiyet[int.Parse(secilenKoltuk.Text) - 1];

                    if (cinsiyet == "Erkek")
                    {
                        RBErkek.Checked = true;
                        secilenKoltuk.BackColor = Color.Blue;
                    }
                    else if (cinsiyet == "Kadın")
                    {
                        RBKadin.Checked = false;
                        secilenKoltuk.BackColor = Color.Pink;
                    }
                }
            }
            else
            {
                string yolcu = setraYolcularIsim[int.Parse(secilenKoltuk.Text) - 1];
                if (yolcu != "")
                {
                    TxtYolcuIsim.Text = yolcu;

                    string cinsiyet = setraYolcularCinsiyet[int.Parse(secilenKoltuk.Text) - 1];

                    if (cinsiyet == "Erkek")
                    {
                        RBErkek.Checked = true;
                    }
                    else
                    {
                        RBKadin.Checked = true;
                    }
                }
            }
            #endregion

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panelTravego.Visible = false;
            panelSetra.Visible = false;
        }

        string[] travegoYolcularIsim = new string[60];
        string[] setraYolcularIsim = new string[60];
        string[] travegoYolcularCinsiyet = new string[60];
        string[] setraYolcularCinsiyet = new string[60];
        

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            #region YolcuKayıt

            if (labelOtobusTuru.Text == "Travego")
            {
                string cinsiyet;
                travegoYolcularIsim[int.Parse(labelKoltukNo.Text) - 1] = TxtYolcuIsim.Text;

                if (RBErkek.Checked)
                {
                    cinsiyet = "Erkek";
                }
                else
                {
                    cinsiyet = "Kadın";
                }
                travegoYolcularCinsiyet[int.Parse(labelKoltukNo.Text) - 1] = cinsiyet;
            }
            else
            {
                setraYolcularIsim[int.Parse(labelKoltukNo.Text) - 1] = TxtYolcuIsim.Text;
                string cinsiyet;

                if (RBErkek.Checked)
                {
                    cinsiyet = "Erkek";
                }
                else
                {
                    cinsiyet = "Kadın";
                }
                setraYolcularCinsiyet[int.Parse(labelKoltukNo.Text) - 1] = cinsiyet;
            }

            TxtYolcuIsim.Text = string.Empty;
            labelKoltukNo.Text = "0";
            labelOtobusTuru.Text = "-";
        }

        #endregion

    }
}
