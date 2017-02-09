<%@ Page Title="Result" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="result.aspx.cs" Inherits="onlinetest.result" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div id="pagecontent" class="rounded">
<asp:Label ID="result1" runat="server" Text="Result" CssClass="h1"></asp:Label><br /><br />
<div class="text">
<asp:Label ID="user" runat="server" Text="Name : "></asp:Label>
<asp:Label ID="lblUser" runat="server"></asp:Label><br />
<asp:Label ID="mark" runat="server" Text="Marks : "></asp:Label>
<asp:Label ID="lblMarks" runat="server"></asp:Label><br /><br />
<asp:Label ID="lblError" runat="server" CssClass="error"></asp:Label>
<asp:Label ID="t" runat="server" Text="Thanks for giving the online test."></asp:Label>
</div>
</div>
</asp:Content>
