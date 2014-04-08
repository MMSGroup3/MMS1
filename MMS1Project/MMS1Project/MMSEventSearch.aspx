<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MMSEventSearch.aspx.cs" Inherits="MMS1Project.MMSEventSearch" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        This screen is to search for Events
    </div>
        <asp:RadioButton ID="rdbSimpleSearch" runat="server" Text="Simple Search" GroupName="SearchType" />
        <asp:RadioButton ID="rdbRankedSearch" runat="server" Text="Ranked Search" GroupName="SearchType" />
        <div>
        <asp:Label ID="lblKeyword">Keyword: </asp:Label><asp:TextBox ID="txtKeyword" runat="server"></asp:TextBox>
            <br />
            <br />
            <br />
            <br />
            <asp:Button ID="btnSubmit" runat="server" Text="Search" OnClick="btnSubmit_Click" />
        </div>
        <asp:DataGrid ID="grdEvents" runat="server" ></asp:DataGrid>
    </form>
</body>
</html>
