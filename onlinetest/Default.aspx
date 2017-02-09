<%@ Page Title="Online Test" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="onlinetest._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

<div id="pagecontent" class="rounded">
<asp:Label ID="welcome" runat="server" Text="Welcome to Online Test" CssClass="h1"></asp:Label><br /><br />
<div class="text">
This online test system is developed to check the knowledge of an ASP.Net developer who has the intermidiate experience of working with .Net. It contains
some of the most basic questions that every .Net developer should anwser. So if you are ready to check up your knowledge then click the Registration button. 
</div><br /><br />
<asp:Button ID="register" runat="server" Text="Registration" CssClass="btn" OnClick="register_Click"/><br /><br />
<div class="text">
if you have any question or feedback about this system then please mail me on my email Id : jsjhass@gmail.com
</div><br />
</div>

</asp:Content>
