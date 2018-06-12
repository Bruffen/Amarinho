namespace AmarinhoInterface
{
    partial class frmInserirProduto
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
            this.lbNomeProduto = new System.Windows.Forms.Label();
            this.lbTeorAlco = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btnInserirProduto = new System.Windows.Forms.Button();
            this.btnVoltarTipoProduto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbNomeProduto
            // 
            this.lbNomeProduto.AutoSize = true;
            this.lbNomeProduto.Location = new System.Drawing.Point(17, 32);
            this.lbNomeProduto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNomeProduto.Name = "lbNomeProduto";
            this.lbNomeProduto.Size = new System.Drawing.Size(119, 17);
            this.lbNomeProduto.TabIndex = 0;
            this.lbNomeProduto.Text = "Nome do Produto";
            // 
            // lbTeorAlco
            // 
            this.lbTeorAlco.AutoSize = true;
            this.lbTeorAlco.Location = new System.Drawing.Point(17, 74);
            this.lbTeorAlco.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTeorAlco.Name = "lbTeorAlco";
            this.lbTeorAlco.Size = new System.Drawing.Size(98, 17);
            this.lbTeorAlco.TabIndex = 0;
            this.lbTeorAlco.Text = "Teor Alcoólico";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 119);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Capacidade";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(147, 32);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(189, 22);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(125, 70);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(88, 22);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(125, 116);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(88, 22);
            this.textBox3.TabIndex = 1;
            // 
            // btnInserirProduto
            // 
            this.btnInserirProduto.Location = new System.Drawing.Point(236, 119);
            this.btnInserirProduto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnInserirProduto.Name = "btnInserirProduto";
            this.btnInserirProduto.Size = new System.Drawing.Size(115, 71);
            this.btnInserirProduto.TabIndex = 2;
            this.btnInserirProduto.Text = "Inserir Novo Produto";
            this.btnInserirProduto.UseVisualStyleBackColor = true;
            // 
            // btnVoltarTipoProduto
            // 
            this.btnVoltarTipoProduto.Location = new System.Drawing.Point(16, 162);
            this.btnVoltarTipoProduto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnVoltarTipoProduto.Name = "btnVoltarTipoProduto";
            this.btnVoltarTipoProduto.Size = new System.Drawing.Size(100, 28);
            this.btnVoltarTipoProduto.TabIndex = 3;
            this.btnVoltarTipoProduto.Text = "Voltar";
            this.btnVoltarTipoProduto.UseVisualStyleBackColor = true;
            // 
            // frmInserirProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 206);
            this.Controls.Add(this.btnVoltarTipoProduto);
            this.Controls.Add(this.btnInserirProduto);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbTeorAlco);
            this.Controls.Add(this.lbNomeProduto);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmInserirProduto";
            this.Text = "Novo Produto";
            this.Load += new System.EventHandler(this.frmInserirProduto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNomeProduto;
        private System.Windows.Forms.Label lbTeorAlco;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button btnInserirProduto;
        private System.Windows.Forms.Button btnVoltarTipoProduto;
    }
}