<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="IndexUI.aspx.cs" Inherits="VersityWebApp.UI.IndexUI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:HyperLink ID="UpdateHyperLink" runat="server" NavigateUrl="~/UI/UpdateStudentUI.aspx">Update Page</asp:HyperLink>
            <br />
            <br />
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
                        <asp:DropDownList ID="departmentDropDownList" runat="server">
                        </asp:DropDownList>
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
        <br />
        <br />
        <div>
            <asp:GridView ID="studentsGridView" runat="server" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" ForeColor="Black" GridLines="Vertical" AutoGenerateColumns="False">
                <AlternatingRowStyle BackColor="#CCCCCC" />
                <Columns>
                    <asp:TemplateField  HeaderText="Registation Number">
                        <ItemTemplate>
                            <asp:Label runat="server" Id="testLabel" Text='<%#Eval("RegNo") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField  HeaderText="Student Name">
                        <ItemTemplate>
                            <asp:Label runat="server" Text='<%#Eval("StudentName") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField  HeaderText="Contact">
                        <ItemTemplate>
                            <asp:Label runat="server" Text='<%#Eval("ContactNo") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField  HeaderText="Email">
                        <ItemTemplate>
                            <asp:Label runat="server" Text='<%#Eval("Email") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField  HeaderText="Department Name">
                        <ItemTemplate>
                            <asp:Label runat="server" Text='<%#Eval("DeptName") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Action">
                        <ItemTemplate>
                            <asp:HyperLink NavigateUrl='<%#Eval("StudentId", "~/UI/UpdateStudentUI.aspx?id={0}") %>'  runat="server">Update</asp:HyperLink>
                            <asp:HyperLink NavigateUrl='<%#Eval("StudentId", "~/UI/DeleteConfirmationUI.aspx?id={0}") %>' runat="server">Delete</asp:HyperLink>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>

                <FooterStyle BackColor="#CCCCCC" />
                <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                <SortedAscendingHeaderStyle BackColor="#808080" />
                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                <SortedDescendingHeaderStyle BackColor="#383838" />
            </asp:GridView>
        </div>
    </form>
</body>
</html>
