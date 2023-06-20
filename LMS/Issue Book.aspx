<%@ Page Title="" Language="C#" MasterPageFile="~/Librarian.Master" AutoEventWireup="true" CodeBehind="Issue Book.aspx.cs" Inherits="LMS.Issue_Book" %>

<asp:Content ID="Content1" ContentPlaceHolderID="LMainContent" runat="server">
    <asp:Label ID="lblMessage" runat="server" Text="" ForeColor="Red"></asp:Label>
    <br />

    <span>Student : </span>
    <asp:DropDownList ID="ddlStudentList" runat="server"></asp:DropDownList>
    <asp:RequiredFieldValidator ID="rvStudent" runat="server" ErrorMessage="Please Select Student name" ControlToValidate="ddlStudentList" ForeColor="Red"></asp:RequiredFieldValidator><br />
    <br/>
    <span>Book </span>
    <asp:DropDownList ID="ddlBookList" runat="server"></asp:DropDownList>
    <asp:RequiredFieldValidator ID="rvBook" runat="server" ErrorMessage="Please Select Book name" ControlToValidate="ddlBookList" ForeColor="Red"></asp:RequiredFieldValidator><br />
    <br/>
   <asp:Button ID="btnIssueBook" runat="server" Text="Save" OnClick="BtnSaveIssueBook_Click"  /><br /><br />
    <asp:GridView ID="gvIssueBook" runat="server" CssClass="table"></asp:GridView>
</asp:Content>

