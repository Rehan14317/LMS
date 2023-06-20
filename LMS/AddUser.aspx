<%@ Page Title="" Language="C#" MasterPageFile="~/Librarian.Master" AutoEventWireup="true" CodeBehind="AddUser.aspx.cs" Inherits="LMS.AddUser" %>
<asp:Content ID="Content2" ContentPlaceHolderID="LMainContent" runat="server">
    <asp:Label ID="lblMessage" runat="server" Text="" ForeColor="Red"></asp:Label>
    <br />
     <span>Login Id </span>
    <asp:TextBox ID="txtLoginId" runat="server" CssClass="form-control"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Please enter LoginId" ControlToValidate="txtLoginId" ForeColor="Red"></asp:RequiredFieldValidator><br />
    
     <span>usertype </span>
    <asp:TextBox ID="txtusertype" textMode="number" runat="server" CssClass="form-control"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Please enter UserType" ControlToValidate="txtusertype" ForeColor="Red"></asp:RequiredFieldValidator><br />

    <span>User Name </span>
    <asp:TextBox ID="txtUserName" runat="server" CssClass="form-control"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Please enter User name" ControlToValidate="txtUserName" ForeColor="Red"></asp:RequiredFieldValidator><br />
    
     <span>Password </span>
    <asp:TextBox ID="txtPassword" textMode="Password" runat="server" CssClass="form-control"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Please enter Password" ControlToValidate="txtPassword" ForeColor="Red"></asp:RequiredFieldValidator><br />

    <span>Class Name </span>    
    <asp:TextBox ID="txtClassName" runat="server" CssClass="form-control"></asp:TextBox><br />
    <span>Address</span>
    <asp:TextBox ID="txtAddress" runat="server" TextMode="MultiLine" CssClass="form-control"></asp:TextBox><br />
    <br />
    <asp:Button ID="BtnSaveUser" runat="server" Text="Save" OnClick="BtnSaveUser_Click" /><br /><br />
    <asp:GridView ID="gvUser" runat="server" CssClass="table"></asp:GridView>
</asp:Content>