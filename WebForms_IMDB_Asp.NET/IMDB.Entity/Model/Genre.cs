namespace IMDB.Entity
{
    public class Genre
    {
        public int GenreID { get; set; }

        public string GenreName { get; set; }


        public override string ToString()
        {
            return GenreName;
        }

    }

     
}
