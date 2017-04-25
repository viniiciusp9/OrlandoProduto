namespace Cadastro
{
    partial class FrmProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProduto));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tstSalvar = new System.Windows.Forms.ToolStripButton();
            this.tstLimpar = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.tstCancelar = new System.Windows.Forms.ToolStripButton();
            this.erDescricao = new System.Windows.Forms.ErrorProvider(this.components);
            this.erNome = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.txtPreco4 = new System.Windows.Forms.TextBox();
            this.txtPreco3 = new System.Windows.Forms.TextBox();
            this.txtPreco2 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPNumber = new System.Windows.Forms.TextBox();
            this.txtNSerie = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.txtPreco1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnCadastrarProd = new System.Windows.Forms.Button();
            this.dtmData = new System.Windows.Forms.DateTimePicker();
            this.lblMenssagem = new System.Windows.Forms.Label();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.cboOpcao = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erDescricao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erNome)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tstSalvar,
            this.tstLimpar,
            this.toolStripButton1,
            this.tstCancelar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(964, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tstSalvar
            // 
            this.tstSalvar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tstSalvar.Image = ((System.Drawing.Image)(resources.GetObject("tstSalvar.Image")));
            this.tstSalvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tstSalvar.Name = "tstSalvar";
            this.tstSalvar.Size = new System.Drawing.Size(42, 22);
            this.tstSalvar.Text = "&Salvar";
            this.tstSalvar.Click += new System.EventHandler(this.tstSalvar_Click);
            // 
            // tstLimpar
            // 
            this.tstLimpar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tstLimpar.Image = ((System.Drawing.Image)(resources.GetObject("tstLimpar.Image")));
            this.tstLimpar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tstLimpar.Name = "tstLimpar";
            this.tstLimpar.Size = new System.Drawing.Size(48, 22);
            this.tstLimpar.Text = "&Limpar";
            this.tstLimpar.Click += new System.EventHandler(this.tstLimpar_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(45, 22);
            this.toolStripButton1.Text = "Excluir";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // tstCancelar
            // 
            this.tstCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tstCancelar.Image = ((System.Drawing.Image)(resources.GetObject("tstCancelar.Image")));
            this.tstCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tstCancelar.Name = "tstCancelar";
            this.tstCancelar.Size = new System.Drawing.Size(30, 22);
            this.tstCancelar.Text = "&Sair";
            this.tstCancelar.Click += new System.EventHandler(this.tstCancelar_Click);
            // 
            // erDescricao
            // 
            this.erDescricao.ContainerControl = this;
            // 
            // erNome
            // 
            this.erNome.ContainerControl = this;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(944, 266);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Cadastrar produto";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.txtPreco4);
            this.groupBox1.Controls.Add(this.txtPreco3);
            this.groupBox1.Controls.Add(this.txtPreco2);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtPNumber);
            this.groupBox1.Controls.Add(this.txtNSerie);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtModelo);
            this.groupBox1.Controls.Add(this.txtPreco1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Controls.Add(this.lblNome);
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Controls.Add(this.btnCadastrarProd);
            this.groupBox1.Controls.Add(this.dtmData);
            this.groupBox1.Controls.Add(this.lblMenssagem);
            this.groupBox1.Controls.Add(this.txtPreco);
            this.groupBox1.Controls.Add(this.txtMarca);
            this.groupBox1.Controls.Add(this.txtDescricao);
            this.groupBox1.Controls.Add(this.txtCodigo);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(921, 254);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(610, 168);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Calcular Preço";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(500, 152);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(44, 13);
            this.label14.TabIndex = 26;
            this.label14.Text = "Preço 4";
            // 
            // txtPreco4
            // 
            this.txtPreco4.Location = new System.Drawing.Point(500, 168);
            this.txtPreco4.Name = "txtPreco4";
            this.txtPreco4.Size = new System.Drawing.Size(100, 20);
            this.txtPreco4.TabIndex = 25;
            this.txtPreco4.TabStop = false;
            this.txtPreco4.Text = "0";
            this.txtPreco4.TextChanged += new System.EventHandler(this.txtPreco4_TextChanged);
            // 
            // txtPreco3
            // 
            this.txtPreco3.Location = new System.Drawing.Point(394, 168);
            this.txtPreco3.Name = "txtPreco3";
            this.txtPreco3.Size = new System.Drawing.Size(100, 20);
            this.txtPreco3.TabIndex = 24;
            this.txtPreco3.TabStop = false;
            this.txtPreco3.Text = "0";
            this.txtPreco3.TextChanged += new System.EventHandler(this.txtPreco3_TextChanged);
            // 
            // txtPreco2
            // 
            this.txtPreco2.Location = new System.Drawing.Point(288, 168);
            this.txtPreco2.Name = "txtPreco2";
            this.txtPreco2.Size = new System.Drawing.Size(100, 20);
            this.txtPreco2.TabIndex = 23;
            this.txtPreco2.TabStop = false;
            this.txtPreco2.Text = "0";
            this.txtPreco2.TextChanged += new System.EventHandler(this.txtPreco2_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(394, 152);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 13);
            this.label13.TabIndex = 22;
            this.label13.Text = "Preço 3";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(285, 152);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 13);
            this.label12.TabIndex = 21;
            this.label12.Text = "Preço 2";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(179, 152);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "Preço 1";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(559, 91);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Part Number";
            // 
            // txtPNumber
            // 
            this.txtPNumber.Location = new System.Drawing.Point(562, 107);
            this.txtPNumber.Name = "txtPNumber";
            this.txtPNumber.Size = new System.Drawing.Size(123, 20);
            this.txtPNumber.TabIndex = 6;
            // 
            // txtNSerie
            // 
            this.txtNSerie.Location = new System.Drawing.Point(411, 107);
            this.txtNSerie.Name = "txtNSerie";
            this.txtNSerie.Size = new System.Drawing.Size(145, 20);
            this.txtNSerie.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(408, 91);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Nº Serie";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(252, 91);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Modelo";
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(255, 107);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(144, 20);
            this.txtModelo.TabIndex = 4;
            // 
            // txtPreco1
            // 
            this.txtPreco1.Location = new System.Drawing.Point(182, 168);
            this.txtPreco1.Name = "txtPreco1";
            this.txtPreco1.Size = new System.Drawing.Size(100, 20);
            this.txtPreco1.TabIndex = 20;
            this.txtPreco1.TabStop = false;
            this.txtPreco1.Text = "0";
            this.txtPreco1.TextChanged += new System.EventHandler(this.txtPreco1_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(747, 225);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Limpar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(196, 49);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(489, 20);
            this.txtNome.TabIndex = 1;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(192, 33);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(90, 13);
            this.lblNome.TabIndex = 11;
            this.lblNome.Text = "Nome do Produto";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(828, 225);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click_1);
            // 
            // btnCadastrarProd
            // 
            this.btnCadastrarProd.Location = new System.Drawing.Point(655, 225);
            this.btnCadastrarProd.Name = "btnCadastrarProd";
            this.btnCadastrarProd.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrarProd.TabIndex = 9;
            this.btnCadastrarProd.Text = "Cadastrar";
            this.btnCadastrarProd.UseVisualStyleBackColor = true;
            this.btnCadastrarProd.Click += new System.EventHandler(this.btnCadastrarProd_Click_1);
            // 
            // dtmData
            // 
            this.dtmData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtmData.Location = new System.Drawing.Point(699, 107);
            this.dtmData.Name = "dtmData";
            this.dtmData.Size = new System.Drawing.Size(204, 20);
            this.dtmData.TabIndex = 66;
            this.dtmData.TabStop = false;
            this.dtmData.ValueChanged += new System.EventHandler(this.dtmData_ValueChanged);
            // 
            // lblMenssagem
            // 
            this.lblMenssagem.AutoSize = true;
            this.lblMenssagem.Location = new System.Drawing.Point(28, 152);
            this.lblMenssagem.Name = "lblMenssagem";
            this.lblMenssagem.Size = new System.Drawing.Size(0, 13);
            this.lblMenssagem.TabIndex = 10;
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(22, 168);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(150, 20);
            this.txtPreco.TabIndex = 7;
            this.txtPreco.Text = "0";
            this.txtPreco.TextChanged += new System.EventHandler(this.txtPreco_TextChanged);
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(22, 107);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(227, 20);
            this.txtMarca.TabIndex = 3;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(691, 49);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(212, 20);
            this.txtDescricao.TabIndex = 2;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(25, 49);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(165, 20);
            this.txtCodigo.TabIndex = 5;
            this.txtCodigo.TabStop = false;
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(696, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Data";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Preço de Custo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Marca";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(688, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descrição";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvProdutos);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.txtFiltro);
            this.tabPage1.Controls.Add(this.cboOpcao);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(944, 266);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Pesquisar";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.AllowUserToAddRows = false;
            this.dgvProdutos.AllowUserToDeleteRows = false;
            this.dgvProdutos.AllowUserToOrderColumns = true;
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Location = new System.Drawing.Point(6, 71);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.ReadOnly = true;
            this.dgvProdutos.Size = new System.Drawing.Size(930, 189);
            this.dgvProdutos.TabIndex = 4;
            this.dgvProdutos.ReadOnlyChanged += new System.EventHandler(this.dgvClientes_ReadOnlyChanged);
            this.dgvProdutos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientes_CellContentClick);
            this.dgvProdutos.DoubleClick += new System.EventHandler(this.dgvProdutos_DoubleClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Pesquisa";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(156, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Filtro";
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(159, 33);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(777, 20);
            this.txtFiltro.TabIndex = 1;
            this.txtFiltro.TextChanged += new System.EventHandler(this.txtFiltro_TextChanged);
            // 
            // cboOpcao
            // 
            this.cboOpcao.FormattingEnabled = true;
            this.cboOpcao.Items.AddRange(new object[] {
            "Código",
            "Nome"});
            this.cboOpcao.Location = new System.Drawing.Point(6, 33);
            this.cboOpcao.Name = "cboOpcao";
            this.cboOpcao.Size = new System.Drawing.Size(147, 21);
            this.cboOpcao.TabIndex = 0;
            this.cboOpcao.Text = "NOME";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 39);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(952, 292);
            this.tabControl1.TabIndex = 2;
            // 
            // FrmProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 343);
            this.ControlBox = false;
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.toolStrip1);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Produto";
            this.Activated += new System.EventHandler(this.FrmProduto_Activated);
            this.Load += new System.EventHandler(this.FrmProduto_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmProduto_KeyDown);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erDescricao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erNome)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tstSalvar;
        private System.Windows.Forms.ToolStripButton tstLimpar;
        private System.Windows.Forms.ToolStripButton tstCancelar;
        private System.Windows.Forms.ErrorProvider erDescricao;
        private System.Windows.Forms.ErrorProvider erNome;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.ComboBox cboOpcao;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnCadastrarProd;
        private System.Windows.Forms.DateTimePicker dtmData;
        private System.Windows.Forms.Label lblMenssagem;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtPreco4;
        private System.Windows.Forms.TextBox txtPreco3;
        private System.Windows.Forms.TextBox txtPreco2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtPNumber;
        private System.Windows.Forms.TextBox txtNSerie;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.TextBox txtPreco1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}