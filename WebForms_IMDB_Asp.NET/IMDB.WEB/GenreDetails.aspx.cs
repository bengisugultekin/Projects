using IMDB.DAL;
using System;

namespace IMDB.WEB
{
    public partial class GenreDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["ID"] != null)
            {
                int genreID = int.Parse(Request.QueryString["ID"]);

                Repeater1.DataSource = MovieRepository.GetAllMoviesByGenre(genreID);
                Repeater1.DataBind();

                Title = GenreRepository.GetGenre(genreID).GenreName;
                GenreName.InnerText += GenreRepository.GetGenre(genreID).GenreName;
            }
        }
    }
}