using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using BusinessLayer;
using System.Data;

namespace University
{
    public partial class Login : System.Web.UI.Page
    {
        LoginBL obj_LoginBL = new LoginBL();
        
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void Log_Click(object sender, EventArgs e)
        {
            try
            {
                string username = Nametxt.Text;
                string pwd = Passwordtxt.Text;

                DataSet ds = new DataSet();

                ds = obj_LoginBL.Login_Site(username, pwd);

                if (ds.Tables[0].Rows.Count == 0)
                {
                    Resultlbl.Text = "Please Sign up............";
                    Loginlbl.Visible = false;
                    Namelbl.Visible = false;
                    Nametxt.Visible = false;
                    Passwordlbl.Visible = false;
                    Passwordtxt.Visible = false;
                    Log.Visible = false;
                    Session["Username"] = "";
                    var name = Session["Username"];
                    //Session["Username"] = null;
                }


                //SqlCommand cmd2 = new SqlCommand("Select * from enrollment where username='" + username + "'",con);
                //SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
                DataSet ds2 = new DataSet();
                //da2.Fill(ds2);
                ds2 = ds2 = obj_LoginBL.Login_Course(username);
                //con.Close();
                if (ds.Tables[0].Rows.Count > 0 && ds2.Tables[0].Rows.Count == 0)
                {
                    Resultlbl.Text = "Please Enroll in a course in Student Portal";
                    Loginlbl.Visible = false;
                    Namelbl.Visible = false;
                    Nametxt.Visible = false;
                    Passwordlbl.Visible = false;
                    Passwordtxt.Visible = false;
                    Log.Visible = false;
                    SignUp.Visible = false;
                    Session["Username"] = Nametxt.Text;

                }

                if (ds.Tables[0].Rows.Count > 0 && ds2.Tables[0].Rows.Count > 0)
                {

                    Session["Username"] = Nametxt.Text;
                    Resultlbl.Text = (Session["Username"]).ToString();

                    Response.Redirect("course.aspx");
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
           
        }

        protected void SignUp_Click(object sender, EventArgs e)
        {
            Response.Redirect("SignUp.aspx");
        }
    }
}