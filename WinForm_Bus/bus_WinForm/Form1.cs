using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//TO DO: Arka 5li için cinsiyet !!

namespace bus_WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        
        int counter = 1;
        private void busType_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            string busTypeName = busType.SelectedItem.ToString();
            labelBusTypeName.Text = busType.SelectedItem.ToString();

            if (busTypeName == "Mercedes Travego")
            {
                #region Travego
                panelTravego.Visible = true;
                panelE403.Visible = false;
                counter = 1;
                
                for (int i = 0; i < 12; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {

                        if ((j != 2 || i == 11) && (i != 5 || j < 2))
                        {
                            Button btn = new Button();
                            btn.Click += new EventHandler(btn_Click);
                            btn.Width = 30;
                            btn.Height = 30;
                            btn.Left = btn.Width * j;
                            btn.Top = btn.Width * i;
                            btn.Text = counter.ToString();
                            btn.BackColor = Color.FromArgb(135, 144, 180);
                            btn.ForeColor = Color.White;
                            btn.FlatStyle = FlatStyle.Flat;

                            panelTravego.Controls.Add(btn);
                            counter++;
                        }
                    }
                }
                #endregion
            }

            else
            {
                #region E403

                counter = 1;

                panelE403.Visible = true;
                panelTravego.Visible = false;

                for (int i = 0; i < 12; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if ((j != 2 && j != 3) && (i != 5 || j < 2))
                        {
                            Button btn = new Button();
                            btn.Click += new EventHandler(btn_Click);
                            btn.Width = 30;
                            btn.Height = 30;
                            btn.Left = btn.Width * j;
                            btn.Top = btn.Width * i;
                            btn.Text = counter.ToString();
                            btn.BackColor = Color.FromArgb(135, 144, 180);
                            btn.ForeColor = Color.White;
                            btn.FlatStyle = FlatStyle.Flat;

                            panelE403.Controls.Add(btn);
                            counter++;
                        }
                    }
                }
                #endregion
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {

            Form2 form2 = new Form2();
            if (((Control)sender).BackColor == Color.FromArgb(135, 144, 180)) //mavi ise yani boş ise
            {

                ((Control)sender).BackColor = Color.FromArgb(175, 163, 121); //kahverengi oldu dolu yani

                form2.seatNumber = int.Parse(((Control)sender).Text);

                form2.Show();

            }

            else if (((Control)sender).BackColor == Color.FromArgb(175, 163, 121)) //kahve ise
            {
                form2.seatNumber = int.Parse(((Control)sender).Text);

                form2.Show();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panelTravego.Visible = false;
            panelE403.Visible = false;
        }

        private void panelE403_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}



//this.Controls.Clear();
//ototbüs tipine göre buton oluştur
