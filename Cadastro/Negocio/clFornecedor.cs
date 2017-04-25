using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class clFornecedor
    {
        //propriedade
        public string banco { get; set; }
        public int id { get; set; }
        public string cnpj { get; set; }
        public string ForRazao { get; set; }
        public string ForContato { get; set; }
        public string ForIE { get; set; }
        public string ForIM { get; set; }
        public string ForTel { get; set; }
        public string ForTel2 { get; set; }
        public string ForCel { get; set; }
        public string ForCel2 { get; set; }
        public string ForFax { get; set; }
        public string ForMail { get; set; }
        public string ForCEP { get; set; }
        public string ForRua { get; set; }
        public string ForNum { get; set; }
        public string ForComplemento { get; set; }
        public string ForBairro { get; set; }
        public string ForMunicipio { get; set; }
        public string ForEstado { get; set; }
        public string Data { get; set; }
        public void Gravar()
        {
            //variavel utilizada para "concatenar" textos de forma estruturada
            StringBuilder strQuery = new StringBuilder();

            //montagem do insert
            strQuery.Append(" INSERT INTO tbFornecedor");

            strQuery.Append(" ( ");

            strQuery.Append(" cnpj ");
            strQuery.Append(", ForRazao ");
            strQuery.Append(", ForContato ");
            strQuery.Append(", ForIE ");
            strQuery.Append(", ForIM ");
            strQuery.Append(", ForTel ");
            strQuery.Append(", ForTel2 ");
            strQuery.Append(", ForCel ");
            strQuery.Append(", ForCel2 ");
            strQuery.Append(", ForFax ");
            strQuery.Append(", ForMail ");
            strQuery.Append(", ForCEP ");
            strQuery.Append(", ForRua ");
            strQuery.Append(", ForNum ");
            strQuery.Append(", ForComplemento ");
            strQuery.Append(", ForBairro ");
            strQuery.Append(", ForMunicipio ");
            strQuery.Append(", ForEstado ");

            strQuery.Append(" ) ");

            strQuery.Append(" VALUES ( ");

            strQuery.Append(" '" + cnpj + "'");
            strQuery.Append(", '" + ForRazao + "'");
            strQuery.Append(", '" + ForContato + "'");
            strQuery.Append(", '" + ForIE + "'");
            strQuery.Append(", '" + ForIM + "'");
            strQuery.Append(", '" + ForTel + "'");
            strQuery.Append(", '" + ForTel2 + "'");
            strQuery.Append(", '" + ForCel + "'");
            strQuery.Append(", '" + ForCel2 + "'");
            strQuery.Append(", '" + ForFax + "'");
            strQuery.Append(", '" + ForMail + "'");
            strQuery.Append(", '" + ForCEP + "'");
            strQuery.Append(", '" + ForRua + "'");
            strQuery.Append(", '" + ForNum + "'");
            strQuery.Append(", '" + ForComplemento + "'");
            strQuery.Append(", '" + ForBairro + "'");
            strQuery.Append(", '" + ForMunicipio + "'");
            strQuery.Append(", '" + ForEstado + "'");

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
            strQuery.Append(" UPDATE tbFornecedor");

            strQuery.Append(" SET ");

            strQuery.Append(" ForRazao = '" + ForRazao + "'");
            strQuery.Append(", ForContato = '" + ForContato + "'");
            strQuery.Append(", ForIE = '" + ForIE.Replace(",", ".") + "'");
            strQuery.Append(", ForIM = '" + ForIM + "'");
            strQuery.Append(", ForTel = '" + ForTel.Replace(",", ".") + "'");
            strQuery.Append(", ForTel2 = '" + ForTel2.Replace(",", ".") + "'");
            strQuery.Append(", ForCel = '" + ForCel.Replace(",", ".") + "'");
            strQuery.Append(", ForCel2 = '" + ForCel2.Replace(",", ".") + "'");
            strQuery.Append(", ForFax = '" + ForFax + "'");
            strQuery.Append(", ForMail = '" + ForMail + "'");
            strQuery.Append(", ForCEP = '" + ForCEP + "'");
            strQuery.Append(", ForRua = '" + ForRua + "'");
            strQuery.Append(", ForNum = '" + ForNum + "'");
            strQuery.Append(", ForComplemento = '" + ForComplemento + "'");
            strQuery.Append(", ForBairro = '" + ForBairro + "'");
            strQuery.Append(", ForMunicipio = '" + ForMunicipio + "'");
            strQuery.Append(", ForEstado = '" + ForEstado + "'");

            strQuery.Append(" WHERE ");

            strQuery.Append("id=" + id);
            //INSTANCIA A CLASSE clAcessoDB e executa o comando
            clAcessoDB clAcessoDB = new clAcessoDB();
            clAcessoDB.vConexao = banco;
            clAcessoDB.ExecutaComando(strQuery.ToString());
        }
        public void Excluir()
        {
            StringBuilder strQuery = new StringBuilder();
            //montagem de delete
            strQuery.Append(" DELETE FROM tbFornecedor ");
            strQuery.Append(" WHERE ");
            strQuery.Append(" id = " + id);

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
            strQuery.Append(" SELECT id ID, cnpj CNPJ, ForRazao  " + aspas + "Razão Social" + aspas + ", ForContato Contato, ForIE" + aspas + "Inscrição Estadual" + aspas + ", ForIM" + aspas + "Inscrição Municipal" + aspas + ", ForTel Telefone, ForTel2" + aspas + "Telefone 2" + aspas + ", ForCel Celular, ForCel2" + aspas + "Celular 2" + aspas + ", ForFax Fax, ForMail" + aspas + "E-Mail" + aspas + ", ForCEP CEP, ForRua Rua, ForNum Numero, ForComplemento Complemento, ForBairro Bairro, ForMunicipio Municipio, ForEstado Estado");
            strQuery.Append(" FROM tbFornecedor ");
            if (Campo != string.Empty && Filtro != string.Empty)
            {
                strQuery.Append(" WHERE ");
                strQuery.Append(Campo + " LIKE '" + "%" + Filtro + "%" + "'");
            }
            strQuery.Append(" ORDER BY id ");
            //EXECUTA O COMANDO
            clAcessoDB clAcessoDB = new clAcessoDB();
            clAcessoDB.vConexao = banco;
            return clAcessoDB.RetornaDataSet(strQuery.ToString());
        }
        public SqlDataReader PesquisarCodigo(int id)
        {
            StringBuilder strQuery = new StringBuilder();
            //montagem do select
            strQuery.Append(" SELECT * ");
            strQuery.Append(" FROM tbFornecedor ");
            strQuery.Append(" WHERE ");
            strQuery.Append(" id = " + id);
            //executa oo comando
            clAcessoDB clAcessoDB = new clAcessoDB();
            clAcessoDB.vConexao = banco;
            return clAcessoDB.RetornaDataReader(strQuery.ToString());


        }
    }
}
