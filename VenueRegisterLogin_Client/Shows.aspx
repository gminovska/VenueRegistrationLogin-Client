﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Shows.aspx.cs" Inherits="Shows" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Welcome to your Portal</h1>
        <h2>Click on the link below to add shows</h2>
     <asp:LinkButton ID="ShowsLink" runat="server" PostBackUrl="Shows.aspx">Add Shows</asp:LinkButton>
    </div>
    </form>
</body>
</html>
