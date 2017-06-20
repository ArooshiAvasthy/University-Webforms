using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace University
{
    public partial class MasterPage2 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            
            if (Session["Username"] == null||Session["Username"]=="")
            {
                //Response.Redirect("Login.aspx");

            }

            else
            {
                var name = Session["Username"];
                Username2.Text = "Hi"+" "+ Session["Username"].ToString();
                LogIn_link.Visible = false;
                LogOut_link.Visible = true;
            }
        }
    }
}