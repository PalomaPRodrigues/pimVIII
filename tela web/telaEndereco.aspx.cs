using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using aplicativoMVC.Controllers;
using aplicativoMVC.Models;

namespace tela_web
{
   
    public partial class telaEndereco : System.Web.UI.Page
    {
        Gerenciador gerenciador;
        protected void Page_Load(object sender, EventArgs e)
        {
            gerenciador = new Gerenciador(BancoDeDados.sqlServer);
        }

        protected void btnConsulta_Click(object sender, EventArgs e)
        {
            List<Endereco> enderecos;
            if (TxtId.Text.Equals(""))
            {
                enderecos = gerenciador.dao.Consulta();
            }
            else
            {
                enderecos = gerenciador.dao.Consulta(TxtId.Text);
            }
            lbAgenda.Items.Clear();
            foreach (Endereco p in enderecos)
            {
                lbAgenda.Items.Add(p.ToString());
            }

        }

        protected void btnInserir_Click(object sender, EventArgs e)
        {
            Endereco p = new Endereco();
            p.id = Convert.ToInt32(TxtId.Text);
            p.logradouro = TxtLogradouro.Text;
            p.numero = Convert.ToInt32(TxtNumero.Text);
            p.cep = Convert.ToInt32(TxtCep.Text);
            p.bairro = TxtBairro.Text;
            p.cidade = TxtCidade.Text;
            p.estado = TxtEstado.Text;
            gerenciador.dao.inserir(p);
            TxtId.Text = "";
            TxtLogradouro.Text = "";
            TxtNumero.Text = "";
            TxtCep.Text = "";
            TxtBairro.Text = "";
            TxtCidade.Text = "";
            TxtEstado.Text = "";
        }

        protected void btnAltera_Click(object sender, EventArgs e)
        {
            Endereco p = new Endereco();
            p.id = Convert.ToInt32(TxtId.Text);
            p.logradouro = TxtLogradouro.Text;
            p.numero = Convert.ToInt32(TxtNumero.Text);
            p.cep = Convert.ToInt32(TxtCep.Text);
            p.bairro = TxtBairro.Text;
            p.cidade = TxtCidade.Text;
            p.estado = TxtEstado.Text;
            gerenciador.dao.Altera(p);


        }

        protected void btnExcluir_Click(object sender, EventArgs e)
        {
            Endereco p = new Endereco();
            p.id = Convert.ToInt32(TxtId.Text);
            p.logradouro = TxtLogradouro.Text;
            p.numero = Convert.ToInt32(TxtNumero.Text);
            p.cep = Convert.ToInt32(TxtCep.Text);
            p.bairro = TxtBairro.Text;
            p.cidade = TxtCidade.Text;
            p.estado = TxtEstado.Text;
            gerenciador.dao.Excluir(p);

        }
    }
    
}