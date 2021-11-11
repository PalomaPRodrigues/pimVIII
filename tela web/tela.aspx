<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="tela.aspx.cs" Inherits="tela_web.tela" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            ID:<asp:TextBox ID="TxtID" runat="server" Width="165px"></asp:TextBox>
            <br />
            <br />
            Nome:<asp:TextBox ID="TxtNome" runat="server" Width="253px"></asp:TextBox>
            &nbsp;
            Cpf:<asp:TextBox ID="TxtCpf" runat="server" Width="184px"></asp:TextBox>
            <br />
            <br />
            Endereco:<asp:TextBox ID="TxtEndereco" runat="server" Width="230px"></asp:TextBox>
            &nbsp;&nbsp;
            Telefone:<asp:TextBox ID="TxtTelefone" runat="server" style="margin-top: 9px" Width="151px"></asp:TextBox>
            <br />
            <br />
        </div>
        <asp:Button ID="btnConsulte" runat="server" Text="Consultar" OnClick="btnConsulte_Click" />
        <asp:Button ID="btnInsira" runat="server" Text="Inserir" OnClick="btnInsira_Click" />
        <asp:Button ID="btnAltere" runat="server" Text="Alterar" OnClick="btnAltere_Click" />
        <asp:Button ID="btnExclua" runat="server" Text="Excluir" OnClick="btnExclua_Click" />
        <br />
        <br />
        <asp:ListBox ID="lbAgenda" runat="server" Width="532px"></asp:ListBox>
    </form>
</body>
</html>
