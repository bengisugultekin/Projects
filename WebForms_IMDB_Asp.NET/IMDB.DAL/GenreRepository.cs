using IMDB.Entity;
using IMDB.Entity.Model.DBConnection;
using System.Collections.Generic;
using System.Linq;

namespace IMDB.DAL
{
    public class GenreRepository
    {
        public static List<Genre> GetAllGenres()
        {
            using (IMDbContext db = new IMDbContext())
            {
                return db.Genre.Where(g => g.IsDeleted == false).OrderBy(g => g.GenreName).ToList();
            }
        }

        public static void AddGenre(Genre genre)
        {
            using (IMDbContext db = new IMDbContext())
            {
                var result = db.Genre.FirstOrDefault(g => g.GenreName == genre.GenreName);

                if (result == null)
                {
                    db.Genre.Add(genre);
                    db.SaveChanges();
                }

            }
        }

        public static Genre GetGenre(int id)
        {
            using (IMDbContext db = new IMDbContext())
            {
                return db.Genre.Find(id);
            }
        }
    }
}
