<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Send.aspx.cs" Inherits="CsReverseAjax.Send" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="lblTo" runat="server" Text="To:" />
        <asp:TextBox ID="txtTo" runat="server" /><br />
        <asp:Label ID="lblMessage" runat="server" Text="Message:" />
        <asp:TextBox ID="txtMessage" runat="server" /><br />
        <asp:Button ID="btnSend" runat="server" OnClick="btnSend_Click" Text="Send message" />
    </div>
    </form>
</body>
</html>
