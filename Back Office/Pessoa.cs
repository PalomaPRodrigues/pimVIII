using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back_Office
{
    public class Pessoa
    {
        public int id { get; set; }

        public string nome { get; set; }

        public long cpf { get; set; }

        public long endereco { get; set; }

        public int telefone { get; set; }

        public override bool Equals(object obj)
        {
            bool saida = false;

            if(typeof(Pessoa) == obj.GetType()) { 
                Pessoa pessoa = (Pessoa)obj;
                if(this.id.Equals(pessoa.id) && this.nome == pessoa.nome && this.cpf == pessoa.cpf && this.endereco == pessoa.endereco && this.telefone == pessoa.telefone)
                {
                    saida = true;
                }
            }

            return saida;
        }
        public override string ToString()
        {
            return id + "-" + nome + "-" + cpf + "-" + endereco + "-" + telefone;
        }
    }
}
