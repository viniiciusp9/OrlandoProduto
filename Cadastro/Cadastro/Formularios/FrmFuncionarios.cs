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

namespace Cadastro
{
    public partial class FrmFuncionarios : Form
    {
        public FrmFuncionarios()
        {
            InitializeComponent();
        }

        private void dvgFuncionarios_DoubleClick(object sender, EventArgs e)
        {
            //verifica se existe itens na grid
            if (dgvFuncionarios.RowCount == 0)
            {
                return;
            }
            //carrega a tela com todos os dados do cliente
            SqlDataReader drReader;
            clUsuarios clUsuarios = new clUsuarios();
            clUsuarios.banco = Properties.Settings.Default.conexaoDB;
            drReader = clUsuarios.PesquisarNome(Convert.ToInt32(dgvFuncionarios.CurrentRow.Cells[0].Value));
            if (drReader.Read())
            {
                //TRANFERE OS DADOS DO BANCO DE DADOS PARA O CAMPO DO FORM
                txtCode.Text = drReader["usrCode"].ToString();
                txtLogin.Text = drReader["usrNome"].ToString();
                txtSenha.Text = drReader["usrSenha"].ToString();
                if (Convert.ToBoolean(drReader["usrClientes"].ToString()) == true)
                {
                    chkClientes.Checked = true;
                }
                else
                {
                    chkClientes.Checked = false;
                }
                if (Convert.ToBoolean(drReader["usrProdutos"].ToString()) == true)
                {
                    chkUsuarios.Checked = true;
                }
                else
                {
                    chkUsuarios.Checked = false;
                }
                //HABILITA O FRAME ENVIA CURSOR PARA O CAMPO DESCRIÇAO
                tabControl1.SelectedTab = tabPage2;
                txtLogin.Focus();
            }
            drReader.Close();
        }
        public void PesquisarFun()
        {
            string campo = "";
            //seleciona o campo de pesquia
            if (cboOpcao.Text == "Login")
            {
                campo = "usrNome";
            }
            else if (cboOpcao.Text == "Senha")
            {
                campo = "usrSenha";
            }
            //carrega o datagridview comos clientes cadastrados
            clUsuarios clUsuarios = new clUsuarios();
            clUsuarios.banco = Properties.Settings.Default.conexaoDB;
            dgvFuncionarios.DataSource = clUsuarios.PesquisarUser(campo, txtFiltro.Text).Tables[0];
            //comand utilizado para gerar um efeito "zebrado" no datagridview
            dgvFuncionarios.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
        }
        public void Gravar()
        {
            // instancia a classe de negocio
            clUsuarios clUsuarios = new clUsuarios();
            if (txtLogin.Text == "")
            {
                lblMensagem1.Text = "Insina um Login para o Funcionario";
                return;
            }
            if (txtSenha.Text == "")
            {
                lblMensagem2.Text = "Insina uma senha para o Funcionario";
                return;
            }

            DialogResult resposta;
            resposta = MessageBox.Show("Confirma a inclusão?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (resposta.Equals(DialogResult.No))
            {
                return;
            }

            //carrega as propriedades
            
            clUsuarios.usrNome = txtLogin.Text;
            clUsuarios.usrSenha = txtSenha.Text;
            if (chkClientes.Checked == true)
            {
                clUsuarios.usrClientes = "1";
            }
            else
            {
                clUsuarios.usrClientes = "0";
            }
            if (chkUsuarios.Checked == true)
            {
                clUsuarios.usrProdutos = "1";
            }
            else
            {
                clUsuarios.usrProdutos = "0";
            }

            //variavel com a sstring de conexao com o banco
            clUsuarios.banco = Properties.Settings.Default.conexaoDB;
            if (txtCode.Text == "")
            {
                clUsuarios.Gravar();
            }
            else
            {
                clUsuarios.usrCod = Convert.ToInt32(txtCode.Text);
                clUsuarios.Alterar();
            }
            //mensagem de cofiguração
            MessageBox.Show("Fornecedor incluido com sucesso", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            lblMensagem.Text = "Funcionario cadastrado com sucesso";
            ClearForm.ClearForms(this);

        }

        private void FrmFuncionarios_Load(object sender, EventArgs e)
        {
            PesquisarFun();
        }

        private void dgvFuncionarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            Gravar();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            ClearForm.ClearForms(this);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmFuncionarios_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue.Equals(27)) //ESC
            {
                this.Close();
            }
        }
    }
}
