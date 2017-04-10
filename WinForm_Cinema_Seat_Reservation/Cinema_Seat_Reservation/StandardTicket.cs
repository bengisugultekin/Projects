using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema_Seat_Reservation
{
    public class StandardTicket : Ticket
    {
       

       public void setTotal()
        {
            total = 12 * quantity;
        }

        public override string ToString()
        {
            return quantity.ToString() + " " + ticketType;
        }
    }
}
