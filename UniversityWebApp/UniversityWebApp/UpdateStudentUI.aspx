<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpdateStudentUI.aspx.cs" Inherits="UniversityWebApp.UpdateStudentUI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <div>
            <table>
                <tr>
                    <td>
                        <asp:Label ID="regNoLabel" runat="server" Text="Registation No"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="registationNoTextBox" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td></td>
                    <td>
                        <asp:Button ID="searchButton" runat="server" Text="Search" OnClick="searchButton_Click" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="nameLabel" runat="server" Text="Name"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="nameTextBox" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="contactLabel" runat="server" Text="Contact No"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="contactTextBox" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="emailLabel" runat="server" Text="Email"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="emailTextBox" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="departmentLabel" runat="server" Text="Depertment"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="departmentTextBox" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>
                        <asp:Button ID="registerButton" runat="server" Text="Register" OnClick="registerButton_Click" />
                    </td>
                </tr>
            </table>
            <br />
            <asp:Label ID="messageLabel" runat="server" Text="EYES HERE"></asp:Label> 
        </div>
        </div>
    </form>
</body>
</html>
