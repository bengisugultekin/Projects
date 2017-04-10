using IMDB.DAL;
using System;

namespace IMDB.WEB
{
    public partial class DirectorDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {           

            if (Request.QueryString["ID"] != null)
            {
                int directorID = int.Parse(Request.QueryString["ID"]);

                Repeater1.DataSource = MovieRepository.GetAllMoviesByDirector(directorID);
                Repeater1.DataBind();

                Title = DirectorRepository.GetDirector(directorID).DirectorName;
                directorName.InnerText += DirectorRepository.GetDirector(directorID).DirectorName;
            }
        }
    }
}