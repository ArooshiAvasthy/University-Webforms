using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DataAccess;
namespace BusinessLayer
{
    public class LoginBL
    {
        ILoginDAL obj_LoginDAL = new LoginDAL();
        public DataSet Login_Site(string username, string pwd) 
        {
            try
            {
                DataSet ds = new DataSet();
                ds = obj_LoginDAL.Login_Site(username, pwd);
                return ds;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public DataSet Login_Course(string username)
        {
            try
            {
                DataSet ds2 = new DataSet();
                ds2 = obj_LoginDAL.Login_Course(username);
                return ds2;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
