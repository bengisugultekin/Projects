using KutuphaneOtomasyon.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KutuphaneOtomasyon.WEB
{
    public partial class WriterList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            Repeater1.DataSource = WriterRepository.GetAllWriters();
            Repeater1.DataBind();


            if (Request.QueryString["ID"] != null)
            {
                int id = int.Parse(Request.QueryString["ID"]);

                WriterRepository.DeleteWriter(id);

                Response.Redirect("WriterList.aspx");
            }
        }
    }
}