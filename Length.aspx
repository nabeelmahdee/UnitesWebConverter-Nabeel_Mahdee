<%@ Page Title="" Language="C#" MasterPageFile="~/masterPage.Master" AutoEventWireup="true" CodeBehind="Length.aspx.cs" Inherits="UnitesWebConverter_Nabeel_Mahdee.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
        .auto-style3 {
        color: #000000;
    }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p style="text-align: center">
        &nbsp;</p>
    <p class="auto-style1">
        <span class="auto-style3">Foot&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; :&nbsp;&nbsp;&nbsp;&nbsp; </span> <asp:TextBox ID="txtBoxFoot" runat="server"></asp:TextBox>
    </p>
    <p class="auto-style1">
        <span class="auto-style3">Kilometer&nbsp;&nbsp;&nbsp; :&nbsp;&nbsp;&nbsp;&nbsp; </span> <asp:TextBox ID="txtBoxKilometer" runat="server"></asp:TextBox>
    </p>
    <p class="auto-style1">
        <span class="auto-style3">Meter&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; :&nbsp;</span>&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="txtBoxMeter" runat="server"></asp:TextBox>
    </p>
    <p style="text-align: center">
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Convert" />
    &nbsp;<asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Reset" />
    </p>
    <p style="text-align: center">
        &nbsp;</p>
    <p style="text-align: center">
        <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Go to weight converter page</asp:LinkButton>
    </p>
    <p style="text-align: center">
        &nbsp;</p>
    <p style="text-align: center">
        &nbsp;</p>
</asp:Content>
