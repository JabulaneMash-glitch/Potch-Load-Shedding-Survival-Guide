<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="FirstOpp2024._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 491px;
            height: 338px;
        }
        .auto-style2 {
            height: 338px;
        }
    </style>
    <h1 style="text-align: center">Potchesfstroom Load Shedding Survival Guide<asp:Image ID="Image1" runat="server" Height="149px" ImageUrl="~/Candles.jpg" Width="173px" />
    </h1>
</head>
<body style="background-color: #999999">
    <form id="form1" runat="server">
        <div>
        </div>
    <table style="width: 100%; height: 283px;">
        <tr>
            <td class="auto-style1">
                <asp:Label ID="Label1" runat="server" Text="Name:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="txtName" runat="server" Height="21px" Width="195px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtName" ErrorMessage="Required!!!" ForeColor="Red"></asp:RequiredFieldValidator>
                <br />
                <br />
                <asp:Label ID="Label2" runat="server" Text="Surname:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="txtSur" runat="server" Height="21px" Width="195px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtSur" ErrorMessage="Required!!!" ForeColor="Red"></asp:RequiredFieldValidator>
                <br />
                <br />
                <asp:Label ID="Label3" runat="server" Text="Email:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="txtEmail" runat="server" Height="21px" Width="195px"></asp:TextBox>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtEmail" ErrorMessage="Required!!!" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
            </td>
            <td class="auto-style2">
                <asp:RadioButton ID="rdbZone1" runat="server" GroupName="Zones" Text="Zone 1 - Central Business Distric" />
                <br />
                <br />
                <asp:RadioButton ID="rdbZone2" runat="server" GroupName="Zones" Text="Zone 2 - Van der Hoff Park" />
                <br />
                <br />
                <asp:RadioButton ID="rdbZone3" runat="server" GroupName="Zones" Text="Zone 3 - Bult Area &amp; University" />
                <br />
                <br />
                <asp:RadioButton ID="rdbZone4" runat="server" GroupName="Zones" Text="Zone 4 - Grimbeek Park &amp; Baillie" />
                <br />
                <br />
                <asp:RadioButton ID="rdbZone5" runat="server" GroupName="Zones" Text="Zone 5 - Mohadin and Promosa" />
                <br />
                <br />
                <asp:RadioButton ID="rdbZone6" runat="server" GroupName="Zones" Text="Zone 6 - Ikageng" />
                <br />
                <br />
                <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="btnSubmit" runat="server" BackColor="Aqua" Height="46px" Text="Submit" Width="166px" OnClick="btnSubmit_Click" />
            </td>
            <td class="auto-style2"></td>
        </tr>
        
    </table>
    </form>
    </body>
</html>
