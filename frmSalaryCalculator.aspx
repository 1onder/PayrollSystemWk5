<%@ Page Language="C#" AutoEventWireup="true" CodeFile="frmSalaryCalculator.aspx.cs" Inherits="frmSalaryCalculator" %>

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
    
        <asp:Label ID="Label1" runat="server" Text="Annual Hours:" Width="100px"></asp:Label>
        <asp:TextBox ID="txtAnnualHours" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Rate:" Width="100px"></asp:Label>
        <asp:TextBox ID="txtRate" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
            Text="Calculate Salary" />
        <br />
        <br />
        <asp:Label ID="lblSalary" runat="server" Text="$"></asp:Label>
    
    </div>
    </form>
</body>
</html>
