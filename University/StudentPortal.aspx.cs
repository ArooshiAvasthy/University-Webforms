using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
using System.Data;


namespace University
{
    public partial class StudentPortal : System.Web.UI.Page
    {
        StudentPortalBL Obj_SP_BL = new StudentPortalBL();

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {

                if (!IsPostBack)
                {
                    if (Session["Username"] == null || Session["Username"] == "")
                    {
                        Response.Redirect("Login.aspx");
                    }

                    DataSet dt = new DataSet();
                    dt = Obj_SP_BL.BL_getDDL();
                    StreamDDL.DataSource = dt;

                    StreamDDL.DataTextField = "Value";
                    StreamDDL.DataValueField = "Value";
                    StreamDDL.DataBind();
                    Name_txt.Text = Session["Username"].ToString();

                    DataSet dt2 = new DataSet();
                    dt2 = Obj_SP_BL.BL_getCourseDDL();
                    CourseDDL.DataSource = dt2;

                    CourseDDL.DataTextField = "Value";
                    CourseDDL.DataValueField = "Value";
                    CourseDDL.DataBind();
                    ShowCompleteGrid();

                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        protected void ShowCompleteGrid()
        {
            try
            {
                DataSet ds = new DataSet();
                ds = Obj_SP_BL.BL_ShowCompleteGrid();
                GRID_2.DataSource = ds;
                GRID_2.DataBind();
            }
           
            catch(Exception ex)
            {
                throw ex;
            }
        }

        protected void grid2_row_edit(object sender, GridViewEditEventArgs e)
        {
            try
            {
                GRID_2.EditIndex = e.NewEditIndex;
                ShowCompleteGrid();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

       

        protected void grid2_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            try
            {
                if (e.Row.RowState == DataControlRowState.Edit)
                {




                    DropDownList ddList = (DropDownList)e.Row.FindControl("DropDownList1");
                    //bind dropdown-list
                    DataSet dt = new DataSet();
                    dt = Obj_SP_BL.BL_getDDL();
                    ddList.DataSource = dt;
                    ddList.DataTextField = "Value";
                    ddList.DataValueField = "Value";
                    ddList.DataBind();


                }
            }
            catch(Exception ex)
            {
                throw ex;
            }

        }

        protected void grid2_row_delete(object sender, GridViewDeleteEventArgs e)
        {
            try
            {

                var s1 = ((Label)GRID_2.Rows[e.RowIndex].FindControl("UserName")).Text;
                var s2 = Session["Username"].ToString();


                if (s1 == s2)
                {

                    int userid = Convert.ToInt32(GRID_2.DataKeys[e.RowIndex].Values["UserId"].ToString());

                    int result = Obj_SP_BL.BL_DeleteGrid(userid);
                    if (result == 1)
                    {
                        ShowCompleteGrid();
                        MsgLabel.Text = "deleted Successfully";
                    }
                }

                else
                    Response.Write("<Script>alert('you can only delete your own records');</Script>");

                ShowCompleteGrid();
            }
            catch(Exception ex)
            {
                throw ex;
            }
            
        }

        protected void grid2_row_update(object sender, GridViewUpdateEventArgs e)
        {
            try
            {
                var s1 = ((Label)GRID_2.Rows[e.RowIndex].FindControl("UserName")).Text;
                var s2 = Session["Username"].ToString();

                //if (((TextBox)GRID_2.Rows[e.RowIndex].FindControl("UserName")).Text==Session["Username"])
                if (s1 == s2)
                {
                    int userid = Convert.ToInt32(GRID_2.DataKeys[e.RowIndex].Values["UserId"].ToString());
                    //TextBox username = (TextBox)(GRID_2.Rows[e.RowIndex].FindControl("UserName"));
                    //TextBox course = (TextBox)(GRID_2.Rows[e.RowIndex].FindControl("Course"));

                    //DataSet dt = new DataSet();
                    //dt = Obj_SP_BL.BL_getDDL();
                    //StreamDDL.DataSource = dt;

                    //StreamDDL.DataTextField = "Value";
                    //StreamDDL.DataValueField = "Value";
                    //StreamDDL.DataBind();


                    string Stream = ((DropDownList)(GRID_2.Rows[e.RowIndex].FindControl("DropDownList1"))).SelectedValue;
                    string Courses = ((DropDownList)(GRID_2.Rows[e.RowIndex].FindControl("Course_DropDownList"))).SelectedValue;
                    TextBox College = (TextBox)(GRID_2.Rows[e.RowIndex].FindControl("College"));

                    //int result = Obj_SP_BL.BL_UpdateGrid(userid, username.Text, course.Text, Stream.Text, College.Text);
                    //int result = Obj_SP_BL.BL_UpdateGrid(userid, s2, course.Text, Stream.Text, College.Text);
                    int result = Obj_SP_BL.BL_UpdateGrid(userid, s2, Courses, Stream, College.Text);
                    if (result == 1)
                    {
                        ShowCompleteGrid();
                        MsgLabel.Text = "Updated Successfully";
                    }
                }

                else
                    Response.Write("<Script>alert('you can only update your own records');</Script>");
                GRID_2.EditIndex = -1;
                ShowCompleteGrid();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        protected void grid2_row_Cancel(object sender, GridViewCancelEditEventArgs e)
        {
            try
            {
                GRID_2.EditIndex = -1;
                ShowCompleteGrid();
            }
          catch(Exception ex)
            {
                throw ex;
            }
        }

        protected void grid2_row_command(object sender, GridViewCommandEventArgs e)
        {
            try
            {
                if (e.CommandName.Equals("Add"))
                {
                    TextBox username = (TextBox)GRID_2.FooterRow.FindControl("txtftrusrname");
                    TextBox course = (TextBox)GRID_2.FooterRow.FindControl("txtftrcourse");
                    TextBox Stream = (TextBox)GRID_2.FooterRow.FindControl("txtftrStream");
                    TextBox College = (TextBox)GRID_2.FooterRow.FindControl("txtftrCollege");

                    int result = Obj_SP_BL.BL_CreateGrid(username.Text, course.Text, Stream.Text, College.Text);
                    if (result == 1)
                    {
                        MsgLabel.Text = "Inserted Successfully";
                    }

                    ShowCompleteGrid();
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }


       protected void submit_Click(object sender, EventArgs e)
        {
            try
            {


                string username = Name_txt.Text;
                string course = CourseDDL.SelectedValue;
                string Stream = StreamDDL.SelectedValue;
                string College = College_txt.Text;

                if (course == "" || Stream == "" || College == "")
                {
                    Response.Write("<Script>alert('Fill Mandatory fields')</script>");
                }
                else
                {
                    int result = Obj_SP_BL.BL_CreateGrid(username, course, Stream, College);
                    if (result == 1)
                    {
                        MsgLabel.Text = "Inserted Successfully";
                    }
                }
                ShowCompleteGrid();
            }
           catch(Exception ex)
            {
                throw ex;
            }
        }

    }
}