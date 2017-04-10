using KutuphaneOtomasyon.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneOtomasyon.DAL
{
    public class UserRepository
    {
        public static void AddUser(User user)
        {
            using (KutuphaneDBContext db = new KutuphaneDBContext())
            {
                db.User.Add(user);
                db.SaveChanges();
            }
        }

        public static List<User> GetAllUsers()
        {
            using (KutuphaneDBContext db = new KutuphaneDBContext())
            {
                return db.User.ToList();
            }
        }
    }
}
