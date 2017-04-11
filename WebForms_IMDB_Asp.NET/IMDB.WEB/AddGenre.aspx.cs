using IMDB.DAL;
using IMDB.Entity;
using System;

namespace IMDB.WEB
{
    public partial class AddGenre : System.Web.UI.Page
    {

        protected void ButtonSave_Click(object sender, EventArgs e)
        {
            Genre newGenre = new Genre();

            newGenre.GenreName = GenreName.Value;

            GenreRepository.AddGenre(newGenre);

            Response.Redirect("ListOfGenres.aspx");
        }
    }
}