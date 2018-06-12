namespace AmarinhoInterface
{
    partial class Form1
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
            this.btnMCastas = new System.Windows.Forms.Button();
            this.btnMTipoProduto = new System.Windows.Forms.Button();
            this.btnVenda = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMCastas
            // 
            this.btnMCastas.Location = new System.Drawing.Point(84, 39);
            this.btnMCastas.Name = "btnMCastas";
            this.btnMCastas.Size = new System.Drawing.Size(110, 54);
            this.btnMCastas.TabIndex = 0;
            this.btnMCastas.Text = "Castas";
            this.btnMCastas.UseVisualStyleBackColor = true;
            this.btnMCastas.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnMTipoProduto
            // 
            this.btnMTipoProduto.Location = new System.Drawing.Point(84, 110);
            this.btnMTipoProduto.Name = "btnMTipoProduto";
            this.btnMTipoProduto.Size = new System.Drawing.Size(110, 54);
            this.btnMTipoProduto.TabIndex = 0;
            this.btnMTipoProduto.Text = "Tipo de Produto";
            this.btnMTipoProduto.UseVisualStyleBackColor = true;
            this.btnMTipoProduto.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnVenda
            // 
            this.btnVenda.Location = new System.Drawing.Point(84, 181);
            this.btnVenda.Name = "btnVenda";
            this.btnVenda.Size = new System.Drawing.Size(110, 54);
            this.btnVenda.TabIndex = 0;
            this.btnVenda.Text = "Vendas";
            this.btnVenda.UseVisualStyleBackColor = true;
            this.btnVenda.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnVenda);
            this.Controls.Add(this.btnMTipoProduto);
            this.Controls.Add(this.btnMCastas);
            this.Name = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCastas;
        private System.Windows.Forms.Button btnTProduto;
        private System.Windows.Forms.Button btnVendas;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.Button btnMCastas;
        private System.Windows.Forms.Button btnMTipoProduto;
        private System.Windows.Forms.Button btnVenda;
    }
}

