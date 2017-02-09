<%@ Page Title="Test" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="test.aspx.cs" Inherits="onlinetest.test" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
<div id="pagecontent" class="rounded">
<asp:Label ID="test1" runat="server" Text="Test" CssClass="h1"></asp:Label>
    <br />
<div id="timer">
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
    <ContentTemplate>
    <asp:Timer ID="Timer1" runat="server">
    </asp:Timer>
    <asp:Label ID="lblRemTime" runat="server"></asp:Label>
    </ContentTemplate>
    </asp:UpdatePanel>
</div>
<br />
<div id="question">
    <asp:UpdatePanel ID="UpdatePanel2" runat="server">
    <ContentTemplate>
    <asp:Label ID="lblQues" runat="server"></asp:Label><br />
    <asp:RadioButtonList ID="rblOption" runat="server">
    </asp:RadioButtonList><br />
    <asp:Button ID="next" runat="server" Text="Next" CssClass="btn" OnClick="next_Click" />
    </ContentTemplate>
    </asp:UpdatePanel>
</div>
 <asp:Label ID="lbError" runat="server"></asp:Label>   
</div>
</asp:Content>
