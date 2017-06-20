using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public interface IBlog_DAL
    {
        void Submit(string title, string body);
    }
}
