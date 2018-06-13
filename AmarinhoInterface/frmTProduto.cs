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
            frmInserirProduto inserirProduto = new frmInserirProduto(db);
            Hide();
            inserirProduto.ShowDialog();

        }
    }
}
