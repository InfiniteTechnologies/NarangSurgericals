<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="AdminAplication._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Sanjivani Ananda</title>
    <link href="Css/style.css" rel="Stylesheet" type="text/css" />
</head>
<body id="loginBody">
    <form id="form1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
    <ContentTemplate>
        <div class="loginBox">
    <div id="logo">
        <img src="images/logo.png" width="200" height="80" border="0" />
    </div>
    <br>
    <img src="images/rope.png" width="127" height="35" border="0" /><br>
    <font size="4" color="#f0f8ff"><b>Login</b></font><br><br>
         <asp:TextBox ID="loginUsername" runat="server" CssClass="loginInputBox" placeholder="Username"></asp:TextBox>
            <asp:TextBox ID="loginPass" runat="server" class="loginInputBox" placeholder="Password" TextMode="Password"></asp:TextBox>    
            <asp:Button ID="loginSubmit" runat="server" Text="" OnClick="loginSubmit_Click" />
    <br><br>
    <span id="loginMsg">
        <asp:Label ID="lblMsg" runat="server" Text="Label"></asp:Label>
    </span>
    <br><br>
    <a href="">Forgot password</a>
</div>
    </ContentTemplate>
    </asp:UpdatePanel>
   
    </form>
</body>
</html>
