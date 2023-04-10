<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblStaffID" runat="server" Text="Staff ID" width="149px"></asp:Label>
        <asp:TextBox ID="txtStaffID" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="lblName" runat="server" Text="Name" width="149px"></asp:Label>
            <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
        </p>
        <asp:Label ID="lblHireDate" runat="server" Text="Hire Date" width="149px"></asp:Label>
        <asp:TextBox ID="txtHireDate" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="lblDepartment" runat="server" Text="Department" width="149px"></asp:Label>
        <asp:TextBox ID="txtDepartment" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblContactNumber" runat="server" Text="Contact Number" width="149px" TabIndex="1"></asp:Label>
            <asp:TextBox ID="txtContactNumber" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:CheckBox ID="chkWeekendAvailability" runat="server" Text="Weekend Availability" />
        </p>
        <asp:Label ID="lblError" runat="server"></asp:Label>
        <p>
            <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
        </p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
