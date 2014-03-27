<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StudySession.aspx.cs" Inherits="StudySession" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="BuddyStyles.css" rel="stylesheet" />
</head>
<body>
    <div id="PageWrapper">
        <form id="form1" runat="server">
            <asp:ScriptManager ID="ScriptManager2" runat="server">
                    <Scripts>
                        <asp:ScriptReference Path="~/Scripts/jquery-2.0/3.min.js" />
                    </Scripts>
                    <Services>
                        <asp:ServiceReference Path="~/WebServices/ChatService.svc" />
                    </Services>
                </asp:ScriptManager>
        <aside>
            <p>Other people on line will show here.</p>
        </aside>
        
            <div class="MainContent">
                <h3>Notecards will show here and can be flipped over and moved to a done piles <br />
                    One for correct and one for incorrect.</h3>
                <div class="Card">
                    <asp:TextBox ID="txtCard" class="user_input" runat="server" Height="205px" Width="487px"  Enabled ="false">Question Here</asp:TextBox>
                </div>
                <asp:Button ID="btnFlip" runat="server" Text="Flip Card" OnClick="btnFlip_Click" />
            </div>
        </form>
    </div>
</body>
</html>
