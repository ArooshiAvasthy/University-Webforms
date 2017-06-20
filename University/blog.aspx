<%@ Page enableEventValidation="False" Title="" Language="C#" MasterPageFile="~/MasterPage2.Master" AutoEventWireup="true" CodeBehind="blog.aspx.cs" Inherits="University.blog" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title></title>
</head>
  
 
<body>
   
    <form id="form1" >
    <div>
    
        <table border="0">
    <tr>
        <td>
            Title:
        </td>
    </tr>
    <tr>
        <td>
            <asp:TextBox ID="txtTitle" runat="server" Width = "550" />
        </td>
    </tr>
    <tr>
        <td>
            &nbsp;
        </td>
    </tr>
    <tr>
        <td>
            Body:
        </td>
    </tr>
    <tr>
        <td>
            <asp:TextBox ID="txtBody" runat="server" TextMode="MultiLine" ValidateRequestMode="Disabled" />
          
        </td>
    </tr>
    <tr>
        <td>
            &nbsp;
        </td>
    </tr>
    <tr>
        <td>
            <asp:Button ID="btnSubmit" Text="Submit" runat="server" OnClick="Submit" />
        </td>
    </tr>
</table>
<script type="text/javascript" src="//tinymce.cachefly.net/4.0/tinymce.min.js"></script>
<script type="text/javascript">
    tinymce.init({ selector: 'textarea' });
</script>
    </div>
    </form>
</body>
</html>
</asp:Content>
