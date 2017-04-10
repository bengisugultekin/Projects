using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplicationForm_CRUD.Models;

namespace WebApplicationForm_CRUD
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int id = int.Parse(Request.QueryString["ID"]);

                using (BakkalDBEntities db = new BakkalDBEntities())
                {
                    var result = db.Customers.Find(id);
                    TextBoxName.Text = result.CustomerName;
                    TextBoxSurname.Text = result.CustomerSurname;
                    TextBoxPhone.Text = result.PhoneNumber;
                    TextBoxAddress.Text = result.Address;
                }
            }           
        }

        protected void ButtonUpdate_Click(object sender, EventArgs e)
        {
            using (BakkalDBEntities db = new BakkalDBEntities())
            {
                int id = int.Parse(Request.QueryString["ID"]);
                var result = db.Customers.Find(id);

                result.CustomerName = TextBoxName.Text;
                result.CustomerSurname = TextBoxSurname.Text;
                result.PhoneNumber = TextBoxPhone.Text;
                result.Address = TextBoxAddress.Text;
              
                db.SaveChanges();

                Response.Redirect("Customers.aspx");

            }
        }
    }
}