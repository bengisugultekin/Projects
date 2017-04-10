using KutuphaneOtomasyon.DAL;
using KutuphaneOtomasyon.Entity.Model;
using System;

namespace KutuphaneOtomasyon.WEB
{
    public partial class RentBook : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                TextBoxBookName.Text = BookRepository.GetBook(int.Parse(Request.QueryString["ID"])).BookName;

                DropDownListUser.DataSource = UserRepository.GetAllUsers();
                DropDownListUser.DataTextField = "UserName";
                DropDownListUser.DataValueField = "UserID";
                DropDownListUser.DataBind();
            }
        }

        protected void ButtonRent_Click(object sender, EventArgs e)
        {
            Rent rent = new Rent();

            rent.BookID = int.Parse(Request.QueryString["ID"]);
            rent.UserID = int.Parse(DropDownListUser.SelectedItem.Value);
            rent.RentDate = DateTime.Now;
            rent.ReturnDate = DateTime.Now.AddDays(15);

            RentRepository.AddRent(rent);
            Response.Redirect("AllRecords.aspx"); 
        }
    }
}