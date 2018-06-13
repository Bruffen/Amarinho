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
            this.comboBoxCasta.Location = new System.Drawing.Point(16, 53);
            this.comboBoxCasta.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxCasta.Name = "comboBoxCasta";
            this.comboBoxCasta.Size = new System.Drawing.Size(160, 24);
            this.comboBoxCasta.TabIndex = 0;
            this.comboBoxCasta.SelectedIndexChanged += new System.EventHandler(this.comboBoxCasta_SelectedIndexChanged);
            // 
            // lbCasta
            // 
            this.lbCasta.AutoSize = true;
            this.lbCasta.Location = new System.Drawing.Point(17, 33);
            this.lbCasta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCasta.Name = "lbCasta";
            this.lbCasta.Size = new System.Drawing.Size(44, 17);
            this.lbCasta.TabIndex = 1;
            this.lbCasta.Text = "Casta";
            // 
            // comboBoxTProduto
            // 
            this.comboBoxTProduto.FormattingEnabled = true;
            this.comboBoxTProduto.Location = new System.Drawing.Point(228, 53);
            this.comboBoxTProduto.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxTProduto.Name = "comboBoxTProduto";
            this.comboBoxTProduto.Size = new System.Drawing.Size(160, 24);
            this.comboBoxTProduto.TabIndex = 2;
            this.comboBoxTProduto.SelectedIndexChanged += new System.EventHandler(this.comboBoxTProduto_SelectedIndexChanged);
            // 
            // lbTipoProduto
            // 
            this.lbTipoProduto.AutoSize = true;
            this.lbTipoProduto.Location = new System.Drawing.Point(299, 33);
            this.lbTipoProduto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTipoProduto.Name = "lbTipoProduto";
            this.lbTipoProduto.Size = new System.Drawing.Size(90, 17);
            this.lbTipoProduto.TabIndex = 1;
            this.lbTipoProduto.Text = "Tipo Produto";
            // 
            // btnInsertCasta
            // 
            this.btnInsertCasta.Location = new System.Drawing.Point(35, 150);
            this.btnInsertCasta.Margin = new System.Windows.Forms.Padding(4);
            this.btnInsertCasta.Name = "btnInsertCasta";
            this.btnInsertCasta.Size = new System.Drawing.Size(116, 65);
            this.btnInsertCasta.TabIndex = 3;
            this.btnInsertCasta.Text = "Inserir Nova Casta";
            this.btnInsertCasta.UseVisualStyleBackColor = true;
            this.btnInsertCasta.Click += new System.EventHandler(this.btnInsertCasta_Click);
            // 
            // btnInsertTipoProduto
            // 
            this.btnInsertTipoProduto.Location = new System.Drawing.Point(261, 150);
            this.btnInsertTipoProduto.Margin = new System.Windows.Forms.Padding(4);
            this.btnInsertTipoProduto.Name = "btnInsertTipoProduto";
            this.btnInsertTipoProduto.Size = new System.Drawing.Size(116, 65);
            this.btnInsertTipoProduto.TabIndex = 3;
            this.btnInsertTipoProduto.Text = "Inserir Novo Tipo Produto";
            this.btnInsertTipoProduto.UseVisualStyleBackColor = true;
            this.btnInsertTipoProduto.Click += new System.EventHandler(this.btnInsertTipoProduto_Click);
            // 
            // btnInsertProduto
            // 
            this.btnInsertProduto.Location = new System.Drawing.Point(127, 241);
            this.btnInsertProduto.Margin = new System.Windows.Forms.Padding(4);
            this.btnInsertProduto.Name = "btnInsertProduto";
            this.btnInsertProduto.Size = new System.Drawing.Size(171, 65);
            this.btnInsertProduto.TabIndex = 3;
            this.btnInsertProduto.Text = "Inserir Novo Produto";
            this.btnInsertProduto.UseVisualStyleBackColor = true;
            this.btnInsertProduto.Click += new System.EventHandler(this.btnInsertProduto_Click);
            // 
            // btnVoltar4
            // 
            this.btnVoltar4.Location = new System.Drawing.Point(16, 293);
            this.btnVoltar4.Margin = new System.Windows.Forms.Padding(4);
            this.btnVoltar4.Name = "btnVoltar4";
            this.btnVoltar4.Size = new System.Drawing.Size(100, 28);
            this.btnVoltar4.TabIndex = 4;
            this.btnVoltar4.Text = "Voltar";
            this.btnVoltar4.UseVisualStyleBackColor = true;
            this.btnVoltar4.Click += new System.EventHandler(this.btnVoltar4_Click);
            // 
            // frmTProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 336);
            this.Controls.Add(this.btnVoltar4);
            this.Controls.Add(this.btnInsertTipoProduto);
            this.Controls.Add(this.btnInsertProduto);
            this.Controls.Add(this.btnInsertCasta);
            this.Controls.Add(this.comboBoxTProduto);
            this.Controls.Add(this.lbTipoProduto);
            this.Controls.Add(this.lbCasta);
            this.Controls.Add(this.comboBoxCasta);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmTProduto";
            this.Text = "frmTProduto";
            this.Load += new System.EventHandler(this.frmTProduto_Load);
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