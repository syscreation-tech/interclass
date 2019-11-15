using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Regra_de_Negocios
{
    public class Query 
    {
        private MySqlCommand comando;
        private MySqlTransaction trans;

        public Query(String sql, MySqlConnection connection)
        {
            try
            {
                comando = connection.CreateCommand();
                comando.CommandText = sql;
            }
            catch (Exception ex)
            {
                comando.Dispose();
                throw new Exception(ex.Message);
            }
        }

        public Query(String sql, MySqlConnection connection, string conexao)
        {
            try
            {
                comando = connection.CreateCommand();

                comando.Connection = connection;
                comando.Transaction = trans;

                comando = new MySqlCommand(sql, connection, trans);
                comando.ExecuteNonQuery();
                trans.Commit();
            }
            catch (Exception ex)
            {
                comando.Dispose();
                trans.Rollback();
                throw new Exception(ex.Message);
            }
        }

        public void Dispose()
        {

            comando.Dispose();
        }

        public DataSet ExecuteDataSet(string table)
        {
            MySqlDataAdapter da = new MySqlDataAdapter(comando);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }

        public void ExecuteNonQuery()
        {
            comando.ExecuteNonQuery();
        }

        public MySqlDataReader ExecuteQuery()
        {
            return comando.ExecuteReader();
        }

        public DataTable fillDataTable(string table)
        {
            MySqlDataAdapter da = new MySqlDataAdapter(comando);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public Query SetParameter(String nome, object valor)
        {
            var parametro = comando.CreateParameter();
            parametro.ParameterName = nome;
            parametro.Value = valor;
            comando.Parameters.Add(parametro);
            return this;
        }

    }

    public class DBSessao : IDisposable
    {
        private MySqlConnection conexao;
        private string msg;

        public DBSessao()
        {
            try
            {
                conexao = new MySqlConnection("Server=localhost;DataBase=login;User=root;pwd=Gabriel@01");

                conexao.Open();

            }
            catch (Exception ex)
            {
                throw new Exception("Banco Inválido" + ex.Message);
            }
        }

        public void Dispose()
        {
            if (conexao.State == ConnectionState.Open)
                conexao.Close();
        }

        public Query CreateQuery(String sql)
        {
            return new Query(sql, conexao);
        }

        public Query ExecuteTransaction(string query)
        {
            return new Query(query, conexao, string.Empty);
        }

       
        public void ExecutaComando(string query)
        {
            var vComando = new MySqlCommand
            {
                CommandText = query,
                CommandType = CommandType.Text,
                Connection = conexao
            };
            vComando.ExecuteNonQuery();
        }
        public MySqlDataReader RetornaComando(string query)
        {
            var comando = new MySqlCommand(query, conexao);
            return comando.ExecuteReader();
        }


        public MySqlConnection MyConectarBD()
        {

            try
            {
                conexao.Open();
            }

            catch (Exception erro)
            {
                msg = "Ocorreu um erro ao se conectar" + erro.Message;
            }
            return conexao;
        }

        public MySqlConnection MyDesconectarBD()
        {

            try
            {
                conexao.Close();
            }

            catch (Exception erro)
            {
                msg = "Ocorreu um erro ao se conectar" + erro.Message;
            }
            return conexao;
        }
    }
}
