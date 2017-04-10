using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema_Seat_Reservation
{
    public partial class SeatsForm : Form
    {
        int clickCounter;
        Ticket ticket = new Ticket();

        public SeatsForm(Ticket ticketFromTicketForm)
        {
            InitializeComponent();

            ticket = ticketFromTicketForm;
            clickCounter = ticketFromTicketForm.quantity;
        }

        private void SeatsForm_Load(object sender, EventArgs e)
        {
            int counter = 1;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 16; j++)
                {
                    if (i != 3)
                    {
                        Button seat = new Button();
                        seat.Click += Button_Click;
                        seat.Height = 30;
                        seat.Width = 30;
                        
                        seat.Font = new Font("Arial", 8, FontStyle.Bold);
                        seat.Text = counter.ToString();

                        seat.Left = seat.Width * j;
                        seat.Top = seat.Height * i;
                        seat.FlatStyle = FlatStyle.Flat;
                        seat.BackColor = Color.Gray;

                        if (ticket.time == "01:00 PM")
                        {
                            foreach (var item in Schedule.permanantSeatList1pm)
                            {
                                if (i == seatLocation.setI(item.ToString()))
                                {
                                    if (j == seatLocation.setJ(item.ToString()))
                                    {
                                        seat.BackgroundImage = Properties.Resources.person;
                                        seat.BackgroundImageLayout = ImageLayout.Stretch;
                                        seat.BackColor = Color.Black;
                                        seat.Text = string.Empty;
                                        seat.Click -= Button_Click;
                                    }
                                }
                            }
                        }
                        else if (ticket.time == "04:00 PM")
                        {
                            foreach (var item in Schedule.permanantSeatList4pm)
                            {
                                if (i == seatLocation.setI(item.ToString()))
                                {
                                    if (j == seatLocation.setJ(item.ToString()))
                                    {
                                        seat.BackgroundImage = Properties.Resources.person;
                                        seat.BackgroundImageLayout = ImageLayout.Stretch;
                                        seat.BackColor = Color.Black;
                                        seat.Text = string.Empty;
                                        seat.Click -= Button_Click;

                                    }
                                }
                            }
                        }
                        else if (ticket.time == "07:00 PM")
                        {
                            foreach (var item in Schedule.permanantSeatList7pm)
                            {
                                if (i == seatLocation.setI(item.ToString()))
                                {
                                    if (j == seatLocation.setJ(item.ToString()))
                                    {
                                        seat.BackgroundImage = Properties.Resources.person;
                                        seat.BackgroundImageLayout = ImageLayout.Stretch;
                                        seat.BackColor = Color.Black;
                                        seat.Text = string.Empty;
                                        seat.Click -= Button_Click;

                                    }
                                }
                            }
                        }            


                        panelSeats.Controls.Add(seat);
                        counter++;
                    }

                }
                counter = 1;
            }
            
           
        }
        bool flag = true;

        seatLocation seatLocation = new seatLocation();

        private void Button_Click(object sender, EventArgs e)
        {
            Button chosenSeat = sender as Button;

            if (flag == false && chosenSeat.BackColor == Color.Gray) //quantitiy aşarsa uyarı ver
            {
                MessageBox.Show("You can choose " + ticket.quantity + " seats.");
                
            }
            if (chosenSeat.BackColor == Color.DeepPink) //koltuktan vazgeçtik geri al
            {
                LabelChosenSeat.Text = string.Empty;

                chosenSeat.BackColor = Color.Gray;
                clickCounter++;
                flag = true;

                ticket.chosenSeatList.Remove(seatLocation.addSeatAlphabet(chosenSeat.Location.Y) + chosenSeat.Text);
                ticket.chosenSeatList.Sort();

                foreach (var item in ticket.chosenSeatList)
                {
                    LabelChosenSeat.Text += item + ", ";

                }
            }
            else if(chosenSeat.BackColor == Color.Gray && flag == true) // koltuğu seçtik
            {
                LabelChosenSeat.Text = string.Empty;

                chosenSeat.BackColor = Color.DeepPink;
                clickCounter--;

                ticket.chosenSeatList.Add(seatLocation.addSeatAlphabet(chosenSeat.Location.Y) + chosenSeat.Text);
                ticket.chosenSeatList.Sort();

                foreach (var item in ticket.chosenSeatList)
                {
                    LabelChosenSeat.Text += item + ", ";

                }
            }
            if (clickCounter == 0)
            {
                flag = false;
                
            }     

        }

        private void buttonContinue_Click(object sender, EventArgs e)
        {
            Schedule createPermanentList = new Schedule();
            createPermanentList.setSchedule(ticket);


            if (LabelChosenSeat.Text == string.Empty)
            {
                MessageBox.Show("You have to choose " + ticket.quantity + " seats.");
            }
            else
            {
                Hide();
                TicketInformationForm ticketInfoForm = new TicketInformationForm(ticket);
                ticketInfoForm.Show();
            }
            
        }

        private void linkBackToSchedules_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            TicketForm backToTickets = new TicketForm(ticket);
            backToTickets.Show();
        }
    }
}
