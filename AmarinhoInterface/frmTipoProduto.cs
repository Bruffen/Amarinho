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
    public partial class frmTipoProduto : Form
    {
        private DataBase db;

        public frmTipoProduto(DataBase db)
        {
            InitializeComponent();
            this.db = db;
        }

        private void frmTipoProduto_Load(object sender, EventArgs e)
        {
            tableTipoProduto.DataSource = db.MostarTudo("Tipo_Produto");
        }

        private void btnVoltarMenuProdutoII_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem a certeza que pretende sair?", "Sair?"
               , MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                frmTProduto voltaMenu = new frmTProduto(db);
                voltaMenu.Show();
                Close();
            }
        }


        private void btnAddTipoProduto_Click(object sender, EventArgs e)
        {
            frmInserirProduto inserirTipoProduto = new frmInserirProduto(db);
            Close();
            inserirTipoProduto.Show();
        }

        private void btnRemoveProduto_Click(object sender, EventArgs e)
        {
            db.RemoverTipoProduto(int.Parse(tableTipoProduto.SelectedRows[0].Cells["Tipo_Produto_ID"].Value.ToString()));
            frmTipoProduto_Load(sender, e);
        }
    }
}
