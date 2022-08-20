<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DockSlips.aspx.cs" Inherits="CPRG214_Marina.App.DockSlips" %>

<%@ Register Src="~/Controls/DockSelector.ascx" TagPrefix="uc1" TagName="DockSelector" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h3> Docks and Available Slips</h3>
    <uc1:DockSelector runat="server" id="DockSelector" AllowPostBack="True" />
&nbsp;&nbsp;<br />
<br />
<br />
<br />
<div class="uxSlips">
    <asp:GridView ID="uxAvailableSlips" runat="server" Width="377px"></asp:GridView>
</div>
</asp:Content>
