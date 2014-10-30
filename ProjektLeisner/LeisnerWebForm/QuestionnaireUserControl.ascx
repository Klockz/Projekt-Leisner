﻿<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="QuestionnaireUserControl.ascx.cs" Inherits="LeisnerWebForm.QuestionnaireUserControl" %>

<h1>BedWetter Questionnaire</h1>
<asp:Table ID="Table1" runat="server">
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

