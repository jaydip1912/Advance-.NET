﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Question_05
{
    public partial class Globalization : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            decimal money = 480;
            Label2.Text = DateTime.Now.ToShortDateString();
            Label3.Text=money.ToString("c");
        }
    }
}