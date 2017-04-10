using IMDB.DAL;
using System;

namespace IMDB.WEB
{
    public partial class UpdateDirector : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["ID"] != null && !IsPostBack)
            {
                int id = int.Parse(Request.QueryString["ID"]);

                TextBoxDirectorName.Text = DirectorRepository.GetDirector(id).DirectorName;
                
            }
        }

        protected void ButtonSave_Click(object sender, EventArgs e)
        {
            int id = int.Parse(Request.QueryString["ID"]);

            DirectorRepository.UpdateDirector(id, TextBoxDirectorName.Text);

            Response.Redirect("ListOfDirectors.aspx");
        }
    }
}