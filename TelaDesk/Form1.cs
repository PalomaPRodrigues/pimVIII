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
    public partial class Form1 : Form
    {
        private Gerenciador gerenciador;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gerenciador = new Gerenciador(BancoDeDados.sqlServer);
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            List<Pessoa> pessoas;
            if (txtId.Text.Equals(""))
            {
                pessoas = gerenciador.dao.Consulte();
            }
            else
            {
                pessoas = gerenciador.dao.Consulte(txtId.Text);
            }
            lbCadastro.Items.Clear();
            foreach (Pessoa p in pessoas)
            {
                    lbCadastro.Items.Add(p.ToString());
                
            }
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            Pessoa p = new Pessoa();
            p.id = Convert.ToInt16(txtId.Text);
            p.nome = txtNome.Text;
            p.cpf = Convert.ToInt32(txtCpf.Text);
            p.endereco = txtEndereco.Text;
            p.telefone = Convert.ToInt32(txtTelefone.Text);
            gerenciador.dao.insira(p);
            txtId.Text = "";
            txtNome.Text = "";
            txtCpf.Text = "";
            txtEndereco.Text = "";
            txtTelefone.Text = "";
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Pessoa p = new Pessoa();
            p.id = Convert.ToInt32(txtId.Text);
            p.nome = txtNome.Text;
            p.cpf = Convert.ToInt32(txtCpf.Text);
            p.endereco = txtEndereco.Text;
            p.telefone = Convert.ToInt32(txtTelefone.Text);
            gerenciador.dao.Altere(p);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Pessoa p = new Pessoa();
            p.id = Convert.ToInt32(txtId.Text);
            p.nome = txtNome.Text;
            p.cpf = Convert.ToInt32(txtCpf.Text);
            p.endereco = txtEndereco.Text;
            p.telefone = Convert.ToInt32(txtTelefone.Text);
            gerenciador.dao.Exclua(p);
        }
    }
}
