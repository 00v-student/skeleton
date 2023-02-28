<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="watchid" runat="server" Text="Watch ID" width="91px"></asp:Label>
            <asp:TextBox ID="txtWatchID" runat="server"></asp:TextBox>
         <br>   <asp:Label ID="desc" runat="server" Text="Description" width="91px"></asp:Label>
            <asp:TextBox ID="txtDesc" runat="server"></asp:TextBox>
         <br>  <asp:Label ID="price" runat="server" Text="Price" width="91px"></asp:Label>
            <asp:TextBox ID="txtPrice" runat="server"></asp:TextBox>
            <br><asp:Label ID="dateadd" runat="server" Text="Date added" width="91px"></asp:Label>
            <asp:TextBox ID="txtDateAdded" runat="server"></asp:TextBox>
           <br> <asp:Label ID="stock" runat="server" Text="Stock" width="91px"></asp:Label>
            <asp:TextBox ID="txtStock" runat="server"></asp:TextBox>
            <br><asp:Label ID="type" runat="server" Text="Type of Watch"></asp:Label>
            <asp:TextBox ID="txtType" runat="server"></asp:TextBox>
        </div>
        <asp:CheckBox ID="available" runat="server" Text="available" />
        <p>
            <asp:Label ID="lblError" runat="server"></asp:Label>
        </p>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" Width="39px" />
        <asp:Button ID="btnCancel" runat="server" style="margin-left: 31px" Text="cancel" />
    </form>
</body>
</html>
