<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Second.aspx.cs" Inherits="WebAppOne.Second" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td>
                    <asp:Label ID="LblMsg" runat="server" Font-Size="Larger" ForeColor="Maroon"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="BtnRegister" runat="server" Text="Register" />
                </td>
            </tr>
        </table>
        <div>
        </div>
    </form>
</body>
</html>
