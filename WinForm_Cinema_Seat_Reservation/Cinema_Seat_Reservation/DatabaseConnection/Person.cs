using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema_Seat_Reservation.DatabaseConnection
{
    public class Person
    {
        public int PersonID { get; set; }
        public string NameSurname { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public string Address { get; set; }

        public string CreditCardNumber { get; set; }

        public int ExpirationMonth { get; set; }

        public int ExpirationYear { get; set; }

        public int Cvv { get; set; }

        public double totalPrice { get; set; }
    }
}
