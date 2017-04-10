using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema_Seat_Reservation
{
    public enum TicketType
    {
        Student,
        Standard
    };

    public class Ticket
    {
        public int TicketID { get; set; }
        public int quantity { get; set; }
        public double total { get; set; }

        public TicketType ticketType;

        //public List<string> chosenSeatList = new List<string>();

        private readonly List<string> _chosenSeatList = new List<string>();
        public virtual List<string> chosenSeatList { get { return _chosenSeatList; } set { chosenSeatList = _chosenSeatList; } }

        public List<StudentTicket> studentTicketList = new List<StudentTicket>();

        public List<StandardTicket> standardTicketList = new List<StandardTicket>();

        public string time { get; set; }

        private string _date = DateTime.Now.ToShortDateString();
        public string date { get { return _date; } set { date = _date; } }

        public override string ToString()
        {
            return quantity + " Person";
        }


    }
}
