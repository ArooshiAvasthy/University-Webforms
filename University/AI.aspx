﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AI.aspx.cs"  MasterPageFile="~/MasterPage2.Master" Inherits="University.AI" %>

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
    <table>
    <tr>
    <td> 
        <%--Select File--%>
        </td>
        <td>
        <asp:FileUpload ID="FileUpload1" runat="server" ToolTip="Select File" />
        </td>
        <td> 
        <asp:Button ID="Button1" runat="server" Text="Upload" onclick="Button1_Click" />
        </td>
        <td>
 
<%--            <asp:Button ID="Button2" runat="server" Text="View Files" 
                onclick="Button2_Click" />--%>
               </td>
        </tr>
 
</table>
<table><tr><td><p><asp:Label ID="Label2" runat="server" Text=""></asp:Label>  </p></td></tr></table>
 
<asp:GridView ID="GridView1" runat="server" Caption="Excel Files " 
        CaptionAlign="Top" HorizontalAlign="Justify" 
         DataKeyNames="id" onselectedindexchanged="GridView1_SelectedIndexChanged" 
        ToolTip="Excel FIle DownLoad Tool" CellPadding="4" ForeColor="#333333" 
        GridLines="None">
        <RowStyle BackColor="#E3EAEB" />
        <Columns>
            <asp:CommandField ShowSelectButton="True" SelectText="Download" ControlStyle-ForeColor="Blue"/>
        </Columns>
        <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
        <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
        <HeaderStyle BackColor="Gray" Font-Bold="True" ForeColor="White" />
        <EditRowStyle BackColor="#7C6F57" />
        <AlternatingRowStyle BackColor="White" />
    </asp:GridView> 
   
    
    </div>
    </form>
</body>
</html>
    </asp:Content>