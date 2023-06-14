<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Demo._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

          <br />
       <asp:Label Text="Enter Department to add" runat="server" /><asp:TextBox ID="DeptTB" runat="server" />
       <asp:Button ID="Button2" runat="server" Text="Add Dept" OnClick="Button2_Click" />
        

   

</asp:Content>
