namespace IMDB.Entity.Model
{
    public class Movie
    {
        public int MovieID { get; set; }

        public string MovieName { get; set; }

        public string Description { get; set; }

        public int ReleaseDate { get; set; } //year

        public decimal Score { get; set; }

        public int ScoreCounter { get; set; }

        public decimal totalScore { get; set; }

        public bool IsDeleted { get; set; }

        public int GenreID { get; set; }

        public int DirectorID { get; set; }


        //mapping
        public Genre Genre { get; set; }
        public Director Director { get; set; }


        public decimal CalculateScore(int addScore)
        {
            ScoreCounter++;
            totalScore += addScore;
            return totalScore / ScoreCounter;
        }
    }


}
