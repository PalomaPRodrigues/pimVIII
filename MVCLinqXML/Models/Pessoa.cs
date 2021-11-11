using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCLinqXML.Models
{
    public class Pessoa
    {
        public Pessoa()
        {
        }

        public Pessoa(int id, string nome, long cpf, string endereco, int telefone)
        {
            this.id = id;
            this.nome = nome;
            this.cpf = cpf;
            this.endereco = endereco;
            this.telefone = telefone;
        }
        public int id { get; set; }

        public string nome { get; set; }

        public long cpf { get; set; }

        public string endereco { get; set; }

        public int telefone { get; set; }
    }
}