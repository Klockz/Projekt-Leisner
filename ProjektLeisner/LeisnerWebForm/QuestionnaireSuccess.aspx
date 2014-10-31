<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="QuestionnaireSuccess.aspx.cs" Inherits="LeisnerWebForm.QuestionnaireSuccess" %>
<%@ Register Src="~/Header.ascx" TagPrefix="HeaderUserControl" TagName="HeaderTag" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Leisner - Questionnaire submitted</title>
    <link href="StyleSheets\LeisnerStyle.css" rel="Stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div id="main" align="center">
        <HeaderUserControl:HeaderTag ID="HeaderTag1" runat="server" />
        <div id="content" align="center">
    Questionnaire was succesfully submitted.
        </div>
    </div>
    </form>
</body>
</html>
