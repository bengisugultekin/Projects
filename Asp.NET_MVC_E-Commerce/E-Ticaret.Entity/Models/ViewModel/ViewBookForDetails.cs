namespace E_Ticaret.Entity.Models.ViewModel
{
    public class ViewBookForDetails
    {
        public int BookID { get; set; }

        public string BookName { get; set; }

        public string BookSubject { get; set; }

        public string Publisher { get; set; }

        public int WriterID { get; set; }

        public string WriterName { get; set; }

        public decimal Price { get; set; }

        public string PhotoUrl { get; set; }
    }
}
