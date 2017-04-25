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

namespace Cadastro
{
    public partial class FrmInicio : Form
    {
        //propriedades estáticas para receber
        //informações vindas de outro formulário

        public static bool Clientes { get; set; }

        public static bool Produtos { get; set; }

        public FrmInicio()
        {
            InitializeComponent();
        }

        private void btnCadProduto_Click(object sender, EventArgs e)
        {
            new FrmProduto().Show();
        }

        private void btnCadCliente_Click(object sender, EventArgs e)
        {
            new Cadastro().Show();
        }

        private void btnCadFornecedor_Click(object sender, EventArgs e)
        {
            new FrmCadFornecedor().Show();
        }

        private void FrmInicio_Activated(object sender, EventArgs e)
        {
            //desabilita o menus bloqueados para o usuário
            if (Clientes == false)
            {
                btnCadCliente.Enabled = false;
            }
            if (Produtos == false)
            {
                btnCadProduto.Enabled = false;
            }

        }

        private void FrmInicio_Load(object sender, EventArgs e)
        {
           
        }

        private void FrmInicio_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnCadFuncionario_Click(object sender, EventArgs e)
        {
            new FrmFuncionarios().Show();
        }
    }
}
