<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ResStatus.aspx.cs" Inherits="WCF_Consume_ASPNET.ResStatus" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            PNR Number : <asp:TextBox runat="server" ID="txtPNRNumber"></asp:TextBox>
            <br />
            <asp:Button runat="server" ID="btnSubmit" Text="Submit" OnClick="btnSubmit_Click" />
            <br /><br />
            <asp:Label runat="server" ID="lblMsg"></asp:Label>
        </div>
    </form>
</body>
</html>
