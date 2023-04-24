<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="lblError" runat="server">
        <div>
        </div>
        <asp:ListBox ID="lstStockList" runat="server" Height="80px" OnSelectedIndexChanged="lstStockList_SelectedIndexChanged" Width="128px"></asp:ListBox>
        <p>
            <asp:Button ID="BtnAdd" runat="server" OnClick="BtnAdd_Click" Text="Add" />
            <asp:Button ID="BtnDelete" runat="server" Text="Delete" OnClick="BtnDelete_Click" />
            <asp:Button ID="BtnEdit" runat="server" Text="Edit" OnClick="BtnEdit_Click" />
        </p>
        <p id="lblError">
            <asp:Label ID="Label1" runat="server" Text="Enter type"></asp:Label>
            <asp:TextBox ID="txttypearea" runat="server"></asp:TextBox>
            <asp:Button ID="Apply" runat="server" OnClick="Button2_Click" Text="Apply" />
            <asp:Button ID="clr" runat="server" OnClick="clr_Click" Text="clear" />
        </p>
        <p>
            <asp:Label ID="lblError0" runat="server"></asp:Label>
        </p>
    </form>
</body>
</html>
