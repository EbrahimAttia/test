<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="test._Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Database Connection Test</h2>
    <p>Click the button below to test the connection to your MySQL database via XAMPP.</p>
   
    <div style="margin: 20px 0;">
        <asp:Button ID="btnTest" runat="server" Text="Test MySQL Connection" OnClick="BtnTest_Click" CssClass="btn btn-primary" />
    </div>

    <div class="alert alert-info">
        <p><strong>Result:</strong></p>
        <asp:Label ID="lblResult" runat="server" Text="Waiting to connect..."></asp:Label>
        <asp:Label ID="Label1" runat="server" Text="Waiting to connect..."></asp:Label>

        <asp:Label ID="Label2" runat="server" Text="Waiting to connect..."></asp:Label>

        <asp:Label ID="Label3" runat="server" Text="Waiting to connect..."></asp:Label>

        <asp:Label ID="Label4" runat="server" Text="Waiting to connect..."></asp:Label>


    </div>

    <div style="margin-top:20px">
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="true"
        CssClass="table table-bordered table-striped"></asp:GridView>
</div>


</asp:Content>