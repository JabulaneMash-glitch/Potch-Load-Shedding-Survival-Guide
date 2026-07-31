<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Info.aspx.cs" Inherits="FirstOpp2024.Info" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
        <style type="text/css">
            .auto-style1 {
                width: 538px;
                height: 441px;
            }
            .auto-style2 {
                height: 441px;
            }
        </style>
        <h1 style="text-align: center">Potchesfstroom Load Shedding Survival Guide</h1>
</head>
<body style="background-color: #FFFF66">
    <form id="form1" runat="server">
        <div>
        </div>
    <table style="width: 100%; height: 340px;">
        <tr>
            <td class="auto-style1">
                <asp:Label ID="lblNameOut" runat="server" Font-Size="X-Large"></asp:Label>
                <br />
                <br />
                <asp:Label ID="lblZoneOut" runat="server"></asp:Label>
                <br />
                <br />
                <br />
                <asp:Label ID="lblDate" runat="server"></asp:Label>
                <br />
                <asp:Label ID="lblTime" runat="server" Text="Label"></asp:Label>
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="btnHome" runat="server" BackColor="Aqua" Height="39px" OnClick="btnHome_Click" Text="Home" Width="160px" />
                <br />
            </td>
            <td class="auto-style2">
                <br />
                <asp:Label ID="Label5" runat="server" Text="Select Date to see future forecast:"></asp:Label>
                <asp:Calendar ID="Calendar1" runat="server" BackColor="#FFFFCC" BorderColor="#FFCC66" BorderWidth="1px" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="#663399" Height="275px" ShowGridLines="True" Width="303px">
                    <DayHeaderStyle BackColor="#FFCC66" Font-Bold="True" Height="1px" />
                    <NextPrevStyle Font-Size="9pt" ForeColor="#FFFFCC" />
                    <OtherMonthDayStyle ForeColor="#CC9966" />
                    <SelectedDayStyle BackColor="#CCCCFF" Font-Bold="True" />
                    <SelectorStyle BackColor="#FFCC66" />
                    <TitleStyle BackColor="#990000" Font-Bold="True" Font-Size="9pt" ForeColor="#FFFFCC" />
                    <TodayDayStyle BackColor="#FFCC66" ForeColor="White" />
                </asp:Calendar>
            </td>
            <td class="auto-style2"></td>
        </tr>
       
    </table>
    &nbsp;&nbsp;&nbsp;
        <div style="margin-left: 160px">
        </div>
    </form>
    </body>
</html>
