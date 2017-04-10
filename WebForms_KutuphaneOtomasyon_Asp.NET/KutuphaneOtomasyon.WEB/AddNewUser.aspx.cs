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
    public partial class AddNewUser : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonAdd_Click(object sender, EventArgs e)
        {
            User newUser = new User();
            newUser.UserName = TextBoxUserName.Text;
            newUser.Address = TextBoxAddress.Text;
            newUser.PhoneNumber = TextBoxPhone.Text;

            UserRepository.AddUser(newUser);
            Response.Redirect("UserList.aspx");
        }
    }
}