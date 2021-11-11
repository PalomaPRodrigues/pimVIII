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
    public partial class telaTelefone : System.Web.UI.Page
    {
        Gerenciador gerenciador;
        protected void Page_Load(object sender, EventArgs e)
        {
            gerenciador = new Gerenciador(BancoDeDados.sqlServer);
        }

        protected void btnConsultar_Click(object sender, EventArgs e)
        {
            List<Telefone> telefones;
            if (TxtId.Text.Equals(""))
            {
                telefones = gerenciador.dao.Consultar();
            }
            else
            {
                telefones = gerenciador.dao.Consultar(TxtId.Text);
            }
            lbAgenda.Items.Clear();
            foreach (Telefone p in telefones)
            {
                lbAgenda.Items.Add(p.ToString());
            }
        }

        protected void btnInserir_Click(object sender, EventArgs e)
        {
            Telefone p = new Telefone();
            p.id = Convert.ToInt32(TxtId.Text);
            p.numero = Convert.ToInt32(TxtNumero.Text);
            p.ddd = Convert.ToInt32(TxtDdd.Text);
            p.tipoTelefone = TxtTipoTelfone.Text;
            gerenciador.dao.inseri(p);
            TxtId.Text = "";
            TxtNumero.Text = "";
            TxtDdd.Text = "";
            TxtTipoTelfone.Text = "";
        }

        protected void btnAlterar_Click(object sender, EventArgs e)
        {
            Telefone p = new Telefone();
            p.id = Convert.ToInt32(TxtId.Text);
            p.numero = Convert.ToInt32(TxtNumero.Text);
            p.ddd = Convert.ToInt32(TxtDdd.Text);
            p.tipoTelefone = TxtTipoTelfone.Text;
            gerenciador.dao.Alterar(p);
        }

        protected void btnExclue_Click(object sender, EventArgs e)
        {
            Telefone p = new Telefone();
            p.id = Convert.ToInt32(TxtId.Text);
            p.numero = Convert.ToInt32(TxtNumero.Text);
            p.ddd = Convert.ToInt32(TxtDdd.Text);
            p.tipoTelefone = TxtTipoTelfone.Text;
            gerenciador.dao.Exclue(p);
        }
    }
}