<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="_2doParcialASPNET.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>5. Con java/tomcat (JSP) y C# (ASPNET), genere la función Fibonacci.</h2>
            <h3>Con C# ASP.NET</h3>
            <h3>Nombre: Galo Osvaldo Pocoma Mamani</h3>
            <h4>Numeros a generar: </h4>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <div>
                <asp:Button ID="ButtonCS" runat="server" OnClick="ButtonCS_Click" Text="Genera numeros con C#" />
                <br />
            </div>

        </div>
        
        
    </form>
    <div class="table">
        <asp:Table ID="Table1" runat="server"
            CellPadding="10"
            HorizontalAlign="Center">
            <asp:TableRow>
                <asp:TableHeaderCell>Fibonacci</asp:TableHeaderCell>
            </asp:TableRow>
            
        </asp:Table>
    </div>
</body>
</html>