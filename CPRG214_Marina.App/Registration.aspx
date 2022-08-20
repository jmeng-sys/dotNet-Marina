<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="CPRG214_Marina.App.Registration" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <h3>Registration</h3>
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
                <td>Phone:</td>
                <td>
                    <asp:TextBox ID="uxPhone" runat="server"></asp:TextBox>
                </td>
            </tr><tr>
                <td>City:</td>
                <td>
                    <asp:TextBox ID="uxCity" runat="server"></asp:TextBox>
                </td>
            </tr>
            
            <tr>
                <td colspan="2">
                    <asp:Button ID="uxRegister" runat="server" Text="Register" OnClick="uxRegistration_Click" />
                </td>
            </tr>
            
        </table>
    </div>
</asp:Content>
