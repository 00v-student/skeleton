<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 100px">
    <form id="form1" runat="server">
        
        <div>
        </div>
        <p>
        <asp:Label ID="lblOrderNumber" runat="server" style="z-index: 1; left: 24px; top: 108px; position: absolute" Text="OrderNumber"></asp:Label>
        <asp:TextBox ID="txtOrderNumber" runat="server" style="z-index: 1; top: 105px; position: absolute; margin-bottom: 0px; left: 200px;" width="188"></asp:TextBox>
        <asp:TextBox ID="txtOrderDate" runat="server" style="z-index: 1; left: 200px; top: 153px; position: absolute" width="188px"></asp:TextBox>
        <asp:Label ID="lblOrderDate" runat="server" style="z-index: 1; left: 24px; top: 152px; position: absolute; width: 134px;" Text="Order Date" height="27px"></asp:Label>
        <asp:Label ID="lblOrderDescription" runat="server" height="27px" style="z-index: 1; left: 24px; top: 197px; position: absolute; width: 179px" Text="Order Description"></asp:Label>
        <asp:Label ID="lblOrderTotal" runat="server" height="27px" style="z-index: 1; left: 24px; top: 244px; position: absolute" Text="Order Total" width="134px"></asp:Label>
        <asp:Label ID="lblCustomerID" runat="server" height="27px" style="z-index: 1; left: 24px; top: 294px; position: absolute" Text="Customer ID" width="134px"></asp:Label>
        <asp:Label ID="lblStaffName" runat="server" height="27px" style="z-index: 1; left: 24px; top: 341px; position: absolute" Text="Staff Name" width="134px"></asp:Label>
        <asp:TextBox ID="txtOrderDescription" runat="server" style="z-index: 1; left: 200px; top: 198px; position: absolute" width="188px"></asp:TextBox>
        <asp:TextBox ID="txtOrderTotal" runat="server" style="z-index: 1; left: 200px; top: 244px; position: absolute" width="188px"></asp:TextBox>
        <asp:TextBox ID="txtCustomerID" runat="server" style="z-index: 1; left: 200px; top: 298px; position: absolute" width="188px" OnTextChanged="txtCustomerID_TextChanged"></asp:TextBox>
        <asp:TextBox ID="txtStaffName" runat="server" style="z-index: 1; left: 200px; top: 346px; position: absolute" width="188px" OnTextChanged="txtStaffName_TextChanged"></asp:TextBox>
        <asp:CheckBox ID="chkOrderComplete" runat="server" style="z-index: 1; left: 24px; top: 392px; position: absolute" Text="Order Complete" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 24px; top: 437px; position: absolute"></asp:Label>
        <p>
            &nbsp;</p>
            <asp:Button ID="btnOk" runat="server" OnClick="btnOk_Click" style="z-index: 1; left: 17px; top: 474px; position: absolute" Text="Ok" />
        </p>
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 76px; top: 475px; position: absolute" Text="Cancel" />
        <asp:Button ID="btnFind"  runat="server" style="z-index: 1; left: 413px; top: 106px; position: absolute" Text="Find" OnClick="btnFind_Click" />
        <p>
            &nbsp;</p>
        
    </form>
</body>
</html>
