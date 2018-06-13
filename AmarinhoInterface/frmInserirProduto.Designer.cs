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
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btnInserirProduto = new System.Windows.Forms.Button();
            this.btnVoltarTipoProduto = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIDProduto = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbNomeProduto
            // 
            this.lbNomeProduto.AutoSize = true;
            this.lbNomeProduto.Location = new System.Drawing.Point(10, 23);
            this.lbNomeProduto.Name = "lbNomeProduto";
            this.lbNomeProduto.Size = new System.Drawing.Size(90, 13);
            this.lbNomeProduto.TabIndex = 0;
            this.lbNomeProduto.Text = "Nome do Produto";
            // 
            // lbTeorAlco
            // 
            this.lbTeorAlco.AutoSize = true;
            this.lbTeorAlco.Location = new System.Drawing.Point(10, 57);
            this.lbTeorAlco.Name = "lbTeorAlco";
            this.lbTeorAlco.Size = new System.Drawing.Size(75, 13);
            this.lbTeorAlco.TabIndex = 0;
            this.lbTeorAlco.Text = "Teor Alcoólico";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Capacidade";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(107, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(143, 20);
            this.textBox1.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(91, 91);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(67, 20);
            this.textBox3.TabIndex = 1;
            // 
            // btnInserirProduto
            // 
            this.btnInserirProduto.Location = new System.Drawing.Point(220, 94);
            this.btnInserirProduto.Name = "btnInserirProduto";
            this.btnInserirProduto.Size = new System.Drawing.Size(86, 58);
            this.btnInserirProduto.TabIndex = 2;
            this.btnInserirProduto.Text = "Inserir Novo Produto";
            this.btnInserirProduto.UseVisualStyleBackColor = true;
            // 
            // btnVoltarTipoProduto
            // 
            this.btnVoltarTipoProduto.Location = new System.Drawing.Point(10, 138);
            this.btnVoltarTipoProduto.Name = "btnVoltarTipoProduto";
            this.btnVoltarTipoProduto.Size = new System.Drawing.Size(75, 23);
            this.btnVoltarTipoProduto.TabIndex = 3;
            this.btnVoltarTipoProduto.Text = "Voltar";
            this.btnVoltarTipoProduto.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(91, 54);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(67, 20);
            this.textBox2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(271, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "ID";
            // 
            // txtIDProduto
            // 
            this.txtIDProduto.Location = new System.Drawing.Point(274, 45);
            this.txtIDProduto.Name = "txtIDProduto";
            this.txtIDProduto.Size = new System.Drawing.Size(32, 20);
            this.txtIDProduto.TabIndex = 1;
            // 
            // frmInserirProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 170);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVoltarTipoProduto);
            this.Controls.Add(this.btnInserirProduto);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.txtIDProduto);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbTeorAlco);
            this.Controls.Add(this.lbNomeProduto);
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
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button btnInserirProduto;
        private System.Windows.Forms.Button btnVoltarTipoProduto;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIDProduto;
    }
}