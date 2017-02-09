<%@ Page Title="Instruction" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="instruction.aspx.cs" Inherits="onlinetest.instruction" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
<div id="pagecontent" class="rounded">
<asp:Label ID="ins" runat="server" Text="Instruction" CssClass="h1"></asp:Label><br /><br />
<div class="text">
Please read these instructions before starting the test:<br /><br />
<ul>
<li>Test contains 10 questions. Each question has 4 options. You have to click the right answer option.</li>
<li>You have 100 seconds to complete the test. Remaining time will be shown.</li>
<li>Each right anwser will give you 1 mark.</li>
<li>At the end of the test, you can view the result of test.</li>
</ul>
</div><br />
<asp:Button ID="start" runat="server" Text="Start Test" CssClass="btn" OnClick="start_Click" />
</div>
</asp:Content>
