<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>StudyBuddy</title>
    <link href="BuddyStyles.css" rel="stylesheet" />
    <style type="text/css">
        .newStyle1 {
            color: #FFFFFF;
            font-weight: bolder;
            font-family: "Arial Black";
            border-style: outset;
        }
    </style>
</head>
<body>
    <div id ="PageWrapper">
        <header>
            <h1 style="background-color: #6699FF" class="newStyle1">Welcome to Study Buddy</h1>
        </header>
        <aside>
            <p>Other people on line will show here.</p>
        </aside>
        <form id="form1" runat="server">
            <asp:ScriptManager ID="ScriptManager1" runat="server">
                <Scripts>
                    <asp:ScriptReference Path="~/Scripts/jquery-2.0.3.min.js" />
                </Scripts>
                <Services>
                    <asp:ServiceReference Path="~/WebServices/ChatService.svc" />
                </Services>
            </asp:ScriptManager>
        <div id="AsideLeft">
            <p>Please log in below</p>
                Name:  <input id="txtName"/>
            <br />
            <br />
            Message:
            <br />
            <textarea id="txtMessage"></textarea>
            <br />
            <br />
            <input id="btnSend" type="button" value="Send" onclick="chatMessage();" />
            <br />
            <br />
            <textarea id="lblChat"></textarea>
            <script type="text/javascript">
               
                  function chatMessage()
                  {
                      var name = $('#txtName').val();
                      var message = $('#txtMessage').val();
                      ChatService.GetChat(name, message, getMessageCallback);
                      //for testing
                      //alert(name + message);
                  }
                
                function getMessageCallback(result)
                {
                    $('#lblChat').text(result + '\r\n');
                    //document.getElementById('lblChat').value += result + '\r\n';
                }
                
            </script>
            
        </div>
            <div class ="MainContent">
                <asp:ImageButton ID="ImageButton1" runat="server" Height="100px" ImageUrl="~/Pictures/Notecard.jpg" OnClick="ImageButton1_Click1" />
                <a href="AddNewCards.aspx">Create a new set of note cards</a><br /><br />
                <asp:ImageButton ID="ImageButton2" runat="server" OnClick="ImageButton2_Click" Height="100px" ImageUrl="~/Pictures/review.png" />
                <a href="ExistingSets.aspx">Use an already existing set of note cards</a><br /><br />
                <asp:ImageButton ID="ImageButton3" runat="server" Height="100px" ImageUrl="~/Pictures/pvp.gif" />
                <a href="PvP.aspx">Play against another player</a>
            </div>
        </form>
            
        <footer>
            <p><a href="About.aspx">About</a>&nbsp;&nbsp;&nbsp; <a href="Help.aspx">Help</a> <a href="ContactUs.aspx">Contact Us</a></p>
        </footer>
    </div>
</body>
</html>
