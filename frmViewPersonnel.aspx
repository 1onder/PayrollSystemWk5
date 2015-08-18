<%@ Page Language="C#" AutoEventWireup="true" CodeFile="frmViewPersonnel.aspx.cs" Inherits="frmViewPersonnel" %>

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
        Personnel<br />
        <br />
        <asp:GridView ID="grdViewPersonnel" runat="server">
        </asp:GridView>
    
    </div>
    </form>
</body>
</html>
