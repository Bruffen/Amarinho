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
    public partial class frmListaProduto : Form
    {
        private DataBase db;

        public frmListaProduto(DataBase db)
        {
            InitializeComponent();
            this.db = db;
        }

        private void frmListaProduto_Load(object sender, EventArgs e)
        {
           gridListaProdutos.DataSource = db.MostarTudo("Produto");
        }

        private void btnAddProdutoLP_Click(object sender, EventArgs e)
        {
            frmTProduto tproduto = new frmTProduto(db);
            Hide();
            tproduto.ShowDialog();
        }
    }
}
