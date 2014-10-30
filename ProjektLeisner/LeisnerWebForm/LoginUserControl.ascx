<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="LoginUserControl.ascx.cs" Inherits="LeisnerWebForm.LoginUserControl" %>

<asp:Login ID="LoginControl" runat="server" UserNameLabelText="Email:" UserNameRequiredErrorMessage="Email is required." OnAuthenticate="LoginControl_Authenticate" OnLoggingIn="LoginControl_LoggingIn">
</asp:Login>



<asp:Label ID="ErrorMessage" runat="server" ForeColor="Red" Text=""></asp:Label>



