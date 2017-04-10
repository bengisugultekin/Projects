using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplicationForm_CRUD.Models;

namespace WebApplicationForm_CRUD
{
    public partial class AddCustomer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonSave_Click(object sender, EventArgs e)
        {
            using (BakkalDBEntities db = new BakkalDBEntities())
            {
                Customer customer = new Customer();
                customer.CustomerName = TextBoxName.Text;
                customer.CustomerSurname = TextBoxSurname.Text;
                customer.PhoneNumber = TextBoxPhone.Text;
                customer.Address = TextBoxAddress.Text;

                db.Customers.Add(customer);
                db.SaveChanges();

                Response.Redirect("customers.aspx");

            }
        }
    }
}