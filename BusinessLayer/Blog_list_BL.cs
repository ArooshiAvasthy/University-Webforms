using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using System.Data;

namespace BusinessLayer
{
    public class Blog_list_BL
    {

       IBlog_List_DAL obj_Blog_List_DAL = new Blog_List_DAL();
       
        public DataTable PopulateBlogs()
        
        {
          try
            {
                DataTable dt = new DataTable();
                dt= obj_Blog_List_DAL.PopulateBlogs();
                return dt;
                
            }
            
          catch(Exception ex)
            {
                throw ex;
            }
                
         }
    }
       
}
