<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PvP.aspx.cs" Inherits="PvP" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="BuddyStyles.css" rel="stylesheet" />
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
    </style>
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
                <h3>PvP Arena</h3>
                <h5>After being answered, box will contain an X or an O</h5><br />

                <asp:UpdatePanel runat="server">
                    <ContentTemplate>
                        <asp:Panel ID="Panel1" runat="server">
                    <div class ="right">
                        <asp:Label ID="lblQuestion" runat="server" Visible ="False" Width="250px"></asp:Label> <br />
                        <asp:TextBox ID="txtAnswer" runat="server" Visible ="false" Height="50px" Width="250px" EnableViewState="False"></asp:TextBox>
                        <asp:Button ID="btnEnter" runat="server" Text="Enter" Visible ="false" EnableViewState="False" OnClick="btnEnter_Click1"/>
                        <asp:TextBox ID="txtSecret" runat="server" Visible ="false"></asp:TextBox>
                    </div>
                    <asp:ImageButton ID="q00" runat="server" Height="150px" OnClick="q00_Click"   />
                    <asp:ImageButton ID="q01" runat="server" Height="150px"  OnClick="q00_Click" />
                    <asp:ImageButton ID="q02" runat="server" Height="150px" OnClick="q00_Click" /><br />
                    <asp:ImageButton ID="q10" runat="server" Height="150px"  OnClick="q00_Click" />
                    <asp:ImageButton ID="q11" runat="server" Height="150px" OnClick="q00_Click" />
                    <asp:ImageButton ID="q12" runat="server" Height="150px"  OnClick="q00_Click"/><br />
                    <asp:ImageButton ID="q20" runat="server" Height="150px"  OnClick="q00_Click" />
                    <asp:ImageButton ID="q21" runat="server" Height="150px"  OnClick="q00_Click"/>
                    <asp:ImageButton ID="q22" runat="server" Height="150px"  OnClick="q00_Click" />
               
                </asp:Panel>

                    </ContentTemplate>
                </asp:UpdatePanel>
                

                
               
            </div>
        </form>
    </div>
    
</body>
</html>
