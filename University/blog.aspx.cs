using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;

namespace University
{
    public partial class blog : System.Web.UI.Page
    {

        BlogBL obj_BlogBl = new BlogBL();

        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                
            }
        }

        protected void Submit(object sender, EventArgs e)
        {
            try
            {
                obj_BlogBl.Submit(txtTitle.Text, txtBody.Text);
                Response.Redirect("~/Blog_List.aspx");
            }
           catch(Exception ex)
            {
                throw ex;
            }
        }
                  
         
    }
}