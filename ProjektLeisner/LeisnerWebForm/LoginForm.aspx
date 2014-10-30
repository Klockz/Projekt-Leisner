<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginForm.aspx.cs" Inherits="LeisnerWebForm.LoginForm" %>
<%@ Register Src="~/LoginUserControl.ascx" TagPrefix="LoginUserControl" TagName="LoginTag" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
            <div id="main" align="center">
            <asp:Image runat="server" ImageAlign="Middle" ImageUrl="~/Images/bg-top.jpg"/>
            <div id="userControl">
                <LoginUserControl:LoginTag runat="server"/>
            </div>
        </div>
    </form>
</body>
</html>
