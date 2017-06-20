<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage2.Master" AutoEventWireup="true" CodeBehind="course.aspx.cs" Inherits="University.course" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title></title>
    <link href="StyleSheet/StyleSheet1.css" rel="stylesheet" />
</head>
<body>
    <form id="form1">
    <div>

        <ul id="rig">
    <li>
        <a class="rig-cell" href="DBMS.aspx" >
            <img class="rig-img" src="img/dbms_new_1_250x200.gif"  runat="server" alt="image1" />
            <span class="rig-overlay"></span>
            <span class="rig-text">DBMS</span>
        </a>
        &nbsp;&nbsp;&nbsp;
    </li>
    <li>
        <a class="rig-cell" href="Java.aspx">
            <img class="rig-img" src="img/java_1_250x200.jpg" alt="image1"/>
            <span class="rig-overlay"></span>
            <span class="rig-text">Java</span>
        </a>
        &nbsp;&nbsp;&nbsp;
    </li>
    <li>
        <a class="rig-cell" href="Robotics.aspx">
            <img class="rig-img" src="img/robotics_1_250x200.jpg"  alt="image1"/>
            <span class="rig-overlay"></span>
            <span class="rig-text">Robotics</span>
        </a>
        &nbsp;&nbsp;&nbsp;
    </li>
    <li>
        <a class="rig-cell" href="AI.aspx">
            <img class="rig-img" src="img/AI_1_250x200.jpg" alt="image1"/>
            <span class="rig-overlay"></span>
            <span class="rig-text">Artificial Intelligence</span>
        </a>
    </li>
            <br /><br /> <br /><br /> <br /><br />
</ul>
    </div>
    </form>
</body>
</html>
</asp:Content>
