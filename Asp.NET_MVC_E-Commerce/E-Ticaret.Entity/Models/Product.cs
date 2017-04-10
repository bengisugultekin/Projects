namespace E_Ticaret.Entity.Models
{
    public class Product
    {
        public int ProductID { get; set; }

        public int BookID { get; set; }

        public string PhotoUrl { get; set; }

        public string BookName { get; set; }

        public int BookCount { get; set; }

        public decimal Price { get; set; }

        public decimal TotalPrice
        {
            get { return Price * BookCount; }

        }

        public bool Checked { get; set; }

        //mapping?
    }
}
