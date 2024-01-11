<%@ Page Title="" Language="C#" MasterPageFile="~/sablon.Master" AutoEventWireup="true" CodeBehind="randevuekle.aspx.cs" Inherits="WebApplication1.randevuekle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style1 {
        width: 800px;
    }
    .auto-style2 {
        color: #FFFFFF;
        text-align: right;
    }
    .auto-style3 {
        width: 705px;
    }
    .auto-style4 {
        color: #FF3300;
    }
    .auto-style5 {
        color: #FFFFFF;
        height: 26px;
    }
    .auto-style6 {
        width: 705px;
        height: 26px;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2 style="color: #FFFFFF">Randevu Ekleme</h2>
<p style="color: #FFFFFF">
    &nbsp;</p>
<table class="auto-style1">
    <tr>
        <td class="auto-style2">TC No. :</td>
        <td class="auto-style3"><asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" CssClass="auto-style4" ErrorMessage="RequiredFieldValidator">Boş Bırakılamaz</asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td class="auto-style2">İsim : </td>
        <td class="auto-style3">
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2" CssClass="auto-style4" ErrorMessage="RequiredFieldValidator">Boş Bırakılamaz</asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td class="auto-style2">Soyisim : </td>
        <td class="auto-style3">
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBox3" CssClass="auto-style4" ErrorMessage="RequiredFieldValidator">Boş Bırakılamaz</asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td class="auto-style2">İl : </td>
        <td class="auto-style3">
            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TextBox4" CssClass="auto-style4" ErrorMessage="RequiredFieldValidator">Boş Bırakılamaz</asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td class="auto-style2">İlçe : </td>
        <td class="auto-style3">
            <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="TextBox5" CssClass="auto-style4" ErrorMessage="RequiredFieldValidator">Boş Bırakılamaz</asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td class="auto-style2">Klinik : </td>
        <td class="auto-style3">
            <asp:TextBox ID="TextBox6" runat="server" OnTextChanged="TextBox6_TextChanged" Width="289px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="TextBox6" CssClass="auto-style4" ErrorMessage="RequiredFieldValidator">Boş Bırakılamaz</asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td class="auto-style2">Hastane : </td>
        <td class="auto-style3">
            <asp:TextBox ID="TextBox7" runat="server" Width="289px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="TextBox7" CssClass="auto-style4" ErrorMessage="RequiredFieldValidator">Boş Bırakılamaz</asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td class="auto-style2">Tarih : </td>
        <td class="auto-style3">
            <asp:TextBox ID="TextBox8" runat="server" Width="289px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="TextBox8" CssClass="auto-style4" ErrorMessage="RequiredFieldValidator">Boş Bırakılamaz</asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td class="auto-style5"></td>
        <td class="auto-style6">
            <asp:Button ID="Button1" runat="server" Text="Kaydet" Width="56px" />
            <br />
            <asp:Label ID="Label1" runat="server"></asp:Label>
        </td>
    </tr>
</table>
</asp:Content>
