namespace AmarinhoInterface
{
    partial class frmTProduto
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
            this.comboBoxCasta = new System.Windows.Forms.ComboBox();
            this.lbCasta = new System.Windows.Forms.Label();
            this.comboBoxTProduto = new System.Windows.Forms.ComboBox();
            this.lbTipoProduto = new System.Windows.Forms.Label();
            this.btnInsertCasta = new System.Windows.Forms.Button();
            this.btnInsertTipoProduto = new System.Windows.Forms.Button();
            this.btnInsertProduto = new System.Windows.Forms.Button();
            this.btnVoltar4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxCasta
            // 
            this.comboBoxCasta.FormattingEnabled = true;
            this.comboBoxCasta.Location = new System.Drawing.Point(12, 43);
            this.comboBoxCasta.Name = "comboBoxCasta";
            this.comboBoxCasta.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCasta.TabIndex = 0;
            // 
            // lbCasta
            // 
            this.lbCasta.AutoSize = true;
            this.lbCasta.Location = new System.Drawing.Point(13, 27);
            this.lbCasta.Name = "lbCasta";
            this.lbCasta.Size = new System.Drawing.Size(34, 13);
            this.lbCasta.TabIndex = 1;
            this.lbCasta.Text = "Casta";
            // 
            // comboBoxTProduto
            // 
            this.comboBoxTProduto.FormattingEnabled = true;
            this.comboBoxTProduto.Location = new System.Drawing.Point(171, 43);
            this.comboBoxTProduto.Name = "comboBoxTProduto";
            this.comboBoxTProduto.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTProduto.TabIndex = 2;
            // 
            // lbTipoProduto
            // 
            this.lbTipoProduto.AutoSize = true;
            this.lbTipoProduto.Location = new System.Drawing.Point(224, 27);
            this.lbTipoProduto.Name = "lbTipoProduto";
            this.lbTipoProduto.Size = new System.Drawing.Size(68, 13);
            this.lbTipoProduto.TabIndex = 1;
            this.lbTipoProduto.Text = "Tipo Produto";
            // 
            // btnInsertCasta
            // 
            this.btnInsertCasta.Location = new System.Drawing.Point(26, 122);
            this.btnInsertCasta.Name = "btnInsertCasta";
            this.btnInsertCasta.Size = new System.Drawing.Size(87, 53);
            this.btnInsertCasta.TabIndex = 3;
            this.btnInsertCasta.Text = "Inserir Nova Casta";
            this.btnInsertCasta.UseVisualStyleBackColor = true;
            // 
            // btnInsertTipoProduto
            // 
            this.btnInsertTipoProduto.Location = new System.Drawing.Point(196, 122);
            this.btnInsertTipoProduto.Name = "btnInsertTipoProduto";
            this.btnInsertTipoProduto.Size = new System.Drawing.Size(87, 53);
            this.btnInsertTipoProduto.TabIndex = 3;
            this.btnInsertTipoProduto.Text = "Inserir Novo Tipo Produto";
            this.btnInsertTipoProduto.UseVisualStyleBackColor = true;
            // 
            // btnInsertProduto
            // 
            this.btnInsertProduto.Location = new System.Drawing.Point(95, 196);
            this.btnInsertProduto.Name = "btnInsertProduto";
            this.btnInsertProduto.Size = new System.Drawing.Size(128, 53);
            this.btnInsertProduto.TabIndex = 3;
            this.btnInsertProduto.Text = "Inserir Novo Produto";
            this.btnInsertProduto.UseVisualStyleBackColor = true;
            // 
            // btnVoltar4
            // 
            this.btnVoltar4.Location = new System.Drawing.Point(12, 238);
            this.btnVoltar4.Name = "btnVoltar4";
            this.btnVoltar4.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar4.TabIndex = 4;
            this.btnVoltar4.Text = "Voltar";
            this.btnVoltar4.UseVisualStyleBackColor = true;
            // 
            // frmTProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 273);
            this.Controls.Add(this.btnVoltar4);
            this.Controls.Add(this.btnInsertTipoProduto);
            this.Controls.Add(this.btnInsertProduto);
            this.Controls.Add(this.btnInsertCasta);
            this.Controls.Add(this.comboBoxTProduto);
            this.Controls.Add(this.lbTipoProduto);
            this.Controls.Add(this.lbCasta);
            this.Controls.Add(this.comboBoxCasta);
            this.Name = "frmTProduto";
            this.Text = "frmTProduto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxCasta;
        private System.Windows.Forms.Label lbCasta;
        private System.Windows.Forms.ComboBox comboBoxTProduto;
        private System.Windows.Forms.Label lbTipoProduto;
        private System.Windows.Forms.Button btnInsertCasta;
        private System.Windows.Forms.Button btnInsertTipoProduto;
        private System.Windows.Forms.Button btnInsertProduto;
        private System.Windows.Forms.Button btnVoltar4;
    }
}