using IMDB.DAL;
using System;

namespace IMDB.WEB
{
    public partial class ListOfMovies : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["sort"] == "rating_desc")
            {
                Repeater1.DataSource = MovieRepository.GetAllMoviesByDescRating();
                Repeater1.DataBind();
            }
            else if (Request.QueryString["sort"] == "year_desc")
            {
                Repeater1.DataSource = MovieRepository.GetAllMoviesByDescYear();
                Repeater1.DataBind();
            }
            else
            {
                Repeater1.DataSource = MovieRepository.GetAllMovies();
                Repeater1.DataBind();
            }


            //For Delete
            if (Request.QueryString["ID"] != null)
            {
                int id = int.Parse(Request.QueryString["ID"]);

                MovieRepository.DeleteMovie(id);

                Response.Redirect("ListOfMovies.aspx");
            }

            

        }
    }
}