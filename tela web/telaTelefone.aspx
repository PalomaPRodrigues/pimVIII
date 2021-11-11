<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="telaTelefone.aspx.cs" Inherits="tela_web.telaTelefone" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            ID:<asp:TextBox ID="TxtId" runat="server" Width="55px"></asp:TextBox>
            <br />
            <br />
            Ddd:<asp:TextBox ID="TxtDdd" runat="server" Width="48px"></asp:TextBox>
&nbsp; Numero:
            <asp:TextBox ID="TxtNumero" runat="server"></asp:TextBox>
&nbsp;TipoTelefone:
            <asp:TextBox ID="TxtTipoTelfone" runat="server"></asp:TextBox>
            <br />
            <br />
            <br />
            <asp:ListBox ID="lbAgenda" runat="server" Width="887px"></asp:ListBox>
            <br />
            <br />
            <asp:Button ID="btnConsultar" runat="server" Text="Consultar" OnClick="btnConsultar_Click" />
            <asp:Button ID="btnInserir" runat="server" Text="Inserir" OnClick="btnInserir_Click" />
            <asp:Button ID="btnAlterar" runat="server" Text="Alterar" OnClick="btnAlterar_Click" />
            <asp:Button ID="btnExclue" runat="server" Text="Exclue" OnClick="btnExclue_Click" />
        </div>
    </form>
</body>
</html>
