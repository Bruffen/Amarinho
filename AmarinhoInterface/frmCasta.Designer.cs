namespace AmarinhoInterface
{
    partial class frmCasta
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
            this.btnAddNCasta = new System.Windows.Forms.Button();
            this.lbNomeCasta = new System.Windows.Forms.Label();
            this.labTipoCasta = new System.Windows.Forms.Label();
            this.lbLocalOrigem = new System.Windows.Forms.Label();
            this.txtDescricaoCasta = new System.Windows.Forms.Label();
            this.txtNomeCasta = new System.Windows.Forms.TextBox();
            this.txtTipoCasta = new System.Windows.Forms.TextBox();
            this.TxtLocalOrigem = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.btnVoltarMenuCastas = new System.Windows.Forms.Button();
            this.lbIdCasta = new System.Windows.Forms.Label();
            this.txtIDCasta = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAddNCasta
            // 
            this.btnAddNCasta.Location = new System.Drawing.Point(552, 321);
            this.btnAddNCasta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddNCasta.Name = "btnAddNCasta";
            this.btnAddNCasta.Size = new System.Drawing.Size(111, 102);
            this.btnAddNCasta.TabIndex = 0;
            this.btnAddNCasta.Text = "Inserir Nova Casta";
            this.btnAddNCasta.UseVisualStyleBackColor = true;
            this.btnAddNCasta.Click += new System.EventHandler(this.btnAddNCasta_Click);
            // 
            // lbNomeCasta
            // 
            this.lbNomeCasta.AutoSize = true;
            this.lbNomeCasta.Location = new System.Drawing.Point(17, 49);
            this.lbNomeCasta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNomeCasta.Name = "lbNomeCasta";
            this.lbNomeCasta.Size = new System.Drawing.Size(105, 17);
            this.lbNomeCasta.TabIndex = 1;
            this.lbNomeCasta.Text = "Nome da Casta";
            // 
            // labTipoCasta
            // 
            this.labTipoCasta.AutoSize = true;
            this.labTipoCasta.Location = new System.Drawing.Point(16, 96);
            this.labTipoCasta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labTipoCasta.Name = "labTipoCasta";
            this.labTipoCasta.Size = new System.Drawing.Size(96, 17);
            this.labTipoCasta.TabIndex = 1;
            this.labTipoCasta.Text = "Tipo de Casta";
            // 
            // lbLocalOrigem
            // 
            this.lbLocalOrigem.AutoSize = true;
            this.lbLocalOrigem.Location = new System.Drawing.Point(16, 138);
            this.lbLocalOrigem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbLocalOrigem.Name = "lbLocalOrigem";
            this.lbLocalOrigem.Size = new System.Drawing.Size(112, 17);
            this.lbLocalOrigem.TabIndex = 1;
            this.lbLocalOrigem.Text = "Local de Origem";
            // 
            // txtDescricaoCasta
            // 
            this.txtDescricaoCasta.AutoSize = true;
            this.txtDescricaoCasta.Location = new System.Drawing.Point(16, 177);
            this.txtDescricaoCasta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtDescricaoCasta.Name = "txtDescricaoCasta";
            this.txtDescricaoCasta.Size = new System.Drawing.Size(71, 17);
            this.txtDescricaoCasta.TabIndex = 1;
            this.txtDescricaoCasta.Text = "Descrição";
            // 
            // txtNomeCasta
            // 
            this.txtNomeCasta.Location = new System.Drawing.Point(133, 49);
            this.txtNomeCasta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNomeCasta.Name = "txtNomeCasta";
            this.txtNomeCasta.Size = new System.Drawing.Size(400, 22);
            this.txtNomeCasta.TabIndex = 2;
            // 
            // txtTipoCasta
            // 
            this.txtTipoCasta.Location = new System.Drawing.Point(133, 92);
            this.txtTipoCasta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTipoCasta.Name = "txtTipoCasta";
            this.txtTipoCasta.Size = new System.Drawing.Size(400, 22);
            this.txtTipoCasta.TabIndex = 2;
            // 
            // TxtLocalOrigem
            // 
            this.TxtLocalOrigem.Location = new System.Drawing.Point(133, 134);
            this.TxtLocalOrigem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtLocalOrigem.Name = "TxtLocalOrigem";
            this.TxtLocalOrigem.Size = new System.Drawing.Size(400, 22);
            this.TxtLocalOrigem.TabIndex = 2;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(133, 177);
            this.txtDescricao.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(400, 137);
            this.txtDescricao.TabIndex = 2;
            this.txtDescricao.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // btnVoltarMenuCastas
            // 
            this.btnVoltarMenuCastas.Location = new System.Drawing.Point(17, 394);
            this.btnVoltarMenuCastas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnVoltarMenuCastas.Name = "btnVoltarMenuCastas";
            this.btnVoltarMenuCastas.Size = new System.Drawing.Size(100, 28);
            this.btnVoltarMenuCastas.TabIndex = 3;
            this.btnVoltarMenuCastas.Text = "Voltar";
            this.btnVoltarMenuCastas.UseVisualStyleBackColor = true;
            this.btnVoltarMenuCastas.Click += new System.EventHandler(this.btnVoltarMenuCastas_Click);
            // 
            // lbIdCasta
            // 
            this.lbIdCasta.AutoSize = true;
            this.lbIdCasta.Location = new System.Drawing.Point(588, 26);
            this.lbIdCasta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbIdCasta.Name = "lbIdCasta";
            this.lbIdCasta.Size = new System.Drawing.Size(19, 17);
            this.lbIdCasta.TabIndex = 4;
            this.lbIdCasta.Text = "Id";
            // 
            // txtIDCasta
            // 
            this.txtIDCasta.Location = new System.Drawing.Point(592, 46);
            this.txtIDCasta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIDCasta.Name = "txtIDCasta";
            this.txtIDCasta.Size = new System.Drawing.Size(60, 22);
            this.txtIDCasta.TabIndex = 2;
            // 
            // frmCasta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 438);
            this.Controls.Add(this.lbIdCasta);
            this.Controls.Add(this.btnVoltarMenuCastas);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.TxtLocalOrigem);
            this.Controls.Add(this.txtTipoCasta);
            this.Controls.Add(this.txtIDCasta);
            this.Controls.Add(this.txtNomeCasta);
            this.Controls.Add(this.txtDescricaoCasta);
            this.Controls.Add(this.lbLocalOrigem);
            this.Controls.Add(this.labTipoCasta);
            this.Controls.Add(this.lbNomeCasta);
            this.Controls.Add(this.btnAddNCasta);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmCasta";
            this.Text = "Casta";
            this.Load += new System.EventHandler(this.frmCasta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddNCasta;
        private System.Windows.Forms.Label lbNomeCasta;
        private System.Windows.Forms.Label labTipoCasta;
        private System.Windows.Forms.Label lbLocalOrigem;
        private System.Windows.Forms.Label txtDescricaoCasta;
        private System.Windows.Forms.TextBox txtNomeCasta;
        private System.Windows.Forms.TextBox txtTipoCasta;
        private System.Windows.Forms.TextBox TxtLocalOrigem;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Button btnVoltarMenuCastas;
        private System.Windows.Forms.Label lbIdCasta;
        private System.Windows.Forms.TextBox txtIDCasta;
    }
}