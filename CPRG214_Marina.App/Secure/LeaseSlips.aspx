<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="LeaseSlips.aspx.cs" Inherits="CPRG214_Marina.App.Secure.LeaseSlips" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h3>Please Select A Slip to Lease</h3>

    <div class="col-md-4">
        <table class="table">
            <tr>
                <td style="width:150px; height: 30px;">Enter Slip Number:</td>
                <td>
                    <asp:TextBox ID="uxSelectedSlip" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Button ID="uxConfirm" runat="server" Text="Confirm" OnClick="uxConfirm_Click" />
                </td>
            </tr>
        </table>
        <p>Your Customer ID:</p>
        <asp:Label ID="uxCustID" runat="server" Text=""></asp:Label>
    </div>
    <br />
    <div class="uxSlips">
    <asp:GridView ID="uxLeasedSlips" runat="server" Width="260px"></asp:GridView>
    </div>
</asp:Content>
