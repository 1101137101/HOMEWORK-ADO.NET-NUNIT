<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="WebApplication1.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        輸入您的年齡：
        <asp:TextBox ID="txtAge" runat="server" Width="66px"></asp:TextBox>
        
        歲
        
        <asp:Button ID="btnCal" runat="server" Text="計算" OnClick="btnCal_Click" />

        <br />
        您是 

        <asp:DropDownList ID="ddlYearFormat" runat="server">
            <asp:ListItem Value="W">西元</asp:ListItem>
            <asp:ListItem Value="C">民國</asp:ListItem>
        </asp:DropDownList>
        <asp:Label ID="lblYear" runat="server" Text=""></asp:Label>年 出生
    </div>
    </form>
</body>
</html>
