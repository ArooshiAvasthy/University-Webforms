using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
using System.Data;


namespace University
{
    public partial class DisplayBlog_Page : System.Web.UI.Page
    {
        DisplayBlog_Page_BL obj_displayblog = new DisplayBlog_Page_BL();

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!this.IsPostBack)
                {
                    string blogId = this.Page.RouteData.Values["BlogId"].ToString();
                    DataTable dt = new DataTable();
                    dt = obj_displayblog.PopulateBlog(blogId);
                    lblTitle.Text = dt.Rows[0]["Title"].ToString();
                    lblBody.Text = dt.Rows[0]["Body"].ToString();
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
           
        }

        
    }
}