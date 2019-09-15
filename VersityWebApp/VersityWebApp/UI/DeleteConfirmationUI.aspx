<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DeleteConfirmationUI.aspx.cs" Inherits="VersityWebApp.UI.DeleteConfirmationUI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 60px;
        }
        .auto-style2 {
            height: 23px;
        }
        .auto-style3 {
            width: 60px;
            height: 23px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td>
                        <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label>
                    </td>
                    <td class="auto-style1">
                        <asp:Label ID="nameLabel" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label3" runat="server" Text="RegNo"></asp:Label>
                    </td>
                    <td class="auto-style1">
                        <asp:Label ID="regNoLabel" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="Label5" runat="server" Text="Contact"></asp:Label>
                    </td>
                    <td class="auto-style3">
                        <asp:Label ID="contactLabel" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label7" runat="server" Text="Email"></asp:Label>
                    </td>
                    <td class="auto-style1">
                        <asp:Label ID="emailLabel" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label9" runat="server" Text="Department"></asp:Label>
                    </td>
                    <td class="auto-style1">
                        <asp:Label ID="departmentLabel" runat="server"></asp:Label>
                    </td>
                </tr>
            </table>
            <br />
            <asp:Label ID="Label11" runat="server" Text="Do You Really Want To Delete This Student Information"></asp:Label>
            <br />
            <br />
            <asp:Button ID="deleteButton" runat="server" Text="Delete" OnClick="deleteButton_Click" />
            <asp:Button ID="cancelButton" runat="server" Text="Cancel" OnClick="cancelButton_Click" />
           
        </div>
    </form>
</body>
</html>
