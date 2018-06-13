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
            this.btnRemoveCasta.Location = new System.Drawing.Point(324, 386);
            this.btnRemoveCasta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRemoveCasta.Name = "btnRemoveCasta";
            this.btnRemoveCasta.Size = new System.Drawing.Size(163, 42);
            this.btnRemoveCasta.TabIndex = 0;
            this.btnRemoveCasta.Text = "Remover";
            this.btnRemoveCasta.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(29, 58);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(656, 276);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnAddCasta
            // 
            this.btnAddCasta.Location = new System.Drawing.Point(523, 386);
            this.btnAddCasta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddCasta.Name = "btnAddCasta";
            this.btnAddCasta.Size = new System.Drawing.Size(163, 42);
            this.btnAddCasta.TabIndex = 0;
            this.btnAddCasta.Text = "Adicionar";
            this.btnAddCasta.UseVisualStyleBackColor = true;
            this.btnAddCasta.Click += new System.EventHandler(this.btnAddCasta_Click);
            // 
            // btnVoltarMenuProduto
            // 
            this.btnVoltarMenuProduto.Location = new System.Drawing.Point(16, 390);
            this.btnVoltarMenuProduto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnVoltarMenuProduto.Name = "btnVoltarMenuProduto";
            this.btnVoltarMenuProduto.Size = new System.Drawing.Size(129, 42);
            this.btnVoltarMenuProduto.TabIndex = 2;
            this.btnVoltarMenuProduto.Text = "Voltar";
            this.btnVoltarMenuProduto.UseVisualStyleBackColor = true;
            this.btnVoltarMenuProduto.Click += new System.EventHandler(this.btnVoltarMenuProduto_Click);
            // 
            // frmCastas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 443);
            this.Controls.Add(this.btnVoltarMenuProduto);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnAddCasta);
            this.Controls.Add(this.btnRemoveCasta);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmCastas";
            this.Text = "Castas";
            this.Load += new System.EventHandler(this.frmCastas_Load);
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