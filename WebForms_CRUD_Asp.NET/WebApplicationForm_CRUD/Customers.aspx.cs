using System;
using System.Linq;
using System.Web.UI.WebControls;
using WebApplicationForm_CRUD.Models;

namespace WebApplicationForm_CRUD
{
    public partial class Customers : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            using (BakkalDBEntities db = new BakkalDBEntities())
            {
                Repeater1.DataSource = db.Customers.ToList();
                Repeater1.DataBind();
            }

            if (Request.QueryString["ID"] != null)
            {
                int id = int.Parse(Request.QueryString["ID"]);

                using (BakkalDBEntities db = new BakkalDBEntities())
                {
                    var result = db.Customers.Find(id);
                    db.Customers.Remove(result);
                    db.SaveChanges();

                    Response.Redirect("Customers.aspx");

                }
            }
        }
    }
}





