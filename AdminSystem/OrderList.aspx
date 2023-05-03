<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 100px">









    <form id="form1" runat="server">
        <asp:ListBox ID="lstOrderList" runat="server" Height="504px" Width="412px"></asp:ListBox>
        <p>
        <asp:Button ID="btnAdd" runat="server" Text="Add" OnClick="Button1_Click" style="height: 35px" />
            <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" Text="Edit" />
            <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" Text="Delete" />
        </p>
        <p>
            &nbsp;</p>
        <p>
            Enter a Order Description&nbsp;
            <asp:TextBox ID="txtEnterDesc" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="btnApply" runat="server" OnClick="btnApply_Click" Text="Apply" />
            <asp:Button ID="btnClear" runat="server" OnClick="btnClear_Click" Text="Clear" />
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="lblError" runat="server" Text="Error"></asp:Label>
        </p>
    </form>









    </body>
</html>
