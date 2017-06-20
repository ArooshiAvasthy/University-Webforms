<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage2.Master" AutoEventWireup="true" CodeBehind="Blog_List.aspx.cs" Inherits="University.Blog_List" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title></title>
</head>
<body>
    <form id="form1">
    <div>

    <h2>
    Blogs</h2>
<br />
<asp:HyperLink ID="HyperLink1" NavigateUrl="~/Blog.aspx" Text="Add Blog" runat="server" />
<hr />
<asp:Repeater ID="rptPages" runat="server">
    <ItemTemplate>
        <%# Container.ItemIndex + 1 %>
        <asp:HyperLink ID="HyperLink2" NavigateUrl='<%# string.Format("~/Blogs/{0}/{1}.aspx", Eval("BlogId"), Eval("Slug")) %>'
            Text='<%# Eval("Title") %>' runat="server" />
        
    </ItemTemplate>
    <SeparatorTemplate>
        <br />
    </SeparatorTemplate>
</asp:Repeater>

    </div>
    </form>
</body>
</html>

</asp:Content>
