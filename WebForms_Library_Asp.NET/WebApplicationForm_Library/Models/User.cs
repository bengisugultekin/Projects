using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplicationForm_Library.Models
{
    public class User
    {
        public int UserID { get; set; }
        public string UserName { get; set; }

        public string Address { get; set; }

        public string PhoneNumber { get; set; }

        //public ICollection<RentedBook> RentedBooks { get; set; }
    }
}