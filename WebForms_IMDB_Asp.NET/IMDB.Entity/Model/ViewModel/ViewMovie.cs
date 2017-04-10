namespace IMDB.Entity.Model.ViewModel
{
    public class ViewMovie
    {
        public int MovieID { get; set; }

        public string MovieName { get; set; }

        public string Description { get; set; }

        public int ReleaseDate { get; set; }

        public decimal Score { get; set; }

        public int ScoreCounter { get; set; }

        public decimal TotalScore { get; set; }


        public string GenreName { get; set; }

        public string DirectorName { get; set; }

        public int DirectorID { get; set; }

        public int GenreID { get; set; }
    }
}
