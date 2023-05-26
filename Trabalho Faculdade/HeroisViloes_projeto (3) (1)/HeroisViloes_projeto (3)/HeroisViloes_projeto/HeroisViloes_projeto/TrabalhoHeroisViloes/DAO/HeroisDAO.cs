using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HeroisViloes.Model.DAO;
using HeroisViloes.Model.Entities;
using TrabalhoHeroisViloes.VIEW.Herois;


namespace viloessViloes.Model
{
    public class heroisDAO : IDao
    {
       
        private SqlConnection _conexao;
        public heroisDAO()
        {
            this._conexao = Conexao.obterConexao();
        }

        public bool atualizar(object objeto)
        {
            this._conexao = Conexao.obterConexao();
            SuperHeroi herois = new SuperHeroi();
            herois = (SuperHeroi)objeto;

            bool sucesso = false;

            string UPDATE = "UPDATE viloesS set nome = '" + herois.NomePessoa +
                 "', anoNasc '" + herois.AnoNasc +
                 "', idade'" + herois.Idade +
                 "', email'" + herois.Email +
                 "', caminhoImagem'" + herois.caminhoImagem +
                 "', nomeviloes'" + herois.NomeHeroi +
                 "', planetaOrigem'" + herois.PlanetaOrigem +
                 "', atividadeProfissional'" + herois.AtividadeProfissional +
                 "', parceiro '" + herois.Parceiro +
                 "', superPoder '" + herois.SuperPoder +
                 "', grupo '" + herois.Grupo +
                 "', pontoFraco'" + herois.PontoFraco +
                 "' Where idherois =" + herois.IdPessoa;
            try
            {
                SqlCommand command = new SqlCommand(UPDATE, _conexao);

                if (command.ExecuteNonQuery() == 1)
                {
                    Console.WriteLine("Sucesso na Atualização dos Dados");
                    command.Dispose();
                    sucesso = true;
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Erro na Atualização" + ex);
            }
            finally {
                Conexao.fecharConexao(_conexao);
            }
            return sucesso;

        }

        public List<SuperHeroi> consultarTodos()
        {
            string SELECT = "SELECT * FROM Herois";
            var superHerois = new List<SuperHeroi>();

            try
            {
                _conexao = Conexao.obterConexao();
                SqlCommand command = new SqlCommand(SELECT, _conexao);

                //dataReader ira receber o resultado da consulta
                // somente para leitura 
                SqlDataReader dataReader;

                //Exuta a consulta
                dataReader = command.ExecuteReader();
                
                while (dataReader.Read()) // Lendo Registro
                {
                    SuperHeroi herois = new SuperHeroi();
                    herois.IdPessoa = dataReader.GetInt32(0);
                    herois.NomePessoa = dataReader.GetString(1);
                    herois.AnoNasc = dataReader.GetInt32(2);
                    herois.Idade = dataReader.GetInt32(3);
                    herois.Email = dataReader.GetString(4);
                    herois.caminhoImagem = dataReader.GetString(5);
                    herois.NomeHeroi = dataReader.GetString(6);
                    herois.PlanetaOrigem = dataReader.GetString(7);
                    herois.AtividadeProfissional = dataReader.GetString(8);
                    herois.Parceiro = dataReader.GetString(9);
                    herois.SuperPoder = dataReader.GetString(10);
                    herois.Grupo = dataReader.GetString(11);
                    herois.PontoFraco = dataReader.GetString(12);

                    superHerois.Append(herois);

                    command.Dispose();
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Erro na Consulta: " + ex);
            }
            finally
            {
                Conexao.fecharConexao(_conexao);
            }

            return superHerois;
        }


        public Object consultar(object objeto)
        {
            
            SuperHeroi herois = new SuperHeroi();
            herois = (SuperHeroi)objeto;

            bool sucesso = false;

            string SELECT = "SELECT * FROM viloesS WHERE idviloes = " + herois.IdPessoa;

            try
            {
                _conexao = Conexao.obterConexao();
                SqlCommand command = new SqlCommand(SELECT, _conexao);

                //dataReader ira receber o resultado da consulta
                // somente para leitura 
                SqlDataReader dataReader;

                //Exuta a consulta
                dataReader = command.ExecuteReader();

                if (dataReader.Read()) // Lendo Registro
                {
                    herois.IdPessoa = dataReader.GetInt32(0);
                    herois.NomePessoa = dataReader.GetString(1);
                    herois.AnoNasc = dataReader.GetInt32(2);
                    herois.Idade = dataReader.GetInt32(3);
                    herois.Email = dataReader.GetString(4);
                    herois.caminhoImagem = dataReader.GetString(5);
                    herois.NomeHeroi = dataReader.GetString(6);
                    herois.PlanetaOrigem = dataReader.GetString(7);
                    herois.AtividadeProfissional = dataReader.GetString(8);
                    herois.Parceiro = dataReader.GetString(9);
                    herois.SuperPoder = dataReader.GetString(10);
                    herois.Grupo = dataReader.GetString(11);
                    herois.PontoFraco = dataReader.GetString(12);

                    command.Dispose();
                    sucesso = true;
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Erro na Consulta: " + ex);
            }
            finally
            {
                Conexao.fecharConexao(_conexao);
            }
            return herois;
        }

        public List<object> consultar(string sql)
        {
            List<object> listaherois = null;
            try
            {
                _conexao = Conexao.obterConexao();
                SqlCommand command = new SqlCommand(sql, _conexao);

                // DataReader ira receber o resultada da consulta 
                //Somente para leitura
                SqlDataReader dataReader;

                // Executa a consulta 
                dataReader = command.ExecuteReader();
                if (dataReader.HasRows)
                    listaherois = new List<object>();

                while (dataReader.Read()) // Lendo Registros 
                {
                    SuperHeroi herois = new SuperHeroi();
                    herois.IdPessoa = dataReader.GetInt32(0);
                    herois.NomePessoa = dataReader.GetString(1);
                    herois.AnoNasc = dataReader.GetInt32(2);
                    herois.Idade = dataReader.GetInt32(3);
                    herois.Email = dataReader.GetString(4);
                    herois.caminhoImagem = dataReader.GetString(5);
                    herois.NomeHeroi = dataReader.GetString(6);
                    herois.PlanetaOrigem = dataReader.GetString(7);
                    herois.AtividadeProfissional = dataReader.GetString(8);
                    herois.Parceiro = dataReader.GetString(9);
                    herois.SuperPoder = dataReader.GetString(10);
                    herois.Grupo = dataReader.GetString(11);
                    herois.PontoFraco = dataReader.GetString(12);

                    listaherois.Add(herois);
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Erro na Consulta: " + ex);
            }
            finally
            {
                Conexao.fecharConexao(_conexao);
            }
            return listaherois;
        }

        public bool excluir(object objeto)
        {
            SuperHeroi herois = new SuperHeroi();
            herois = (SuperHeroi)objeto;
            bool sucesso = false;
            string DELETE = "DELETE FROM viloess WHERE idviloes = " + herois.IdPessoa;
            try
            {
               _conexao = Conexao.obterConexao();
                SqlCommand Command = new SqlCommand(DELETE, _conexao);
                if (Command.ExecuteNonQuery() == 1)
                {
                    Command.Dispose();
                    sucesso = true;
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Erro de exclusão" + ex);
            }
            finally
            {
                Conexao.fecharConexao(_conexao);
            }
            return sucesso;
        }

        public bool inserir(object objeto)
        {
            SuperHeroi herois = new SuperHeroi();
            herois = (SuperHeroi)objeto;

            bool sucesso = false;

            string INSERT = "INSERT INTO viloesS (nome, anoNasc, idade, " +
                "email, caminhoImagem, nomeviloes, planetaOrigem, atividadeProfissional, " +
                "parceiro, superPoder, grupo, pontoFraco) " +
                "values (' " + herois.NomePessoa +
                "', '" + herois.AnoNasc +
                "', '" + herois.Idade +
                "', '" + herois.Email +
                "', '" + herois.caminhoImagem +
                "', '" + herois.NomeHeroi +
                "', '" + herois.PlanetaOrigem +
                "', '" + herois.AtividadeProfissional +
                "', '" + herois.Parceiro +
                "', '" + herois.SuperPoder +
                "', '" + herois.Grupo +
                "', '" + herois.PontoFraco +
                "' )";

            try
            {
                _conexao = Conexao.obterConexao();
                SqlCommand command = new SqlCommand(INSERT, _conexao);

                if (command.ExecuteNonQuery() == 1)
                {
                    Console.WriteLine("Sucesso na Inscrição");
                    command.Dispose();
                    sucesso = true;
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Erro de Inserção " + ex);
            }

            finally
            {
                Conexao.fecharConexao(_conexao);
            }
            return sucesso;
        }
    }
}


