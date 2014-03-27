<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ContactUs.aspx.cs" Inherits="ContactUs" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="BuddyStyles.css" rel="stylesheet" />
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 371px;
            text-align: left;
        }
        .auto-style3 {
            width: 167px;
        }
        .auto-style4 {
            width: 167px;
            text-align: right;
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
    
        <table class="auto-style1">
            <tr>
                <td colspan="2" style="text-align: center"><h2>Please use the form below to contact us</h2></td>
            </tr>
            <tr>
                <td class="auto-style4">Name:</td>
                <td class="auto-style2">
                    <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtName" CssClass="ErrorMessage" ErrorMessage="Enter your name" Display="Dynamic">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">Email:</td>
                <td class="auto-style2">
                    <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtEmail" CssClass="ErrorMessage" ErrorMessage="Enter an email address" Display="Dynamic">*</asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtEmail" CssClass="ErrorMessage" ErrorMessage="Enter a valid e-mail address" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">Repeat E-mail:</td>
                <td class="auto-style2">
                    <asp:TextBox ID="txtRepeatEmail" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtRepeatEmail" CssClass="ErrorMessage" ErrorMessage="Repeat email address" Display="Dynamic">*</asp:RequiredFieldValidator>
                    <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txtEmail" ControlToValidate="txtRepeatEmail" CssClass="ErrorMessage" ErrorMessage="E-mail addresses must match"></asp:CompareValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">Contact Phone Number:</td>
                <td class="auto-style2">
                    <asp:TextBox ID="txtPhone" runat="server"></asp:TextBox>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="txtPhone" CssClass="ErrorMessage" ErrorMessage="RegularExpressionValidator" ValidationExpression="((\(\d{3}\) ?)|(\d{3}-))?\d{3}-\d{4}">Enter a valid phone number</asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">Age:</td>
                <td class="auto-style2">
                    <asp:TextBox ID="txtAge" runat="server" TextMode="Number"></asp:TextBox>
                    <asp:RangeValidator ID="RangeValidator1" runat="server" CssClass="ErrorMessage" ErrorMessage="Enter a valid age" MaximumValue="120" MinimumValue="5" ControlToValidate="txtAge" Type="Integer"></asp:RangeValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">Comments</td>
                <td class="auto-style2">
                    <asp:TextBox ID="txtComments" runat="server" Height="82px" Width="242px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtComments" CssClass="ErrorMessage" ErrorMessage="Enter Comments">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style2">
                    <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
                </td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style2">
                    <asp:Button ID="btnSend" runat="server" Text="Send" OnClick="btnSend_Click" />
                </td>
            </tr>
        </table>
    </form>

    </div>
    
</body>
</html>
