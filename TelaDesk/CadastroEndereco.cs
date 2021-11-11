using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using aplicativoMVC.Controllers;
using aplicativoMVC.Models;

namespace TelaDesk
{
    public partial class CadastroEndereco : Form
    {
        private Gerenciador gerenciador;
        public CadastroEndereco()
        {
            InitializeComponent();
        }

        private void CadastroEndereco_Load(object sender, EventArgs e)
        {
            gerenciador = new Gerenciador(BancoDeDados.sqlServer);
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            List<Endereco> enderecos;
            if (txtId.Text.Equals(""))
            {
                enderecos = gerenciador.dao.Consulta();
            }
            else
            {
                enderecos = gerenciador.dao.Consulta(txtId.Text);
            }
            lbCadastroEndereco.Items.Clear();
            foreach(Endereco p in enderecos)
            {
                lbCadastroEndereco.Items.Add(p.ToString());
            }
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            Endereco p = new Endereco();
            p.id = Convert.ToInt32(txtId.Text);
            p.logradouro = txtLogradouro.Text;
            p.numero = Convert.ToInt32(txtNumero.Text);
            p.cep = Convert.ToInt32(txtCep.Text);
            p.bairro = txtCep.Text;
            p.cidade = txtCidade.Text;
            p.estado = txtEstado.Text;
            gerenciador.dao.inserir(p);
            txtId.Text = "";
            txtLogradouro.Text = "";
            txtNumero.Text = "";
            txtCep.Text = "";
            txtBairro.Text = "";
            txtCidade.Text = "";
            txtEstado.Text = "";
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Endereco p = new Endereco();
            p.id = Convert.ToInt32(txtId.Text);
            p.logradouro = txtLogradouro.Text;
            p.numero = Convert.ToInt32(txtNumero.Text);
            p.cep = Convert.ToInt32(txtCep.Text);
            p.bairro = txtCep.Text;
            p.cidade = txtCidade.Text;
            p.estado = txtEstado.Text;
            gerenciador.dao.Altera(p);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Endereco p = new Endereco();
            p.id = Convert.ToInt32(txtId.Text);
            p.logradouro = txtLogradouro.Text;
            p.numero = Convert.ToInt32(txtNumero.Text);
            p.cep = Convert.ToInt32(txtCep.Text);
            p.bairro = txtCep.Text;
            p.cidade = txtCidade.Text;
            p.estado = txtEstado.Text;
            gerenciador.dao.Excluir(p);
        }
    }
}
