<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebServerControls.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            width: 1251px;
            height: 824px;
        }
    </style>
</head>
<body style="height: 885px; width: 1434px; margin-bottom: 642px">
    <form id="form1" runat="server">
        Information<p>
            User Name</p>
        <asp:TextBox ID="TextBox1" runat="server" MaxLength="12"></asp:TextBox>
        <br />
        <br />
        <asp:CheckBox ID="CheckBoxAdmin" runat="server" OnCheckedChanged="CheckBox1_CheckedChanged" Text="System Administrator" />
        <br />
        <br />
        Aplication Role<br />
        <br />
        <asp:RadioButton ID="RadioButton1" runat="server" Text="User" />
        <asp:RadioButton ID="RadioButton2" runat="server" Text="Manager" />
        <asp:RadioButton ID="RadioButton3" runat="server" Text="Director" />
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Save" />
        <br />
    </form>
</body>
</html>
