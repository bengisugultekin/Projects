using IMDB.Entity.Model;
using IMDB.Entity.Model.DBConnection;
using System.Collections.Generic;
using System.Linq;

namespace IMDB.DAL
{
    public class DirectorRepository
    {
        public static List<Director> GetAllDirectors()
        {
            using (IMDbContext db = new IMDbContext())
            {

                return db.Director.Where(d => d.IsDeleted == false).ToList();
            }
        }

        public static void AddDirector(Director director)
        {
            using (IMDbContext db = new IMDbContext())
            {
                if (db.Director.SingleOrDefault(d => d.DirectorName == director.DirectorName) == null)
                {
                    db.Director.Add(director);
                    db.SaveChanges();
                }

            }
        }

        public static void DeleteDirector(int id)
        {
            using (IMDbContext db = new IMDbContext())
            {
                var result = db.Director.Find(id);
                result.IsDeleted = true;
                db.SaveChanges();
            }
        }

        public static void UpdateDirector(int id, string name)
        {
            using (IMDbContext db = new IMDbContext())
            {
                var result = db.Director.Find(id);
                result.DirectorName = name;
                db.SaveChanges();
            }
        }

        public static Director GetDirector(int id)
        {
            using (IMDbContext db = new IMDbContext())
            {
                return db.Director.Find(id);
            }
        }


    }
}
