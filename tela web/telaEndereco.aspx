<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="telaEndereco.aspx.cs" Inherits="tela_web.telaEndereco" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            ID:<asp:TextBox ID="TxtId" runat="server" Width="45px"></asp:TextBox>
            <br />
            <br />
            Logradouro:
            <asp:TextBox ID="TxtLogradouro" runat="server" Width="416px"></asp:TextBox>
&nbsp;Numero:
            <asp:TextBox ID="TxtNumero" runat="server" Width="42px"></asp:TextBox>
&nbsp;CEP:<asp:TextBox ID="TxtCep" runat="server"></asp:TextBox>
            <br />
            <br />
            Bairro:
            <asp:TextBox ID="TxtBairro" runat="server" Width="261px"></asp:TextBox>
&nbsp;Cidade:
            <asp:TextBox ID="TxtCidade" runat="server" Width="127px"></asp:TextBox>
&nbsp;Estado:
            <asp:TextBox ID="TxtEstado" runat="server" Width="234px"></asp:TextBox>
            <br />
            <br />
            <asp:ListBox ID="lbAgenda" runat="server" Width="850px"></asp:ListBox>
            <br />
            <br />
            <asp:Button ID="btnConsulta" runat="server" Text="Consulta" OnClick="btnConsulta_Click" />
            <asp:Button ID="btnInserir" runat="server" Text="Inserir" OnClick="btnInserir_Click" />
            <asp:Button ID="btnAltera" runat="server" Text="Altera" OnClick="btnAltera_Click" />
            <asp:Button ID="btnExcluir" runat="server" Text="Excluir" OnClick="btnExcluir_Click" />
            <br />
        </div>
    </form>
</body>
</html>
