<%@ Page Language="C#" AutoEventWireup="true" CodeFile="frmPersonnel.aspx.cs" Inherits="frmPersonnel" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div align="center">
    
        <asp:ImageButton ID="ImageButton2" runat="server" 
            ImageUrl="~/Images/CoolBiz_Productions_logo.JPG" PostBackUrl="~/frmMain.aspx" />
        <br />
        <br />    

    <asp:Panel ID="Panel1" runat="server" Height="270px" Width="300px" 
            DefaultButton="btnSubmit">
    <div align="left" style="width:450px">
        <asp:Label ID="Label1" runat="server" Text="First Name:" Width="80px"></asp:Label>
        <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
            ControlToValidate="txtFirstName" ErrorMessage="First Name is required"></asp:RequiredFieldValidator>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Last Name:" Width="80px"></asp:Label>
        <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
            ControlToValidate="txtLastName" ErrorMessage="Last Name is required"></asp:RequiredFieldValidator>
        <br />
        <asp:Label ID="Label3" runat="server" Text="Pay Rate:" Width="80px"></asp:Label>
        <asp:TextBox ID="txtPayRate" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
            ControlToValidate="txtPayRate" ErrorMessage="Pay Rate is required"></asp:RequiredFieldValidator>
        <br />
        <asp:Label ID="Label4" runat="server" Text="Start Date:" Width="80px"></asp:Label>
        <asp:TextBox ID="txtStartDate" runat="server"></asp:TextBox>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
            ControlToValidate="txtStartDate" ErrorMessage="Enter date in mm/dd/yyyy format" 
            ValidationExpression="^(((0[1-9]|[12]\d|3[01])\/(0[13578]|1[02])\/((19|[2-9]\d)\d{2}))|((0[1-9]|[12]\d|30)\/(0[13456789]|1[012])\/((19|[2-9]\d)\d{2}))|((0[1-9]|1\d|2[0-8])\/02\/((19|[2-9]\d)\d{2}))|(29\/02\/((1[6-9]|[2-9]\d)(0[48]|[2468][048]|[13579][26])|((16|[2468][048]|[3579][26])00))))$"></asp:RegularExpressionValidator>
        <br />
        <asp:Label ID="Label5" runat="server" Text="End Date:" Width="80px"></asp:Label>
        <asp:TextBox ID="txtEndDate" runat="server"></asp:TextBox>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" 
            ControlToValidate="txtEndDate" ErrorMessage="Enter date in mm/dd/yyyy format" 
            ValidationExpression="^(((0[1-9]|[12]\d|3[01])\/(0[13578]|1[02])\/((19|[2-9]\d)\d{2}))|((0[1-9]|[12]\d|30)\/(0[13456789]|1[012])\/((19|[2-9]\d)\d{2}))|((0[1-9]|1\d|2[0-8])\/02\/((19|[2-9]\d)\d{2}))|(29\/02\/((1[6-9]|[2-9]\d)(0[48]|[2468][048]|[13579][26])|((16|[2468][048]|[3579][26])00))))$"></asp:RegularExpressionValidator>
        </div>
        <br />
        <asp:Button ID="btnSubmit" runat="server" Text="Submit" 
            onclick="btnSubmit_Click" />
        <asp:Button ID="btnCancel" runat="server" Text="Cancel" 
            PostBackUrl="~/frmMain.aspx" ValidationGroup="personnelCancelBtn" />
        <br />
        <asp:Label ID="lblError" runat="server" ForeColor="Red"></asp:Label>
        <br />
        <asp:Label ID="lblErrorInformation" runat="server" ForeColor="#FF9900"></asp:Label>
        <br />
        <asp:Button ID="Button1" runat="server" PostBackUrl="~/frmViewPersonnel.aspx" 
            Text="View Personnel" ValidationGroup="personnelViewBtn" />
        <br />
        <asp:Button ID="Button2" runat="server" PostBackUrl="~/frmEditPersonnel.aspx" 
            Text="Edit Personnel" ValidationGroup="personnelEditBtn" />
    </asp:Panel>
    </div>
    </form>
</body>
</html>
