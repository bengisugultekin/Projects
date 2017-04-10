using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema_Seat_Reservation
{
    public class Schedule
    {
        public static List<string> permanantSeatList1pm = new List<string>();
        public static List<string> permanantSeatList4pm = new List<string>();
        public static List<string> permanantSeatList7pm = new List<string>();

        public void setSchedule(Ticket ticket)
        {
            if (ticket.time == "01:00 PM")
            {
                foreach (var item in ticket.chosenSeatList)
                {
                    permanantSeatList1pm.Add(item);
                }
            }
            else if (ticket.time == "04:00 PM")
            {
                foreach (var item in ticket.chosenSeatList)
                {
                    permanantSeatList4pm.Add(item);
                }
            }
            if (ticket.time == "07:00 PM")
            {
                foreach (var item in ticket.chosenSeatList)
                {
                    permanantSeatList7pm.Add(item);
                }
            }
        }
    }
}