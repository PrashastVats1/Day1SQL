<%@ Page Title="" Language="C#" MasterPageFile="~/OurSite.Master" AutoEventWireup="true" CodeBehind="CachingEx.aspx.cs" Inherits="WebAppSecureSM.Secure.CachingEx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Cache Example</h2>
    <p>
        <asp:Label ID="LblCache" runat="server" Text="Label"></asp:Label>
        <asp:Button ID="btnClickMe" runat="server" OnClick="btnClickMe_Click" Text="Click Here" />
    </p>
</asp:Content>
