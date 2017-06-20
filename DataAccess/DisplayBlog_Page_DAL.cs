using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataAccess
{
    public class DisplayBlog_Page_DAL:IDisplayBlog_Page_DAL
    {

        SqlConnection con = new SqlConnection("Data Source=DLUAAVAST86878;Integrated Security=true;Initial Catalog=University");

        public DataTable PopulateBlog(string blogId)
        {
           try
           {
               string query = "SELECT [Title], [Body] FROM [Blogs] WHERE [BlogId] = @BlogId";

               using (SqlCommand cmd = new SqlCommand(query))
               {
                   using (SqlDataAdapter sda = new SqlDataAdapter())
                   {
                       cmd.Parameters.AddWithValue("@BlogId", blogId);
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
