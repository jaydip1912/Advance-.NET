﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Session.aspx.cs" Inherits="d4.Session" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>
                Asp.NET -server side state manegement - Session Page
            </h1>
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label> <asp:Button ID="Button1" runat="server" Text="Logout" OnClick="Button1_Click" />
        </div>
    </form>
</body>
</html>
