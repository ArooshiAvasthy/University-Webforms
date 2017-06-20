using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using BusinessLayer;


namespace University
{
    public partial class tour : System.Web.UI.Page
    {
        Video_BL obj_video = new Video_BL();
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!IsPostBack)
                {

                    DataList1.DataSource = obj_video.BindGrid();
                    DataList1.DataBind();
                }
            }
           catch(Exception ex)
            {
                throw ex;
            }
        }

       

          
    }
}