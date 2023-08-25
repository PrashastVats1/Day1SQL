<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CustomValidator.aspx.cs" Inherits="WebAppMasterPage.CustomValidator" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style1 {
        width: 430px;
    }
    .auto-style2 {
        width: 615px;
    }
    .auto-style3 {
        width: 555px;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2 class="text-center">CustomValidator Page</h2>
    <table>
        <tr>
            <td class="auto-style3">Enter Lucky Odd Number</td>
            <td class="auto-style1">
                <asp:TextBox ID="TxtOddNum" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style2">
                <asp:CustomValidator ID="CustomValidator1" runat="server" ControlToValidate="TxtOddNum" ErrorMessage="Only Odd Number is allowed" ForeColor="Red" OnServerValidate="CustomValidator1_ServerValidate"></asp:CustomValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style1">
                <asp:Button ID="BtnSubmit" runat="server" OnClick="BtnSubmit_Click" Text="Submit Choice" />
            </td>
            <td class="auto-style2">&nbsp;</td>
        </tr>
        <tr>
            <td colspan="3">
                <asp:Label ID="LblMsg" runat="server"></asp:Label>
            </td>
        </tr>
        </table>
    
</asp:Content>
