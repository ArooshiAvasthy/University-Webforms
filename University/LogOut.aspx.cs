using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace University
{
    public partial class LogOut : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Master.FindControl("LogIn_link").Visible=true;
            Master.FindControl("LogOut_link").Visible = false;
            Session["Username"] = null;
            Response.Redirect("Home.aspx");
        }
    }
}