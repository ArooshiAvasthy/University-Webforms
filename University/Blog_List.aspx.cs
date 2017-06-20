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
    public partial class Blog_List : System.Web.UI.Page
    {
        Blog_list_BL obg_Blog_List = new Blog_list_BL();

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!this.IsPostBack)
                {
                    DataTable dt = new DataTable();
                    dt = obg_Blog_List.PopulateBlogs();
                    rptPages.DataSource = dt;
                    rptPages.DataBind();

                }
            }
           
            catch(Exception ex)
            {
                throw ex;
            }
        }

    }
}