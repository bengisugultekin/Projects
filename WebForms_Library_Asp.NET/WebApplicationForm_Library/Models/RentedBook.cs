using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplicationForm_Library.Models
{
    public class RentedBook
    {
        public int RentedBookID { get; set; }

        //[ForeignKey("User")]
        public int UserID { get; set; }

        public string UserName { get; set; }

        //[ForeignKey("Book")]
        public int BookID { get; set; }

        public DateTime RentDate { get; set; }

        public DateTime ReturnDate { get; set; }

        public string RentalState { get; set; }

        public User User { get; set; }

        public Book Book { get; set; }
    }
}