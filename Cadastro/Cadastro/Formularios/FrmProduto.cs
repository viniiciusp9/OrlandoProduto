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

namespace Cadastro
{
    public partial class FrmProduto : Form
    {
        public static string PrecoFinal1 { get; set; }
        public static string PrecoFinal2 { get; set; }
        public static string PrecoFinal3 { get; set; }
        public static string PrecoFinal4 { get; set; }
        public FrmProduto()
        {
            InitializeComponent();
        }

        public void tstSalvar_Click(object sender, EventArgs e)
        {
            Salvar();

        }

        private void tstLimpar_Click(object sender, EventArgs e)
        {
            ClearForm.ClearForms(this);
        }

        private void tstCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnCadastrarProd_Click(object sender, EventArgs e)
        {
            Salvar();
        }
        public void Salvar()
        {
            {
                if (txtNome.Text == "")
                    erNome.SetError(lblNome, "Insira um nome para o cliente");
            }            // instancia a classe de negocio
            clProduto clProduto = new clProduto();
            if (txtNome.Text == "")
            {
                lblMenssagem.Text = "Insina um nome para o cliente";
                return;
            }



            DialogResult resposta;
            resposta = MessageBox.Show("Confirma o Cadastro do produto?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (resposta.Equals(DialogResult.No))
            {
                return;
            }


            //carrega as propriedades
            clProduto.proMarca = txtMarca.Text;
            clProduto.proPreco = txtPreco.Text;
            clProduto.proData = dtmData.Text;
            clProduto.proNome = txtNome.Text;
            clProduto.proNSerie = txtNSerie.Text;
            clProduto.proPNumber = txtPNumber.Text;
            clProduto.proPreco1 = PrecoFinal1;
            clProduto.proPreco2 = txtPreco2.Text;
            clProduto.proPreco3 = txtPreco3.Text;
            clProduto.proPreco4 = txtPreco4.Text;


            //variavel com a sstring de conexao com o banco
            clProduto.banco = Properties.Settings.Default.conexaoDB;
            if (txtCodigo.Text == "")
            {
                clProduto.Gravar();
            }
            else
            {
                clProduto.proCodigo = Convert.ToInt32(txtCodigo.Text);
                clProduto.Alterar();
            }
            //mensagem de cofiguração
            MessageBox.Show("Cliente incluido com sucesso", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            ClearForm.ClearForms(this);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtDescricao_Validating(object sender, CancelEventArgs e)
        {
        }

        private void txtDescricao_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNome_Validating(object sender, CancelEventArgs e)
        {
            {
                if (txtNome.Text == "")
                    erNome.SetError(lblNome, "Insira um nome para o cliente");
            }
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClearForm.ClearForms(this);
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCadastrarProd_Click_1(object sender, EventArgs e)
        {
            Salvar();
        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvClientes_ReadOnlyChanged(object sender, EventArgs e)
        {
          

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }
        public string banco { get; set; }

        public void FrmProduto_Load(object sender, EventArgs e)
        {
            PrecoFinal1 = "0";
            PrecoFinal2 = "0";
            PrecoFinal3 = "0";
            PrecoFinal4 = "0";
            PesquisarPro();
            
        }
        public void PesquisarPro()
        {
            //carrega o datagridview com os clientes cadastrados
            clProduto clProduto = new clProduto();
            clProduto.banco = Properties.Settings.Default.conexaoDB;
            dgvProdutos.DataSource = clProduto.Pesquisar("proNome", "%").Tables[0];
            //comando utilizado pra gerar um efeito "zebrado" no datagridview
            dgvProdutos.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;

        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            Pesquisar();
        }

        private void FrmProduto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue.Equals(27)) //ESC
            {
                this.Close();
            }
        }

        public void txtPreco_TextChanged(object sender, EventArgs e)
        {

        }
        public void ValorCusto()
        {
           // string PrecoCusto = txtPreco.Text(Convert.ToInt32);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmCalcPreco.PrecoCusto = txtPreco.Text;
            new FrmCalcPreco().Show();
        }

        private void FrmProduto_Activated(object sender, EventArgs e)
        {
            txtPreco1.Text = PrecoFinal1;
            txtPreco2.Text = PrecoFinal2;
            txtPreco3.Text = PrecoFinal3;
            txtPreco4.Text = PrecoFinal4;
        }

        private void txtPreco1_TextChanged(object sender, EventArgs e)
        {
            PrecoFinal1 = txtPreco1.Text;
        }

        private void txtPreco2_TextChanged(object sender, EventArgs e)
        {
            PrecoFinal2 = txtPreco2.Text;
        }

        private void txtPreco3_TextChanged(object sender, EventArgs e)
        {
            PrecoFinal3 = txtPreco3.Text;
        }

        private void txtPreco4_TextChanged(object sender, EventArgs e)
        {
            PrecoFinal4 = txtPreco4.Text;
        }

        private void dgvProdutos_DoubleClick(object sender, EventArgs e)
        {
            //verifica se existe itens na grid
            if (dgvProdutos.RowCount == 0)
            {
                return;
            }
            //carrega a tela com todos os dados do cliente
            SqlDataReader drReader;
            clProduto clProduto = new clProduto();
            clProduto.banco = Properties.Settings.Default.conexaoDB;
            drReader = clProduto.PesquisarCodigo(Convert.ToInt32(dgvProdutos.CurrentRow.Cells[0].Value));
            if (drReader.Read())
            {
                //TRANSFERE OS DADOS DO BANCO DE DADOS PARA O CAMPO DO FORM
                txtCodigo.Text = drReader["proCodigo"].ToString();
                txtNome.Text = drReader["proNome"].ToString();
                txtDescricao.Text = drReader["proDescricao"].ToString();
                txtMarca.Text = drReader["proMarca"].ToString();
                txtModelo.Text = drReader["proModelo"].ToString();
                txtNSerie.Text = drReader["proNSerie"].ToString();
                txtPNumber.Text = drReader["proPNumber"].ToString();
                dtmData.Text = drReader["proData"].ToString();
                txtPreco.Text = drReader["proPreco"].ToString();
                txtPreco1.Text = drReader["proPreco1"].ToString();
                txtPreco2.Text = drReader["proPreco2"].ToString();
                txtPreco3.Text = drReader["proPreco3"].ToString();
                txtPreco4.Text = drReader["proPreco4"].ToString();

                //HABILITA O FRAME ENVIA CURSOR PARA O CAMPO NOME
                tabControl1.SelectedTab = tabPage2;
                txtNome.Focus();
            }
            drReader.Close();
        }
        private void Pesquisar()
        {
            string campo = "";
            //selecione o campo de pesquisa
            if (cboOpcao.Text == "Código")
            {
                campo = "proCodigo";
            }
            else if (cboOpcao.Text == "Nome")
            {
                campo = "proNome";
            }
            clProduto clProduto = new clProduto();
            clProduto.banco = Properties.Settings.Default.conexaoDB;
            dgvProdutos.DataSource = clProduto.Pesquisar(campo, txtFiltro.Text).Tables[0];
            dgvProdutos.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            //validaçao do conteudo
            if (txtCodigo.Text == "")
            {
                return;
            }
            //pergunta para o usuario se ele confirma exclusão de cdastro
            DialogResult resposta;
            resposta = MessageBox.Show("Confirma a Exclusão do cliente", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (resposta.Equals(DialogResult.No))
            {
                return;
            }
            //instancia a classe do negocio
            clProduto clProduto = new clProduto();

            //variavel com string de conexao com o banco
            clProduto.banco = Properties.Settings.Default.conexaoDB;
            clProduto.proCodigo = Convert.ToInt32(txtCodigo.Text);
            clProduto.Excluir();

            //ATUALIZA O DATAGRIDVIEW
            PesquisarPro();

            //mensagem de configuraçãode exclusão
            MessageBox.Show("Cliente excluido com sucesso", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void dtmData_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}

