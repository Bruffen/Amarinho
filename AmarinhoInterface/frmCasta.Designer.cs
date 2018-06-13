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
            this.btnAddNCasta.Location = new System.Drawing.Point(414, 261);
            this.btnAddNCasta.Name = "btnAddNCasta";
            this.btnAddNCasta.Size = new System.Drawing.Size(83, 83);
            this.btnAddNCasta.TabIndex = 0;
            this.btnAddNCasta.Text = "Inserir Nova Casta";
            this.btnAddNCasta.UseVisualStyleBackColor = true;
            // 
            // lbNomeCasta
            // 
            this.lbNomeCasta.AutoSize = true;
            this.lbNomeCasta.Location = new System.Drawing.Point(13, 40);
            this.lbNomeCasta.Name = "lbNomeCasta";
            this.lbNomeCasta.Size = new System.Drawing.Size(80, 13);
            this.lbNomeCasta.TabIndex = 1;
            this.lbNomeCasta.Text = "Nome da Casta";
            // 
            // labTipoCasta
            // 
            this.labTipoCasta.AutoSize = true;
            this.labTipoCasta.Location = new System.Drawing.Point(12, 78);
            this.labTipoCasta.Name = "labTipoCasta";
            this.labTipoCasta.Size = new System.Drawing.Size(73, 13);
            this.labTipoCasta.TabIndex = 1;
            this.labTipoCasta.Text = "Tipo de Casta";
            // 
            // lbLocalOrigem
            // 
            this.lbLocalOrigem.AutoSize = true;
            this.lbLocalOrigem.Location = new System.Drawing.Point(12, 112);
            this.lbLocalOrigem.Name = "lbLocalOrigem";
            this.lbLocalOrigem.Size = new System.Drawing.Size(84, 13);
            this.lbLocalOrigem.TabIndex = 1;
            this.lbLocalOrigem.Text = "Local de Origem";
            // 
            // txtDescricaoCasta
            // 
            this.txtDescricaoCasta.AutoSize = true;
            this.txtDescricaoCasta.Location = new System.Drawing.Point(12, 144);
            this.txtDescricaoCasta.Name = "txtDescricaoCasta";
            this.txtDescricaoCasta.Size = new System.Drawing.Size(55, 13);
            this.txtDescricaoCasta.TabIndex = 1;
            this.txtDescricaoCasta.Text = "Descrição";
            // 
            // txtNomeCasta
            // 
            this.txtNomeCasta.Location = new System.Drawing.Point(100, 40);
            this.txtNomeCasta.Name = "txtNomeCasta";
            this.txtNomeCasta.Size = new System.Drawing.Size(301, 20);
            this.txtNomeCasta.TabIndex = 2;
            // 
            // txtTipoCasta
            // 
            this.txtTipoCasta.Location = new System.Drawing.Point(100, 75);
            this.txtTipoCasta.Name = "txtTipoCasta";
            this.txtTipoCasta.Size = new System.Drawing.Size(301, 20);
            this.txtTipoCasta.TabIndex = 2;
            // 
            // TxtLocalOrigem
            // 
            this.TxtLocalOrigem.Location = new System.Drawing.Point(100, 109);
            this.TxtLocalOrigem.Name = "TxtLocalOrigem";
            this.TxtLocalOrigem.Size = new System.Drawing.Size(301, 20);
            this.TxtLocalOrigem.TabIndex = 2;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(100, 144);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(301, 112);
            this.txtDescricao.TabIndex = 2;
            this.txtDescricao.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // btnVoltarMenuCastas
            // 
            this.btnVoltarMenuCastas.Location = new System.Drawing.Point(13, 320);
            this.btnVoltarMenuCastas.Name = "btnVoltarMenuCastas";
            this.btnVoltarMenuCastas.Size = new System.Drawing.Size(75, 23);
            this.btnVoltarMenuCastas.TabIndex = 3;
            this.btnVoltarMenuCastas.Text = "Voltar";
            this.btnVoltarMenuCastas.UseVisualStyleBackColor = true;
            this.btnVoltarMenuCastas.Click += new System.EventHandler(this.btnVoltarMenuCastas_Click);
            // 
            // lbIdCasta
            // 
            this.lbIdCasta.AutoSize = true;
            this.lbIdCasta.Location = new System.Drawing.Point(441, 21);
            this.lbIdCasta.Name = "lbIdCasta";
            this.lbIdCasta.Size = new System.Drawing.Size(16, 13);
            this.lbIdCasta.TabIndex = 4;
            this.lbIdCasta.Text = "Id";
            // 
            // txtIDCasta
            // 
            this.txtIDCasta.Location = new System.Drawing.Point(444, 37);
            this.txtIDCasta.Name = "txtIDCasta";
            this.txtIDCasta.Size = new System.Drawing.Size(46, 20);
            this.txtIDCasta.TabIndex = 2;
            // 
            // frmCasta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 356);
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