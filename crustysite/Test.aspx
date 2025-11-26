<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Test.aspx.cs" Inherits="crustysite.Test" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
      <asp:Label ID="Name" runat="server">Name</asp:Label>
      <asp:Textbox ID="NameTxt" runat="server"></asp:Textbox>
      <br/>
      <asp:Label ID="Email" runat="server">Email</asp:Label>
      <asp:Textbox ID="EmailTxt" runat="server"></asp:Textbox>
        <!-- Client-side validation -->
          <asp:RegularExpressionValidator
              ID="valEmail"
              ControlToValidate="EmailTxt"
              ErrorMessage="Invalid email format"
              ForeColor="Red"
              ValidationExpression="^[^@\s]+@[^@\s]+\.[^@\s]+$"
              Display="Dynamic"
              runat="server" />
      <br/>
      <asp:Label ID="Password" runat="server">Password</asp:Label>
      <asp:Textbox ID="PasswordTxt" TextMode="Password" runat="server"></asp:Textbox>
      <p>
         <asp:Button ID="Submit" runat="server" OnClick="Submit_Click" Text="Submit"/>
      <p/>
      <asp:Label ID="Output" runat="server"></asp:Label>
    </form>
</body>
</html>
