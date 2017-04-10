using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema_Seat_Reservation
{
    public partial class TicketForm : Form
    {

        Ticket ticket = new Ticket();

        public TicketForm(Ticket ticketFromSchedulesForm)
        {
            InitializeComponent();
            ticket.time = ticketFromSchedulesForm.time;
        }

        private void TicketForm_Load(object sender, EventArgs e)
        {
            labelDay.Text = DateTime.Now.Day.ToString();
            labelDayTxt.Text = DateTime.Now.DayOfWeek.ToString();
            labelMonth.Text = DateTime.Now.ToString("MMMM", CultureInfo.InvariantCulture);
            labelSchedule.Text = ticket.time;
        }

        private void linkBackToSchedules_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            SchedulesForm backToSchedulesForm = new SchedulesForm();
            backToSchedulesForm.Show();
        }


        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            StudentTicket studentTicket = new StudentTicket();
            StandardTicket standardTicket = new StandardTicket();

            studentTicket.quantity = int.Parse(comboBoxStudentCount.SelectedItem.ToString());
            studentTicket.setTotal();
            studentTicket.ticketType = TicketType.Student;
            labelStudentPrice.Text = "€ " + studentTicket.total.ToString("F");

            ticket.studentTicketList.Add(studentTicket);

            ticket.total = studentTicket.total + standardTicket.total;
            labelTotal.Text = "€ " + ticket.total.ToString("F");

            standardTicket.quantity = int.Parse(comboBoxStandardCount.SelectedItem.ToString());
            standardTicket.setTotal();
            standardTicket.ticketType = TicketType.Standard;
            labelStandardPrice.Text = "€ " + standardTicket.total.ToString("F");

            ticket.standardTicketList.Add(standardTicket);

            ticket.total = studentTicket.total + standardTicket.total;
            labelTotal.Text = "€ " + ticket.total.ToString("F");

            
            ticket.quantity = studentTicket.quantity + standardTicket.quantity;
            
        }

        private void buttonContinue_Click(object sender, EventArgs e)
        {
            if (ticket.total == 0)
            {
                MessageBox.Show("You have to choose at least one ticket");
            }
            else
            {
                SeatsForm goToSeatsForm = new SeatsForm(ticket);
                goToSeatsForm.Show();
                Hide();
            }
            
        }
    }
}
