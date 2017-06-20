using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DataAccess;

namespace BusinessLayer
{
    public class DisplayBlog_Page_BL
    {
        IDisplayBlog_Page_DAL obj_displayblogDAL = new DisplayBlog_Page_DAL();
        
        public DataTable PopulateBlog(string blogId)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = obj_displayblogDAL.PopulateBlog(blogId);
                return dt;
            }
           catch(Exception ex)
            {
                throw ex;
            }
         }
    }
}
