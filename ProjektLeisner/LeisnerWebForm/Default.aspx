<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="LeisnerWebForm.Default" %>
<%@ Register Src="~/QuestionnaireUserControl.ascx" TagPrefix="QuestionnaireUserControl" TagName="QuestionnaireTag" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="StyleSheets\LeisnerStyle.css" rel="Stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div id="main" align="center">
            <asp:Image runat="server" ImageUrl="~/Images/bg-top.jpg"/>
            <div id="userControl" align="left">
                <QuestionnaireUserControl:QuestionnaireTag runat="server"/>
            </div>
        </div>
    </form>
</body>
</html>
