using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using System.Data.SqlClient;
using System.Drawing.Printing;
using System.IO;

namespace Cadastro
{
    public partial class FrmCadFornecedor : Form
    {
        public FrmCadFornecedor()

        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            PesquisarCep();
        }
        private void PesquisarCep()
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

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtRazao.Text == "")
            {
              //  erNome.SetError(lblNome, "Insira um nome para o cliente");
            }
            // instancia a classe de negocio
            clFornecedor clFornecedores = new clFornecedor();
            if (txtRazao.Text == "")
            {
                lblMemssagem.Text = "Insina uma Razão social para o Fornecedor";
                return;
            }

            DialogResult resposta;
            resposta = MessageBox.Show("Confirma a inclusão?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (resposta.Equals(DialogResult.No))
            {
                return;
            }

            //carrega as propriedades
            clFornecedores.ForRazao = txtRazao.Text;
            clFornecedores.ForContato = txtRazao.Text;
            clFornecedores.ForIE = mskIE.Text;
            clFornecedores.ForIM = txtIM.Text;
            clFornecedores.ForTel = mskTel.Text;
            clFornecedores.ForTel2 = mskTel2.Text;
            clFornecedores.ForCel = mskCel.Text;
            clFornecedores.ForCel2 = mskCel2.Text;

            //variavel com a sstring de conexao com o banco
            clFornecedores.banco = Properties.Settings.Default.conexaoDB;
            //chama metodo para gravar
            clFornecedores.Gravar();
            //mensagem de cofiguração
            MessageBox.Show("Fornecedor incluido com sucesso", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            lblMemssagem.Text = "Fornecedor cadastrado com sucesso";
            ClearForm.ClearForms(this);
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            ClearForm.ClearForms(this);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmCadFornecedor_Load(object sender, EventArgs e)
        {
            PesquisarDGV();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            ClearForm.ClearForms(this);
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSalvar_Click_1(object sender, EventArgs e)
        {
            Salvar();
        }
        public void Salvar()
        {
            if (txtRazao.Text == "")
            {
                //  erNome.SetError(lblNome, "Insira um nome para o cliente");
            }
            // instancia a classe de negocio
            clFornecedor clFornecedores = new clFornecedor();
            if (txtRazao.Text == "")
            {
                lblMemssagem.Text = "Insina uma Razão social para o Fornecedor";
                return;
            }

            DialogResult resposta;
            resposta = MessageBox.Show("Confirma a inclusão?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (resposta.Equals(DialogResult.No))
            {
                return;
            }

            //carrega as propriedades
            clFornecedores.cnpj = mskcnpj.Text;
            clFornecedores.ForRazao = txtRazao.Text;
            clFornecedores.ForContato = txtRazao.Text;
            clFornecedores.ForIE = mskIE.Text;
            clFornecedores.ForIM = txtIM.Text;
            clFornecedores.ForTel = mskTel.Text;
            clFornecedores.ForTel2 = mskTel2.Text;
            clFornecedores.ForCel = mskCel.Text;
            clFornecedores.ForCel2 = mskCel2.Text;
            clFornecedores.ForBairro = txtBairro.Text;
            clFornecedores.ForCEP = mskCep.Text;
            clFornecedores.ForComplemento = txtComplemento.Text;
            clFornecedores.ForEstado = cboEstado.Text;
            clFornecedores.ForFax = mskFax.Text;
            clFornecedores.ForMail = txtMail.Text;
            clFornecedores.ForMunicipio = txtCidade.Text;
            clFornecedores.ForNum = txtNumero.Text;
            clFornecedores.ForRua = txtEndereco.Text;
            clFornecedores.Data = dtmData.Text;

            //variavel com a sstring de conexao com o banco
            clFornecedores.banco = Properties.Settings.Default.conexaoDB;
            if (txtCodigo.Text == "")
            {
                clFornecedores.Gravar();
            }
            else
            {
                clFornecedores.id = Convert.ToInt32(txtCodigo.Text);
                clFornecedores.Alterar();
            }
            //mensagem de cofiguração
            MessageBox.Show("Cliente incluido com sucesso", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            ClearForm.ClearForms(this);
        }

        private void btnLimpar_Click_1(object sender, EventArgs e)
        {
            ClearForm.ClearForms(this);
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            PesquisarDGV();
        }
        private void PesquisarDGV()
        {
            string campo = "";
            //seleciona o campo de pesquia
            if (cboOpcao.Text == "CNPJ")
            {
                campo = "cnpj";
            }
            else if (cboOpcao.Text == "Razão")
            {
                campo = "forRazao";
            }
            else if(cboOpcao.Text=="Codigo")
            {
                campo = "id";
            }
            //carrega o datagridview comos clientes cadastrados
            clFornecedor clFornecedor = new clFornecedor();
            clFornecedor.banco = Properties.Settings.Default.conexaoDB;
            dgvFornecedor.DataSource = clFornecedor.Pesquisar(campo, txtFiltro.Text).Tables[0];
            //comand utilizado para gerar um efeito "zebrado" no datagridview
            dgvFornecedor.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
        }

        private void FrmCadFornecedor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue.Equals(27)) //ESC
            {
                this.Close();
            }
        }

        private void dgvFornecedor_DoubleClick(object sender, EventArgs e)
        {
            //verifica se existe itens na grid
            if (dgvFornecedor.RowCount == 0)
            {
                return;
            }
            //carrega a tela com todos os dados do cliente
            SqlDataReader drReader;
            clFornecedor clFornecedor = new clFornecedor();
            clFornecedor.banco = Properties.Settings.Default.conexaoDB;
            drReader = clFornecedor.PesquisarCodigo(Convert.ToInt32(dgvFornecedor.CurrentRow.Cells[0].Value));
            if (drReader.Read())
            {
                //TRANFERE OS DADOS DO BANCO DE DADOS PARA O CAMPO DO FORM
                txtCodigo.Text = drReader["id"].ToString();
                mskcnpj.Text = drReader["cnpj"].ToString();
                txtRazao.Text = drReader["ForRazao"].ToString();
                txtBairro.Text = drReader["ForBairro"].ToString();
                txtCidade.Text = drReader["ForMunicipio"].ToString();
                txtComplemento.Text = drReader["ForComplemento"].ToString();
                txtContato.Text = drReader["ForContato"].ToString();
                txtEndereco.Text = drReader["ForRua"].ToString();
                txtIM.Text = drReader["ForIM"].ToString();
                txtMail.Text = drReader["ForMail"].ToString();
                txtNumero.Text = drReader["ForNum"].ToString();
                mskCel.Text = drReader["ForCel"].ToString();
                mskCel2.Text = drReader["ForCel2"].ToString();
                mskCep.Text = drReader["ForCEP"].ToString();
                mskFax.Text = drReader["ForFax"].ToString();
                mskIE.Text = drReader["ForIE"].ToString();
                mskTel.Text = drReader["ForTel"].ToString();
                mskTel2.Text = drReader["ForTel2"].ToString();
                cboEstado.Text = drReader["ForEstado"].ToString();

                //HABILITA O FRAME ENVIA CURSOR PARA O CAMPO DESCRIÇAO
                TabControl1.SelectedTab = Cadastrar;
                mskcnpj.Focus();
            }
            drReader.Close();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            //validaçao do conteudo
            if (txtCodigo.Text == "")
            {
                return;
            }
            //pergunta para o usuario se ele confirma exclusão de cdastro
            DialogResult resposta;
            resposta = MessageBox.Show("Confirma a Exclusão do Fornecedor", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (resposta.Equals(DialogResult.No))
            {
                return;
            }
            //instancia a classe do negocio
            clFornecedor clFornecedor = new clFornecedor();

            //variavel com string de conexao com o banco
            clFornecedor.banco = Properties.Settings.Default.conexaoDB;
            clFornecedor.id = Convert.ToInt32(txtCodigo.Text);
            clFornecedor.Excluir();

            //ATUALIZA O DATAGRIDVIEW
            PesquisarDGV();

            //mensagem de configuraçãode exclusão
            MessageBox.Show("Cliente excluido com sucesso", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            PesquisarCep();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
    }

  


