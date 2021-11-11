using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using aplicativoMVC.Models;
using aplicativoMVC.Models.dal;

namespace aplicativoMVC.Controllers
{
    public class Gerenciador
    {
        public PessoaDao dao;

        public Gerenciador(BancoDeDados bd)
        {
            switch (bd)
            {
                case BancoDeDados.Simulador:
                    dao = new SimuladorDao();
                    break;
                case BancoDeDados.MySql:
                    throw new NotImplementedException("DAO para MySql não implementado");
                case BancoDeDados.sqlServer:
                    dao = new SqlServerDao();
                    break;

            }
        }

    }
}