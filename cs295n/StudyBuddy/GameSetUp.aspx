<%@ Page Language="C#" AutoEventWireup="true" CodeFile="GameSetUp.aspx.cs" Inherits="GameSetUp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="BuddyStyles.css" rel="stylesheet" />
</head>
<body>
    <div id="PageWrapper">
        <form id="form1" runat="server">
            <asp:ScriptManager ID="ScriptManager1" runat="server">
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
                <h2>This page will hold the options for the game.</h2>
            </div>
        </form>
    </div>
</body>
</html>
