﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Question_04
{
    public partial class Cookies : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Cookies["bgcolor"]!=null)
            {
                DropDownList1.SelectedValue = Request.Cookies["bgcolor"].Value;
                bodytag.Style["backgroung-color"]=DropDownList1.SelectedValue.ToString();   
            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            bodytag.Style["background-color"]=DropDownList1.SelectedValue.ToString();
            HttpCookie cookie = new HttpCookie("bgcolor");
            cookie.Expires=DateTime.Now.AddSeconds(2);
            Response.SetCookie(cookie);
        }
    }
}