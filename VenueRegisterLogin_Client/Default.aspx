<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login/Register</title>
</head>
<body>
    <h1>Login or Register</h1>
    <form id="form1" runat="server">
        <hr />
        <div>
            <table>
                <tr>
                    <td>User Name</td>
                    <td>
                        <asp:TextBox ID="userTextBox" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Password</td>
                    <td>
                        <asp:TextBox ID="passTextBox" TextMode="Password" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="loginButton" runat="server" Text="Login" OnClick="loginButton_Click" />
                    </td>
                    <td>
                        <asp:Label ID="errorLabel" runat="server" Text=""></asp:Label></td>
                </tr>
            </table>
            <asp:LinkButton ID="RegisterLink" runat="server" PostBackUrl="Register.aspx">Register</asp:LinkButton>


        </div>
    </form>
</body>
</html>
