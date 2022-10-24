<%@ Page Title="" Language="C#" MasterPageFile="~/WebMasterPage.Master" AutoEventWireup="true" CodeBehind="FrmLogin.aspx.cs" Inherits="FormApp.ClientViews.FrmLogin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:TextBox ID="TxtUserMail" runat="server"></asp:TextBox>
    <asp:Label ID="LblWarning" runat="server" Text=""></asp:Label>
    <asp:TextBox ID="TxtUserPass" runat="server"></asp:TextBox>
    <asp:Button ID="BtnGo" OnClick="BtnGo_Click" runat="server" Text="Go" />
    <asp:Button ID="BtnSignUp" OnClick="BtnSignUp_Click" runat="server" Text="Sign Up" />
</asp:Content>
