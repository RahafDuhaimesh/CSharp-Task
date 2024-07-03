<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginForm.aspx.cs" Inherits="_3_7_2024_Task1.LoginForm" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login Form</title>
    <link rel="stylesheet" href="LoginForm.css" />
</head>
<body>
    <form id="form1" runat="server">
        <center>
            <div id="form" style="background-color: #C0C0C0">

                <%--Name--%>

                <asp:Label ID="Label1" runat="server" Text="Name" ForeColor="#0033CC"></asp:Label>
                &nbsp;&nbsp;
            <asp:TextBox ID="Text1" runat="server" /><br />
                <br />

                <%--Email--%>

                <asp:Label ID="Label2" runat="server" Text="Email" ForeColor="#0033CC"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="Text2" runat="server" /><br />
                <br />

                <%--ID--%>

                <asp:Label ID="Label3" runat="server" Text="ID" ForeColor="#0033CC"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="Text3" runat="server" /><br />
                <br />

                <%--Gender--%>

                <asp:Label ID="Label4" runat="server" Text="Gender" ForeColor="#0033CC"></asp:Label>
                &nbsp;<asp:RadioButton ID="RadioButton1" runat="server" OnCheckedChanged="RadioButton1_CheckedChanged" Text="Female" GroupName="Gender" AutoPostBack="true" />
                <asp:RadioButton ID="RadioButton2" runat="server" Text="Male" GroupName="Gender" />
                <br />
                <br />

                <%--Courses--%>

                <asp:Label ID="Label5" runat="server" Text="Courses" ForeColor="#0033CC"></asp:Label>
                &nbsp;<asp:CheckBox ID="CheckBox1" runat="server" Text="C" />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:CheckBox ID="CheckBox3" runat="server" Text="C++" />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:CheckBox ID="CheckBox2" runat="server" Text="C#" />
                <br />
                <br />

                <%--Description--%>

                <asp:Label ID="Label6" runat="server" Text="Description" ForeColor="#0033CC"></asp:Label>
                &nbsp;&nbsp;
            <asp:TextBox ID="TextBox1" runat="server" Height="100px" Width="403px" TextMode="MultiLine"></asp:TextBox>
                <br />
                <br />

                <%--Button--%>

                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" BackColor="#0033CC" ForeColor="White" />
            </div>
            <p>&nbsp;</p>
            <p>&nbsp;</p>
        </center>
    </form>
</body>
</html>
