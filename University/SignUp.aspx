<%@ Page EnableEventValidation="False" Title="" Language="C#" MasterPageFile="~/MasterPage2.Master" AutoEventWireup="true" CodeBehind="SignUp.aspx.cs" Inherits="University.SignUp" %>
<%@ MasterType VirtualPath="~/MasterPage2.master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title></title>
</head>
<body>
    <h2>New User Registeration Form</h2>
    <form id="form1">
    <div>
        <asp:Label ID="Loginlbl" runat="server" Text="Log In"></asp:Label><br /><br />
        <asp:Label ID="Namelbl" runat="server" Text="UserName:"></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="Nametxt" runat="server"></asp:TextBox><br /><br />
        <asp:Label ID="Passwordlbl" runat="server" Text="Password:"></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="Passwordtxt" runat="server" TextMode="Password"></asp:TextBox><br /><br />
        <asp:Button ID="Submit" runat="server" Text="Submit" OnClick="Submit_click" />&nbsp;&nbsp;&nbsp;&nbsp;
        
    </div>
    </form>
</body>
</html>
        
</asp:Content>
