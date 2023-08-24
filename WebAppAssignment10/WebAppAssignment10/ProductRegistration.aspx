<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProductRegistration.aspx.cs" Inherits="WebAppAssignment10.ProductRegistration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.1/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-4bw+/aepP/YC94hEpVNVgiZdgIC5+VKNBQNGCHeKRQN+PtmoHDEXuppvnDJzQIu9" crossorigin="anonymous" />
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.1/dist/js/bootstrap.bundle.min.js" integrity="sha384-HwwvtgBNo3bZJJLYd8oVXjrBZt8cqVSpeBNS5n7C8IVInixGAoxmnlMuBnhbgrkm" crossorigin="anonymous"></script>
    <title>Product Registration Form</title>
    <style type="text/css">
        .auto-style1 {
            width: 365px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <table class="w-100">
        <tr>
            <td colspan="3"><h2 style="text-align:center">Product Registration Form</h2></td>
        </tr>
        <tr>
            <td class="auto-style1">Product Image</td>
            <td>
                <div class="col-md-4"><asp:Image runat="server" ID="PrImg" ImageUrl="~/Images/Picture 2.jpg"
                Width="150" Height="150" CssClass="img-fluid" />
                </div>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">Product Name</td>
            <td>
                <asp:TextBox ID="PrName" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="PrName" ErrorMessage="Name is required" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">Category</td>
            <td>
                <asp:DropDownList ID="PrCategory" runat="server">
                </asp:DropDownList>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="PrCategory" ErrorMessage="Select one category" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">Price</td>
            <td>
                <asp:TextBox ID="PrPrice" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="PrPrice" ErrorMessage="Price is required" ForeColor="Red"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="PrPrice" ErrorMessage="Must use numeric values only" ForeColor="Red" ValidationExpression="^\d+(\.\d+)?$"></asp:RegularExpressionValidator>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">Description</td>
            <td>
                <asp:TextBox ID="PrDescription" runat="server" TextMode="MultiLine"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="PrDescription" ErrorMessage="Description is required" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">Release Date</td>
            <td>
                <asp:Calendar ID="PrRD" runat="server" Font-Names="Verdana" Font-Size="8pt" ForeColor="#663399" Height="200px" ShowGridLines="True" Width="220px"></asp:Calendar>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td>
                <asp:Button ID="BtnRegPr" runat="server" Text="Register Product" OnClick="BtnRegPr_Click" />
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td colspan="3">
                <asp:Label ID="LblInfo" runat="server"></asp:Label>
            </td>
        </tr>
    </table>
        <div>
        </div>
    </form>
</body>
</html>
