using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;

namespace BusinessEntities
{
    public class Enrollment
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Course { get; set; }
        public string Faculty { get; set; }

    }
}
