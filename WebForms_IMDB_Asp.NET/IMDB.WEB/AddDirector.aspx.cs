using IMDB.DAL;
using IMDB.Entity.Model;
using System;

namespace IMDB.WEB
{
    public partial class AddDirector : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonSave_Click(object sender, EventArgs e)
        {
            Director newDirector = new Director();
            newDirector.DirectorName = TextBoxDirectorName.Text;

            DirectorRepository.AddDirector(newDirector);

            Response.Redirect("ListOfDirectors.aspx");
        }
    }
}