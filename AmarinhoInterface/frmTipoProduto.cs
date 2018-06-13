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

        }
    }
}
