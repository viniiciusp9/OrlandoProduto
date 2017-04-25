using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Cadastro;

namespace Cadastro
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool Clientes;
            bool Produtos;

            //verifica se o nome do usuário foi digitado
            if (txtLogin.Text == "")
            {
                MessageBox.Show("Nome do Usuário Invalido", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtLogin.Focus();
                return;
            }


            //verifica se o nome do usuário foi digitado
            if (txtSenha.Text == "")
            {
                MessageBox.Show("Senha do Usuário Invalido", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtLogin.Focus();
                return;
            }

            //verifica se o usuário e senha existem no banco de dados
            SqlDataReader drReader;
            clUsuarios clUsuarios = new clUsuarios();
            clUsuarios.banco = Properties.Settings.Default.conexaoDB;
            drReader = clUsuarios.pesquisar(txtLogin.Text, txtSenha.Text);
            if (!drReader.Read())
            {
                MessageBox.Show("Acesso Negado!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //verifica a permissão de acesso do usuário
                if (Convert.ToBoolean(drReader["usrClientes"].ToString()) == true)
                {
                    Clientes = true;
                }
                else
                {
                    Clientes = false;
                }
                if (Convert.ToBoolean(drReader["usrProdutos"].ToString()) == true)
                {
                    Produtos = true;
                }
                else
                {
                    Produtos = false;
                }

                //oculta o formulário de login
                Hide();

                //cria a instância do formulário principal
                FrmInicio FrmInicio = new FrmInicio();

                //transfere as permissões de acesso
                //para o form principal
                FrmInicio.Clientes = Clientes;
                FrmInicio.Produtos = Produtos;

                //abre o formulário principal               
                FrmInicio.Show();
            }

            //fecha o datareader
            drReader.Close();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
