using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AmarinhoInterface
{
    public partial class frmTProduto : Form
    {
        private DataBase db;

        public frmTProduto(DataBase db)
        {
            InitializeComponent();
            this.db = db;
        }

        private void comboBoxTProduto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmTProduto_Load(object sender, EventArgs e)
        {
            comboBoxCasta.DataSource = db.MostarTudo("Casta");
            comboBoxCasta.ValueMember = "Casta_ID";
            comboBoxCasta.DisplayMember = "Nome_Casta";

            comboBoxTProduto.DataSource = db.MostarTudo("Tipo_Produto");
            comboBoxTProduto.ValueMember = "Tipo_Produto_ID";
            comboBoxTProduto.DisplayMember = "Desc_Produto";
        }

        private void btnVoltar4_Click(object sender, EventArgs e)
        {
            frmListaProduto listaProduto = new frmListaProduto(db);
            Close();
            listaProduto.Show();
        }

        private void btnInsertCasta_Click(object sender, EventArgs e)
        {
            frmCastas vaiCastas = new frmCastas(db);
            Hide();
            vaiCastas.ShowDialog();
        }

        private void btnInsertTipoProduto_Click(object sender, EventArgs e)
        {
            frmTipoProduto inserirProduto = new frmTipoProduto(db);
            Hide();
            inserirProduto.ShowDialog();
        }

        private void comboBoxCasta_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnInsertProduto_Click(object sender, EventArgs e)
        {
            db.AdicionarProduto(int.Parse(comboBoxCasta.SelectedValue.ToString()), int.Parse(comboBoxTProduto.SelectedValue.ToString()));
        }
    }
}



