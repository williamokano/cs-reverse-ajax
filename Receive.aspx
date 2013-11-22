<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Receive.aspx.cs" Inherits="CsReverseAjax.Receive" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div id="divSetNick" runat="server">
            <asp:Label ID="lblReceiver" Text="Receiver" runat="server" />
            <asp:TextBox ID="txtReceiver" runat="server" /><br />
            <asp:Button ID="btnSetReceiverName" runat="server" Text="Set name" OnClick="btnSetReceiverName_Click" />
        </div>
        <div id="divReceive" runat="server" visible="false">
            <asp:ScriptManager AsyncPostBackTimeout="2147483647" ID="sm1" runat="server">
                <Services>
                    <asp:ServiceReference Path="~/Sender.asmx" />
                </Services>
            </asp:ScriptManager>
            <script type="text/javascript">
                function reverseAjax() {
                    CsReverseAjax.Sender1.ReceiveMessage('<asp:Literal ID="ltrReceiver" runat="server" />',
                        function (response) {

                            anyFun(response);

                            //infinite loop to keep polling
                            setTimeout(reverseAjax, 0);
                        }, function () {
                            //infinite loop to keep polling
                            setTimeout(reverseAjax, 0);
                        });
                }
                
                function anyFun(message) {
                    document.getElementById("messages").innerHTML += message + "<br/>";
                }
            </script>
            <div id="messages"></div>
        </div>
    </form>
</body>
</html>
