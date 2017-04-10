namespace IMDB.Entity.Model
{
    public class Director
    {
        public int DirectorID { get; set; }

        public string DirectorName { get; set; }

        public override string ToString()
        {
            return DirectorName;
        }
    }
}
