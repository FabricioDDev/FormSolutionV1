<%@ Page Title="" Language="C#" MasterPageFile="~/WebMasterPage.Master" AutoEventWireup="true" CodeBehind="FrmSignUp.aspx.cs" Inherits="FormApp.ClientViews.FrmSignUp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:TextBox ID="TxtUserName" runat="server"></asp:TextBox>
    <asp:TextBox ID="TxtUserSubName" runat="server"></asp:TextBox>
    <asp:TextBox ID="TxtUserMail" runat="server"></asp:TextBox>
    <asp:TextBox ID="TxtUserPass" runat="server"></asp:TextBox>
    <asp:DropDownList ID="DdlSex" runat="server"></asp:DropDownList>
    <asp:DropDownList ID="DdlCountry" runat="server"></asp:DropDownList>
    <asp:TextBox ID="TxtBornDate" TextMode="Date" runat="server"></asp:TextBox>

    <asp:Button ID="BtnGo" OnClick="BtnGo_Click" runat="server" Text="Go" />
    <asp:Button ID="BtnLogin" runat="server" Text="Sign Up" />
</asp:Content>
