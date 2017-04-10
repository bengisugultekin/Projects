﻿using KutuphaneOtomasyon.DAL;
using KutuphaneOtomasyon.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KutuphaneOtomasyon.WEB
{
    public partial class AddWriter : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Request.QueryString["ID"] != null && !IsPostBack)
            {
                int id = int.Parse(Request.QueryString["ID"]);

                var result = WriterRepository.GetWriter(id);
                TextBoxWriterName.Text = result.WriterName;
                ButtonAdd.CssClass = "btn btn-success btn-block";
                ButtonAdd.Text = "Update";

            }
        }

        protected void ButtonAdd_Click(object sender, EventArgs e)
        {
            Writer writer = new Writer();
            writer.WriterName = TextBoxWriterName.Text;

            if (ButtonAdd.Text == "Update")
            {
                int id = int.Parse(Request.QueryString["ID"]);
                WriterRepository.UpdateWriter(id, TextBoxWriterName.Text);
                Response.Redirect("WriterList.aspx");
            }
            else
            {
                WriterRepository.AddWriter(writer);
                Response.Redirect("WriterList.aspx");
            }
           
        }
    }
}