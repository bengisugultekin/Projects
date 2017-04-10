using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema_Seat_Reservation
{
    public class StudentTicket : Ticket
    {
       
        public void setTotal()
        {
            total = 10 * quantity;
        }

        public override string ToString()
        {
            return quantity.ToString() + " " +ticketType;
        }
    }
}