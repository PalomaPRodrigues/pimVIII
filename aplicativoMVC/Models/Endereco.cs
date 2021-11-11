using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace aplicativoMVC.Models
{
    public class Endereco
    {
        public int id { get; set; }

        public string logradouro { get; set; }

        public int numero { get; set; }

        public int cep { get; set; }

        public string bairro { get; set; }

        public string cidade { get; set; }

        public string estado { get; set; }


        public override bool Equals(object obj)
        {
            bool saida = false;

            if (typeof(Endereco) == obj.GetType())
            {
                Endereco endereco = (Endereco)obj;
                if (this.id.Equals(endereco.id) && this.logradouro == endereco.logradouro && this.numero == endereco.numero && this.cep == endereco.cep
                    && this.bairro == endereco.bairro && this.cidade == endereco.cidade && this.estado == endereco.estado)
                {
                    saida = true;
                }
            }

            return saida;
        }

        public override string ToString()
        {
            return id + "-" + logradouro + "-" + numero + "-" + cep + "-" + bairro + "-" + cidade + "-" + estado;






        }
    }
}