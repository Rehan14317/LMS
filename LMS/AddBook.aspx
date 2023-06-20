<%@ Page Title="" Language="C#" MasterPageFile="~/Librarian.Master" AutoEventWireup="true" CodeBehind="AddBook.aspx.cs" Inherits="LMS.AddBook" %>
<asp:Content ID="Content2" ContentPlaceHolderID="LMainContent" runat="server">
    <asp:Label ID="lblMessage" runat="server" Text="" ForeColor="Red"></asp:Label>
    <br />
<span>Publisher Name: </span>
    <asp:DropDownList ID="ddlfk_PublisherID" runat="server"></asp:DropDownList>
    <asp:RequiredFieldValidator ID="rvPublisher" runat="server" ErrorMessage="Please Select Publisher Name" ControlToValidate="ddlfk_PublisherID" ForeColor="Red"></asp:RequiredFieldValidator><br />
    <br/>

    <span>BookName: </span>
    <asp:TextBox ID="txtBookName" runat="server" CssClass="form-control"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Please enter publisher name" ControlToValidate="txtBookName" ForeColor="Red"></asp:RequiredFieldValidator><br />
   
    <span>AuthorName: </span>
    <asp:TextBox ID="txtAuthorName" runat="server" CssClass="form-control"></asp:TextBox><br />
    <span>No of Copies</span>
    <asp:TextBox ID="txtcopies" runat="server" TextMode="Number" CssClass="form-control"></asp:TextBox><br />
    <br />
    <asp:Button ID="btnSaveBook" runat="server" Text="Save" OnClick="btnSaveBook_Click" /><br /><br />
    <asp:GridView ID="gvBook" runat="server" CssClass="table"></asp:GridView>
</asp:Content>