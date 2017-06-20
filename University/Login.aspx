<%@ Page enableSessionState="True" enableEventValidation="False" Title="" Language="C#" MasterPageFile="~/MasterPage2.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="University.Login" %>
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
    <form id="form1">
    <div>
        <asp:Label ID="Loginlbl" runat="server" Text="Log In"></asp:Label><br /><br />
        <asp:Label ID="Namelbl" runat="server" Text="UserName:"></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="Nametxt" runat="server"></asp:TextBox><br /><br />
       <%-- <% Session["Username"] = Nametxt.Text;%>--%>
        <asp:Label ID="Passwordlbl" runat="server" Text="Password:"></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="Passwordtxt" runat="server" TextMode="Password"></asp:TextBox><br /><br />
        <asp:Button ID="Log" runat="server" Text="Sign In" OnClick="Log_Click" />&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="SignUp" runat="server" Text="Sign up" OnClick="SignUp_Click" />
        <asp:Label ID="Resultlbl" runat="server"></asp:Label>
        
    </div>
    </form>
</body>
</html>
</asp:Content>
