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
    public partial class tela : System.Web.UI.Page
    {
        Gerenciador gerenciador;
        protected void Page_Load(object sender, EventArgs e)
        {
            gerenciador = new Gerenciador(BancoDeDados.sqlServer);
        }

        protected void btnConsulte_Click(object sender, EventArgs e)
        {
            List<Pessoa> pessoas;
            if (TxtID.Text.Equals(""))
            {
                pessoas = gerenciador.dao.Consulte();
            }
            else
            {
                pessoas = gerenciador.dao.Consulte(TxtID.Text);
            }
            lbAgenda.Items.Clear();
            foreach (Pessoa p in pessoas)
            {
                lbAgenda.Items.Add(p.ToString());
            }
        }

        protected void btnInsira_Click(object sender, EventArgs e)
        {
            Pessoa p = new Pessoa();
            p.id = Convert.ToInt32(TxtID.Text);
            p.nome = TxtNome.Text;
            p.cpf = Convert.ToInt64(TxtCpf.Text);
            p.endereco = TxtEndereco.Text;
            p.telefone = Convert.ToInt32(TxtTelefone.Text);
            gerenciador.dao.insira(p);
            TxtID.Text = "";
            TxtNome.Text = "";
            TxtCpf.Text = "";
            TxtEndereco.Text = "";
            TxtTelefone.Text = "";
        }

        protected void btnAltere_Click(object sender, EventArgs e)
        {
            Pessoa p = new Pessoa();
            p.id = Convert.ToInt32(TxtID.Text);
            p.nome = TxtNome.Text;
            p.cpf = Convert.ToInt64(TxtCpf.Text);
            p.endereco = TxtEndereco.Text;
            p.telefone = Convert.ToInt32(TxtTelefone.Text);
            gerenciador.dao.Altere(p);

        }

        protected void btnExclua_Click(object sender, EventArgs e)
        {
            Pessoa p = new Pessoa();
            p.id = Convert.ToInt32(TxtID.Text);
            p.nome = TxtNome.Text;
            p.cpf = Convert.ToInt32(TxtCpf.Text);
            p.endereco = TxtEndereco.Text;
            p.telefone = Convert.ToInt32(TxtTelefone.Text);
            gerenciador.dao.Exclua(p);
        }

    }
    
}