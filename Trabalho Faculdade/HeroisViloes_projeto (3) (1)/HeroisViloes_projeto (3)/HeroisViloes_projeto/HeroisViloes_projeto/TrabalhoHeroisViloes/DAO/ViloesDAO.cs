using HeroisViloes.Model.Entities;
using HeroisViloes.Model.DAO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoHeroisViloes.VIEW.Herois;

namespace viloessViloes.Model
{
    public class viloesDAO : IDao
    {
        private SqlConnection _conexao;

        public viloesDAO()
        {
            this._conexao = Conexao.obterConexao();
        }
        public bool atualizar(object objeto)
        {
            this._conexao = Conexao.obterConexao();
            SuperViloes viloes = new SuperViloes();
            viloes = (SuperViloes)objeto;

            bool sucesso = false;

            string UPDATE = "UPDATE viloesS set nome = '" + viloes.NomePessoa +
                 "', anoNasc '" + viloes.AnoNasc +
                 "', idade'" + viloes.Idade +
                 "', email'" + viloes.Email +
                 "', caminhoImagem'" + viloes.caminhoImagem +
                 "', nomeviloes'" + viloes.NomeVilao +
                 "', planetaOrigem'" + viloes.PlanetaOrigem +
                 "', atividadeProfissional'" + viloes.AtividadeProfissional +
                 "', parceiro '" + viloes.Parceiro +
                 "', superPoder '" + viloes.SuperPoder +
                 "', grupo '" + viloes.Grupo +
                 "', pontoFraco'" + viloes.PontoFraco +
                 "' Where idviloes =" + viloes.IdPessoa;
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
            finally { Conexao.fecharConexao(_conexao); }
            return sucesso;

        }
        public List<SuperViloes> consultarTodos()
        {
            string SELECT = "SELECT * FROM Viloes";
            var superViloes = new List<SuperViloes>();

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
                    SuperViloes viloes = new SuperViloes();
                    viloes.IdPessoa = dataReader.GetInt32(0);
                    viloes.NomePessoa = dataReader.GetString(1);
                    viloes.AnoNasc = dataReader.GetInt32(2);
                    viloes.Idade = dataReader.GetInt32(3);
                    viloes.Email = dataReader.GetString(4);
                    viloes.caminhoImagem = dataReader.GetString(5);
                    viloes.NomeVilao = dataReader.GetString(6);
                    viloes.PlanetaOrigem = dataReader.GetString(7);
                    viloes.AtividadeProfissional = dataReader.GetString(8);
                    viloes.Parceiro = dataReader.GetString(9);
                    viloes.SuperPoder = dataReader.GetString(10);
                    viloes.Grupo = dataReader.GetString(11);
                    viloes.PontoFraco = dataReader.GetString(12);

                    superViloes.Append(viloes);
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
            return superViloes; 
        }

        public Object consultar(object objeto)
        {
            SuperViloes viloes = new SuperViloes();
            viloes = (SuperViloes)objeto;

            bool sucesso = false;

            string SELECT = "SELECT * FROM viloesS WHERE idviloes = " + viloes.IdPessoa;

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
                    
                    viloes.IdPessoa = dataReader.GetInt32(0);
                    viloes.NomePessoa = dataReader.GetString(1);
                    viloes.AnoNasc = dataReader.GetInt32(2);
                    viloes.Idade = dataReader.GetInt32(3);
                    viloes.Email = dataReader.GetString(4);
                    viloes.caminhoImagem = dataReader.GetString(5);
                    viloes.NomeVilao = dataReader.GetString(6);
                    viloes.PlanetaOrigem = dataReader.GetString(7);
                    viloes.AtividadeProfissional = dataReader.GetString(8);
                    viloes.Parceiro = dataReader.GetString(9);
                    viloes.SuperPoder = dataReader.GetString(10);
                    viloes.Grupo = dataReader.GetString(11);
                    viloes.PontoFraco = dataReader.GetString(12);

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
            return viloes;
        }

        public List<object> consultar(string sql)
        {
            List<object> listaviloes = null;
            try
            {
                SqlConnection conexaoDB = Conexao.obterConexao();
                SqlCommand command = new SqlCommand(sql, conexaoDB);

                // DataReader ira receber o resultada da consulta 
                //Somente para leitura
                SqlDataReader dataReader;

                // Executa a consulta 
                dataReader = command.ExecuteReader();
                if (dataReader.HasRows)
                    listaviloes = new List<object>();

                while (dataReader.Read()) // Lendo Registros 
                {
                    SuperViloes viloes = new SuperViloes();
                    viloes.IdPessoa = dataReader.GetInt32(0);
                    viloes.NomePessoa = dataReader.GetString(1);
                    viloes.AnoNasc = dataReader.GetInt32(2);
                    viloes.Idade = dataReader.GetInt32(3);
                    viloes.Email = dataReader.GetString(4);
                    viloes.caminhoImagem = dataReader.GetString(5);
                    viloes.NomeVilao = dataReader.GetString(6);
                    viloes.PlanetaOrigem = dataReader.GetString(7);
                    viloes.AtividadeProfissional = dataReader.GetString(8);
                    viloes.Parceiro = dataReader.GetString(9);
                    viloes.SuperPoder = dataReader.GetString(10);
                    viloes.Grupo = dataReader.GetString(11);
                    viloes.PontoFraco = dataReader.GetString(12);

                    listaviloes.Add(viloes);
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
            return listaviloes;
        }

        public bool excluir(object objeto)
        {
            SuperViloes viloes = new SuperViloes();
            viloes = (SuperViloes)objeto;
            bool sucesso = false;
            string DELETE = "DELETE FROM viloess WHERE idviloes = " + viloes.IdPessoa;
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
            SuperViloes viloes = new SuperViloes();
            viloes = (SuperViloes)objeto;

            bool sucesso = false;

            string INSERT = "INSERT INTO viloesS (nome, anoNasc, idade, " +
                "email, caminhoImagem, nomeviloes, planetaOrigem, atividadeProfissional, " +
                "parceiro, superPoder, grupo, pontoFraco) " +
                "values (' " + viloes.NomePessoa +
                "', '" + viloes.AnoNasc +
                "', '" + viloes.Idade +
                "', '" + viloes.Email +
                "', '" + viloes.caminhoImagem +
                "', '" + viloes.NomeVilao +
                "', '" + viloes.PlanetaOrigem +
                "', '" + viloes.AtividadeProfissional +
                "', '" + viloes.Parceiro +
                "', '" + viloes.SuperPoder +
                "', '" + viloes.Grupo +
                "', '" + viloes.PontoFraco +
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


