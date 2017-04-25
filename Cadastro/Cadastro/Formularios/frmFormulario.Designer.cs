namespace Cadastro
{
    partial class Cadastro
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cadastro));
            this.tstSalvar = new System.Windows.Forms.ToolStrip();
            this.tstSalva = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.tstExcluir = new System.Windows.Forms.ToolStripButton();
            this.tstPesquisar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tstSair = new System.Windows.Forms.ToolStripButton();
            this.erNome = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Pesquisar = new System.Windows.Forms.TabPage();
            this.cboOpcao = new System.Windows.Forms.ComboBox();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblMensagem = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblMenssagem = new System.Windows.Forms.Label();
            this.btnCep = new System.Windows.Forms.Button();
            this.mskCep = new System.Windows.Forms.MaskedTextBox();
            this.mtbCelular = new System.Windows.Forms.MaskedTextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.cboEstado = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCPF = new System.Windows.Forms.Label();
            this.tstSalvar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erNome)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.Pesquisar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tstSalvar
            // 
            this.tstSalvar.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.tstSalvar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tstSalva,
            this.toolStripButton1,
            this.tstExcluir,
            this.tstPesquisar,
            this.toolStripSeparator1,
            this.tstSair});
            this.tstSalvar.Location = new System.Drawing.Point(0, 0);
            this.tstSalvar.Name = "tstSalvar";
            this.tstSalvar.Size = new System.Drawing.Size(886, 25);
            this.tstSalvar.TabIndex = 4;
            this.tstSalvar.Text = "toolStrip1";
            this.tstSalvar.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.tstSalvar_ItemClicked);
            // 
            // tstSalva
            // 
            this.tstSalva.BackColor = System.Drawing.SystemColors.Control;
            this.tstSalva.Name = "tstSalva";
            this.tstSalva.Size = new System.Drawing.Size(42, 22);
            this.tstSalva.Text = "&Salvar";
            this.tstSalva.Click += new System.EventHandler(this.tstSalva_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(48, 22);
            this.toolStripButton1.Text = "Limpar";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // tstExcluir
            // 
            this.tstExcluir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tstExcluir.Image = ((System.Drawing.Image)(resources.GetObject("tstExcluir.Image")));
            this.tstExcluir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tstExcluir.Name = "tstExcluir";
            this.tstExcluir.Size = new System.Drawing.Size(45, 22);
            this.tstExcluir.Text = "&Excluir";
            this.tstExcluir.Click += new System.EventHandler(this.tstExcluir_Click);
            // 
            // tstPesquisar
            // 
            this.tstPesquisar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tstPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("tstPesquisar.Image")));
            this.tstPesquisar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tstPesquisar.Name = "tstPesquisar";
            this.tstPesquisar.Size = new System.Drawing.Size(61, 22);
            this.tstPesquisar.Text = "&Pesquisar";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tstSair
            // 
            this.tstSair.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tstSair.Image = ((System.Drawing.Image)(resources.GetObject("tstSair.Image")));
            this.tstSair.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tstSair.Name = "tstSair";
            this.tstSair.Size = new System.Drawing.Size(30, 22);
            this.tstSair.Text = "&Sair";
            this.tstSair.Click += new System.EventHandler(this.tstSair_Click);
            // 
            // erNome
            // 
            this.erNome.ContainerControl = this;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Pesquisar);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 54);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(874, 252);
            this.tabControl1.TabIndex = 5;
            // 
            // Pesquisar
            // 
            this.Pesquisar.Controls.Add(this.cboOpcao);
            this.Pesquisar.Controls.Add(this.txtFiltro);
            this.Pesquisar.Controls.Add(this.dgvClientes);
            this.Pesquisar.Location = new System.Drawing.Point(4, 22);
            this.Pesquisar.Name = "Pesquisar";
            this.Pesquisar.Padding = new System.Windows.Forms.Padding(3);
            this.Pesquisar.Size = new System.Drawing.Size(866, 226);
            this.Pesquisar.TabIndex = 0;
            this.Pesquisar.Text = "Pesquisar";
            this.Pesquisar.UseVisualStyleBackColor = true;
            // 
            // cboOpcao
            // 
            this.cboOpcao.FormattingEnabled = true;
            this.cboOpcao.Items.AddRange(new object[] {
            "Codigo",
            "Nome",
            "CPF"});
            this.cboOpcao.Location = new System.Drawing.Point(7, 17);
            this.cboOpcao.Name = "cboOpcao";
            this.cboOpcao.Size = new System.Drawing.Size(121, 21);
            this.cboOpcao.TabIndex = 2;
            this.cboOpcao.Text = "Codigo";
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(159, 17);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(699, 20);
            this.txtFiltro.TabIndex = 1;
            this.txtFiltro.TextChanged += new System.EventHandler(this.txtFiltro_TextChanged);
            // 
            // dgvClientes
            // 
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(6, 43);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.Size = new System.Drawing.Size(852, 177);
            this.dgvClientes.TabIndex = 0;
            this.dgvClientes.DoubleClick += new System.EventHandler(this.dgvClientes_DoubleClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lblMensagem);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(866, 226);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Cadastrar";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblMensagem
            // 
            this.lblMensagem.AutoSize = true;
            this.lblMensagem.Location = new System.Drawing.Point(135, 206);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(0, 13);
            this.lblMensagem.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblCPF);
            this.groupBox1.Controls.Add(this.maskedTextBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.lblMenssagem);
            this.groupBox1.Controls.Add(this.btnCep);
            this.groupBox1.Controls.Add(this.mskCep);
            this.groupBox1.Controls.Add(this.mtbCelular);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.cboEstado);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.txtCidade);
            this.groupBox1.Controls.Add(this.txtBairro);
            this.groupBox1.Controls.Add(this.txtNumero);
            this.groupBox1.Controls.Add(this.txtEndereco);
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Controls.Add(this.txtCodigo);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblNome);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(14, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(835, 211);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados do Cliente";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(716, 42);
            this.maskedTextBox1.Mask = "000,000,000-00";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(98, 20);
            this.maskedTextBox1.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(713, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "CPF";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(658, 182);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Limpar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // lblMenssagem
            // 
            this.lblMenssagem.AutoSize = true;
            this.lblMenssagem.Location = new System.Drawing.Point(12, 187);
            this.lblMenssagem.Name = "lblMenssagem";
            this.lblMenssagem.Size = new System.Drawing.Size(0, 13);
            this.lblMenssagem.TabIndex = 17;
            // 
            // btnCep
            // 
            this.btnCep.Image = ((System.Drawing.Image)(resources.GetObject("btnCep.Image")));
            this.btnCep.Location = new System.Drawing.Point(86, 90);
            this.btnCep.Name = "btnCep";
            this.btnCep.Size = new System.Drawing.Size(37, 23);
            this.btnCep.TabIndex = 3;
            this.btnCep.UseVisualStyleBackColor = true;
            this.btnCep.Click += new System.EventHandler(this.btnCep_Click);
            // 
            // mskCep
            // 
            this.mskCep.Location = new System.Drawing.Point(9, 92);
            this.mskCep.Mask = "00000-999";
            this.mskCep.Name = "mskCep";
            this.mskCep.Size = new System.Drawing.Size(71, 20);
            this.mskCep.TabIndex = 2;
            // 
            // mtbCelular
            // 
            this.mtbCelular.Location = new System.Drawing.Point(682, 146);
            this.mtbCelular.Mask = "(99) 00000-0000";
            this.mtbCelular.Name = "mtbCelular";
            this.mtbCelular.Size = new System.Drawing.Size(132, 20);
            this.mtbCelular.TabIndex = 11;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(739, 182);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 16;
            this.button3.Text = "Cancelar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // cboEstado
            // 
            this.cboEstado.FormattingEnabled = true;
            this.cboEstado.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA\t ",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA\t ",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.cboEstado.Location = new System.Drawing.Point(631, 144);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(45, 21);
            this.cboEstado.TabIndex = 10;
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(551, 182);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Cadastrar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(228, 144);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(394, 20);
            this.txtCidade.TabIndex = 9;
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(9, 145);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(213, 20);
            this.txtBairro.TabIndex = 8;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(716, 92);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(98, 20);
            this.txtNumero.TabIndex = 7;
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(129, 92);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(581, 20);
            this.txtEndereco.TabIndex = 6;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(97, 42);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(613, 20);
            this.txtNome.TabIndex = 0;
            this.txtNome.Tag = "1";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCodigo.Enabled = false;
            this.txtCodigo.HideSelection = false;
            this.txtCodigo.Location = new System.Drawing.Point(6, 42);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(82, 20);
            this.txtCodigo.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(679, 130);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Celular";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(628, 128);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Estado";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(225, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Cidade";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Bairro";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(713, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Numero";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(129, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Endereço";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "CEP";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(94, 26);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Nome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Código";
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(679, 65);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(0, 13);
            this.lblCPF.TabIndex = 21;
            // 
            // Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 318);
            this.ControlBox = false;
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.tstSalvar);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Cadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "1";
            this.Text = "Cadastrar Cliente";
            this.Load += new System.EventHandler(this.Cadastro_Load_1);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Cadastro_DragDrop);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Cadastro_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Cadastro_KeyPress);
            this.tstSalvar.ResumeLayout(false);
            this.tstSalvar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erNome)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.Pesquisar.ResumeLayout(false);
            this.Pesquisar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip tstSalvar;
        private System.Windows.Forms.ToolStripButton tstSalva;
        private System.Windows.Forms.ToolStripButton tstExcluir;
        private System.Windows.Forms.ToolStripButton tstPesquisar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tstSair;
        private System.Windows.Forms.ErrorProvider erNome;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Pesquisar;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lblMensagem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblMenssagem;
        private System.Windows.Forms.Button btnCep;
        private System.Windows.Forms.MaskedTextBox mskCep;
        private System.Windows.Forms.MaskedTextBox mtbCelular;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox cboEstado;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.ComboBox cboOpcao;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCPF;
    }
}

