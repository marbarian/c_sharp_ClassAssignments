<%@ Page Language="C#" AutoEventWireup="true" CodeFile="About.aspx.cs" Inherits="About" %>
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
        
        <div class="MainContent">
            <form id="form1" runat="server">
                <asp:ScriptManager ID="ScriptManager1" runat="server">
                    <Scripts>
                        <asp:ScriptReference Path="~/Scripts/jquery-2.0/3.min.js" />
                    </Scripts>
                    <Services>
                        <asp:ServiceReference Path="~/WebServices/ChatService.svc" />
                    </Services>
                </asp:ScriptManager>
                <nav>
                    <asp:Menu ID="Menu1" runat="server" DataSourceID="SiteMapDataSource1" Orientation="Horizontal" StaticEnableDefaultPopOutImage="False"></asp:Menu>
                    
                    <asp:SiteMapDataSource ID="SiteMapDataSource1" runat="server" ShowStartingNode="False" />
                    
                <h4>SiteMapPath</h4>
                <asp:SiteMapPath ID="SiteMapPath1" runat="server" Font-Names="Verdana" Font-Size="Medium" PathSeparator=" : ">
                    <CurrentNodeStyle ForeColor="#333333" />
                    <NodeStyle Font-Bold="True" ForeColor="#666666" />
                    <PathSeparatorStyle Font-Bold="True" ForeColor="#1C5E55" />
                    <RootNodeStyle Font-Bold="True" ForeColor="#1C5E55" />
                </asp:SiteMapPath>
                    
                </nav>
                
                <h1>All about this site</h1>
                <h3>Play a Game</h3>
                <br />
                <h4>Tree</h4><asp:TreeView ID="TreeView2" runat="server" DataSourceID="SiteMapDataSource2" ShowLines="True"></asp:TreeView>

                <asp:SiteMapDataSource ID="SiteMapDataSource2" runat="server" ShowStartingNode="False" />

                

            </form>
        </div>
    </div>
</body>
</html>
