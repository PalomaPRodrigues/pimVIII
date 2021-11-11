using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aplicativoMVC.Models
{
    public interface PessoaDao
    {
        void insira(Pessoa p);
        List<Pessoa> Consulte();
        List<Pessoa> Consulte(string id);
        void Altere(Pessoa p);
        void Exclua(Pessoa p);
        void inserir(Endereco p);
        List<Endereco> Consulta();
        List<Endereco> Consulta(string id);
        void Altera(Endereco p);
        void Excluir(Endereco p);
        void inseri(Telefone p);
        List<Telefone> Consultar();
        List<Telefone> Consultar(string id);
        void Alterar(Telefone p);
        void Exclue(Telefone p);
    }
}
