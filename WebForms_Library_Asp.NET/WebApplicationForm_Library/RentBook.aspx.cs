using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplicationForm_Library.Models;

namespace WebApplicationForm_Library
{
    public partial class RentBook : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int id = int.Parse(Request.QueryString["ID"]);

                using (LibraryModel db = new LibraryModel())
                {
                    var result = db.Book.Find(id);
                    LabelBookName.Text = result.BookName;
                    LabelWriterName.Text = result.WriterName;
                    LabelSubject.Text = result.BookSubject;
                    LabelShelfNo.Text = result.ShelfNo;
                    LabelPage.Text = result.PageNumber;
                    LabelRentalState.Text = result.RentalState;

                }
            }
        }

        protected void ButtonRent_Click(object sender, EventArgs e)
        {
            using (LibraryModel db = new LibraryModel())
            {
                string phone = TextBoxPhone.Text;

                var result = db.User.FirstOrDefault(a => a.PhoneNumber == phone);
                
                if (result == null)
                {
                    User newUser = new User();
                    newUser.UserName = TextBoxUserName.Text;
                    newUser.Address = TextBoxAddress.Text;
                    newUser.PhoneNumber = TextBoxPhone.Text;

                    db.User.Add(newUser);
                    db.SaveChanges();                   
                }

                RentedBook rentedBook = new RentedBook();
                rentedBook.UserName = TextBoxUserName.Text;
                rentedBook.UserID = db.User.FirstOrDefault(a => a.PhoneNumber == phone).UserID;

                int _bookID = int.Parse(Request.QueryString["ID"]);
                rentedBook.BookID = _bookID;
                rentedBook.RentDate = Calendar1.SelectedDate;
                rentedBook.ReturnDate = Convert.ToDateTime(LabelReturnDate.Text);
                rentedBook.RentalState = "Rented";

                db.RentedBook.Add(rentedBook);

                db.Book.Find(_bookID).RentalState = "Rented";
                
                db.SaveChanges();

                Response.Redirect("BookList.aspx");

            }
        }

        protected void Calendar1_DayRender(object sender, DayRenderEventArgs e)
        {
            if (e.Day.Date < DateTime.Now.Date)
            {

                e.Cell.BackColor = System.Drawing.Color.Gray;

                e.Day.IsSelectable = false;

            }
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            LabelReturnDate.Text = Calendar1.SelectedDate.AddMonths(1).ToLongDateString();
        }
    }
}