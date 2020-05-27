<%@ Page Title="" Language="C#" MasterPageFile="~/masterPage.Master" AutoEventWireup="true" CodeBehind="Weight.aspx.cs" Inherits="UnitesWebConverter_Nabeel_Mahdee.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p style="text-align: center; color: #CC0000">
    &nbsp;</p>
<p style="text-align: center">
    Pound&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="txtBoxPound" runat="server"></asp:TextBox>
    </p>
<p style="text-align: center">
    &nbsp;&nbsp;
    Gram&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; : &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="txtBoxGram" runat="server"></asp:TextBox>
    </p>
<p style="text-align: center">
    Kilogram&nbsp;&nbsp;&nbsp;&nbsp; : &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="txtBoxKilogram" runat="server"></asp:TextBox>
    </p>
<p style="text-align: center">
    &nbsp;</p>
<p style="text-align: center">
    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Convert" style="height: 26px" />
    &nbsp;&nbsp;
    <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Reset" />
    </p>
<p style="text-align: center">
    &nbsp;</p>
<p style="text-align: center">
    <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Go to Length Converter page</asp:LinkButton>
    </p>
    <br />
</asp:Content>
