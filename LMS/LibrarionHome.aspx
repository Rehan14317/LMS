<%@ Page Title="" Language="C#" MasterPageFile="~/Librarian.Master" AutoEventWireup="true" CodeBehind="LibrarionHome.aspx.cs" Inherits="LMS.LibrarionHome" %>
<asp:Content ID="Content1" ContentPlaceHolderID="LMainContent" runat="server">
  



         <style>
       body{
     background:url("https://images.pexels.com/photos/256453/pexels-photo-256453.jpeg?auto=compress&cs=tinysrgb&w=600");
     background-size:150% ;
    background-position: 25px 0px;
}
       h1{
           background-color:whitesmoke;
           font-style:oblique;
       }
       h3{
          
            font-size:25.5px;
             font-style: oblique;
              color:whitesmoke;
       }
     
     </style>

    <center><h1>Welcome To Library Management System : <asp:Label ID="Label1" runat="server" Text=""></asp:Label></h1>
         <br><br ><br><br>
          <div>
                   <p><h3>It is a easy software system that helps within the sleek functioning of the library management system.<br><br>
                   It keeps track of the books issued and returned from the library,LMS involves maintaining of info of <br /><br>
                   existing books yet as new books additional within the library,This system helps keep record of all the<br /><br>
                   books in a library It is utilized in colleges, institutions, universities which provide full support to<br /><br>
                   the librarian and helps in easy management of library.</h3></p>
        </div>
   </center>
 



        
        <asp:Label ID="lblName" runat="server" Text=""></asp:Label>
</asp:Content>

  