using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public interface IStudentPortal_DAL
    {
        DataSet DAL_ShowCompleteGrid();
        int DAL_DeleteGrid(int userid);

        int DAL_CreateGrid(string username, string course, string Stream, string College);
        int DAL_UpdateGrid(int userid, string username, string course, string Stream, string College);
        DataSet getCourseDDL();
        DataSet getDDL();
    }
}
