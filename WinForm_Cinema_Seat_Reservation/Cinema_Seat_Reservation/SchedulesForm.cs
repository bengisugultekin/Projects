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
    public partial class SchedulesForm : Form
    {
        public SchedulesForm()
        {
            InitializeComponent();
        }

        private void button01pm_MouseHover(object sender, EventArgs e)
        {
            button01pm.BackColor = Color.DeepPink;
        }

        private void button01pm_MouseLeave(object sender, EventArgs e)
        {
            button01pm.BackColor = Color.Gray;

        }

        private void button04pm_MouseHover(object sender, EventArgs e)
        {
            button04pm.BackColor = Color.DeepPink;
        }

        private void button04pm_MouseLeave(object sender, EventArgs e)
        {
            button04pm.BackColor = Color.Gray;

        }

        private void button07pm_MouseHover(object sender, EventArgs e)
        {
            button07pm.BackColor = Color.DeepPink;
        }

        private void button07pm_MouseLeave(object sender, EventArgs e)
        {
            button07pm.BackColor = Color.Gray;

        }

        private void SchedulesForm_Load(object sender, EventArgs e)
        {
            labelDay.Text = DateTime.Now.Day.ToString();
            labelDayTxt.Text = DateTime.Now.DayOfWeek.ToString();
            labelMonth.Text = DateTime.Now.ToString("MMMM", CultureInfo.InvariantCulture);
        }

        private void buttonPM_MouseClick(object sender, MouseEventArgs e)
        {
            Hide();

            Ticket ticket = new Ticket();

            ticket.time = ((Control)sender).Text;

            TicketForm buyTicket = new TicketForm(ticket);
            buyTicket.Show();
        }
    }
}
