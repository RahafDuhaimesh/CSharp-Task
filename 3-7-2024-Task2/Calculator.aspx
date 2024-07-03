<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Calculator.aspx.cs" Inherits="_3_7_2024_Task2.Calculator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Simple Calculator</title>
    <link rel="stylesheet" href="Calculator.css"/>
    <style type="text/css">
        .operator {
            margin-top: 0px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <center>
            <div id="form">
                <br />
                <asp:Label ID="Label2" runat="server" Text="Please enter the first number : "></asp:Label>
                <asp:TextBox ID="Text1" runat="server" Height="40px" style="margin-left: 9px" Width="189px"></asp:TextBox><br />
                <asp:Label ID="Label3" runat="server" Text="Please enter the second number : "></asp:Label>
                <asp:TextBox ID="Text2" runat="server" Height="42px" Width="205px"></asp:TextBox><br /><br />
                <asp:Button ID="BtnAdd" runat="server" Text="+" OnClick="BtnAdd_Click" CssClass="operator" Height="29px" Width="38px" />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="BtnMultiply" runat="server" Text="*" OnClick="BtnMultiply_Click" CssClass="operator" Height="33px" Width="33px" />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="BtnDivide" runat="server" Text="/" OnClick="BtnDivide_Click" CssClass="operator" Height="32px" Width="36px" />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="BtnSubtract" runat="server" Text="-" OnClick="BtnSubtract_Click" CssClass="operator" Height="36px" Width="35px" />
                <br />
                <br />
                <asp:Label ID="Label1" runat="server" Text="Result : "></asp:Label>
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            </div>
        </center>
    </form>
</body>
</html>
