using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.IO;
using System.Data.SqlClient;


namespace University
{
    public partial class DBMS : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Data Source=DLUAAVAST86878;Integrated Security=true;Initial Catalog=University");
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {

                if (!IsPostBack)
                {

                    if
                        (Session["Username"] == null)
                    {
                        Response.Redirect("Login.aspx");
                    }
                    else
                    {
                        string name = (Session["Username"]).ToString();

                        string course = Path.GetFileNameWithoutExtension(Request.Path);
                        con.Open();
                        SqlCommand cmd = new SqlCommand("Select * from Enrollment where UserName='" + name + "' and Course='" + course + "'", con);
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataSet ds = new DataSet();
                        da.Fill(ds);
                        con.Close();


                        if (ds.Tables[0].Rows.Count == 0)
                        {
                            Label2.Text = "You have not enrolled for this course";
                            FileUpload1.Visible = false;
                            Button1.Visible = false;
                        }
                        else
                        {
                            Button2_Click();
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }


        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {

                Label2.Visible = true;
                string filePath = FileUpload1.PostedFile.FileName;          // getting the file path of uploaded file
                string filename1 = Path.GetFileName(filePath);               // getting the file name of uploaded file
                string ext = Path.GetExtension(filename1);                      // getting the file extension of uploaded file
                string type = String.Empty;

                if (!FileUpload1.HasFile)
                {
                    Label2.Text = "Please Select File";                          //if file uploader has no file selected
                }
                else
                    if (FileUpload1.HasFile)
                    {
                        try
                        {

                            switch (ext)                                         // this switch code validate the files which allow to upload only PDF  file 
                            {
                                case ".pdf":
                                    type = "application/pdf";
                                    break;
                                case ".ppt":
                                    type = "application/ppt";
                                    break;
                                case ".docx":
                                    type = "application/docx";
                                    break;
                                case ".txt":
                                    type = "application/text";
                                    break;
                                case ".xlsx":
                                    type = "application/excel";
                                    break;

                            }

                            if (type != String.Empty)
                            {
                                //connection();
                                con.Open();
                                Stream fs = FileUpload1.PostedFile.InputStream;
                                BinaryReader br = new BinaryReader(fs);                                 //reads the   binary files
                                Byte[] bytes = br.ReadBytes((Int32)fs.Length);
                                string courses = Path.GetFileNameWithoutExtension(Request.Path);

                                SqlCommand cmd = new SqlCommand("Select * from PDFFiles where name='" + filename1 + "'", con);
                                cmd.ExecuteNonQuery();
                                SqlDataAdapter da = new SqlDataAdapter(cmd);
                                DataSet ds = new DataSet();
                                da.Fill(ds);
                                if (ds.Tables[0].Rows.Count != 0)
                                    Label2.Text = "File Already Exists";
                                else
                                {
                                    string query = "insert into PDFFiles (Name,type,data,courses)" + " values (@Name, @type, @Data,@courses)";   //insert query
                                    SqlCommand com = new SqlCommand(query, con);
                                    com.Parameters.Add("@Name", SqlDbType.VarChar).Value = filename1;
                                    com.Parameters.Add("@type", SqlDbType.VarChar).Value = type;
                                    com.Parameters.Add("@Data", SqlDbType.Binary).Value = bytes;
                                    com.Parameters.Add("@courses", SqlDbType.VarChar).Value = courses;
                                    com.ExecuteNonQuery();


                                    Label2.ForeColor = System.Drawing.Color.Green;
                                    Label2.Text = "File Uploaded Successfully";
                                }
                                con.Close();
                                Button2_Click();
                            }
                            else
                            {
                                Label2.ForeColor = System.Drawing.Color.Red;
                                Label2.Text = "Cannot upload this format";                              // if file is other than speified extension 
                            }
                        }
                        catch (Exception ex)
                        {
                            Label2.Text = "Error: " + ex.Message.ToString();
                        }
                    }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }


        protected void Button2_Click()
        {
            try
            {
                con.Open();
                SqlCommand query = new SqlCommand("Select * from PDFFiles where courses='" + Path.GetFileNameWithoutExtension(Request.Path) + "'", con);
                SqlDataAdapter da = new SqlDataAdapter(query);
                DataSet ds = new DataSet();
                da.Fill(ds);
                GridView1.DataSource = ds;
                GridView1.DataBind();
                con.Close();
            }
            catch(Exception ex)
            {
                throw ex;
            }

        }


        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //connection();
            try
            {

                con.Open();
                SqlCommand com = new SqlCommand("select Name,type,data,courses from  PDFFiles where id=@id", con);
                com.Parameters.AddWithValue("id", GridView1.SelectedRow.Cells[1].Text);
                SqlDataReader dr = com.ExecuteReader();


                if (dr.Read())
                {
                    Response.Clear();
                    Response.Buffer = true;
                    Response.ContentType = dr["type"].ToString();
                    Response.AddHeader("content-disposition", "attachment;filename=" + dr["Name"].ToString());     // to open file prompt Box open or Save file         
                    Response.Charset = "";
                    Response.Cache.SetCacheability(HttpCacheability.NoCache);
                    Response.BinaryWrite((byte[])dr["data"]);
                    Response.End();
                }

                con.Close();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    
    }
}