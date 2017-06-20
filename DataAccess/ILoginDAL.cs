using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public interface ILoginDAL
    {
        DataSet Login_Site(string username, string pwd);
        DataSet Login_Course(string username);
    }
}
