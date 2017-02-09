<%@ Page Title="Registration" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="registration.aspx.cs" Inherits="onlinetest.registration" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
<div id="pagecontent" class="rounded">
<asp:Label ID="re" runat="server" Text="Registration" CssClass="h1"></asp:Label><br />
<div id="rform">
<asp:Label ID="lblUserName" runat="server" Text="Name :"></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtUserName"
        ErrorMessage="Please Enter Your Name!" CssClass="error"></asp:RequiredFieldValidator><br />
<asp:Label ID="lblEmail" runat="server" Text="Email Id :"></asp:Label>&nbsp;&nbsp;<asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" CssClass="error" ErrorMessage="Please Enter Your Email Id!" ControlToValidate="txtEmail"></asp:RequiredFieldValidator>
    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtEmail"
        ErrorMessage="Please enter proper Email Id" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator><br />
</div>
<asp:Button ID="register" runat="server" Text="Register & Continue" CssClass="btn" OnClick="register_Click" /><br /><br />
<asp:Label ID="lblError" runat="server" CssClass="error"></asp:Label>
</div>
</asp:Content>
