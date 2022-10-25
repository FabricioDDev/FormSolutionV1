<%@ Page Title="" Language="C#" MasterPageFile="~/WebMasterPage.Master" AutoEventWireup="true" CodeBehind="FrmSignUp.aspx.cs" Inherits="FormApp.ClientViews.FrmSignUp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row justify-content-center">
        <div class="col-auto">
            <h1>Create a new Account</h1>
        </div>
    </div>
    <div class="row justify-content-center" >
        <div class="col-3 col-auto">
            <asp:Label ID="LblUserName" CssClass="" runat="server" Text="Your Name*"></asp:Label>
            <asp:TextBox ID="TxtUserName" CssClass="form-control" runat="server"></asp:TextBox>
        </div>
        <div class="col-3 col-auto">
            <asp:Label ID="LblUserSubName" CssClass="" runat="server" Text="Your Sub-Name"></asp:Label>
            <asp:TextBox ID="TxtUserSubName" CssClass="form-control" runat="server"></asp:TextBox>
        </div>
    </div>
    <div class="row justify-content-center">
        <div class="col-3 col-auto">
             <asp:Label ID="LblUserMail" CssClass="" runat="server" Text="Your Mail"></asp:Label>
             <asp:TextBox ID="TxtUserMail" CssClass="form-control" runat="server"></asp:TextBox>
        </div>
        <div class="col-3 col-auto">
            <asp:Label ID="LblUserPass" CssClass="" runat="server" Text="Your New Pass"></asp:Label>
            <asp:TextBox ID="TxtUserPass" CssClass="form-control" runat="server"></asp:TextBox>
        </div>
    </div>
    <div class="row justify-content-center">
        <div class="col-3 col-auto">
            <asp:Label ID="LblSex" CssClass="" runat="server" Text="Your Sex"></asp:Label>
            <asp:DropDownList ID="DdlSex" CssClass="btn dropdown-toggle" runat="server"></asp:DropDownList>
        </div>
        <div class="col-3 col-auto">
            <asp:Label ID="LblCountry" CssClass="" runat="server" Text="Where are your from?"></asp:Label>
            <asp:DropDownList ID="DdlCountry" CssClass="btn dropdown-toggle" runat="server"></asp:DropDownList>
        </div>
    </div>
    <div class="row justify-content-center">
        <div class="col-3 col-auto">
            <asp:Label ID="LblBornDate" CssClass="" runat="server" Text="Your BornDate?"></asp:Label>
            <asp:TextBox ID="TxtBornDate" CssClass="form-control" TextMode="Date" runat="server"></asp:TextBox>
        </div>
        <div class="col-3 col-auto">
            <asp:CheckBox ID="CkbAllow" CssClass="form-check" Text="Accept all rules" runat="server" />
            <asp:Button ID="BtnGo" CssClass="btn btn-primary" OnClick="BtnGo_Click" runat="server" Text="Go" />
            <asp:Button ID="BtnLogin" CssClass="btn btn-secondary" OnClick="BtnLogin_Click" runat="server" Text="Login" />
        </div>
    </div>
               
</asp:Content>
