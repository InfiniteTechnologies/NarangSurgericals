<%@ Page Language="C#" AutoEventWireup="true" CodeFile="layout.aspx.cs" Inherits="manage_layout" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
   
    <link href="Css/layout.css" type="text/css" rel="Stylesheet" />
    <link href="Css/menu.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div id="container">
        <div class="header">
            <div id="logo">
                <img src="Images/logo.png" width="100%" />
            </div>
            <div id="headright">
                <img src="Images/glyphicons_003_user.png" />&nbsp;
                    <img src="Images/glyphicons_003_user.png" />&nbsp;
                    <img src="Images/glyphicons_003_user.png" />&nbsp;Welcome to <b>Mayank Kothari</b><br /><br />
                <div> 
                    <asp:LinkButton ID="LinkButton1" runat="server" CssClass="btns">My Account</asp:LinkButton>
                    <asp:LinkButton ID="LinkButton2" runat="server" CssClass="btns">Log Out</asp:LinkButton>
                </div>
            </div>
        </div>
        <div id="nav">
            <ul class="menu">
                <li><a href="">Dashboard</a></li>
                <li><a href="">Dashboard</a>
                    <ul>
                        <li><a href="">Dashboard</a></li>
                        <li><a href="">Dashboard</a></li>
                        <li><a href="">Dashboard</a></li>                        
                    </ul>
                </li>
                <li><a href="">Dashboard</a></li>
                <li><a href="">Dashboard</a></li>
                <li><a href="">Dashboard</a></li>
            </ul>
        </div>
        <div class="workingarea">
            
        </div>
    </div>
    </form>
</body>
</html>
