using IMDB.DAL;
using System;

namespace IMDB.WEB
{
    public partial class MovieDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["ID"] != null)
            {
                int id = int.Parse(Request.QueryString["ID"]);

                var movie = MovieRepository.GetViewMovie(id);

                LabelMovieName.Text = movie.MovieName;
                LabelDirectorName.Text = movie.DirectorName;
                LabelGenreName.Text = movie.GenreName;
                LabelDescription.Text = movie.Description;
                LabelReleaseDate.Text = movie.ReleaseDate.ToString();
                LabelScore.Text = movie.Score.ToString();

                Title = movie.MovieName + " (" + movie.ReleaseDate + ")";
            }

        }

        protected void ButtonSubmit_Click(object sender, EventArgs e)
        {
            int id = int.Parse(Request.QueryString["ID"]);

            var movie = MovieRepository.GetMovie(id);

            movie.Score = movie.CalculateScore(int.Parse(Score.Value));


            MovieRepository.UpdateMovieScore(movie);

            Response.Redirect("MovieDetails.aspx?ID=" + id);
        }
    }
}