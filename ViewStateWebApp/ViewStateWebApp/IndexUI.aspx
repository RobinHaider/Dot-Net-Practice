<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="IndexUI.aspx.cs" Inherits="ViewStateWebApp.IndexUI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="nameLabel" runat="server" Text="Name"></asp:Label>
            <asp:TextBox ID="nameTextBox" runat="server"></asp:TextBox>
            <br />
            <br />
            <br />
            <asp:Button ID="saveButton" runat="server" Text="Save" OnClick="saveButton_Click" />
            <br />
            <br />
            <asp:Button ID="showButton" runat="server" Text="Show" OnClick="showButton_Click" />
            <br />
            <br />
            <asp:Label ID="displayNameLabel" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
