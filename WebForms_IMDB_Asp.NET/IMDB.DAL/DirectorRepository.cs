using IMDB.Entity.Model;
using IMDB.Entity.Model.DBConnection;
using IMDB.Entity.Model.ViewModel;
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
                return db.Director.ToList();
            }
        }

        public static void AddDirector(Director director)
        {
            using (IMDbContext db = new IMDbContext())
            {
                db.Director.Add(director);
                db.SaveChanges();
            }
        }

        public static void DeleteDirector(int id)
        {
            using (IMDbContext db = new IMDbContext())
            {
                var result = db.Director.Find(id);
                db.Director.Remove(result);
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
