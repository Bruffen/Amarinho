namespace AmarinhoInterface
{
    partial class frmListaProduto
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
            this.gridListaProdutos = new System.Windows.Forms.DataGridView();
            this.btnVoltar3 = new System.Windows.Forms.Button();
            this.btnAddProdutoLP = new System.Windows.Forms.Button();
            this.btnRemovProdutoLP = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridListaProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // gridListaProdutos
            // 
            this.gridListaProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridListaProdutos.Location = new System.Drawing.Point(29, 37);
            this.gridListaProdutos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gridListaProdutos.Name = "gridListaProdutos";
            this.gridListaProdutos.Size = new System.Drawing.Size(600, 314);
            this.gridListaProdutos.TabIndex = 0;
            // 
            // btnVoltar3
            // 
            this.btnVoltar3.Location = new System.Drawing.Point(17, 390);
            this.btnVoltar3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnVoltar3.Name = "btnVoltar3";
            this.btnVoltar3.Size = new System.Drawing.Size(100, 28);
            this.btnVoltar3.TabIndex = 1;
            this.btnVoltar3.Text = "Voltar";
            this.btnVoltar3.UseVisualStyleBackColor = true;
            // 
            // btnAddProdutoLP
            // 
            this.btnAddProdutoLP.Location = new System.Drawing.Point(491, 358);
            this.btnAddProdutoLP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddProdutoLP.Name = "btnAddProdutoLP";
            this.btnAddProdutoLP.Size = new System.Drawing.Size(139, 60);
            this.btnAddProdutoLP.TabIndex = 2;
            this.btnAddProdutoLP.Text = "Inserir Novo Produto";
            this.btnAddProdutoLP.UseVisualStyleBackColor = true;
            // 
            // btnRemovProdutoLP
            // 
            this.btnRemovProdutoLP.Location = new System.Drawing.Point(324, 358);
            this.btnRemovProdutoLP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRemovProdutoLP.Name = "btnRemovProdutoLP";
            this.btnRemovProdutoLP.Size = new System.Drawing.Size(139, 60);
            this.btnRemovProdutoLP.TabIndex = 2;
            this.btnRemovProdutoLP.Text = "Remover Produto";
            this.btnRemovProdutoLP.UseVisualStyleBackColor = true;
            // 
            // frmListaProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 433);
            this.Controls.Add(this.btnRemovProdutoLP);
            this.Controls.Add(this.btnAddProdutoLP);
            this.Controls.Add(this.btnVoltar3);
            this.Controls.Add(this.gridListaProdutos);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmListaProduto";
            this.Text = "Lista de Produtos";
            this.Load += new System.EventHandler(this.frmListaProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridListaProdutos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridListaProdutos;
        private System.Windows.Forms.Button btnVoltar3;
        private System.Windows.Forms.Button btnAddProdutoLP;
        private System.Windows.Forms.Button btnRemovProdutoLP;
    }
}