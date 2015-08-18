<%@ Page Language="C#" AutoEventWireup="true" CodeFile="frmMain.aspx.cs" Inherits="frmMain" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body text="V">
    <form id="form1" runat="server">
    <div align="center">
    
        <asp:Image ID="Image1" runat="server" 
            ImageUrl="~/Images/CoolBiz_Productions_logo.JPG" />
        <br />
        <br />
        <asp:ImageButton ID="ImageButton1" runat="server" Height="70px" 
            ImageUrl="~/Images/calculator_img.jpg" 
            PostBackUrl="~/frmSalaryCalculator.aspx" Width="80px" />
        <asp:LinkButton ID="LinkButton1" runat="server" 
            PostBackUrl="~/frmSalaryCalculator.aspx">Salary Calculator</asp:LinkButton>
        <br />
        <asp:ImageButton ID="ImageButton2" runat="server" Height="70px" 
            ImageUrl="~/Images/employees_img.jpg" PostBackUrl="~/frmPersonnel.aspx" 
            Width="80px" />
        <asp:LinkButton ID="LinkButton2" runat="server" 
            PostBackUrl="~/frmPersonnel.aspx">Add New Employee</asp:LinkButton>
        <br />
        <asp:ImageButton ID="ImageButton3" runat="server" Height="70px" 
            ImageUrl="~/Images/activity_img.jpg" PostBackUrl="~/frmUserActivity.aspx" 
            Width="80px" />
        <asp:LinkButton ID="LinkButton3" runat="server" 
            PostBackUrl="~/frmUserActivity.aspx">View User Activity</asp:LinkButton>
        <br />
        <asp:ImageButton ID="ImageButton4" runat="server" Height="70px" 
            ImageUrl="~/Images/personnel_img.jpg" PostBackUrl="~/frmViewPersonnel.aspx" 
            Width="80px" />
        <asp:LinkButton ID="LinkButton4" runat="server" 
            PostBackUrl="~/frmViewPersonnel.aspx">View Personnel</asp:LinkButton>
        <br />
        <asp:ImageButton ID="ImageButton5" runat="server" Height="70px" 
            ImageUrl="~/Images/search_img.jpg" PostBackUrl="~/frmSearchPersonnel.aspx" 
            Width="80px" />
        <asp:LinkButton ID="LinkButton5" runat="server" 
            PostBackUrl="~/frmSearchPersonnel.aspx">Search Personnel</asp:LinkButton>
        <br />
        <asp:ImageButton ID="ImageButton6" runat="server" Height="70px" 
            ImageUrl="~/Images/edit_img.jpg" Width="80px" 
            PostBackUrl="~/frmEditPersonnel.aspx" />
        <asp:LinkButton ID="LinkButton6" runat="server" 
            PostBackUrl="~/frmEditPersonnel.aspx">Edit Employees</asp:LinkButton>
        <br />
    
    </div>
    </form>
</body>
</html>
