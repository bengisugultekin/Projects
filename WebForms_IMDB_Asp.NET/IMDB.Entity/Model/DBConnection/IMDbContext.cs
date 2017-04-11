namespace IMDB.Entity.Model.DBConnection
{
    using System.Data.Entity;

    public class IMDbContext : DbContext
    {

        public IMDbContext()
            : base("name=IMDbContext")
        {
        }

        public virtual DbSet<Movie> Movie { get; set; }
        public virtual DbSet<Genre> Genre { get; set; }
        public virtual DbSet<Director> Director { get; set; }

    }


}