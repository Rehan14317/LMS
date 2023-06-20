<%@ Page Title="" Language="C#" MasterPageFile="~/Student.Master" AutoEventWireup="true" CodeBehind="Feedback.aspx.cs" Inherits="LMS.Feedback" %>

<asp:Content ID="Content1" ContentPlaceHolderID="SMainContent" runat="server">
    <asp:Label ID="lblMessage" runat="server" Text="" ForeColor="Red"></asp:Label>
     <style>
        
         body{  
            background-image:url("https://st2.depositphotos.com/3837271/8657/i/450/depositphotos_86576638-stock-photo-your-feedback-matters-placard.jpg");            
            background-size:81%;
            background-position: 125px 100px;
            }
     
       
     
     </style>
    <br/>
    <by/>
    <h2>WELCOME TO THE FEEDBACK SECTION</h2>
    <br />
    <span>Name :  </span>
    <asp:TextBox ID="txtName" runat="server" CssClass="form-control"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Please enter Your Name" ControlToValidate="txtName" ForeColor="Red"></asp:RequiredFieldValidator><br />
    <span>Email-Address: </span>
    <asp:TextBox ID="txtEmail" runat="server"   CssClass="form-control"></asp:TextBox><br />
    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Please enter Your Email" ControlToValidate="txtEmail" ForeColor="Red"></asp:RequiredFieldValidator><br />

    <span>FeedBack :</span>
     <asp:TextBox ID="txtFed" runat="server" CssClass="form-control"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" TextMode="MultiLine" runat="server" ErrorMessage="Please enter Your Feedback" ControlToValidate="txtFed" ForeColor="Red"></asp:RequiredFieldValidator><br />
    
    <asp:Button ID="BtnFeedback" runat="server" Text="Save" OnClick="BtnFeedback_Click" /><br /><br />
</asp:Content>

