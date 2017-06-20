using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataAccess
{
    public class SignUp_DAL:ISignUp_DAL
    {
        SqlConnection con = new SqlConnection("Data Source=DLUAAVAST86878;Integrated Security=true;Initial Catalog=University");

        public void SignUp(string name, string password)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Insert into login values('" + name + "','" + password + "')", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
