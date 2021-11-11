using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace aplicativoMVC.Models.dal
{
    public class SimuladorDao : PessoaDao

    {
        private static List<Pessoa> bd = new List<Pessoa>();
        private static List<Endereco> bds = new List<Endereco>();
        private static List<Telefone> bdd = new List<Telefone>();

        public void Altere(Pessoa p)
        {
            foreach (Pessoa pessoa in bd)
            {
                if (pessoa.id.Equals(p.id))
                {
                    pessoa.nome = p.nome;
                    pessoa.cpf = p.cpf;
                    pessoa.endereco = p.endereco;
                    pessoa.telefone = p.telefone;
                }
            }
        }

        public List<Pessoa> Consulte()
        {
            return bd;
        }

        List<Pessoa> PessoaDao.Consulte(string id)
        {
            List<Pessoa> saida = new List<Pessoa>();

            foreach (Pessoa pessoa in bd)
            {
                if (pessoa.id.Equals(id))
                {
                    saida.Add(pessoa);
                }
            }
            return saida;
        }

        public void Exclua(Pessoa p)
        {
            bd.Remove(p);
        }

        public void insira(Pessoa p)
        {
            bd.Add(p);
        }

        public void inserir(Endereco p)
        {
            bds.Add(p);
        }

        public List<Endereco> Consulta()
        {
            return bds;
        }

        public List<Endereco> Consulta(string id)
        {
            List<Endereco> saida = new List<Endereco>();

            System.Collections.IList list = bd;
            for (int i = 0; i < list.Count; i++)
            {
                Endereco endereco = (Endereco)list[i];
                if (endereco.id.Equals(id))
                {
                    saida.Add(endereco);
                }
            }

            return saida;

        }

        public void Altera(Endereco p)
        {
            foreach (Endereco endereco in bds)
            {
                if (endereco.id.Equals(p.id))
                {
                    endereco.logradouro = p.logradouro;
                    endereco.numero = p.numero;
                    endereco.cep = p.cep;
                    endereco.bairro = p.bairro;
                    endereco.cidade = p.cidade;
                    endereco.estado = p.estado;
                }
            }
        }

        public void Excluir(Endereco p)
        {
            bds.Remove(p);
        }

        public void inseri(Telefone p)
        {
            bdd.Add(p);
        }

        public List<Telefone> Consultar()
        {
            return bdd;
        }

        public List<Telefone> Consultar(string id)
        {
            List<Telefone> saida = new List<Telefone>();

            foreach(Telefone telefone in bdd)
            {
                if(telefone.id.Equals(id))
                {
                    saida.Add(telefone);
                }
            }

            return saida;
        }

        public void Alterar(Telefone p)
        {
            foreach(Telefone telefone in bdd)
            {
                if (telefone.id.Equals(p.id))
                {
                    telefone.id = p.id;
                    telefone.numero = p.numero;
                    telefone.ddd = p.ddd;
                    telefone.tipoTelefone = p.tipoTelefone;

                }
            }
        }

        public void Exclue(Telefone p)
        {
            bdd.Remove(p);
        }
    }
    }
