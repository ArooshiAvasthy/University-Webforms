using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;


namespace University
{
    public partial class SignUp : System.Web.UI.Page
    {
        SignUp_BL obj_SignUp_DAL = new SignUp_BL();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Submit_click(object sender, EventArgs e)
        {
            try
            {
                obj_SignUp_DAL.SignUp(Nametxt.Text, Passwordtxt.Text);
                Session["Username"] = Nametxt.Text;
                Response.Redirect("StudentPortal.aspx");
            }
            catch(Exception ex)
            {
                throw ex;
            }

        }
    }
}