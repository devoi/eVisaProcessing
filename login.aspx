<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="eVisaProcessing.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>E-Visa | Login</title>
</head>
<body style="margin:0 auto;text-align:center;">
    <h3>E-Visa Processing</h3>
    <br />
    <br />
    <br />
    <form id="form1" runat="server">
        <div>
            <h4>Login</h4>
            <asp:Label ID="Label1" runat="server" Text="Username"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            <br />
            <span>Login as:</span>&nbsp;&nbsp;&nbsp;
            <asp:RadioButton ID="RadioButton1" runat="server" Text="Admin" GroupName="role" OnCheckedChanged="RadioButton1_CheckedChanged" />
&nbsp;&nbsp;
            <asp:RadioButton ID="RadioButton2" runat="server" Text="HR" GroupName="role" OnCheckedChanged="RadioButton2_CheckedChanged" />
&nbsp;&nbsp;
            <asp:RadioButton ID="RadioButton3" runat="server" Text="Employee" GroupName="role" OnCheckedChanged="RadioButton3_CheckedChanged" />
            <br />
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" Text="Login" BackColor="#009900" Font-Size="Large" OnClick="Button1_Click" />
            <br />
            <br />

        </div>
    </form>
</body>
</html>
