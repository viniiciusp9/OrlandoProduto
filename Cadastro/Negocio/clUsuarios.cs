using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class clUsuarios
    {
        //propriedades
        public string banco { get; set; }
        public int usrCod { get; set; }
        public string usrNome { get; set; }
        public string usrSenha { get; set; }
        public string usrClientes { get; set; }
        public string usrProdutos { get; set; }



        public SqlDataReader pesquisar(string usrNome, string usrSenha)
        {
            StringBuilder strQuery = new StringBuilder();
            //montagem do select 
            strQuery.Append("  SELECT usrNome, usrSenha, ");
            strQuery.Append(" usrClientes, usrProdutos");
            strQuery.Append(" FROM tbUsuarios ");
            strQuery.Append(" WHERE ");
            strQuery.Append(" usrNome = '" + usrNome + "'");
            strQuery.Append(" AND ");
            strQuery.Append(" usrSenha = '" + usrSenha + "'");



            //executa o comando 
            clAcessoDB clAcessoDB = new clAcessoDB();
            clAcessoDB.vConexao = banco;
            return clAcessoDB.RetornaDataReader(strQuery.ToString());
        }
        public DataSet PesquisarUser(string Campo, string Filtro)
        {
            StringBuilder strQuery = new StringBuilder();

            //montagem do select
            strQuery.Append(" SELECT usrCode Codigo, usrNome Nome, usrClientes Clientes, usrProdutos Produtos ");
            strQuery.Append(" FROM tbUsuarios ");
            if (Campo != string.Empty && Filtro != string.Empty)
            {
                strQuery.Append(" WHERE ");
                strQuery.Append(Campo + " LIKE '" + "%" + Filtro + "%" + "'");
            }
            strQuery.Append(" ORDER BY usrNome ");
            //EXECUTA O COMANDO
            clAcessoDB clAcessoDB = new clAcessoDB();
            clAcessoDB.vConexao = banco;
            return clAcessoDB.RetornaDataSet(strQuery.ToString());
        }
        public SqlDataReader PesquisarNome(int CodUser)
        {
            StringBuilder strQuery = new StringBuilder();
            //montagem do select
            strQuery.Append(" SELECT * ");
            strQuery.Append(" FROM tbUsuarios ");
            strQuery.Append(" WHERE ");
            strQuery.Append(" usrCode = " + CodUser);
            //executa oo comando
            clAcessoDB clAcessoDB = new clAcessoDB();
            clAcessoDB.vConexao = banco;
            return clAcessoDB.RetornaDataReader(strQuery.ToString());
        }
        public void Gravar()
        {
            //variavel utilizada para "concatenar" textos de forma estruturada
            StringBuilder strQuery = new StringBuilder();

            //montagem do insert
            strQuery.Append(" INSERT INTO tbUsuarios");

            strQuery.Append(" ( ");

            strQuery.Append(" usrNome ");
            strQuery.Append(", usrSenha ");
            strQuery.Append(", usrClientes ");
            strQuery.Append(", usrProdutos ");

            strQuery.Append(" ) ");

            strQuery.Append(" VALUES ( ");

            strQuery.Append(" '" + usrNome + "'");
            strQuery.Append(", '" + usrSenha + "'");
            strQuery.Append(", '" + usrClientes + "'");
            strQuery.Append(", '" + usrProdutos + "'");

            strQuery.Append(" ) ");

            //instancia a classe clAcessoDB e executa o comando
            clAcessoDB clAcessoDB = new clAcessoDB();
            clAcessoDB.vConexao = banco;
            clAcessoDB.ExecutaComando(strQuery.ToString());
        }
        public void Alterar()
        {
            StringBuilder strQuery = new StringBuilder();
            //montagem do UPDATE
            strQuery.Append(" UPDATE tbUsuarios");

            strQuery.Append(" SET ");

            strQuery.Append(" usrNome = '" + usrNome + "'");
            strQuery.Append(", usrSenha = '" + usrSenha + "'");
            strQuery.Append(", usrClientes = '" + usrClientes + "'");
            strQuery.Append(", usrProdutos = '" + usrProdutos + "'");

            strQuery.Append(" WHERE ");

            strQuery.Append("usrCode=" + usrCod);
            //INSTANCIA A CLASSE clAcessoDB e executa o comando
            clAcessoDB clAcessoDB = new clAcessoDB();
            clAcessoDB.vConexao = banco;
            clAcessoDB.ExecutaComando(strQuery.ToString());
        }
        public void Excluir()
        {
            StringBuilder strQuery = new StringBuilder();
            //montagem de delete
            strQuery.Append(" DELETE FROM tbUsuarios ");
            strQuery.Append(" WHERE ");
            strQuery.Append(" usrCode = " + usrCod);

            //instancia a classe clAcessoDB e xecutar o comando
            clAcessoDB clAcessoDB = new clAcessoDB();
            clAcessoDB.vConexao = banco;
            clAcessoDB.ExecutaComando(strQuery.ToString());
        }

    }
}
