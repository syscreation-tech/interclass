<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Gabriel_TCM.Ac"%>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Sistema de Login</h1>
        </div>
        <div>
            <table>
                <tr>
                    <td>
                        <asp:Label runat="server" ID ="lblLogin" Text="Login:" Font-Bold ="true"></asp:Label>
                    </td>
                    <td>
                         <asp:TextBox runat="server" ID="txtLogin" Width="150px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label runat="server" ID ="lblSenha" Text="Senha:" Font-Bold ="true"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox runat="server" ID="txtSenha" TextMode="Password" Width="150px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td></td>
                    <td>
                        <asp:Button runat="server" ID="btnLogar" text="Logar" OnClick="btnLogar_Click" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
