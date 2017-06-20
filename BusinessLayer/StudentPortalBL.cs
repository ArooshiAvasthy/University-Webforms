using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DataAccess;

namespace BusinessLayer
{
    public class StudentPortalBL
    {
        IStudentPortal_DAL Obj_SP_DAL = new StudentPortal_DAL();
        public DataSet BL_ShowCompleteGrid()
        {
            try
            {
                DataSet ds = Obj_SP_DAL.DAL_ShowCompleteGrid();
                return ds;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }


        public int BL_DeleteGrid(int userid)
        {
            try
            {
                int result = Obj_SP_DAL.DAL_DeleteGrid(userid);
                return result;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }


        public int BL_UpdateGrid(int userid, string username, string course, string Stream, string College)
        {
            try
            {
                int result = Obj_SP_DAL.DAL_UpdateGrid(userid, username, course, Stream, College);

                return result;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }


        public int BL_CreateGrid(string username, string course, string Stream, string College)
        {
            try
            {
                int result = Obj_SP_DAL.DAL_CreateGrid(username, course, Stream, College);

                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public DataSet BL_getDDL()
        {
            try
            {
                DataSet ds = Obj_SP_DAL.getDDL();
                return ds;
            }
           
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataSet BL_getCourseDDL()
        {
            try 
            {
                DataSet ds = Obj_SP_DAL.getCourseDDL();
                return ds;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
