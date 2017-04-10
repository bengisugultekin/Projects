using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplicationForm_Library.Models
{
    public class Book
    {
        public int BookID { get; set; }
        public string BookName { get; set; }

        public string BookSubject { get; set; }

        public string ShelfNo { get; set; }

        public string PageNumber { get; set; }

        public string WriterName { get; set; }

        public string RentalState { get; set; }

        //public ICollection<RentedBook> RentedBooks { get; set; }
    }
}