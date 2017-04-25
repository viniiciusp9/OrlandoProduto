namespace Cadastro
{
    partial class FrmCalcPreco
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtPrecoCusto = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPrecoF1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCalcP1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCustoP1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtPrecoF2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCalcP2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCustoP2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtPrecoF3 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCalcP3 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCustoP3 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtPrecoF4 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCalcP4 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtCustoP4 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valor Custo";
            // 
            // txtPrecoCusto
            // 
            this.txtPrecoCusto.Location = new System.Drawing.Point(34, 38);
            this.txtPrecoCusto.Name = "txtPrecoCusto";
            this.txtPrecoCusto.Size = new System.Drawing.Size(100, 20);
            this.txtPrecoCusto.TabIndex = 2;
            this.txtPrecoCusto.TextChanged += new System.EventHandler(this.txtPrecoCusto_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPrecoF1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtCalcP1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtCustoP1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(34, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(198, 184);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Preço 1";
            // 
            // txtPrecoF1
            // 
            this.txtPrecoF1.Location = new System.Drawing.Point(9, 138);
            this.txtPrecoF1.Name = "txtPrecoF1";
            this.txtPrecoF1.Size = new System.Drawing.Size(129, 20);
            this.txtPrecoF1.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Preço Final:";
            // 
            // txtCalcP1
            // 
            this.txtCalcP1.Location = new System.Drawing.Point(9, 90);
            this.txtCalcP1.Name = "txtCalcP1";
            this.txtCalcP1.Size = new System.Drawing.Size(129, 20);
            this.txtCalcP1.TabIndex = 3;
            this.txtCalcP1.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "% de lucro:";
            // 
            // txtCustoP1
            // 
            this.txtCustoP1.Location = new System.Drawing.Point(9, 42);
            this.txtCustoP1.Name = "txtCustoP1";
            this.txtCustoP1.Size = new System.Drawing.Size(129, 20);
            this.txtCustoP1.TabIndex = 1;
            this.txtCustoP1.TextChanged += new System.EventHandler(this.txtCustoP1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Valor Custo:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtPrecoF2);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtCalcP2);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtCustoP2);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(238, 64);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(198, 184);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Preço 2";
            // 
            // txtPrecoF2
            // 
            this.txtPrecoF2.Location = new System.Drawing.Point(9, 138);
            this.txtPrecoF2.Name = "txtPrecoF2";
            this.txtPrecoF2.Size = new System.Drawing.Size(129, 20);
            this.txtPrecoF2.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Preço Final:";
            // 
            // txtCalcP2
            // 
            this.txtCalcP2.Location = new System.Drawing.Point(9, 90);
            this.txtCalcP2.Name = "txtCalcP2";
            this.txtCalcP2.Size = new System.Drawing.Size(129, 20);
            this.txtCalcP2.TabIndex = 3;
            this.txtCalcP2.TextChanged += new System.EventHandler(this.txtCalcP2_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "% de lucro:";
            // 
            // txtCustoP2
            // 
            this.txtCustoP2.Location = new System.Drawing.Point(9, 42);
            this.txtCustoP2.Name = "txtCustoP2";
            this.txtCustoP2.Size = new System.Drawing.Size(129, 20);
            this.txtCustoP2.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Valor Custo:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtPrecoF3);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txtCalcP3);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txtCustoP3);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Location = new System.Drawing.Point(34, 254);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(198, 184);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Preço 3";
            // 
            // txtPrecoF3
            // 
            this.txtPrecoF3.Location = new System.Drawing.Point(9, 138);
            this.txtPrecoF3.Name = "txtPrecoF3";
            this.txtPrecoF3.Size = new System.Drawing.Size(129, 20);
            this.txtPrecoF3.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 122);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Preço Final:";
            // 
            // txtCalcP3
            // 
            this.txtCalcP3.Location = new System.Drawing.Point(9, 90);
            this.txtCalcP3.Name = "txtCalcP3";
            this.txtCalcP3.Size = new System.Drawing.Size(129, 20);
            this.txtCalcP3.TabIndex = 3;
            this.txtCalcP3.TextChanged += new System.EventHandler(this.txtCalcP3_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 74);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "% de lucro:";
            // 
            // txtCustoP3
            // 
            this.txtCustoP3.Location = new System.Drawing.Point(9, 42);
            this.txtCustoP3.Name = "txtCustoP3";
            this.txtCustoP3.Size = new System.Drawing.Size(129, 20);
            this.txtCustoP3.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Valor Custo:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtPrecoF4);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.txtCalcP4);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.txtCustoP4);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Location = new System.Drawing.Point(238, 254);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(198, 184);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Preço 4";
            // 
            // txtPrecoF4
            // 
            this.txtPrecoF4.Location = new System.Drawing.Point(9, 138);
            this.txtPrecoF4.Name = "txtPrecoF4";
            this.txtPrecoF4.Size = new System.Drawing.Size(129, 20);
            this.txtPrecoF4.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 122);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "Preço Final:";
            // 
            // txtCalcP4
            // 
            this.txtCalcP4.Location = new System.Drawing.Point(9, 90);
            this.txtCalcP4.Name = "txtCalcP4";
            this.txtCalcP4.Size = new System.Drawing.Size(129, 20);
            this.txtCalcP4.TabIndex = 3;
            this.txtCalcP4.TextChanged += new System.EventHandler(this.txtCalcP4_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 74);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "% de lucro:";
            // 
            // txtCustoP4
            // 
            this.txtCustoP4.Location = new System.Drawing.Point(9, 42);
            this.txtCustoP4.Name = "txtCustoP4";
            this.txtCustoP4.Size = new System.Drawing.Size(129, 20);
            this.txtCustoP4.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 26);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "Valor Custo:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(199, 454);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Sair";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(361, 454);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 10;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(280, 454);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 11;
            this.button3.Text = "Limpar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // FrmCalcPreco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 499);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtPrecoCusto);
            this.Controls.Add(this.label1);
            this.Name = "FrmCalcPreco";
            this.Text = "FrmCalcPreco";
            this.Activated += new System.EventHandler(this.FrmCalcPreco_Activated);
            this.Load += new System.EventHandler(this.FrmCalcPreco_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPrecoCusto;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPrecoF1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCalcP1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCustoP1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtPrecoF2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCalcP2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCustoP2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtPrecoF3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCalcP3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCustoP3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtPrecoF4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtCalcP4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtCustoP4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button button3;
    }
}