using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataAccess
{
    public class Blog_List_DAL:IBlog_List_DAL
    {
        SqlConnection con = new SqlConnection("Data Source=DLUAAVAST86878;Integrated Security=true;Initial Catalog=University");

        public DataTable PopulateBlogs()
        {
            try 
            {
                string query = "SELECT [BlogId], [Title], REPLACE([Title], ' ', '-') [SLUG], [Body] FROM [Blogs]";

                using (SqlCommand cmd = new SqlCommand(query))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter())
                    {
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);
                            return dt;

                        }
                    }
                }
            }
            
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
