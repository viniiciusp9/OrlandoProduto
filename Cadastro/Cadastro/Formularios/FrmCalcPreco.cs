using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Cadastro
{
    public partial class FrmCalcPreco : Form
    {
        public static string PrecoCusto { get; set; }
        public FrmCalcPreco()
        {
            InitializeComponent();
        }

        private void FrmCalcPreco_Load(object sender, EventArgs e)
        {
            FrmProduto.PrecoFinal1 = txtPrecoF1.Text;
        }

        private void txtCustoP1_TextChanged(object sender, EventArgs e)
        {
          //  txtCustoP1 == txtPrecoCusto;
        }

        private void txtPrecoCusto_TextChanged(object sender, EventArgs e)
        {
            txtCustoP1.Text = txtPrecoCusto.Text;
            txtCustoP2.Text = txtPrecoCusto.Text;
            txtCustoP3.Text = txtPrecoCusto.Text;
            txtCustoP4.Text = txtPrecoCusto.Text;

        }

        public void textBox3_TextChanged(object sender, EventArgs e)
        {
            string CalcP1=txtCalcP1.Text;
            string ValorCusto = txtCustoP1.Text;
            double intValorCusto = Convert.ToDouble(ValorCusto);
            double intCalcP1 = Convert.ToDouble(CalcP1);
            double porcentagem = (intCalcP1/100);
            //int Preco1Calculado = (intValorCusto*porcentagem);
            double Preco1Calculado = (intValorCusto*porcentagem);
            double Preco1Final = (Preco1Calculado + intValorCusto);
            // string valorpf1 = Convert.ToString("valorp1");
            string valorfinal = Convert.ToString(Preco1Final);
            txtPrecoF1.Text = valorfinal;
        }
        public void Valores()
        {
            string PrecoF1=txtPrecoF1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //string PrecoFinal1 = txtPrecoF1.Text;
            FrmProduto.PrecoFinal1 = txtPrecoF1.Text;
            FrmProduto.PrecoFinal2 = txtPrecoF2.Text;
            FrmProduto.PrecoFinal3 = txtPrecoF3.Text;
            FrmProduto.PrecoFinal4 = txtPrecoF4.Text;
            Close();

        }

        private void txtCalcP2_TextChanged(object sender, EventArgs e)
        {
            string CalcP2 = txtCalcP2.Text;
            string ValorCusto = txtCustoP2.Text;
            double intValorCusto = Convert.ToDouble(ValorCusto);
            double intCalcP2 = Convert.ToDouble(CalcP2);
            double porcentagem = (intCalcP2 / 100);
            //int Preco1Calculado = (intValorCusto*porcentagem);
            double Preco2Calculado = (intValorCusto * porcentagem);
            double Preco2Final = (Preco2Calculado + intValorCusto);
            // string valorpf1 = Convert.ToString("valorp1");
            string valorfinal = Convert.ToString(Preco2Final);
            txtPrecoF2.Text = valorfinal;
        }

        private void txtCalcP3_TextChanged(object sender, EventArgs e)
        {
            string CalcP3 = txtCalcP3.Text;
            string ValorCusto = txtCustoP3.Text;
            double intValorCusto = Convert.ToDouble(ValorCusto);
            double intCalcP3 = Convert.ToDouble(CalcP3);
            double porcentagem = (intCalcP3 / 100);
            //int Preco1Calculado = (intValorCusto*porcentagem);
            double Preco3Calculado = (intValorCusto * porcentagem);
            double Preco3Final = (Preco3Calculado + intValorCusto);
            // string valorpf1 = Convert.ToString("valorp1");
            string valorfinal = Convert.ToString(Preco3Final);
            txtPrecoF3.Text = valorfinal;
        }

        private void txtCalcP4_TextChanged(object sender, EventArgs e)
        {
            string CalcP4 = txtCalcP4.Text;
            string ValorCusto = txtCustoP4.Text;
            double intValorCusto = Convert.ToDouble(ValorCusto);
            double intCalcP4 = Convert.ToDouble(CalcP4);
            double porcentagem = (intCalcP4 / 100);
            //int Preco1Calculado = (intValorCusto*porcentagem);
            double Preco4Calculado = (intValorCusto * porcentagem);
            double Preco4Final = (Preco4Calculado + intValorCusto);
            // string valorpf1 = Convert.ToString("valorp1");
            string valorfinal = Convert.ToString(Preco4Final);
            txtPrecoF4.Text = valorfinal;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmCalcPreco_Activated(object sender, EventArgs e)
        {
            txtPrecoCusto.Text = PrecoCusto;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ClearForm.ClearForms(this);
        }
    }
}
