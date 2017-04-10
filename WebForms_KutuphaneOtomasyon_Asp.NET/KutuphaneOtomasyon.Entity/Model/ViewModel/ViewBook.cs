﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KutuphaneOtomasyon.Entity.Models.ViewModel
{
    public class ViewBook
    {
        public int BookID { get; set; }

        public string BookName { get; set; }

        public string BookSubject { get; set; }

        public int PageCount { get; set; }        

        public int ShelfNumber { get; set; }    

        public bool IsRented { get; set; }



        public string WriterName { get; set; }

    }
}