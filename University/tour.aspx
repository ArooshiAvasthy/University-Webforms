<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage2.Master" AutoEventWireup="true" CodeBehind="tour.aspx.cs" Inherits="University.tour1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head >
    <title></title>
    <link href="StyleSheet/ImageGallery.css" rel="stylesheet" />
</head>
<body>
<form id="form1">
  <div id="images-box">
    <div class="holder">
        
        <div id="image-1" class="image-lightbox">
            <span class="close"><a href="#">X</a></span>
            <img src="MasterTemplate/Images/img1.jpg" alt="earth!">
            <a class="expand" href="#image-1"></a>
        </div>
    </div>
    <div class="holder">
        <div id="image-2" class="image-lightbox">
            <span class="close"><a href="#">X</a></span>
            <img src="MasterTemplate/Images/img2.jpg" alt="earth!">
            <a class="expand" href="#image-2"></a>
            <br /><br />
        </div>
    </div>
    <div class="holder">
        <div id="image-3" class="image-lightbox">
            <span class="close"><a href="#">X</a></span>
            <img src="img/EDIT.png" alt="earth!">
            <a class="expand" href="#image-3"></a>
        </div>
    </div>
        <br />
       <div class="holder">
        <div id="image-4" class="image-lightbox">
            <span class="close"><a href="#">X</a></span>
            <img src="img/EDIT.png" alt="earth!">
            <a class="expand" href="#image-4"></a>
        </div>
    </div>
</div>
        
    </form>
</body>
</html>

</asp:Content>
