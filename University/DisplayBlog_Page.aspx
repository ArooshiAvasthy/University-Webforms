<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage2.Master" AutoEventWireup="true" CodeBehind="DisplayBlog_Page.aspx.cs" Inherits="University.DisplayBlog_Page" %>
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
       <asp:Label ID="lblTitle" runat="server" /></h2>
     <hr />
<asp:Label ID="lblBody" runat="server" />
    </div>
    </form>
</body>
</html>

</asp:Content>
