<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:TextBox ID="txtSearch" runat="server" Width="100px"></asp:TextBox>
        &nbsp;<asp:Button ID="btnSearch" runat="server" OnClick="btnSearch_Click" Text="查詢" />
        <br />
        <asp:GridView ID="gvResult" runat="server" CellPadding="4" Width="464px" ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="White" />
            <EditRowStyle BackColor="#7C6F57" />
            <FooterStyle BackColor="#1C5E55" ForeColor="White" Font-Bold="True" />
            <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#E3EAEB" />
            <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F8FAFA" />
            <SortedAscendingHeaderStyle BackColor="#246B61" />
            <SortedDescendingCellStyle BackColor="#D4DFE1" />
            <SortedDescendingHeaderStyle BackColor="#15524A" />
        </asp:GridView>
        <hr />
        Name:<asp:TextBox ID="txtName" runat="server" Width="100px"></asp:TextBox>
        &nbsp;Gender:<asp:TextBox ID="txtGender" runat="server" Width="100px"></asp:TextBox>
        &nbsp;Age:<asp:TextBox ID="txtAge" runat="server" Width="100px"></asp:TextBox>
        &nbsp;<asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="新增" />


        <br />
        StudentID:<asp:TextBox ID="txtE_ID" runat="server" Width="100px"></asp:TextBox>
        &nbsp;Name:<asp:TextBox ID="txtE_Name" runat="server" Width="100px"></asp:TextBox>
        &nbsp;Gender:<asp:TextBox ID="txtE_Gender" runat="server" Width="100px"></asp:TextBox>
        &nbsp;Age:<asp:TextBox ID="txtE_Age" runat="server" Width="100px"></asp:TextBox>
        &nbsp;<asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" Text="修改" />


        <br />
        StudentID:<asp:TextBox ID="txtD_ID" runat="server" Width="100px"></asp:TextBox>
        &nbsp;<asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" Text="刪除" />


    </div>
    </form>
</body>
</html>
