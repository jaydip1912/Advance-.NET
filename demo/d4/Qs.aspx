﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Qs.aspx.cs" Inherits="d4.Qs" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td>Enter First name</td>
                    <td>
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Enter last name</td>
                    <td>
                        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click"/>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>