using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using aplicativoMVC.Models;

namespace aplicativoMVC
{
    public class SqlServerDao : PessoaDao
    {
        private static SqlConnection con;

        public SqlServerDao()
        {
            if(con == null)
            {
                try
                {
                    SqlConnectionStringBuilder cs = new SqlConnectionStringBuilder();
                    cs.DataSource = "BORG-QUEEN";
                    cs.InitialCatalog = "Pessoa";
                    cs.Authentication = SqlAuthenticationMethod.ActiveDirectoryIntegrated;
                    cs.TrustServerCertificate = true;

                    con = new SqlConnection(cs.ConnectionString);
                    con.Open();
                }
                catch (SqlException e)
                {
                    Console.Error.WriteLine("Ocorreu uma exceção de BD: " + e.Message);
                    throw new ApplicationException("Ocorreu uma exceção de BD: " + e.Message);
                }
            }
        }
        public void Altera(Endereco p)
        {
           
            
        }

        public void Alterar(Telefone p)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "UPDATE Pessoa SET DDD =" + p.ddd+ " WHERE Id = '" + p.id + "WHERE NUMERO =" + p.numero + "WHERE TIPOTELEFONE" + p.tipoTelefone + "';";
            cmd.ExecuteNonQuery();
        }

        public void Altere(Pessoa p)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "UPDATE Pessoa SET Nome =" + p.nome + " WHERE Id = '" + p.id + "WHERE CPF =" + p.cpf + "WHERE ENDERECO" + p.endereco + "';";
            cmd.ExecuteNonQuery();

        }

        public List<Endereco> Consulta()
        {
            throw new NotImplementedException();
        }

        public List<Endereco> Consulta(string id)
        {
            throw new NotImplementedException();
        }

        public List<Telefone> Consultar()
        {
            List<Telefone> telefones = new List<Telefone>();

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "SELECT Id, Nome, CPF, Endereco FROM Pessoa;";
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Telefone telefone = new Telefone();
                telefone.id = reader.GetInt32(1);
                telefone.ddd = reader.GetInt32(1);
                telefone.numero = reader.GetInt32(1);
                telefone.tipoTelefone = reader.GetString(1);
                telefones.Add(telefone);
            }
            reader.Close();

            return telefones;
        }

        public List<Telefone> Consultar(string id)
        {
            List<Telefone> telefones = new List<Telefone>();

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "SELECT Id, Nome, CPF, Endereco FROM Pessoa. WHERE ID = '" + id + "';";
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Telefone telefone = new Telefone();
                telefone.id = reader.GetInt32(1);
                telefone.ddd = reader.GetInt32(1);
                telefone.numero = reader.GetInt32(1);
                telefone.tipoTelefone = reader.GetString(1);
                telefones.Add(telefone);
            }
            reader.Close();

            return telefones;
        }

        public List<Pessoa> Consulte()
        {
            List<Pessoa> pessoa = new List<Pessoa>();

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "SELECT Id, Nome, CPF, Endereco FROM Pessoa;";
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Pessoa pessoas = new Pessoa();
                pessoas.id = reader.GetInt32(1);
                pessoas.nome = reader.GetString(0);
                pessoas.cpf = reader.GetByte(0);
                pessoas.endereco = reader.GetString(0);
                pessoa.Add(pessoas);
            }
            reader.Close();

            return pessoa;
        }

        public List<Pessoa> Consulte(string id)
        {
            List<Pessoa> pessoa = new List<Pessoa>();

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "SELECT Id, Nome, CPF, Endereco FROM Pessoa WHERE ID = '" + id + "';";
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Pessoa pessoas = new Pessoa();
                pessoas.id = reader.GetInt32(1);
                pessoas.nome = reader.GetString(0);
                pessoas.cpf = reader.GetByte(0);
                pessoas.endereco = reader.GetString(0);
                pessoa.Add(pessoas);
            }
            reader.Close();

            return pessoa;
        }

        public void Exclua(Pessoa p)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "DELETE Pessoa WHERE Nome =" + p.nome + " AND Id = '" + p.id + "AND CPF =" + p.cpf + 
                "AND ENDERECO" + p.endereco + "';";
            SqlDataReader reader = cmd.ExecuteReader();
        }

        public void Exclue(Telefone p)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "DELETE Pessoa WHERE ID =" + p.id + " AND DDD = '" + p.ddd + "AND Numero =" + p.numero +
                "AND TIPOTELEFONE" + p.tipoTelefone + "';";
            SqlDataReader reader = cmd.ExecuteReader();
        }

        public void Excluir(Endereco p)
        {
            throw new NotImplementedException();
        }

        public void inseri(Telefone p)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "Insert Into Pessoa (Id, DDD, Numero, TipoTelefone)" +
                "VALUES('" + p.id + "'," + p.id + ",'" + p.ddd + "','" + p.numero + "'," + p.tipoTelefone + ");";
            SqlDataReader reader = cmd.ExecuteReader();
            cmd.ExecuteNonQuery();
        }

        public void inserir(Endereco p)
        {
            throw new NotImplementedException();
        }

        public void insira(Pessoa p)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "Insert Into Pessoa (Nome, Id, Cpf, Endereco)" +
                "VALUES('" + p.nome +"'," + p.id+ ",'" + p.cpf+"','" + p.endereco + "';";
            SqlDataReader reader = cmd.ExecuteReader();
            cmd.ExecuteNonQuery();
        }
    }

   
    
        
}