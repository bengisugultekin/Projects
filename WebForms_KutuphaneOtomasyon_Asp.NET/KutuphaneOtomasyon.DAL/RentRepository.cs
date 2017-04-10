using KutuphaneOtomasyon.Entity.Model;
using KutuphaneOtomasyon.Entity.Model.ViewModel;
using System.Collections.Generic;
using System.Linq;

namespace KutuphaneOtomasyon.DAL
{
    public class RentRepository
    {
        public static void AddRent(Rent rent)
        {
            using (KutuphaneDBContext db = new KutuphaneDBContext())
            {
                db.Rent.Add(rent);

                var result = db.Book.Find(rent.BookID);
                result.IsRented = true;

                db.SaveChanges();
            }
        }

        //public static List<Rent> GetAllRent()
        //{
        //    using (KutuphaneDBContext db = new KutuphaneDBContext())
        //    {
        //        return db.Rent.ToList();
        //    }
        //}

        public static List<ViewRent> GetAllRents()
        {
            using (KutuphaneDBContext db = new KutuphaneDBContext())
            {
                return db.Rent.Select(r => new ViewRent
                {
                    BookName = r.Book.BookName,
                    UserName = r.User.UserName,
                    RentDate = r.RentDate,
                    ReturnDate = r.ReturnDate,
                   
                }).ToList();
            }
        }


    }
}
