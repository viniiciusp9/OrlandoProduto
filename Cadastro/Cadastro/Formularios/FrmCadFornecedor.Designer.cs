namespace Cadastro
{
    partial class FrmCadFornecedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadFornecedor));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.Cadastrar = new System.Windows.Forms.TabPage();
            this.dtmData = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label20 = new System.Windows.Forms.Label();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.lblMemssagem = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.cboEstado = new System.Windows.Forms.ComboBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.mskCep = new System.Windows.Forms.MaskedTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIM = new System.Windows.Forms.TextBox();
            this.mskFax = new System.Windows.Forms.MaskedTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.mskCel2 = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.mskCel = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.mskTel2 = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.mskTel = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.mskIE = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtContato = new System.Windows.Forms.TextBox();
            this.mskcnpj = new System.Windows.Forms.MaskedTextBox();
            this.txtRazao = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TabControl1 = new System.Windows.Forms.TabControl();
            this.Pesquisar = new System.Windows.Forms.TabPage();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.cboOpcao = new System.Windows.Forms.ComboBox();
            this.dgvFornecedor = new System.Windows.Forms.DataGridView();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.toolStrip1.SuspendLayout();
            this.Cadastrar.SuspendLayout();
            this.dtmData.SuspendLayout();
            this.TabControl1.SuspendLayout();
            this.Pesquisar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFornecedor)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton4,
            this.toolStripButton3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(948, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(42, 22);
            this.toolStripButton1.Text = "&Salvar";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(48, 22);
            this.toolStripButton2.Text = "&Limpar";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(45, 22);
            this.toolStripButton4.Text = "Excluir";
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(30, 22);
            this.toolStripButton3.Text = "&Sair";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // Cadastrar
            // 
            this.Cadastrar.Controls.Add(this.dtmData);
            this.Cadastrar.Location = new System.Drawing.Point(4, 22);
            this.Cadastrar.Name = "Cadastrar";
            this.Cadastrar.Padding = new System.Windows.Forms.Padding(3);
            this.Cadastrar.Size = new System.Drawing.Size(916, 284);
            this.Cadastrar.TabIndex = 1;
            this.Cadastrar.Text = "Cadastrar";
            this.Cadastrar.UseVisualStyleBackColor = true;
            // 
            // dtmData
            // 
            this.dtmData.Controls.Add(this.dateTimePicker1);
            this.dtmData.Controls.Add(this.label20);
            this.dtmData.Controls.Add(this.btnImprimir);
            this.dtmData.Controls.Add(this.txtCodigo);
            this.dtmData.Controls.Add(this.label19);
            this.dtmData.Controls.Add(this.lblMemssagem);
            this.dtmData.Controls.Add(this.txtMail);
            this.dtmData.Controls.Add(this.label18);
            this.dtmData.Controls.Add(this.btnCancelar);
            this.dtmData.Controls.Add(this.btnLimpar);
            this.dtmData.Controls.Add(this.btnSalvar);
            this.dtmData.Controls.Add(this.cboEstado);
            this.dtmData.Controls.Add(this.txtCidade);
            this.dtmData.Controls.Add(this.label17);
            this.dtmData.Controls.Add(this.label16);
            this.dtmData.Controls.Add(this.txtBairro);
            this.dtmData.Controls.Add(this.label15);
            this.dtmData.Controls.Add(this.button1);
            this.dtmData.Controls.Add(this.mskCep);
            this.dtmData.Controls.Add(this.label14);
            this.dtmData.Controls.Add(this.label13);
            this.dtmData.Controls.Add(this.txtNumero);
            this.dtmData.Controls.Add(this.label12);
            this.dtmData.Controls.Add(this.txtComplemento);
            this.dtmData.Controls.Add(this.txtEndereco);
            this.dtmData.Controls.Add(this.label5);
            this.dtmData.Controls.Add(this.txtIM);
            this.dtmData.Controls.Add(this.mskFax);
            this.dtmData.Controls.Add(this.label11);
            this.dtmData.Controls.Add(this.mskCel2);
            this.dtmData.Controls.Add(this.label10);
            this.dtmData.Controls.Add(this.mskCel);
            this.dtmData.Controls.Add(this.label9);
            this.dtmData.Controls.Add(this.mskTel2);
            this.dtmData.Controls.Add(this.label8);
            this.dtmData.Controls.Add(this.mskTel);
            this.dtmData.Controls.Add(this.label7);
            this.dtmData.Controls.Add(this.label6);
            this.dtmData.Controls.Add(this.mskIE);
            this.dtmData.Controls.Add(this.label4);
            this.dtmData.Controls.Add(this.txtContato);
            this.dtmData.Controls.Add(this.mskcnpj);
            this.dtmData.Controls.Add(this.txtRazao);
            this.dtmData.Controls.Add(this.label1);
            this.dtmData.Controls.Add(this.label2);
            this.dtmData.Controls.Add(this.label3);
            this.dtmData.Location = new System.Drawing.Point(6, 0);
            this.dtmData.Name = "dtmData";
            this.dtmData.Size = new System.Drawing.Size(924, 320);
            this.dtmData.TabIndex = 5;
            this.dtmData.TabStop = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(765, 195);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(134, 20);
            this.dateTimePicker1.TabIndex = 46;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(716, 201);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(33, 13);
            this.label20.TabIndex = 45;
            this.label20.Text = "Data:";
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(459, 226);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(75, 23);
            this.btnImprimir.TabIndex = 44;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(55, 17);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 43;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(6, 20);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(43, 13);
            this.label19.TabIndex = 42;
            this.label19.Text = "Código:";
            // 
            // lblMemssagem
            // 
            this.lblMemssagem.AutoSize = true;
            this.lblMemssagem.Location = new System.Drawing.Point(15, 281);
            this.lblMemssagem.Name = "lblMemssagem";
            this.lblMemssagem.Size = new System.Drawing.Size(0, 13);
            this.lblMemssagem.TabIndex = 41;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(717, 114);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(182, 20);
            this.txtMail.TabIndex = 11;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(714, 98);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(35, 13);
            this.label18.TabIndex = 39;
            this.label18.Text = "Email:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(789, 226);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 22;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click_1);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(674, 226);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 21;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click_1);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(561, 226);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 20;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click_1);
            // 
            // cboEstado
            // 
            this.cboEstado.FormattingEnabled = true;
            this.cboEstado.Location = new System.Drawing.Point(371, 226);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(38, 21);
            this.cboEstado.TabIndex = 19;
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(228, 226);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(133, 20);
            this.txtCidade.TabIndex = 18;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(368, 210);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(24, 13);
            this.label17.TabIndex = 35;
            this.label17.Text = "UF:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(225, 210);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(55, 13);
            this.label16.TabIndex = 34;
            this.label16.Text = "Municipio:";
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(9, 226);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(207, 20);
            this.txtBairro.TabIndex = 17;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 210);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(74, 13);
            this.label15.TabIndex = 32;
            this.label15.Text = "Bairro/Distrito:";
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(86, 168);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(23, 23);
            this.button1.TabIndex = 13;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // mskCep
            // 
            this.mskCep.Location = new System.Drawing.Point(9, 168);
            this.mskCep.Mask = "00000-999";
            this.mskCep.Name = "mskCep";
            this.mskCep.Size = new System.Drawing.Size(71, 20);
            this.mskCep.TabIndex = 12;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 152);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(31, 13);
            this.label14.TabIndex = 28;
            this.label14.Text = "CEP:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(714, 152);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(74, 13);
            this.label13.TabIndex = 27;
            this.label13.Text = "Complemento:";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(609, 168);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 20);
            this.txtNumero.TabIndex = 15;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(606, 152);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "Numero:";
            // 
            // txtComplemento
            // 
            this.txtComplemento.Location = new System.Drawing.Point(717, 168);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(182, 20);
            this.txtComplemento.TabIndex = 16;
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(118, 168);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(482, 20);
            this.txtEndereco.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(115, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Rua/Logradouro:";
            // 
            // txtIM
            // 
            this.txtIM.Location = new System.Drawing.Point(118, 114);
            this.txtIM.Name = "txtIM";
            this.txtIM.Size = new System.Drawing.Size(100, 20);
            this.txtIM.TabIndex = 5;
            // 
            // mskFax
            // 
            this.mskFax.Location = new System.Drawing.Point(612, 114);
            this.mskFax.Mask = "(00)0000-0000";
            this.mskFax.Name = "mskFax";
            this.mskFax.Size = new System.Drawing.Size(81, 20);
            this.mskFax.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(609, 98);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(27, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "Fax:";
            // 
            // mskCel2
            // 
            this.mskCel2.Location = new System.Drawing.Point(515, 114);
            this.mskCel2.Mask = "(00)00000-0000";
            this.mskCel2.Name = "mskCel2";
            this.mskCel2.Size = new System.Drawing.Size(85, 20);
            this.mskCel2.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(512, 98);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Celular 2:";
            // 
            // mskCel
            // 
            this.mskCel.Location = new System.Drawing.Point(418, 114);
            this.mskCel.Mask = "(00)00000-0000";
            this.mskCel.Name = "mskCel";
            this.mskCel.Size = new System.Drawing.Size(85, 20);
            this.mskCel.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(415, 98);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Celular:";
            // 
            // mskTel2
            // 
            this.mskTel2.Location = new System.Drawing.Point(328, 114);
            this.mskTel2.Mask = "(00)0000-0000";
            this.mskTel2.Name = "mskTel2";
            this.mskTel2.Size = new System.Drawing.Size(81, 20);
            this.mskTel2.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(325, 98);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Telefone 2:";
            // 
            // mskTel
            // 
            this.mskTel.Location = new System.Drawing.Point(237, 114);
            this.mskTel.Mask = "(00)0000-0000";
            this.mskTel.Name = "mskTel";
            this.mskTel.Size = new System.Drawing.Size(81, 20);
            this.mskTel.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(234, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Telefone :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(115, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Inscrição Municipal:";
            // 
            // mskIE
            // 
            this.mskIE.Location = new System.Drawing.Point(9, 114);
            this.mskIE.Mask = "000.000.000.000";
            this.mskIE.Name = "mskIE";
            this.mskIE.Size = new System.Drawing.Size(100, 20);
            this.mskIE.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Inscrição Estadual:";
            // 
            // txtContato
            // 
            this.txtContato.Location = new System.Drawing.Point(732, 59);
            this.txtContato.Name = "txtContato";
            this.txtContato.Size = new System.Drawing.Size(167, 20);
            this.txtContato.TabIndex = 3;
            // 
            // mskcnpj
            // 
            this.mskcnpj.Location = new System.Drawing.Point(582, 59);
            this.mskcnpj.Mask = "00.000.000/0000-00";
            this.mskcnpj.Name = "mskcnpj";
            this.mskcnpj.Size = new System.Drawing.Size(127, 20);
            this.mskcnpj.TabIndex = 2;
            // 
            // txtRazao
            // 
            this.txtRazao.Location = new System.Drawing.Point(9, 59);
            this.txtRazao.Name = "txtRazao";
            this.txtRazao.Size = new System.Drawing.Size(554, 20);
            this.txtRazao.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Razão Social:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(579, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "CNPJ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(729, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Contato:";
            // 
            // TabControl1
            // 
            this.TabControl1.Controls.Add(this.Pesquisar);
            this.TabControl1.Controls.Add(this.Cadastrar);
            this.TabControl1.Location = new System.Drawing.Point(12, 28);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new System.Drawing.Size(924, 310);
            this.TabControl1.TabIndex = 0;
            // 
            // Pesquisar
            // 
            this.Pesquisar.Controls.Add(this.txtFiltro);
            this.Pesquisar.Controls.Add(this.cboOpcao);
            this.Pesquisar.Controls.Add(this.dgvFornecedor);
            this.Pesquisar.Location = new System.Drawing.Point(4, 22);
            this.Pesquisar.Name = "Pesquisar";
            this.Pesquisar.Padding = new System.Windows.Forms.Padding(3);
            this.Pesquisar.Size = new System.Drawing.Size(916, 284);
            this.Pesquisar.TabIndex = 0;
            this.Pesquisar.Text = "Pesquisar";
            this.Pesquisar.UseVisualStyleBackColor = true;
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(144, 18);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(763, 20);
            this.txtFiltro.TabIndex = 2;
            this.txtFiltro.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // cboOpcao
            // 
            this.cboOpcao.FormattingEnabled = true;
            this.cboOpcao.Items.AddRange(new object[] {
            "CNPJ",
            "Razão",
            "Codigo"});
            this.cboOpcao.Location = new System.Drawing.Point(6, 17);
            this.cboOpcao.Name = "cboOpcao";
            this.cboOpcao.Size = new System.Drawing.Size(121, 21);
            this.cboOpcao.TabIndex = 1;
            this.cboOpcao.Text = "CNPJ";
            // 
            // dgvFornecedor
            // 
            this.dgvFornecedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFornecedor.Location = new System.Drawing.Point(6, 44);
            this.dgvFornecedor.Name = "dgvFornecedor";
            this.dgvFornecedor.Size = new System.Drawing.Size(901, 234);
            this.dgvFornecedor.TabIndex = 0;
            this.dgvFornecedor.DoubleClick += new System.EventHandler(this.dgvFornecedor_DoubleClick);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // FrmCadFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 369);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.TabControl1);
            this.KeyPreview = true;
            this.Name = "FrmCadFornecedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Fornecedor";
            this.Load += new System.EventHandler(this.FrmCadFornecedor_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmCadFornecedor_KeyDown);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.Cadastrar.ResumeLayout(false);
            this.dtmData.ResumeLayout(false);
            this.dtmData.PerformLayout();
            this.TabControl1.ResumeLayout(false);
            this.Pesquisar.ResumeLayout(false);
            this.Pesquisar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFornecedor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.TabPage Cadastrar;
        private System.Windows.Forms.GroupBox dtmData;
        private System.Windows.Forms.Label lblMemssagem;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.ComboBox cboEstado;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MaskedTextBox mskCep;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIM;
        private System.Windows.Forms.MaskedTextBox mskFax;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.MaskedTextBox mskCel2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox mskCel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox mskTel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox mskTel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox mskIE;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtContato;
        private System.Windows.Forms.MaskedTextBox mskcnpj;
        private System.Windows.Forms.TextBox txtRazao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabControl TabControl1;
        private System.Windows.Forms.TabPage Pesquisar;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.ComboBox cboOpcao;
        private System.Windows.Forms.DataGridView dgvFornecedor;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label20;
    }
}