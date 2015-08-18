<%@ Page Language="C#" AutoEventWireup="true" CodeFile="frmUserActivity.aspx.cs" Inherits="frmUserActivity" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div align="center">
    
        <asp:ImageButton ID="ImageButton1" runat="server" 
            ImageUrl="~/Images/CoolBiz_Productions_logo.JPG" PostBackUrl="~/frmMain.aspx" />
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="User Activity"></asp:Label>
        <br />
        <br />
        <asp:GridView ID="grdUserActivity" runat="server" 
            onselectedindexchanged="grdUserActivity_SelectedIndexChanged">
        </asp:GridView>
    
    </div>
    </form>
</body>
</html>
