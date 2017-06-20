using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;

namespace BusinessLayer
{
     
    public class BlogBL
    {
        IBlog_DAL obj_Blog = new Blog_DAL();
        public void Submit(string title,string body)
        {
            try
            {
                obj_Blog.Submit(title, body);
            }
           catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
