<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="QuestionnairePage.aspx.cs" Inherits="LeisnerWebForm.QuestionnairePage" %>
<%@ Register Src="~/Header.ascx" TagPrefix="HeaderUserControl" TagName="HeaderTag" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Leisner - Questionnaire</title>
    <link href="StyleSheets\LeisnerStyle.css" rel="Stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div id="main" align="center">
            <HeaderUserControl:HeaderTag runat="server" />
            <div id="content" align="left">
                <h1>BedWetter Questionnaire</h1>
                <asp:Table ID="Table1" runat="server">
                    <asp:TableRow>
                        <asp:TableCell>Patient:</asp:TableCell>
                        <asp:TableCell><asp:DropDownList ID="patientDropDown" runat="server"/></asp:TableCell></asp:TableRow><asp:TableRow>
                        <asp:TableCell>Date:</asp:TableCell><asp:TableCell><asp:TextBox ID="dateTextBox" runat="server"/>
                            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" ForeColor="Red" runat="server" ErrorMessage="Date must be entered in format: YYYY-MM-DD (ex. 2014-10-31)" ControlToValidate="dateTextBox" ValidationExpression="^(19|20)\d\d[- /.](0[1-9]|1[012])[- /.](0[1-9]|[12][0-9]|3[01])$"></asp:RegularExpressionValidator> </asp:TableCell>
                    </asp:TableRow>
                </asp:Table>
                <p />
                <h2>WetBed incidents:</h2>
                <asp:Panel ID="wetBedIncidentsPanel" runat="server" />
                <asp:Button CssClass="buttondefaultgreen" ID="addWetBedIncidentButton" runat="server" Text="Add new incident" OnClick="addWetBedIncident_Click" />
                <p />
                <h2>Toilet visits:</h2>
                <asp:Panel ID="toiletVisitsPanel" runat="server" />
                <asp:Button CssClass="buttondefaultgreen" ID="addToiletVisitButton" runat="server" Text="Add new visit" OnClick="addToiletVisit_Click"/>
                <p />
                <asp:Table ID="Table2" runat="server">
                    <asp:TableRow>
                        <asp:TableCell>Motivation:</asp:TableCell>
                        <asp:TableCell>
                            <asp:DropDownList ID="motivationDropDown" runat="server">
                                <asp:ListItem Value="1" />
                                <asp:ListItem Value="2" />
                                <asp:ListItem Value="3" />
                                <asp:ListItem Value="4" />
                                <asp:ListItem Value="5" />
                                <asp:ListItem Value="6" />
                                <asp:ListItem Value="7" />
                                <asp:ListItem Value="8" />
                                <asp:ListItem Value="9" />
                                <asp:ListItem Value="10" />
                            </asp:DropDownList>
                        </asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow>
                        <asp:TableCell>Comment:</asp:TableCell>
                        <asp:TableCell><asp:TextBox ID="commentTextBox" runat="server" Height="100" Width="350" /></asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow>
                        <asp:TableCell>Please contact?</asp:TableCell>
                        <asp:TableCell><asp:CheckBox ID="contactCheckBox" runat="server" /></asp:TableCell>
                    </asp:TableRow>
                </asp:Table>
                <p />
                <asp:Button CssClass="buttondefaultorange" ID="submitQuestionnairButton" runat="server" Text="Submit Questionnaire" OnClick="submitQuestionnaire_Click" />
            </div>
        </div>
    </form>
</body>
</html>
