using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DataAccess;

namespace BusinessLayer
{
    public class SignUp_BL
    {
        ISignUp_DAL obj_SignUp_DAL = new SignUp_DAL();

         public void SignUp(string name, string password)
        {
            try
            {
                obj_SignUp_DAL.SignUp(name, password);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
