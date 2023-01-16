<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Add.aspx.cs" Inherits="CRUD.Add" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            First Name -
            <asp:TextBox ID="txtFname" runat="server"></asp:TextBox>
            <br />
            Last Name -
            <asp:TextBox ID="txtLname" runat="server"></asp:TextBox>
            <br />
            Student ID -
            <asp:TextBox ID="txtID" runat="server"></asp:TextBox>
            <br />
            Birth Date -
            <asp:TextBox ID="txtDOB" runat="server"></asp:TextBox>
&nbsp;<br />
            Email Id&nbsp;&nbsp;&nbsp; -
            <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
        </div>
        <asp:Button ID="insert" runat="server" OnClick="insert_Click" Text="Insert" />
        <asp:Button ID="delete" runat="server" OnClick="delete_Click" Text="Delete" />
        <asp:Button ID="update" runat="server" OnClick="update_Click" Text="Update" />
    </form>
</body>
</html>
