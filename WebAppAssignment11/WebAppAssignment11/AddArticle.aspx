<%@ Page Title="" Language="C#" MasterPageFile="~/SiteMaster.Master" AutoEventWireup="true" CodeBehind="AddArticle.aspx.cs" Inherits="WebAppAssignment11.AddArticle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 390px;
        }
        .auto-style2 {
            width: 586px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2 class="text-center">Insert Artice Page</h2>
    <table class="w-100">
        <tr>
            <td class="auto-style1">Article Id</td>
            <td class="auto-style2">
                <asp:TextBox ID="ArticleId" runat="server"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">Title</td>
            <td class="auto-style2">
                <asp:TextBox ID="ArticleTitle" runat="server"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">Content</td>
            <td class="auto-style2">
                <asp:TextBox ID="ArticleContent" runat="server" TextMode="MultiLine"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">Publish Date</td>
            <td class="auto-style2">
                <asp:TextBox ID="PublishDate" runat="server"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td class="auto-style2">
                <asp:Button ID="BtnAddArticle" runat="server" OnClick="BtnAddArticle_Click" Text="Add Article" />
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td colspan="3">
                <asp:Label ID="LblMsg" runat="server"></asp:Label>
            </td>
        </tr>
        </table>
</asp:Content>
