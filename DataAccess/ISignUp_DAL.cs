using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public interface ISignUp_DAL
    {
        void SignUp(string name, string password);
    }
}
