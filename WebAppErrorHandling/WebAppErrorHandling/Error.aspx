<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Error.aspx.cs" Inherits="WebAppErrorHandling.Error" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2 style="text-align:center">Error Occured!!!!</h2>
            <div style="text-align:center">
                <asp:Label ID="LblMsg" runat="server"></asp:Label>
            </div>
        </div>
    </form>
</body>
</html>
