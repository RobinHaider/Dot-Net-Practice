<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="IndexUI.aspx.cs" Inherits="ListBoxWebApp.IndexUI" %>

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
            <asp:Button ID="saveButton" runat="server" OnClick="saveButton_Click" Text="Save" />
            <br />
            <br />
            <asp:Button ID="showAllButton" runat="server" OnClick="showAllButton_Click" Text="Show All Names" />
            <br />
            <br />
            <br />
            <asp:ListBox ID="showAllNamesListBox" runat="server" Height="211px" Width="245px"></asp:ListBox>
            <br />
            <br />
            <asp:Label ID="itemCountLabel" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
