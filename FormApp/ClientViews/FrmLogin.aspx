<%@ Page Title="" Language="C#" MasterPageFile="~/WebMasterPage.Master" AutoEventWireup="true" CodeBehind="FrmLogin.aspx.cs" Inherits="FormApp.ClientViews.FrmLogin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
 
    <div class="row justify-content-center">
        <div class="col-auto">
            <h1>Hey,I missed you!</h1>
        </div>
    </div>
    <div class="row justify-content-center">
        <div class="col-auto">
            <label class="form-label">Your Mail*</label>
            <asp:TextBox ID="TxtUserMail" CssClass="form-control" runat="server"></asp:TextBox>
            <asp:Label ID="LblWarning" runat="server" CssClass="" Text=""></asp:Label>

            <label class="form-label">Your Pass*</label>
            <asp:TextBox ID="TxtUserPass" CssClass="form-control" runat="server"></asp:TextBox>
        </div>
    </div>
    <div class="row justify-content-center">
        <div class="col-auto">
            <asp:Button ID="BtnGo" OnClick="BtnGo_Click" CssClass="btn btn-primary" runat="server" Text="Go" />
            <asp:Button ID="BtnSignUp" OnClick="BtnSignUp_Click" CssClass="btn btn-secondary" runat="server" Text="Sign Up" />
        </div>
    </div>
 
</asp:Content>
