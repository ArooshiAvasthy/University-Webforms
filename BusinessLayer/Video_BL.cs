using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using System.Data;

namespace BusinessLayer
{
    public class Video_BL
    {
        Video_DAL obj_video = new Video_DAL();
        public DataTable BindGrid()
        {
            try
            {
                DataTable dt = new DataTable();
                dt = obj_video.BindGrid();
                return dt;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
