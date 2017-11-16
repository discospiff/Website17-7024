<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ReadXML.aspx.cs" Inherits="WebService.ReadXML" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Submit your Plant XML"></asp:Label>
            <br />
            <asp:FileUpload ID="XMLFileUpload" runat="server" />
            <br />
            <asp:Button ID="Button1" runat="server" CssClass="button" OnClick="Button1_Click" Text="Submit" />
            <br />
            <asp:Label ID="LblStatus" runat="server" Text="No File Selected"></asp:Label>
            <br />
            <asp:Button ID="BtnConvertWebService" runat="server" OnClick="BtnConvertWebService_Click" Text="Convert 250 Meters to Inches" />
        </div>
    </form>
</body>
</html>
