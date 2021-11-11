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
    public partial class CadastroTelefone : Form
    {
        private Gerenciador gerenciador;
        public CadastroTelefone()
        {
            InitializeComponent();
        }

        private void CadastroEndereco_Load(object sender, EventArgs e)
        {
            gerenciador = new Gerenciador(BancoDeDados.sqlServer);
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            List<Telefone> telefones;
            if (txtId.Text.Equals(""))
            {
                telefones = gerenciador.dao.Consultar();
            }
            else
            {
                telefones = gerenciador.dao.Consultar (txtId.Text);
            }
            lbCadastroEndereco.Items.Clear();
            foreach(Telefone p in telefones)
            {
                lbCadastroEndereco.Items.Add(p.ToString());
            }
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            Telefone p = new Telefone();
            p.id = Convert.ToInt32(txtId.Text);
            p.ddd = Convert.ToInt32(txtDDD.Text);
            p.numero = Convert.ToInt32(txtNumero.Text);
            p.tipoTelefone = txtTpTelefone.Text;
            gerenciador.dao.inseri(p);
            txtId.Text = "";
            txtDDD.Text = "";
            txtNumero.Text = "";
            txtTpTelefone.Text = "";

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Telefone p = new Telefone();
            p.id = Convert.ToInt32(txtId.Text);
            p.ddd = Convert.ToInt32(txtDDD.Text);
            p.numero = Convert.ToInt32(txtNumero.Text);
            p.tipoTelefone = txtTpTelefone.Text;
            gerenciador.dao.Alterar(p);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Telefone p = new Telefone();
            p.id = Convert.ToInt32(txtId.Text);
            p.ddd = Convert.ToInt32(txtDDD.Text);
            p.numero = Convert.ToInt32(txtNumero.Text);
            p.tipoTelefone = txtTpTelefone.Text;
            gerenciador.dao.Exclue(p);
        }
    }
}
