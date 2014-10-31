<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="LeisnerWebForm.Default" %>
<%@ Register Src="~/Header.ascx" TagPrefix="HeaderUserControl" TagName="HeaderTag" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Leisner - Login</title>
    <link href="StyleSheets\LeisnerStyle.css" rel="Stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div id="main" align="center">
            <HeaderUserControl:HeaderTag runat="server" />
            <div id="content" align="center">
                <asp:Login ID="LoginControl" runat="server" UserNameLabelText="Email:" UserNameRequiredErrorMessage="Email is required."
                    OnAuthenticate="LoginControl_Authenticate" OnLoggingIn="LoginControl_LoggingIn">
                    <LoginButtonStyle CssClass="buttondefaultorange" />
                </asp:Login>
                <asp:Label ID="ErrorMessage" runat="server" ForeColor="Red" Text=""></asp:Label>
            </div>
        </div>
    </form>
</body>
</html>
