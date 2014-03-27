<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AddNewCards.aspx.cs" Inherits="AddNewCards" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="BuddyStyles.css" rel="stylesheet" />
</head>
<body>
    <div id="PageWrapper">
        <aside>
            <p>Other people on line will show here.</p>
        </aside>
        <form id="form1" runat="server">
            <asp:ScriptManager ID="ScriptManager1" runat="server">
                <Scripts>
                    <asp:ScriptReference Path="~/Scripts/jquery-2.0/3.min.js" />
                </Scripts>
                <Services>
                    <asp:ServiceReference Path="~/WebServices/ChatService.svc" />
                </Services>
            </asp:ScriptManager>
            <div class ="MainContent">
                <h3>This is where you will add new cards</h3>
                <p>&nbsp;</p>
                Subject: <br />
                <asp:TextBox ID="Subject" runat="server"></asp:TextBox> <br /><br />
                <div class="Card">
                    Question: <br />
                    <asp:TextBox ID="Question" runat="server" Height="83px" Width="488px"></asp:TextBox> 
                    <br />
                    Answer:  <br />
                    <asp:TextBox ID="Answer" runat="server" Height="41px" Width="485px"></asp:TextBox> <br /><br />
                    <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
                </div>
                <p>&nbsp;</p>
                <p>&nbsp;</p>

             </div>
        </form>
    </div>
    
</body>
</html>
