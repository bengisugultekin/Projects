using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplicationForm_Library.Models;

namespace WebApplicationForm_Library
{
    public partial class UserList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            using (LibraryModel db = new LibraryModel())
            {
                Repeater1.DataSource = db.User.ToList();
                Repeater1.DataBind();

            }
            
           
        }
    }
}