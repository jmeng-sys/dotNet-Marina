<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="CPRG214_Marina.App.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <h3>Login</h3>
    <div class="col-md-4">
        <table class="table">
            <tr>
                <td style="width:150px; height: 30px;">First Name:</td>
                <td>
                    <asp:TextBox ID="uxFirstName" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Last Name:</td>
                <td>
                    <asp:TextBox ID="uxLastName" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Button ID="uxAuthenticate" runat="server" Text="Login" OnClick="uxAuthenticate_Click" />
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Label ID="uxError" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
        </table>
    </div>
</asp:Content>
