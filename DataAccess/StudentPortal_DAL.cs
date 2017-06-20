using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataAccess
{
    public class StudentPortal_DAL:IStudentPortal_DAL
    {
         SqlConnection con = new SqlConnection("Data Source=DLUAAVAST86878;Integrated Security=true;Initial Catalog=University");
       
        public DataSet DAL_ShowCompleteGrid()
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Select * from Enrollment", con);
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


        public int DAL_DeleteGrid(int userid)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("delete from Enrollment where UserId=" + userid, con);
                int result = cmd.ExecuteNonQuery();
                con.Close();
                return result;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }


        public int DAL_UpdateGrid(int userid, string username, string course, string Stream, string College)
        {
            try 
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Update Enrollment set Username='" + username + "',course='" + course + "',Stream='" + Stream + "',College='" + College + "'where UserId=" + userid, con);
                int result = cmd.ExecuteNonQuery();
                con.Close();

                return result;
            }
          catch(Exception ex)
            {
                throw ex;
            }
        }


        public int DAL_CreateGrid(string username, string course, string Stream, string College)
        {
            try
            {
                con.Open();
                SqlCommand cmd =
                new SqlCommand(
                "insert into Enrollment(UserName,Course,Stream,College) values('" + username + "','" +
                course + "','" + Stream + "','" + College + "')", con);
                int result = cmd.ExecuteNonQuery();
                con.Close();

                return result;
            }
           catch(Exception ex)
            {
                throw ex;
            }
        }


        public DataSet getDDL()
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Select Value from Constants where dropdown='Stream'", con);
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

        public DataSet getCourseDDL()
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Select Value from Constants where dropdown='Course'", con);
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
    
    }
}
