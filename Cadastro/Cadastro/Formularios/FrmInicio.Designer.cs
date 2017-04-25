namespace Cadastro
{
    partial class FrmInicio
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
            this.btnCadCliente = new System.Windows.Forms.Button();
            this.btnCadProduto = new System.Windows.Forms.Button();
            this.btnCadFornecedor = new System.Windows.Forms.Button();
            this.btnCadFuncionario = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fornecedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCadCliente
            // 
            this.btnCadCliente.Location = new System.Drawing.Point(12, 38);
            this.btnCadCliente.Name = "btnCadCliente";
            this.btnCadCliente.Size = new System.Drawing.Size(107, 40);
            this.btnCadCliente.TabIndex = 0;
            this.btnCadCliente.Text = "Cliente";
            this.btnCadCliente.UseVisualStyleBackColor = true;
            this.btnCadCliente.Click += new System.EventHandler(this.btnCadCliente_Click);
            // 
            // btnCadProduto
            // 
            this.btnCadProduto.Location = new System.Drawing.Point(125, 38);
            this.btnCadProduto.Name = "btnCadProduto";
            this.btnCadProduto.Size = new System.Drawing.Size(107, 40);
            this.btnCadProduto.TabIndex = 1;
            this.btnCadProduto.Text = "Produto";
            this.btnCadProduto.UseVisualStyleBackColor = true;
            this.btnCadProduto.Click += new System.EventHandler(this.btnCadProduto_Click);
            // 
            // btnCadFornecedor
            // 
            this.btnCadFornecedor.Location = new System.Drawing.Point(238, 38);
            this.btnCadFornecedor.Name = "btnCadFornecedor";
            this.btnCadFornecedor.Size = new System.Drawing.Size(107, 40);
            this.btnCadFornecedor.TabIndex = 2;
            this.btnCadFornecedor.Text = "Fornecedor";
            this.btnCadFornecedor.UseVisualStyleBackColor = true;
            this.btnCadFornecedor.Click += new System.EventHandler(this.btnCadFornecedor_Click);
            // 
            // btnCadFuncionario
            // 
            this.btnCadFuncionario.Location = new System.Drawing.Point(351, 38);
            this.btnCadFuncionario.Name = "btnCadFuncionario";
            this.btnCadFuncionario.Size = new System.Drawing.Size(107, 40);
            this.btnCadFuncionario.TabIndex = 3;
            this.btnCadFuncionario.Text = "Funcionario";
            this.btnCadFuncionario.UseVisualStyleBackColor = true;
            this.btnCadFuncionario.Click += new System.EventHandler(this.btnCadFuncionario_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCadFuncionario);
            this.groupBox1.Controls.Add(this.btnCadFornecedor);
            this.groupBox1.Controls.Add(this.btnCadProduto);
            this.groupBox1.Controls.Add(this.btnCadCliente);
            this.groupBox1.Location = new System.Drawing.Point(0, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(472, 116);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastrar";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(947, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem,
            this.produtoToolStripMenuItem,
            this.fornecedorToolStripMenuItem,
            this.funcionarioToolStripMenuItem,
            this.toolStripMenuItem1});
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.clienteToolStripMenuItem.Text = "&Cliente";
            // 
            // produtoToolStripMenuItem
            // 
            this.produtoToolStripMenuItem.Name = "produtoToolStripMenuItem";
            this.produtoToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.produtoToolStripMenuItem.Text = "&Produto";
            // 
            // fornecedorToolStripMenuItem
            // 
            this.fornecedorToolStripMenuItem.Name = "fornecedorToolStripMenuItem";
            this.fornecedorToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.fornecedorToolStripMenuItem.Text = "&Fornecedor";
            // 
            // funcionarioToolStripMenuItem
            // 
            this.funcionarioToolStripMenuItem.Name = "funcionarioToolStripMenuItem";
            this.funcionarioToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.funcionarioToolStripMenuItem.Text = "&Funcionario";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(134, 6);
            // 
            // FrmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 377);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nome Programa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.FrmInicio_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmInicio_FormClosing);
            this.Load += new System.EventHandler(this.FrmInicio_Load);
            this.groupBox1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCadCliente;
        private System.Windows.Forms.Button btnCadProduto;
        private System.Windows.Forms.Button btnCadFornecedor;
        private System.Windows.Forms.Button btnCadFuncionario;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fornecedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem funcionarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
    }
}