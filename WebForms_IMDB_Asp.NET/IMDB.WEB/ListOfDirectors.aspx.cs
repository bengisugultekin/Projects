using IMDB.DAL;
using System;

namespace IMDB.WEB
{
    public partial class ListOfDirectors : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Repeater1.DataSource = DirectorRepository.GetAllDirectors();
            Repeater1.DataBind();

            if (Request.QueryString["ID"] != null)
            {
                int id = int.Parse(Request.QueryString["ID"]);

                DirectorRepository.DeleteDirector(id);

                Response.Redirect("ListOfDirectors.aspx");
            }

        }
    }
}