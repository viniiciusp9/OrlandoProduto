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
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PesquisarCEP();
        }
        public void Pesquisarcli()
        {
            string campo = "";
            //seleciona o campo de pesquia
            if (cboOpcao.Text == "Codigo")
            {
                campo = "cliCodigo";
            }
            else if (cboOpcao.Text == "Nome")
            {
                campo = "cliNome    ";
            }
            else if (cboOpcao.Text == "CPF")
            {
                campo = "cliCPF    ";
            }
            //carrega o datagridview comos clientes cadastrados
            clCliente clCliente = new clCliente();
            clCliente.banco = Properties.Settings.Default.conexaoDB;
            dgvClientes.DataSource = clCliente.Pesquisar(campo, txtFiltro.Text).Tables[0];
            //comand utilizado para gerar um efeito "zebrado" no datagridview
            dgvClientes.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Salvar();
        }
        void Cadastrar()
        {
            
        }
        private void Cadastro_KeyPress(object sender, KeyPressEventArgs e)
        {
            //enviar Tab quando fro pressionado enter
            if ((e.KeyChar.CompareTo((char)Keys.Return)) ==0)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void Cadastro_DragDrop(object sender, DragEventArgs e)
        {

        }


        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tstSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Cadastro_Load(object sender, EventArgs e)
        {
          //  OpenForm();
        }
        
        void PesquisarCEP()
        {
            DataSet ds = new DataSet();

            string xml = "http://cep.republicavirtual.com.br/web_cep.php?cep=@cep&formato=xml".Replace("@cep", mskCep.Text);
            ds.ReadXml(xml);
            if (ds.Tables[0].Rows[0]["resultado_txt"].ToString() == "sucesso - cep completo" || ds.Tables[0].Rows[0]["resultado_txt"].ToString() == "sucesso - cep único")
            {
                txtEndereco.Text = ds.Tables[0].Rows[0]["tipo_logradouro"].ToString() + " " + ds.Tables[0].Rows[0]["logradouro"].ToString();
                txtBairro.Text = ds.Tables[0].Rows[0]["bairro"].ToString();
                txtCidade.Text = ds.Tables[0].Rows[0]["cidade"].ToString();
                cboEstado.Text = ds.Tables[0].Rows[0]["uf"].ToString();
                txtNumero.Focus();
            }
            else
            {
                MessageBox.Show("CEP não Encontrado!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public static void OpenForm(Type frmType)
        {
            bool bolCtl = false;
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType().Equals(frmType))
                {
                    form.Show();
                    bolCtl = true;
                    break;
                }
            }

            if (!bolCtl)
            {
                Form frm = (Form)Activator.CreateInstance(frmType);
                frm.Show();
            }
        }

        private void tstSalvar_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
   
        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtNome_Validating(object sender, CancelEventArgs e)
        {

        }

        public void Cadastro_Load_1(object sender, EventArgs e)
        {
            Pesquisarcli();
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void tstSalva_Click(object sender, EventArgs e)
        {
            Salvar();
           
        }
        public void Salvar()
        {
            string valor = maskedTextBox1.Text;
            
            
            {

                if (Negocio.clValidaCPF.IsCpf(valor))
                {
                    lblCPF.Text = "O número é um CPF Válido !";
                }
                else
                {
                    lblCPF.Text = "O número é um CPF Inválido !";
                }
            }

            if (txtNome.Text == "")
            {
                erNome.SetError(lblNome, "Insira um nome para o cliente");
            }
            // instancia a classe de negocio
            clCliente clClientes = new clCliente();
            if (txtNome.Text == "")
            {
                lblMensagem.Text = "Insina um nome para o cliente";
                return;
            }
            if (maskedTextBox1.Text == "")
            {
                lblMensagem.Text = "Insina um CPF para o cliente";
                return;
            }


            DialogResult resposta;
            resposta = MessageBox.Show("Confirma a inclusão?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (resposta.Equals(DialogResult.No))
            {
                return;
            }

            //carrega as propriedades
            clClientes.cliNome = txtNome.Text;
            clClientes.cliEndereco = txtEndereco.Text;
            clClientes.cliNumero = txtNumero.Text;
            clClientes.cliBairro = txtBairro.Text;
            clClientes.cliCidade = txtCidade.Text;
            clClientes.cliEstado = cboEstado.Text;
            clClientes.cliCEP = mskCep.Text;
            clClientes.cliCelular = mtbCelular.Text;
            clClientes.cliCPF = maskedTextBox1.Text;

            //variavel com a sstring de conexao com o banco
            clClientes.banco = Properties.Settings.Default.conexaoDB;
            if (txtCodigo.Text == "")
            {
                clClientes.Gravar();
            }
            else
            {
                clClientes.cliCodigo = Convert.ToInt32(txtCodigo.Text);
                clClientes.Alterar();
            }
            Pesquisarcli();
            MessageBox.Show("Cliente Cadastrado com Sucesso", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);       
            //mensagem de cofiguração
            MessageBox.Show("Cliente incluido com sucesso", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            ClearForm.ClearForms(this);
            erNome.SetError(lblNome, "");
           // lblNome = "";
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            ClearForm.ClearForms(this);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ClearForm.ClearForms(this);
        }

        private void Cadastro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue.Equals(27)) //ESC
            {
                this.Close();
            }
        }

        private void dgvClientes_DoubleClick(object sender, EventArgs e)
        {
            //verifica se existe itens na grid
            if(dgvClientes.RowCount==0)
            {
                return;
            }
            //carrega a tela com todos os dados do cliente
            SqlDataReader drReader;
            clCliente clCliente = new clCliente();
            clCliente.banco = Properties.Settings.Default.conexaoDB;
            drReader = clCliente.PesquisarCodigo(Convert.ToInt32(dgvClientes.CurrentRow.Cells[0].Value));
            if(drReader.Read())
            {
                //TRANFERE OS DADOS DO BANCO DE DADOS PARA O CAMPO DO FORM
                txtCodigo.Text = drReader["cliCodigo"].ToString();
                txtNome.Text = drReader["cliNome"].ToString();
                txtEndereco.Text = drReader["cliEndereco"].ToString();
                txtNumero.Text = drReader["cliNumero"].ToString();
                txtBairro.Text = drReader["cliBairro"].ToString();
                txtCidade.Text = drReader["cliCidade"].ToString();
                cboEstado.Text = drReader["cliEstado"].ToString();
                mskCep.Text = drReader["cliCep"].ToString();
                mtbCelular.Text = drReader["cliCelular"].ToString();

                //HABILITA O FRAME ENVIA CURSOR PARA O CAMPO DESCRIÇAO
                tabControl1.SelectedTab = tabPage2;
                txtNome.Focus();
            }
            drReader.Close();
        }

        private void tstExcluir_Click(object sender, EventArgs e)
        {
            //validaçao do conteudo
            if (txtCodigo.Text=="")
            {
                return;
            }
            //pergunta para o usuario se ele confirma exclusão de cdastro
            DialogResult resposta;
            resposta = MessageBox.Show("Confirma a Exclusão do cliente", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if(resposta.Equals(DialogResult.No))
            {
                return;
            }
            //instancia a classe do negocio
            clCliente clCliente = new clCliente();

            //variavel com string de conexao com o banco
            clCliente.banco = Properties.Settings.Default.conexaoDB;
            clCliente.cliCodigo = Convert.ToInt32(txtCodigo.Text);
            clCliente.Excluir();

            //ATUALIZA O DATAGRIDVIEW
            Pesquisarcli();

            //mensagem de configuraçãode exclusão
            MessageBox.Show("Cliente excluido com sucesso", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Salvar();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCep_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();

            string xml = "http://cep.republicavirtual.com.br/web_cep.php?cep=@cep&formato=xml".Replace("@cep", mskCep.Text);
            ds.ReadXml(xml);
            if (ds.Tables[0].Rows[0]["resultado_txt"].ToString() == "sucesso - cep completo" || ds.Tables[0].Rows[0]["resultado_txt"].ToString() == "sucesso - cep único")
            {
                txtEndereco.Text = ds.Tables[0].Rows[0]["tipo_logradouro"].ToString() + " " + ds.Tables[0].Rows[0]["logradouro"].ToString();
                txtBairro.Text = ds.Tables[0].Rows[0]["bairro"].ToString();
                txtCidade.Text = ds.Tables[0].Rows[0]["cidade"].ToString();
                cboEstado.Text = ds.Tables[0].Rows[0]["uf"].ToString();
                txtNumero.Focus();
            }
            else
            {
                MessageBox.Show("CEP não Encontrado!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            Pesquisarcli();
        }

    }
}
