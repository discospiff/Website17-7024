<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GetPlants.aspx.cs" Inherits="WebService.GetPlants" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="BtnReadPlants" runat="server" OnClick="BtnReadPlants_Click" Text="Read Plants" />
        </div>
    </form>
</body>
</html>
