<%@ Page Title="" Language="C#" MasterPageFile="~/Librarian.Master" AutoEventWireup="true" CodeBehind="AddPublisher.aspx.cs" Inherits="LMS.AddPublisher" %>

<asp:Content ID="Content1" ContentPlaceHolderID="LMainContent" runat="server">
    <asp:Label ID="lblMessage" runat="server" Text="" ForeColor="Red"></asp:Label>
    <br />
    <span>Publisher Name: </span>
    <asp:TextBox ID="txtPublisherName" runat="server" CssClass="form-control"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Please enter publisher name" ControlToValidate="txtPublisherName" ForeColor="Red"></asp:RequiredFieldValidator><br />
    <span>Address: </span>
    <asp:TextBox ID="txtAddress" runat="server" TextMode="MultiLine" CssClass="form-control"></asp:TextBox><br />
    <span>Pincode</span>
    <asp:TextBox ID="txtPincode" runat="server" TextMode="Number" CssClass="form-control"></asp:TextBox><br />
    <br />
        <asp:Button ID="BtnSavePublisher" runat="server" Text="Save" OnClick="BtnSavePublisher_Click" /><br /><br />
        <asp:GridView ID="gvPublisher" runat="server" CssClass="table"></asp:GridView>
</asp:Content>

