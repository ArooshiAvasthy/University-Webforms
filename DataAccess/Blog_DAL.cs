using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace DataAccess
{
    public class Blog_DAL:IBlog_DAL
    {
        SqlConnection con = new SqlConnection("Data Source=DLUAAVAST86878;Integrated Security=true;Initial Catalog=University");
        public void Submit(string title, string body)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Insert into Blogs values('" + title + "','" + body + "')", con);
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
