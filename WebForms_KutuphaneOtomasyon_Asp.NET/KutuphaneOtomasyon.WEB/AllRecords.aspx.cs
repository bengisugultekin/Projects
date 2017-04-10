﻿using KutuphaneOtomasyon.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KutuphaneOtomasyon.WEB
{
    public partial class RentList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Repeater1.DataSource = RentRepository.GetAllRents();           
            Repeater1.DataBind();
        }
    }
}