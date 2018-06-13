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
            this.tableTipoProduto.Location = new System.Drawing.Point(27, 38);
            this.tableTipoProduto.Name = "tableTipoProduto";
            this.tableTipoProduto.Size = new System.Drawing.Size(437, 226);
            this.tableTipoProduto.TabIndex = 0;
            // 
            // btnRemoveProduto
            // 
            this.btnRemoveProduto.Location = new System.Drawing.Point(217, 307);
            this.btnRemoveProduto.Name = "btnRemoveProduto";
            this.btnRemoveProduto.Size = new System.Drawing.Size(118, 41);
            this.btnRemoveProduto.TabIndex = 1;
            this.btnRemoveProduto.Text = "Remover";
            this.btnRemoveProduto.UseVisualStyleBackColor = true;
            // 
            // btnAddTipoProduto
            // 
            this.btnAddTipoProduto.Location = new System.Drawing.Point(363, 307);
            this.btnAddTipoProduto.Name = "btnAddTipoProduto";
            this.btnAddTipoProduto.Size = new System.Drawing.Size(118, 41);
            this.btnAddTipoProduto.TabIndex = 1;
            this.btnAddTipoProduto.Text = "Adicionar";
            this.btnAddTipoProduto.UseVisualStyleBackColor = true;
            // 
            // btnVoltarMenuProdutoII
            // 
            this.btnVoltarMenuProdutoII.Location = new System.Drawing.Point(13, 307);
            this.btnVoltarMenuProdutoII.Name = "btnVoltarMenuProdutoII";
            this.btnVoltarMenuProdutoII.Size = new System.Drawing.Size(89, 41);
            this.btnVoltarMenuProdutoII.TabIndex = 2;
            this.btnVoltarMenuProdutoII.Text = "Voltar";
            this.btnVoltarMenuProdutoII.UseVisualStyleBackColor = true;
            this.btnVoltarMenuProdutoII.Click += new System.EventHandler(this.btnVoltarMenuProdutoII_Click);
            // 
            // frmTipoProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 360);
            this.Controls.Add(this.btnVoltarMenuProdutoII);
            this.Controls.Add(this.btnAddTipoProduto);
            this.Controls.Add(this.btnRemoveProduto);
            this.Controls.Add(this.tableTipoProduto);
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