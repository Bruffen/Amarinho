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
    public partial class frmInserirProduto : Form
    {
        private DataBase db;
        public frmInserirProduto(DataBase db)
        {
            InitializeComponent();
            this.db = db;
        }

        private void frmInserirProduto_Load(object sender, EventArgs e)
        {

        }

        private void btnVoltarTipoProduto_Click(object sender, EventArgs e)
        {
            frmTipoProduto voltaMenu = new frmTipoProduto(db);
            Close();
            voltaMenu.Show();
        }

        private void btnInserirProduto_Click(object sender, EventArgs e)
        {
            db.AdicionarTipoProduto(int.Parse(textBoxId.Text), textBoxTipo.Text, int.Parse(textBoxTeor.Text), float.Parse(textCapacidade.Text));
            btnVoltarTipoProduto_Click(sender, e);
        }
    }
}
