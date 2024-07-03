<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DataLoginPage.aspx.cs" Inherits="_3_7_2024_Task1.DataLoginPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
        <link rel="stylesheet" href="LoginForm.css"/>

</head>
<body>
    <form id="form1" runat="server">
        <div>
              <center>
        <div id="form" style="background-color: #C0C0C0">
            <h2>Your Data !</h2>
            <asp:Label ID="LabelName" runat="server" Text=""></asp:Label><br />
            <asp:Label ID="LabelEmail" runat="server" Text=""></asp:Label><br />
            <asp:Label ID="LabelID" runat="server" Text=""></asp:Label><br />
            <asp:Label ID="LabelGender" runat="server" Text=""></asp:Label><br />
            <asp:Label ID="LabelCourses" runat="server" Text=""></asp:Label><br />
            <asp:Label ID="LabelDescription" runat="server" Text=""></asp:Label><br />
        </div>
        <p>&nbsp;</p>
        <p>&nbsp;</p>
        </center>
        </div>
    </form>
</body>
</html>
