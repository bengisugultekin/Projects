using System.Collections.Generic;

namespace E_Ticaret.Entity.Models
{
    public class Customer
    {
        public int CustomerID { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string Address { get; set; }

        public List<Custom> CustomList { get; set; }






    }


}
