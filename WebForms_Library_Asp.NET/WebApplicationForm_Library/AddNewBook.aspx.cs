using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplicationForm_Library.Models;

namespace WebApplicationForm_Library
{
    public partial class AddNewBook : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void ButtonAdd_Click(object sender, EventArgs e)
        {
            using (LibraryModel db = new LibraryModel())
            {
                Book newBook = new Book();
                newBook.BookName = TextBoxBookName.Text;
                newBook.WriterName = TextBoxWriterName.Text;
                newBook.BookSubject = TextBoxSubject.Text;
                newBook.ShelfNo = TextBoxShelfNo.Text;
                newBook.PageNumber = TextBoxPage.Text;
                newBook.RentalState = TextBoxRentalState.Text;

                db.Book.Add(newBook);
                db.SaveChanges();

                Response.Redirect("BookList.aspx");

            }
        }
    }
}