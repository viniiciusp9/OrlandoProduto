using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadastro.Formularios
{
    public partial class FrmSplash : Form
    {
        public FrmSplash()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //oculta o form splash 
            Hide();
            //desativa p timer
            timer1.Enabled = false;

            //cria a instancia do form de login
            FrmLogin FrmLogin = new FrmLogin();
            FrmLogin.Show();
        }

        private void FrmSplash_Load(object sender, EventArgs e)
        {
            //MUDA O PONTEIRO DO MOUSE
            UseWaitCursor = true;
        }
    }
}
