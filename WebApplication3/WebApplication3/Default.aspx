<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication3._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
<div>
    <h1 class="display-4">Welcome</h1>
    <p>Введіть число: <asp:TextBox ID="TextBox1" runat="server" Width="103px"></asp:TextBox>
        <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click1" Height="30px" Width="90px" />
       </p>
    <div class="form-group">
       <p> <asp:Label ID="Label3" runat="server" Text=""></asp:Label></p>
    </div>
      <asp:Button ID="btnDecr" runat="server" Text="Decr" OnClick="btnDecr_Click1" Height="30px" Width="90px" /> <asp:Label ID="Label4" runat="server" Text=""></asp:Label></p>
      <asp:Button ID="btnIncr" runat="server" Text="Incr" OnClick="btnIncr_Click1" Height="30px" Width="90px" /></p>
    </div>
</asp:Content>
