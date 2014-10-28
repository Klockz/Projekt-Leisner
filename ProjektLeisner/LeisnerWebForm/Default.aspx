<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="LeisnerWebForm.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="StyleSheets\LeisnerStyle.css" rel="Stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div id="main">
        <h1>BedWetter Questionnaire</h1>
        <asp:Table runat="server">
            <asp:TableRow>
                <asp:TableCell>Patient:</asp:TableCell>
                <asp:TableCell><asp:Label ID="patientLabel" runat="server"/></asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>Date:</asp:TableCell>
                <asp:TableCell><asp:TextBox ID="dateTextBox" runat="server"/></asp:TableCell>
            </asp:TableRow>
        </asp:Table>
        <p />
        <h2>WetBed incidents:</h2>
        <asp:ListView ID="WetBedListView" runat="server">
            <LayoutTemplate>
                <table>
                    <tr>
                        <th>Time</th>
                        <th>Size</th>
                    </tr>
                    <tr id="itemPlaceHolder" runat="server" />
                 </table>
            </LayoutTemplate>
            <ItemTemplate>
                <tr>
                    <td><asp:Label runat="server"><%#Eval("Time") %></asp:Label></td>
                    <td><asp:Label runat="server"><%#Eval("Size") %></asp:Label></td>
                </tr>
            </ItemTemplate>
        </asp:ListView>
        <p />
        <asp:Table runat="server">
            <asp:TableRow>
                <asp:TableCell>Time:</asp:TableCell>
                <asp:TableCell><asp:TextBox ID="timeTextBox" runat="server"/></asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>Spot Size:</asp:TableCell>
                <asp:TableCell><asp:TextBox ID="sizeTextBox" runat="server"/></asp:TableCell>
            </asp:TableRow>
        </asp:Table>
        <p />
        <asp:Button CssClass="buttondefaultgreen" ID="createWetBedButton" runat="server" Text="Create WetBed Incident" OnClick="createWetBedButton_Click" />
        <p />
        <h2>Toilet visits:</h2>
        <asp:ListView ID="toiletVisitsListView" runat="server">
            <LayoutTemplate>
                <table>
                    <tr>
                        <th>Time</th>
                    </tr>
                    <tr id="itemPlaceHolder" runat="server" />
                 </table>
            </LayoutTemplate>
            <ItemTemplate>
                <tr>
                    <td><asp:Label ID="Label1" runat="server"><%#Eval("Time") %></asp:Label></td>
                </tr>
            </ItemTemplate>
        </asp:ListView>
        <p />
        <asp:Table runat="server">
            <asp:TableRow>
                <asp:TableCell>Time:</asp:TableCell>
                <asp:TableCell><asp:TextBox ID="TextBox1" runat="server"/></asp:TableCell>
            </asp:TableRow>
        </asp:Table>
        <p />
        <asp:Button CssClass="buttondefaultgreen" ID="createToiletVisitButton" runat="server" Text="Create Toilet Visit" />
        <p />
        <asp:Table runat="server">
            <asp:TableRow>
                <asp:TableCell>Motivation:</asp:TableCell>
                <asp:TableCell><asp:TextBox ID="motivationTextBox" runat="server"/></asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>Comment:</asp:TableCell>
                <asp:TableCell><asp:TextBox ID="commentTextBox" runat="server"/></asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>Please contact?</asp:TableCell>
                <asp:TableCell><asp:CheckBox ID="contactCheckBox" runat="server" /></asp:TableCell>
            </asp:TableRow>
        </asp:Table>
        <p />
        <asp:Button CssClass="buttondefaultorange" ID="submitQuestionnairButton" runat="server" Text="Submit Questionnaire" />
    </div>
    </form>
</body>
</html>
