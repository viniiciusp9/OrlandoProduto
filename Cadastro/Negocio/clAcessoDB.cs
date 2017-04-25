using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class clAcessoDB
    {
        //variavel para reecebe rstring de conexao
        public string vConexao = "";


        //método responsavel por abrir a conexao com o banco de dados
        public SqlConnection AbreBanco()
        {
            //abre a conexao com o banco de dados
            SqlConnection conn = new SqlConnection(vConexao);
            conn.Open();
            return conn;
        }
        //método responsavel por fechar a conexao com o banco de dados
        public void FechaBanco(SqlConnection conn)
        {
            //fecha a conexao com a base de dados
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
                conn.Dispose();
            }
        }
        public void ExecutaComando(string strQuery)
        {
            SqlConnection conn = new SqlConnection();
            try
            {
                conn = AbreBanco();
                SqlCommand cmdComando = new SqlCommand();
                cmdComando.CommandText = strQuery;
                cmdComando.CommandType = CommandType.Text;
                cmdComando.Connection = conn;

                //passa os valores da quer SQL, tipo do comando
                //conexao e executa o comando
                cmdComando.ExecuteNonQuery();
            }
            //tratamento de excessoes
            catch (System.Exception ex)
            {
                throw ex;
            }
            finally
            {
                //em caso de erro ou não, finaliza
                FechaBanco(conn);
            }
        }
        //dataset é usado para retorna um volume grande de registros utilizado principalmente para componentes
        //datagridview
        public DataSet RetornaDataSet(string strQuery)
        {
            //cria o objeto de conexao
            SqlConnection conn = new SqlConnection();
            try
            {
                //abre a conexao com o banco de dados
                conn = AbreBanco();
                // cria o objeto e comando
                SqlCommand cmdComando = new SqlCommand();
                //passa os valores da query SQL, tipo de comando, conexao e executa
                cmdComando.CommandText = strQuery;
                cmdComando.CommandType = CommandType.Text;
                cmdComando.Connection = conn;
                //declara um dataadapter
                SqlDataAdapter daAdaptador = new SqlDataAdapter();
                //declara um dataset
                DataSet dsDataSet = new DataSet();
                //passa o comando a ser executado pelo dataadapter
                daAdaptador.SelectCommand = cmdComando;
                //o dataadapter faz a conexao com o banco de dados 
                //carrega o dataset fecha a conexao 
                daAdaptador.Fill(dsDataSet);
                //retorna o dataset carregado
                return dsDataSet;
                //tratamento de exccessoes
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
            finally
            {
                //em caso de erro ou não, o finally
                ///é executado para fechar a conexao com o banco de dados
                FechaBanco(conn);
            }
        }
        public SqlDataReader RetornaDataReader(string strQuery)
        {
            //criar o objeto de conexao
            SqlConnection conn = new SqlConnection();
            try
            {
                //abre a conexao com o banco de dados
                conn = AbreBanco();
                //Cria o objeto de comando
                SqlCommand cmdComando = new SqlCommand();
                //passa os valores da query sql, tipo do comando
                //conxao e executa o comando
                cmdComando.CommandText = strQuery;
                cmdComando.CommandType = CommandType.Text;
                cmdComando.Connection = conn;
                //retorna o comando executando a leitura
                return cmdComando.ExecuteReader(CommandBehavior.CloseConnection);
                //tratamento das execessoes
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }
    }
}

