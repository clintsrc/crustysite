<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewData.aspx.cs" Inherits="crustysite.ViewData" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form_output" runat="server">
        <div>
        <asp:GridView ID="GridViewUser" AutogenerateColumns="true" runat="server">
        </asp:GridView>
        </div>
    </form>
</body>
</html>
