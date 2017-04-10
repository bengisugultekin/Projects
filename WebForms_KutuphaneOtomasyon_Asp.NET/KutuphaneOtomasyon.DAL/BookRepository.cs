using KutuphaneOtomasyon.Entity.Model;
using KutuphaneOtomasyon.Entity.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneOtomasyon.DAL
{
    public class BookRepository
    {
        public static List<ViewBook> GetAllBooks()
        {
            using (KutuphaneDBContext db = new KutuphaneDBContext())
            {
                return db.Book.Select(b => new ViewBook
                {
                    BookID = b.BookID,
                    BookName = b.BookName,
                    BookSubject = b.BookSubject,
                    PageCount = b.PageCount,
                    IsRented = b.IsRented,
                    ShelfNumber = b.ShelfNumber,
                    WriterName = b.Writer.WriterName,
                }).ToList();
            }
        }

        public static void AddBook(Book book)
        {
            using (KutuphaneDBContext db = new KutuphaneDBContext())
            {
                db.Book.Add(book);
                db.SaveChanges();
            }
        }

        public static Book GetBook(int id)
        {
            using (KutuphaneDBContext db = new KutuphaneDBContext())
            {
                return db.Book.Find(id);
            }
        }

    }
}
