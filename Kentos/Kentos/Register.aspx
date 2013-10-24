<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="Kentos.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        First Name:
        <asp:TextBox ID="txtFname" runat="server"></asp:TextBox>
        <br />
        Surname: <asp:TextBox ID="txtSname" runat="server"></asp:TextBox>
        <br />
        DOB: <asp:TextBox ID="txtDOB" runat="server"></asp:TextBox>
        <br />
        Address Line 1: <asp:TextBox ID="txtAdd1" runat="server"></asp:TextBox>
        <br />
        Address Line 2: <asp:TextBox ID="txtAdd2" runat="server"></asp:TextBox>
        <br />
        Address Line 3: <asp:TextBox ID="txtAdd3" runat="server"></asp:TextBox>
        <br />
        County: <asp:TextBox ID="txtCounty" runat="server"></asp:TextBox>
        <br />
        Username: <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
        <br />
        Password: <asp:TextBox ID="txtPassword" TextMode="Password" runat="server"></asp:TextBox>
        <br />
        Confirm Password: <asp:TextBox ID="txtCPassword" TextMode="Password" runat="server"></asp:TextBox>
        <br />
        Email: <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
        <br />
        Confirm Email: <asp:TextBox ID="txtCEmail" runat="server"></asp:TextBox>
    
        <br />
        <br />
        <asp:Button ID="btnRegister" runat="server" Text="Register" OnClick="btnRegister_Click" />
    
    </div>
    </form>
</body>
</html>
