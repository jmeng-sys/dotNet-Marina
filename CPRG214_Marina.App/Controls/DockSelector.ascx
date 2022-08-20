<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="DockSelector.ascx.cs" Inherits="CPRG214_Marina.App.Controls.DockSelector" %>

<asp:DropDownList ID="uxDocks" runat="server" Height="30px" Width="152px" OnSelectedIndexChanged="uxDocks_SelectedIndexChanged" AutoPostBack="True">
    <asp:ListItem>-- Select --</asp:ListItem>
</asp:DropDownList>
