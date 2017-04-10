using System;
using System.Collections.Generic;

namespace E_Ticaret.Entity.Models
{
    public class Custom
    {
        public int CustomID { get; set; }
        public List<Product> ShoppingBag { get; set; }
        public double TotalBill { get; set; }
        public int CustomerID { get; set; }
        public DateTime OrderDate { get; set; }
        public string ShippingAddress { get; set; }

        public Customer Customer { get; set; }
    }
}
