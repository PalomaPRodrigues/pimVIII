using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace aplicativoMVC.Models
{
    public class Telefone
    {
        public int id { get; set; }

        public int numero { get; set; }

        public int ddd { get; set; }

        public string tipoTelefone { get; set; }

        public override bool Equals(object obj)
        {
            bool saida = false;

            if (typeof(Telefone) == obj.GetType())
            {
                Telefone telefone = (Telefone)obj;
                if (this.id.Equals(telefone.id) && this.numero == telefone.numero && this.ddd == telefone.ddd && this.tipoTelefone == telefone.tipoTelefone )
                {
                    saida = true;
                }
            }
            return saida;
        }

        public override string ToString()
        {
            return id + "-" + numero + "-" + ddd + "-" + tipoTelefone;
        }
    }
}