namespace AmarinhoInterface
{
    partial class frmCastas
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
            this.btnRemoveCasta = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAddCasta = new System.Windows.Forms.Button();
            this.btnVoltarMenuProduto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRemoveCasta
            // 
            this.btnRemoveCasta.Location = new System.Drawing.Point(243, 314);
            this.btnRemoveCasta.Name = "btnRemoveCasta";
            this.btnRemoveCasta.Size = new System.Drawing.Size(122, 34);
            this.btnRemoveCasta.TabIndex = 0;
            this.btnRemoveCasta.Text = "Remover";
            this.btnRemoveCasta.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 47);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(492, 224);
            this.dataGridView1.TabIndex = 1;
            // 
            // btnAddCasta
            // 
            this.btnAddCasta.Location = new System.Drawing.Point(392, 314);
            this.btnAddCasta.Name = "btnAddCasta";
            this.btnAddCasta.Size = new System.Drawing.Size(122, 34);
            this.btnAddCasta.TabIndex = 0;
            this.btnAddCasta.Text = "Adicionar";
            this.btnAddCasta.UseVisualStyleBackColor = true;
            // 
            // btnVoltarMenuProduto
            // 
            this.btnVoltarMenuProduto.Location = new System.Drawing.Point(12, 317);
            this.btnVoltarMenuProduto.Name = "btnVoltarMenuProduto";
            this.btnVoltarMenuProduto.Size = new System.Drawing.Size(97, 34);
            this.btnVoltarMenuProduto.TabIndex = 2;
            this.btnVoltarMenuProduto.Text = "Voltar";
            this.btnVoltarMenuProduto.UseVisualStyleBackColor = true;
            // 
            // frmCastas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 360);
            this.Controls.Add(this.btnVoltarMenuProduto);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnAddCasta);
            this.Controls.Add(this.btnRemoveCasta);
            this.Name = "frmCastas";
            this.Text = "Castas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRemoveCasta;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAddCasta;
        private System.Windows.Forms.Button btnVoltarMenuProduto;
    }
}