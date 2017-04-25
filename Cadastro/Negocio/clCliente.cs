using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
   public class clCliente
    {
        //propriedade
        public string banco      { get; set; }
        public int    cliCodigo  { get; set; }
        public string cliNome    { get; set; }
        public string cliEndereco  { get; set; }
        public string cliNumero  { get; set; }
        public string cliBairro  { get; set; }
        public string cliCidade  { get; set; }
        public string cliEstado  { get; set; }
        public string cliCEP     { get; set; }
        public string cliCelular { get; set; }
        public string cliCPF { get; set; }
        public void Gravar()
        {
            //variavel utilizada para "concatenar" textos de forma estruturada
            StringBuilder strQuery = new StringBuilder();

            //montagem do insert
            strQuery.Append(" INSERT INTO tbCliente");

            strQuery.Append(" ( ");

            strQuery.Append(" cliNome ");
            strQuery.Append(", cliEndereco ");
            strQuery.Append(", cliNumero ");
            strQuery.Append(", cliBairro ");
            strQuery.Append(", cliCidade ");
            strQuery.Append(", cliEstado ");
            strQuery.Append(", cliCEP ");
            strQuery.Append(", cliCPF ");
            strQuery.Append(", cliCelular ");

            strQuery.Append(" ) ");

            strQuery.Append(" VALUES ( ");

            strQuery.Append(" '" + cliNome + "'");
            strQuery.Append(", '" + cliEndereco + "'");
            strQuery.Append(", '" + cliNumero + "'");
            strQuery.Append(", '" + cliBairro + "'");
            strQuery.Append(", '" + cliCidade + "'");
            strQuery.Append(", '" + cliEstado + "'");
            strQuery.Append(", '" + cliCEP + "'");
            strQuery.Append(", '" + cliCPF + "'");
            strQuery.Append(", '" + cliCelular + "'");

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
            strQuery.Append(" UPDATE tbCliente");

            strQuery.Append(" SET ");

            strQuery.Append(" cliNome = '" + cliNome + "'");
            strQuery.Append(", cliEndereco = '" + cliEndereco + "'");
            strQuery.Append(", cliNumero = '" + cliNumero + "'");
            strQuery.Append(", cliBairro= '" + cliBairro + "'");
            strQuery.Append(", cliCidade = '" + cliCidade + "'");
            strQuery.Append(", cliEstado = '" + cliEstado + "'");
            strQuery.Append(", cliCEP = '" + cliCEP + "'");
            strQuery.Append(", cliCPF = '" + cliCPF + "'");
            strQuery.Append(", cliCelular = '" + cliCelular + "'");

            strQuery.Append(" WHERE ");

            strQuery.Append("cliCodigo=" + cliCodigo);
            //INSTANCIA A CLASSE clAcessoDB e executa o comando
            clAcessoDB clAcessoDB = new clAcessoDB();
            clAcessoDB.vConexao = banco;
            clAcessoDB.ExecutaComando(strQuery.ToString());
        }
        public void Excluir()
        {
            StringBuilder strQuery = new StringBuilder();
            //montagem de delete
            strQuery.Append(" DELETE FROM tbCliente ");
            strQuery.Append(" WHERE ");
            strQuery.Append(" cliCodigo = " + cliCodigo);

            //instancia a classe clAcessoDB e xecutar o comando
            clAcessoDB clAcessoDB = new clAcessoDB();
            clAcessoDB.vConexao = banco;
            clAcessoDB.ExecutaComando(strQuery.ToString());
        }
        public DataSet Pesquisar(string Campo, string Filtro)
        {
            StringBuilder strQuery = new StringBuilder();

            //montagem do select
            string aspas = "" + (char)34;
            strQuery.Append(" SELECT cliCodigo Código, cliNome Nome, CliCPF CPF, cliEndereco Rua, cliNumero Numero, cliBairro Bairro, cliCidade Cidade, cliEstado Estado, cliCEP CEP, cliCelular Celular  ");
            strQuery.Append(" FROM tbCliente ");
            if (Campo != string.Empty && Filtro != string.Empty)
            {
                strQuery.Append(" WHERE ");
                strQuery.Append(Campo + " LIKE '" + "%" + Filtro + "%" + "'");
            }
            strQuery.Append(" ORDER BY cliNome ");
            //EXECUTA O COMANDO
            clAcessoDB clAcessoDB = new clAcessoDB();
            clAcessoDB.vConexao = banco;
            return clAcessoDB.RetornaDataSet(strQuery.ToString());
        }
        public SqlDataReader PesquisarCodigo(int CodCli)
        {
            StringBuilder strQuery = new StringBuilder();
            //montagem do select
            strQuery.Append(" SELECT * ");
            strQuery.Append(" FROM tbCliente ");
            strQuery.Append(" WHERE ");
            strQuery.Append(" cliCodigo = " + CodCli);
            //executa oo comando
            clAcessoDB clAcessoDB = new clAcessoDB();
            clAcessoDB.vConexao = banco;
            return clAcessoDB.RetornaDataReader(strQuery.ToString());
        }
    }
}
