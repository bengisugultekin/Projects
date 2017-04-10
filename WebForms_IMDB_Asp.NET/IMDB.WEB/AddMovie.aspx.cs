﻿using IMDB.DAL;
using IMDB.Entity.Model.ViewModel;
using System;

namespace IMDB.WEB
{
    public partial class AddMovie : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DropDownListDirectorName.DataSource = DirectorRepository.GetAllDirectors();
                DropDownListDirectorName.DataBind();

                DropDownListGenre.DataSource = GenreRepository.GetAllGenres();
                DropDownListGenre.DataBind();
            }
        }

        protected void ButtonSave_Click(object sender, EventArgs e)
        {
            ViewMovie newMovie = new ViewMovie();

            newMovie.MovieName = TextBoxMovieName.Text;
            newMovie.DirectorName = DropDownListDirectorName.SelectedItem.Text;
            newMovie.GenreName = DropDownListGenre.SelectedItem.Text;
            newMovie.Description = TextBoxDescription.Text;
            newMovie.ReleaseDate = int.Parse(TextBoxReleaseDate.Text);
            newMovie.Score = decimal.Parse(TextBoxScore.Text);
            newMovie.TotalScore = newMovie.Score;
            newMovie.ScoreCounter = 1;

            MovieRepository.AddMovie(newMovie);

            Response.Redirect("ListOfMovies.aspx");
        }
    }
}