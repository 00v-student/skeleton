<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="R u sure u wanna delete the record?"></asp:Label>
        </div>
        <asp:Button ID="yes" runat="server" Text="Im sure" OnClick="yes_Click" />
        <asp:Button ID="no" runat="server" style="margin-left: 39px" Text="No" Width="57px" OnClick="no_Click" />
    </form>
</body>
</html>
