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
    public partial class Produto : Form
    {
        public Produto()
        {
            InitializeComponent();
        }

        private void casta_Click(object sender, EventArgs e)
        {
            frmCastas casta = new frmCastas();
            Hide();
            casta.ShowDialog();
        }

        private void tipoProduto_Click(object sender, EventArgs e)
        {
            frmTipoProduto tipoProduto = new frmTipoProduto();
            Hide();
            tipoProduto.ShowDialog();
        }

        private void venda_Click(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}



      