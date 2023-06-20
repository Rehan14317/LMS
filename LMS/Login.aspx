<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="LMS.Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" /><br />
    <asp:Label ID="lblMessage" runat="server" Text=""  ForeColor="Red"></asp:Label><br />
    <center>
        <h1>LOGIN PAGE</h1>
    </center>
     <style>
        
         body{  
             background-image:url("https://wallpaperaccess.com/full/253342.jpg");
     background-size:150% ;
    background-position: 25px 0px;
}
       h1{
           background-color: mintcream;
           padding-bottom: 3px;
       }
       h3{
          
            font-size:25px;
              color:whitesmoke;
       }
     
     </style>
     
    <asp:ValidationSummary ID="ValidationSummary2" runat="server" ForeColor="Red" /><br />
      
       
    <asp:Label ID="Label1" runat="server" Text=""  ForeColor="Red"></asp:Label><br />
    <span><u><h3>Login Id : </h3></u> </span>
    <asp:TextBox ID="txtLoginId" runat="server" CssClass="form-control"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtLoginId" ErrorMessage="Please enter login id" ForeColor="Red">*</asp:RequiredFieldValidator>
    <br />
    <span><u><h3>Password : <h3></u></span>
    <asp:TextBox ID="txtPassword" runat="server" CssClass="form-control" TextMode="Password"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtPassword" ErrorMessage="Please enter password" ForeColor="Red">*</asp:RequiredFieldValidator>
    <br />
     <br>
    <asp:Button ID="Button1" runat="server" Text="Login" OnClick="BtnLogin_Click" ForeColor="Black" />
     

</asp:Content>
