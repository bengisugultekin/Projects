using System;
using System.Globalization;
using System.Windows.Forms;

namespace Cinema_Seat_Reservation
{
    public partial class TicketInformationForm : Form
    {
        Ticket ticket = new Ticket();

        public TicketInformationForm(Ticket ticketFromSeatsForm)
        {
            InitializeComponent();
            ticket = ticketFromSeatsForm;
        }

        private void TicketInformationForm_Load(object sender, EventArgs e)
        {
            labelSchedule.Text = ticket.time;
            labelPerson.Text = ticket.ToString();
            labelTotal.Text = "€" + ticket.total.ToString("F");

            foreach (var item in ticket.chosenSeatList)
            {
                labelSeatNumbers.Text += item + ", ";
            }



            labelDay.Text = DateTime.Now.Day.ToString();
            labelDayTxt.Text = DateTime.Now.DayOfWeek.ToString();
            labelMonth.Text = DateTime.Now.ToString("MMMM", CultureInfo.InvariantCulture);


            for (int i = 0; i < ticket.studentTicketList.Count; i++)
            {
                if (ticket.studentTicketList[ticket.studentTicketList.Count - 1].quantity != 0)
                {
                    labelStudent.Text = ticket.studentTicketList[ticket.studentTicketList.Count - 1].ToString();
                }

            }

            for (int i = 0; i < ticket.standardTicketList.Count; i++)
            {
                if (ticket.standardTicketList[ticket.standardTicketList.Count - 1].quantity != 0)
                {
                    labelStandard.Text = ticket.standardTicketList[ticket.standardTicketList.Count - 1].ToString();

                }
            }

        }

        private void labelExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void labelBack_Click(object sender, EventArgs e)
        {
            Hide();
            SchedulesForm backToSchedules = new SchedulesForm();
            backToSchedules.Show();
        }

        private void buttonContinue_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Payment succesfully completed.");

            Application.Exit();
        }

        private void linkBackToSchedules_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            SeatsForm backToSeats = new SeatsForm(ticket);
            backToSeats.Show();

        }
    }
}
