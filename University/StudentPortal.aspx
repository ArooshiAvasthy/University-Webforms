<%@ Page EnableEventValidation="false" Title="" Language="C#" MasterPageFile="~/MasterPage2.Master" AutoEventWireup="true" CodeBehind="StudentPortal.aspx.cs" Inherits="University.StudentPortal" %>
<%@ MasterType VirtualPath="~/MasterPage2.master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="MasterTemplate/css/style.css" rel="stylesheet" />
</asp:Content>
  
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
 
   <!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head >
    <title></title>
 <style type="text/css">
.Gridview
{
font-family:Verdana;
font-size:10pt;
font-weight:normal;
color:#B70000;

}
.clr {
	clear:both;
	padding:0;
	margin:0;
	width:100%;
	font-size:0;
	line-height:0;
}
</style>
</head>
<body>
    <form id="form1" >
    <div>
        <div id="login">
            <div id="Enroll-nav">
           <asp:Label ID="Enroll" runat="server" Text="Enroll in the Course"></asp:Label>
        </div>
        
        <div class="form">
            <asp:Label ID="Name" runat="server" Text="Name" Font-Underline="true"></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="Name_txt" runat="server" ReadOnly="true"></asp:TextBox><br /><br />
            <asp:Label ID="course_lbl" runat="server" Text="Course" Font-Underline="true"></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;
             <asp:DropDownList ID="CourseDDL" runat="server"></asp:DropDownList><br /><br /><br />
            <asp:Label ID="Stream_lbl" runat="server" Text="Stream"></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="StreamDDL" runat="server"></asp:DropDownList><br />
            <asp:Label ID="College_lbl" runat="server" Text="College" Font-Underline="true"></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="College_txt" runat="server"></asp:TextBox><br /><br />
            <asp:Button ID="submit" runat="server" Text="Submit" OnClick="submit_Click" />
            <br /><br /><br /><br />
        </div>
        <div class="clr">
        </div>
        </div>
        
            <asp:GridView ID="GRID_2" DataKeyNames="UserId" runat="server"
                 AutoGenerateColumns="false" CssClass="Gridview" HeaderStyle-BackColor="#B70000"
                 ShowFooter="true" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="White" Column-Width="2 px"
                 OnRowDeleting ="grid2_row_delete" onrowediting="grid2_row_edit"  onrowcommand="grid2_row_command" onrowcancelingedit="grid2_row_Cancel"
                 OnRowUpdating="grid2_row_update" onRowDataBound="grid2_RowDataBound">

         <Columns>
            <asp:TemplateField>
                 <EditItemTemplate>
                     
                     <asp:ImageButton ID="Update" ToolTip="Update" AlternateText="Update" CommandName="Update" Height="20px" Width="10px" runat="server" imageUrl="~/Img/update.jpg"/>
                     <asp:ImageButton ID="Cancel" ToolTip="Cancel" AlternateText="Cancel" CommandName="Cancel" Height="20px" Width="10px" runat="server" imageUrl="~/Img/Cancel.jpg" />
               
                 </EditItemTemplate>
                 <ItemTemplate>
                     <asp:ImageButton ID="Edit" AlternateText="Edit" ToolTip="Edit" CommandName="Edit"  Height="20px" Width="20px" runat="server" imageUrl="~/Img/Edit.png"/>  
                     <asp:ImageButton ID="Delete" AlternateText="Delete" ToolTip="Delete" CommandName="Delete"  Height="20px" Width="20px" runat="server" imageUrl="~/Img/delete.jpg"/>  
                 </ItemTemplate>
                 <FooterTemplate>
                      <asp:ImageButton ID="Add" ToolTip="Add" AlternateText="Add" CommandName="Add" Height="20px" Width="20px" runat="server" imageUrl="~/Img/ADD.png"/>
                 </FooterTemplate>
             </asp:TemplateField>
             <asp:TemplateField HeaderText="Name">
                  <%--<EditItemTemplate>
                     <asp:TextBox ID="username" runat="server" Text='<%#Eval("Username") %>' />
                 </EditItemTemplate>--%>
                 <ItemTemplate>
                     <asp:label id="username" runat="server" Text='<%#Eval("Username") %>'/>
                 </ItemTemplate>
                 <FooterTemplate>
                   <asp:TextBox ID="txtftrusrname" runat="server"/>
                   <asp:RequiredFieldValidator ID="rfvusername" runat="server" ControlToValidate="txtftrusrname" Text="*" ValidationGroup="validaiton"/>
                 </FooterTemplate>
             </asp:TemplateField>
             <asp:TemplateField HeaderText="Course">
                 <EditItemTemplate>
                     <asp:DropDownList ID="Course_DropDownList" runat="server"  ></asp:DropDownList>
                 </EditItemTemplate>
                 <ItemTemplate>
                     <asp:label id="course" runat="server" Text='<%#Eval("Course") %>'/>
                 </ItemTemplate>
                 <FooterTemplate>
                   <asp:TextBox ID="txtftrcourse" runat="server"/>
                   <asp:RequiredFieldValidator ID="rfvcourse" runat="server" ControlToValidate="txtftrcourse" Text="*" ValidationGroup="validaiton"/>
                 </FooterTemplate>
             </asp:TemplateField>
              <asp:TemplateField HeaderText="Stream">
                 <EditItemTemplate>
                  <%--<asp:TextBox ID="Stream" runat="server" Text='<%#Eval("Stream") %>' ></asp:TextBox>--%>
                     <asp:DropDownList ID="DropDownList1" runat="server" ></asp:DropDownList>
                 </EditItemTemplate>
                 <ItemTemplate>
                     <asp:label id="Stream" runat="server" Text='<%#Eval("Stream") %>'/>
                     
                 </ItemTemplate>
                  <FooterTemplate>
                       <asp:TextBox ID="txtftrStream" runat="server"/>
                       <asp:RequiredFieldValidator ID="rfvstream" runat="server" ControlToValidate="txtftrStream" Text="*" ValidationGroup="validaiton"/>
                  </FooterTemplate>
             </asp:TemplateField>
              <asp:TemplateField HeaderText="College">
                 <EditItemTemplate>
                     <asp:TextBox ID="College" runat="server" Text='<%#Eval("College") %>' />
                 </EditItemTemplate>
                 <ItemTemplate>
                     <asp:label id="College" runat="server" Text='<%#Eval("College") %>'/>
                 </ItemTemplate>
                  <FooterTemplate>
                       <asp:TextBox ID="txtftrCollege" runat="server"/>
                       <asp:RequiredFieldValidator ID="txtftrColleges" runat="server" ControlToValidate="txtftrCollege" Text="*" ValidationGroup="validaiton"/>
                  </FooterTemplate>
             </asp:TemplateField>

         </Columns>
           

        </asp:GridView>
        <br />
         <asp:Label id="MsgLabel" runat="server" Text=""></asp:Label>
    </div>
    </form>
</body>
</html>
</asp:Content>
