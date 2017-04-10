using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplicationForm_Library.Models;

namespace WebApplicationForm_Library
{
    public partial class BookList : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            using (LibraryModel db = new LibraryModel())
            {
                Repeater1.DataSource = db.Book.ToList();
                Repeater1.DataBind();                
            }

            if (Request.QueryString["ID"] != null)
            {
                int id = int.Parse(Request.QueryString["ID"]);

                using (LibraryModel db = new LibraryModel())
                {
                    var result = db.Book.Find(id);
                    db.Book.Remove(result);
                    db.SaveChanges();

                    Response.Redirect("BookList.aspx");

                }
            }
        }
    }
}