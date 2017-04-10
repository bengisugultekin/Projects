using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplicationForm_Library.Models;

namespace WebApplicationForm_Library
{
    public partial class UpdateBook : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int id = int.Parse(Request.QueryString["ID"]);

                using (LibraryModel db = new LibraryModel())
                {
                    var result = db.Book.Find(id);
                    TextBoxBookName.Text = result.BookName;
                    TextBoxWriterName.Text = result.WriterName;
                    TextBoxSubject.Text = result.BookSubject;
                    TextBoxShelfNo.Text = result.ShelfNo;
                    TextBoxPage.Text = result.PageNumber;
                    TextBoxRentalState.Text = result.RentalState;


                }
            }
        }

        protected void ButtonUpdate_Click(object sender, EventArgs e)
        {
            using (LibraryModel db = new LibraryModel())
            {
                int id = int.Parse(Request.QueryString["ID"]);
                var result = db.Book.Find(id);
                result.BookName = TextBoxBookName.Text;
                result.WriterName = TextBoxWriterName.Text;
                result.BookSubject = TextBoxSubject.Text;
                result.ShelfNo = TextBoxShelfNo.Text;
                result.PageNumber = TextBoxPage.Text;
                result.RentalState = TextBoxRentalState.Text;

                db.SaveChanges();

                Response.Redirect("BookList.aspx");
            }

        }
    }
}