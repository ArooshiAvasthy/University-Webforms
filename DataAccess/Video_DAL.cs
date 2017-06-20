using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace DataAccess
{

    public class Video_DAL
    {
        SqlConnection con = new SqlConnection("Data Source=DLUAAVAST86878;Integrated Security=true;Initial Catalog=University");

        public DataTable BindGrid()
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    con.Open();
                    cmd.CommandText = "select Id, Name, Path from tblFiles";
                    cmd.Connection = con;
                    DataTable dt = new DataTable();
                    SqlDataAdapter sda = new SqlDataAdapter();
                    sda.SelectCommand = cmd;
                    sda.Fill(dt);
                    con.Close();
                    return dt;

                }
            }
           catch(Exception ex)
            {
                throw ex;
            }

        }
    }
}
