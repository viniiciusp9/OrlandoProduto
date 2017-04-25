namespace Cadastro
{
    partial class FrmFuncionarios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Pesquisar = new System.Windows.Forms.TabPage();
            this.dgvFuncionarios = new System.Windows.Forms.DataGridView();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.cboOpcao = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblMensagem = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.lblCode = new System.Windows.Forms.Label();
            this.lblMensagem1 = new System.Windows.Forms.Label();
            this.lblMensagem2 = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.chkUsuarios = new System.Windows.Forms.CheckBox();
            this.chkClientes = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.Pesquisar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionarios)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Pesquisar);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(13, 54);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(641, 318);
            this.tabControl1.TabIndex = 0;
            // 
            // Pesquisar
            // 
            this.Pesquisar.Controls.Add(this.dgvFuncionarios);
            this.Pesquisar.Controls.Add(this.txtFiltro);
            this.Pesquisar.Controls.Add(this.cboOpcao);
            this.Pesquisar.Controls.Add(this.label2);
            this.Pesquisar.Controls.Add(this.label1);
            this.Pesquisar.Location = new System.Drawing.Point(4, 22);
            this.Pesquisar.Name = "Pesquisar";
            this.Pesquisar.Padding = new System.Windows.Forms.Padding(3);
            this.Pesquisar.Size = new System.Drawing.Size(633, 292);
            this.Pesquisar.TabIndex = 0;
            this.Pesquisar.Text = "Pesquisar";
            this.Pesquisar.UseVisualStyleBackColor = true;
            // 
            // dgvFuncionarios
            // 
            this.dgvFuncionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFuncionarios.Location = new System.Drawing.Point(20, 62);
            this.dgvFuncionarios.Name = "dgvFuncionarios";
            this.dgvFuncionarios.Size = new System.Drawing.Size(593, 166);
            this.dgvFuncionarios.TabIndex = 4;
            this.dgvFuncionarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFuncionarios_CellContentClick);
            this.dgvFuncionarios.DoubleClick += new System.EventHandler(this.dvgFuncionarios_DoubleClick);
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(147, 35);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(466, 20);
            this.txtFiltro.TabIndex = 3;
            // 
            // cboOpcao
            // 
            this.cboOpcao.FormattingEnabled = true;
            this.cboOpcao.Items.AddRange(new object[] {
            "Login",
            "Senha"});
            this.cboOpcao.Location = new System.Drawing.Point(20, 34);
            this.cboOpcao.Name = "cboOpcao";
            this.cboOpcao.Size = new System.Drawing.Size(102, 21);
            this.cboOpcao.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(144, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Filtro";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pesquisa";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lblMensagem);
            this.tabPage2.Controls.Add(this.txtCode);
            this.tabPage2.Controls.Add(this.lblCode);
            this.tabPage2.Controls.Add(this.lblMensagem1);
            this.tabPage2.Controls.Add(this.lblMensagem2);
            this.tabPage2.Controls.Add(this.btnSair);
            this.tabPage2.Controls.Add(this.btnLimpar);
            this.tabPage2.Controls.Add(this.btnSalvar);
            this.tabPage2.Controls.Add(this.txtSenha);
            this.tabPage2.Controls.Add(this.txtLogin);
            this.tabPage2.Controls.Add(this.chkUsuarios);
            this.tabPage2.Controls.Add(this.chkClientes);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(633, 292);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Dados do Funcionario";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // lblMensagem
            // 
            this.lblMensagem.AutoSize = true;
            this.lblMensagem.Location = new System.Drawing.Point(23, 221);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(13, 13);
            this.lblMensagem.TabIndex = 14;
            this.lblMensagem.Text = "  ";
            // 
            // txtCode
            // 
            this.txtCode.Enabled = false;
            this.txtCode.Location = new System.Drawing.Point(69, 29);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(100, 20);
            this.txtCode.TabIndex = 13;
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(20, 32);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(43, 13);
            this.lblCode.TabIndex = 12;
            this.lblCode.Text = "Codigo:";
            // 
            // lblMensagem1
            // 
            this.lblMensagem1.AutoSize = true;
            this.lblMensagem1.Location = new System.Drawing.Point(327, 90);
            this.lblMensagem1.Name = "lblMensagem1";
            this.lblMensagem1.Size = new System.Drawing.Size(13, 13);
            this.lblMensagem1.TabIndex = 11;
            this.lblMensagem1.Text = "  ";
            // 
            // lblMensagem2
            // 
            this.lblMensagem2.AutoSize = true;
            this.lblMensagem2.Location = new System.Drawing.Point(340, 143);
            this.lblMensagem2.Name = "lblMensagem2";
            this.lblMensagem2.Size = new System.Drawing.Size(0, 13);
            this.lblMensagem2.TabIndex = 10;
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(215, 240);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 8;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(118, 240);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 7;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(23, 240);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 6;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(23, 137);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(297, 20);
            this.txtSenha.TabIndex = 5;
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(23, 90);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(297, 20);
            this.txtLogin.TabIndex = 4;
            // 
            // chkUsuarios
            // 
            this.chkUsuarios.AutoSize = true;
            this.chkUsuarios.Location = new System.Drawing.Point(23, 198);
            this.chkUsuarios.Name = "chkUsuarios";
            this.chkUsuarios.Size = new System.Drawing.Size(67, 17);
            this.chkUsuarios.TabIndex = 3;
            this.chkUsuarios.Text = "Usuarios";
            this.chkUsuarios.UseVisualStyleBackColor = true;
            // 
            // chkClientes
            // 
            this.chkClientes.AutoSize = true;
            this.chkClientes.Location = new System.Drawing.Point(23, 175);
            this.chkClientes.Name = "chkClientes";
            this.chkClientes.Size = new System.Drawing.Size(63, 17);
            this.chkClientes.TabIndex = 2;
            this.chkClientes.Text = "Clientes";
            this.chkClientes.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Senha:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Login:";
            // 
            // FrmFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 384);
            this.Controls.Add(this.tabControl1);
            this.KeyPreview = true;
            this.Name = "FrmFuncionarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Funcionários";
            this.Load += new System.EventHandler(this.FrmFuncionarios_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmFuncionarios_KeyDown);
            this.tabControl1.ResumeLayout(false);
            this.Pesquisar.ResumeLayout(false);
            this.Pesquisar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionarios)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Pesquisar;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboOpcao;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.DataGridView dgvFuncionarios;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblMensagem2;
        private System.Windows.Forms.Label lblMensagem1;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.CheckBox chkUsuarios;
        private System.Windows.Forms.CheckBox chkClientes;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Label lblMensagem;
    }
}