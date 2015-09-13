<%@ Page Language="C#" AutoEventWireup="true" Title="Detention Calculator" CodeBehind="Default.aspx.cs" Inherits="DetentionCalculatorWeb.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h3>Detention Calculator</h3>
            <table>
                <tr>
                    <td>StudentName</td>
                    <td>
                        <asp:TextBox ID="txtStudentName" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Offenses</td>
                    <td>
                        <asp:ListBox ID="lstOffenses" SelectionMode="Multiple" runat="server"></asp:ListBox></td>
                </tr>
                <tr>
                    <td>Student Time</td>
                    <td>
                        <asp:RadioButton GroupName="StudentName" runat="server" ID="rdbGoodTime" Text="Good Time" Checked="true" />
                        <asp:RadioButton GroupName="StudentName" runat="server" ID="rdbBadTime" Text="Bad Time" />
                    </td>
                </tr>
                <tr>
                    <td>Calculation Mode</td>
                    <td>
                        <asp:RadioButton GroupName="calculationMode" runat="server" ID="rdbConcurrentMode" Text="Concurrent Mode" Checked="true" />
                        <asp:RadioButton GroupName="calculationMode" runat="server" ID="rdbConsecutiveMode" Text="Consecutive Mode" />
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Button runat="server" ID="btnCalculate" Text="Calculate" OnClick="btnCalculate_Click" /></td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Label runat="server" ID="lblSuccess" ForeColor="Green" />
                        <asp:Label runat="server" ID="lblFailure" ForeColor="Red" /></td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
