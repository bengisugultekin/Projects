using IMDB.DAL;
using IMDB.Entity.Model.ViewModel;
using System;

namespace IMDB.WEB
{
    public partial class UpdateMovie : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["ID"] != null && !IsPostBack)
            {
                DropDownListDirectorName.DataSource = DirectorRepository.GetAllDirectors();
                DropDownListDirectorName.DataBind();

                DropDownListGenre.DataSource = GenreRepository.GetAllGenres();
                DropDownListGenre.DataBind();

                int id = int.Parse(Request.QueryString["ID"]);

                var movie = MovieRepository.GetViewMovie(id);

                MovieName.Value = movie.MovieName;

                DropDownListDirectorName.ClearSelection();
                DropDownListDirectorName.Items.FindByValue(movie.DirectorName).Selected = true;
                DropDownListGenre.ClearSelection();
                DropDownListGenre.Items.FindByValue(movie.GenreName).Selected = true;
                Description.Value = movie.Description;
                ReleaseDate.Value = movie.ReleaseDate.ToString();
                Score.Value = movie.Score.ToString();

                Title = movie.MovieName + " (" + movie.ReleaseDate + ")";
            }

        }

        protected void ButtonSave_Click(object sender, EventArgs e)
        {
            ViewMovie movie = new ViewMovie();

            movie.MovieID = int.Parse(Request.QueryString["ID"]);
            movie.MovieName = MovieName.Value;
            movie.DirectorName = DropDownListDirectorName.SelectedItem.Text;
            movie.GenreName = DropDownListGenre.SelectedItem.Text;
            movie.Description = Description.Value;
            movie.ReleaseDate = int.Parse(ReleaseDate.Value);
            movie.Score = decimal.Parse(Score.Value);
            movie.TotalScore = movie.Score;
            movie.ScoreCounter = 1;

            MovieRepository.UpdateMovie(movie);

            Response.Redirect("ListOfMovies.aspx");
        }
    }
}