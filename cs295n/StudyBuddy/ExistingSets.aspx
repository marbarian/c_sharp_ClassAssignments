<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ExistingSets.aspx.cs" Inherits="ExistingSets" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Question Sets</title>
    <link href="BuddyStyles.css" rel="stylesheet" />
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            text-align: center;
        }
        </style>
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
    <h3>This is where you will pick the list of note cards you would like to be quizzed on</h3>
    
    
        <br />
        <table class="auto-style1">
            <tr>
                <th>Programming</th>
                <th>Networking</th>
                <th>Vocabuly Builder</th>
                <th>Not so Trivial Pursuit</th>
            </tr>
            <tr>
                <td class="auto-style2">c#</td>
                <td class="auto-style2">Hardware</td>
                <td class="auto-style2">Level 1</td>
                <td class="auto-style2">To boldly go . . . </td>
            </tr>
            <tr>
                <td class="auto-style2">PHP</td>
                <td class="auto-style2">Software</td>
                <td class="auto-style2">Level 2</td>
                <td class="auto-style2">80&#39;s Dance Party</td>
            </tr>
            <tr>
                <td class="auto-style2">JavaScript</td>
                <td class="auto-style2">Wiring</td>
                <td class="auto-style2">Level 3</td>
                <td class="auto-style2">Random</td>
            </tr>
        </table>
    
    
    </div>
    </form>
    </div>
    
</body>
</html>
