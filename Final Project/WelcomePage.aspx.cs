﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Final_Project
{
    public partial class WelcomePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void PlazaBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Webforms/ShoppingPlazaForm.aspx");
        }

        protected void ExitBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("/WebForms/ExitPage.aspx");
        }
    }
}