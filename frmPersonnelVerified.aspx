<%@ Page Language="C#" AutoEventWireup="true" CodeFile="frmPersonnelVerified.aspx.cs" Inherits="frmPersonnelVerified" %>

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
        <asp:Label ID="Label1" runat="server" Text="Information to Submit"></asp:Label>
        <br />
        <asp:TextBox ID="txtVerifiedInfo" runat="server" Height="80px" 
            TextMode="MultiLine" Width="400px"></asp:TextBox>
    
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" PostBackUrl="~/frmViewPersonnel.aspx" 
            Text="View Personnel" />
    
    </div>
    </form>
</body>
</html>
