<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Eksamen1.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

</head>
<body>

    <form id="form1" runat="server">
        <asp:GridView ID="ElevGridView" runat="server" ></asp:GridView>
        <asp:Button ID="VisAlleElever" runat="server" Text="Vis alle elever" OnClick="VisAlleElever_Click" />
    </form>
</body>
</html>
