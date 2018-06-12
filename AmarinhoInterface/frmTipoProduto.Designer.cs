namespace AmarinhoInterface
{
    partial class frmTipoProduto
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
            this.tableTipoProduto = new System.Windows.Forms.DataGridView();
            this.btnRemoveProduto = new System.Windows.Forms.Button();
            this.btnAddTipoProduto = new System.Windows.Forms.Button();
            this.btnVoltarMenuProdutoII = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tableTipoProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // tableTipoProduto
            // 
            this.tableTipoProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableTipoProduto.Location = new System.Drawing.Point(36, 47);
            this.tableTipoProduto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableTipoProduto.Name = "tableTipoProduto";
            this.tableTipoProduto.Size = new System.Drawing.Size(583, 278);
            this.tableTipoProduto.TabIndex = 0;
            // 
            // btnRemoveProduto
            // 
            this.btnRemoveProduto.Location = new System.Drawing.Point(289, 378);
            this.btnRemoveProduto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRemoveProduto.Name = "btnRemoveProduto";
            this.btnRemoveProduto.Size = new System.Drawing.Size(157, 50);
            this.btnRemoveProduto.TabIndex = 1;
            this.btnRemoveProduto.Text = "Remover";
            this.btnRemoveProduto.UseVisualStyleBackColor = true;
            // 
            // btnAddTipoProduto
            // 
            this.btnAddTipoProduto.Location = new System.Drawing.Point(484, 378);
            this.btnAddTipoProduto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddTipoProduto.Name = "btnAddTipoProduto";
            this.btnAddTipoProduto.Size = new System.Drawing.Size(157, 50);
            this.btnAddTipoProduto.TabIndex = 1;
            this.btnAddTipoProduto.Text = "Adicionar";
            this.btnAddTipoProduto.UseVisualStyleBackColor = true;
            // 
            // btnVoltarMenuProdutoII
            // 
            this.btnVoltarMenuProdutoII.Location = new System.Drawing.Point(17, 378);
            this.btnVoltarMenuProdutoII.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnVoltarMenuProdutoII.Name = "btnVoltarMenuProdutoII";
            this.btnVoltarMenuProdutoII.Size = new System.Drawing.Size(119, 50);
            this.btnVoltarMenuProdutoII.TabIndex = 2;
            this.btnVoltarMenuProdutoII.Text = "Voltar";
            this.btnVoltarMenuProdutoII.UseVisualStyleBackColor = true;
            // 
            // frmTipoProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 443);
            this.Controls.Add(this.btnVoltarMenuProdutoII);
            this.Controls.Add(this.btnAddTipoProduto);
            this.Controls.Add(this.btnRemoveProduto);
            this.Controls.Add(this.tableTipoProduto);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmTipoProduto";
            this.Text = "Tipo de Produto";
            this.Load += new System.EventHandler(this.frmTipoProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tableTipoProduto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView tableTipoProduto;
        private System.Windows.Forms.Button btnRemoveProduto;
        private System.Windows.Forms.Button btnAddTipoProduto;
        private System.Windows.Forms.Button btnVoltarMenuProdutoII;
    }
}