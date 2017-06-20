using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataAccess
{
    public class LoginDAL:ILoginDAL
    {
        SqlConnection con = new SqlConnection("Data Source=DLUAAVAST86878;Integrated Security=true;Initial Catalog=University");

        public DataSet Login_Site(string username,string pwd)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Select * from login where username='" + username + "' and password='" + pwd + "'", con);
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                con.Close();
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
                SqlCommand cmd2 = new SqlCommand("Select * from enrollment where username='" + username + "'", con);
                SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
                DataSet ds2 = new DataSet();
                da2.Fill(ds2);

                con.Close();
                return ds2;
            }
           catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
