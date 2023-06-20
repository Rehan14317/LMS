<%@ Page Title="" Language="C#" MasterPageFile="~/Student.Master" AutoEventWireup="true" CodeBehind="StudentHome.aspx.cs" Inherits="LMS.StudentHome" %>
<asp:Content ID="Content1" ContentPlaceHolderID="SMainContent" runat="server">

 
     <style>
       body{
    background:url("https://www.edigitallibrary.com/img/library-img.jpg");
     background-size:150% ;
    background-position: 25px 0px;
}
       h1{
           background-color:gold;
       }
       h3{
          
            font-size:25px;
              color:whitesmoke;
       }
     
     </style>

    <center><h1>Welcome To Library Management System : <asp:Label ID="lblName" runat="server" Text=""></asp:Label></h1>
         <br><br ><br><br>
          <div>
                   <p><h3>It is a easy software system that helps within the sleek functioning of the library management system.<br><br>
                   It keeps track of the books issued and returned from the library,LMS involves maintaining of info of <br /><br>
                   existing books yet as new books additional within the library,This system helps keep record of all the<br /><br>
                   books in a library It is utilized in colleges, institutions, universities which provide full support to<br /><br>
                   the librarian and helps in easy management of library.</h3></p>
        </div>
   </center>
 




</asp:Content>
