<%@ Page Title="" Language="C#" MasterPageFile="~/sablon.Master" AutoEventWireup="true" CodeBehind="randevuiptal.aspx.cs" Inherits="WebApplication1.randevuiptal" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style1 {
        color: #FFFFFF;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2 class="auto-style1">Randevu İptal Et</h2>
<p>
    &nbsp;</p>
<p>
    <asp:ListBox ID="ListBox1" runat="server" Height="279px" Width="156px"></asp:ListBox>
<p>
    &nbsp;</p>
<p>
    <asp:CheckBox ID="CheckBox1" runat="server" CssClass="auto-style1" Text="Onaylıyorum" AutoPostBack="True" OnCheckedChanged="CheckBox1_CheckedChanged" />
</p>
<p>
    &nbsp;</p>
<p>
    <asp:Button ID="Button1" runat="server" Enabled="False" OnClick="Button1_Click" Text="İptal Et" />
</p>
<p>
    &nbsp;</p>
<p>
    <asp:Label ID="Label1" runat="server"></asp:Label>
</p>
</asp:Content>
