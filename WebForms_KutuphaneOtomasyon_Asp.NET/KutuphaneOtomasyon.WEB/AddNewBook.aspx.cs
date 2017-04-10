using KutuphaneOtomasyon.DAL;
using KutuphaneOtomasyon.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KutuphaneOtomasyon.WEB
{
    public partial class AddNewBook : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DropDownListWriter.DataSource = WriterRepository.GetAllWriters();
                DropDownListWriter.DataTextField = "WriterName";
                DropDownListWriter.DataValueField = "WriterID";
                DropDownListWriter.DataBind();
            }            
        }

        protected void ButtonAdd_Click(object sender, EventArgs e)
        {

            Book newBook = new Book();
            newBook.BookName = TextBoxBookName.Text;
            newBook.BookSubject = TextBoxSubject.Text;
            newBook.ShelfNumber = int.Parse(TextBoxShelfNo.Text);
            newBook.PageCount = int.Parse(TextBoxPage.Text);
            newBook.WriterID = int.Parse(DropDownListWriter.SelectedItem.Value);

            BookRepository.AddBook(newBook);           

            Response.Redirect("BookList.aspx");

        }
    }
}
