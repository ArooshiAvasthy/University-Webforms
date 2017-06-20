using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public interface IDisplayBlog_Page_DAL
    {
        DataTable PopulateBlog(string blogId);
    }
}
