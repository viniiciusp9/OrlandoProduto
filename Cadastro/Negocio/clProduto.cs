using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class clProduto
    {
        //propriedades

        public string banco { get; set; }
        public int proCodigo { get; set; }
        public string proNome { get; set; }
        public string proDescricao { get; set; }
        public string proMarca { get; set; }
        public string proPreco { get; set; }
        public string proData { get; set; }
        public string proPreco1 { get; set; }
        public string proPreco2 { get; set; }
        public string proPreco3 { get; set; }
        public string proPreco4 { get; set; }
        public string proModelo { get; set; }
        public string proNSerie { get; set; }
        public string proPNumber { get; set; }
        public void Gravar()
        {
            //variavel utilizada para "concatenar" textos de forma estruturada
            StringBuilder strQuery = new StringBuilder();

            //montagem do insert
            strQuery.Append(" INSERT INTO tbProdutos");

            strQuery.Append(" ( ");

            strQuery.Append(" proNome ");
            strQuery.Append(", proDescricao ");
            strQuery.Append(", proMarca ");
            strQuery.Append(", proPreco ");
            strQuery.Append(", proData ");
            strQuery.Append(", proPreco1 ");
            strQuery.Append(", proPreco2 ");
            strQuery.Append(", proPreco3 ");
            strQuery.Append(", proPreco4 ");
            strQuery.Append(", proModelo ");
            strQuery.Append(", proNSerie ");
            strQuery.Append(", proPNumber ");

            strQuery.Append(" ) ");

            strQuery.Append(" VALUES ( ");

            strQuery.Append(" '" + proNome + "'");
            strQuery.Append(", '" + proDescricao + "'");
            strQuery.Append(", '" + proMarca + "'");
            strQuery.Append(", '" + proPreco.Replace(",", ".") + "'");
            strQuery.Append(", '" + proData + "'");
            strQuery.Append(", '" + proPreco1.Replace(",",".") + "'");
            strQuery.Append(", '" + proPreco2.Replace(",", ".") + "'");
            strQuery.Append(", '" + proPreco3.Replace(",", ".") + "'");
            strQuery.Append(", '" + proPreco4.Replace(",", ".") + "'");
            strQuery.Append(", '" + proModelo + "'");
            strQuery.Append(", '" + proNSerie + "'");
            strQuery.Append(", '" + proPNumber + "'");

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
            strQuery.Append(" UPDATE tbProdutos");

            strQuery.Append(" SET ");

            strQuery.Append(" proNome = '" + proNome + "'");
            strQuery.Append(", proDescricao = '" + proDescricao + "'");
            strQuery.Append(", proMarca = '" + proMarca + "'");
            strQuery.Append(", proPreco = '" + proPreco.Replace(",", ".") + "'");
            strQuery.Append(", proData = '" + proData + "'");
            strQuery.Append(", proPreco1 = '" + proPreco1.Replace(",", ".") + "'");
            strQuery.Append(", proPreco2 = '" + proPreco2.Replace(",", ".") + "'");
            strQuery.Append(", proPreco3 = '" + proPreco3.Replace(",", ".") + "'");
            strQuery.Append(", proPreco4 = '" + proPreco4.Replace(",", ".") + "'");
            strQuery.Append(", proModelo = '" + proModelo + "'");
            strQuery.Append(", proNSerie = '" + proNSerie + "'");
            strQuery.Append(", proPNumber = '" + proPNumber + "'");

            strQuery.Append(" WHERE ");

            strQuery.Append("procodigo=" + proCodigo);
            //INSTANCIA A CLASSE clAcessoDB e executa o comando
            clAcessoDB clAcessoDB = new clAcessoDB();
            clAcessoDB.vConexao = banco;
            clAcessoDB.ExecutaComando(strQuery.ToString());
        }
        public void Excluir()
        {
            StringBuilder strQuery = new StringBuilder();
            //montagem de delete
            strQuery.Append(" DELETE FROM tbProdutos ");
            strQuery.Append(" WHERE ");
            strQuery.Append(" proCodigo = " + proCodigo);

            //instancia a classe clAcessoDB e xecutar o comando
            clAcessoDB clAcessoDB = new clAcessoDB();
            clAcessoDB.vConexao = banco;
            clAcessoDB.ExecutaComando(strQuery.ToString());
        }

        public DataSet Pesquisar(string Campo, string Filtro)
        {
            StringBuilder strQuery = new StringBuilder();

            //montagem do select
            string aspas =""+ (char)34;
            strQuery.Append(" SELECT proCodigo Código, proNome Nome, proDescricao Descrição, proModelo Modelo, proNSerie "+aspas+"Nº Serie"+aspas+",  proPNumber " + aspas +"Part Number"+aspas+", proPreco "+aspas+"Preco de custo"+aspas+", proData Data, proPreco1 "+aspas+" Preço 1"+aspas+", proPreco2 "+aspas+"Preço 2"+aspas+", proPreco3 "+aspas+"Preço 3"+aspas+", proPreco4 "+aspas+"Preço 4"+aspas);
            strQuery.Append(" FROM tbProdutos ");
            if (Campo != string.Empty && Filtro != string.Empty)
            {
                strQuery.Append(" WHERE ");
                strQuery.Append(Campo + " LIKE '" + "%" + Filtro + "%" + "'");
            }
            strQuery.Append(" ORDER BY proNome ");
            //EXECUTA O COMANDO
            clAcessoDB clAcessoDB = new clAcessoDB();
            clAcessoDB.vConexao = banco;
            return clAcessoDB.RetornaDataSet(strQuery.ToString());
        }
        public SqlDataReader PesquisarCodigo(int Codpro)
        {
            StringBuilder strQuery = new StringBuilder();
            //montagem do select
            strQuery.Append(" SELECT * ");
            strQuery.Append(" FROM tbProdutos ");
            strQuery.Append(" WHERE ");
            strQuery.Append(" proCodigo = " + Codpro);
            //executa oo comando
            clAcessoDB clAcessoDB = new clAcessoDB();
            clAcessoDB.vConexao = banco;
            return clAcessoDB.RetornaDataReader(strQuery.ToString());
        }
    }

}
