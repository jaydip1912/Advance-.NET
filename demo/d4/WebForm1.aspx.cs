﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace d4
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(HiddenField1.Value!=null)
            {
                int val=Int32.Parse(HiddenField1.Value);
                val = val + 1;
                Label1.Text = "Value of Hiddend field "+ val.ToString();

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label1.Visible = true;
        }
    }
}