using IMDB.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IMDB.WEB
{
    public partial class ListOfGenres : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Repeater1.DataSource = GenreRepository.GetAllGenres();
                Repeater1.DataBind();
            }
        }
    }
}