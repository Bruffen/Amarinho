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
    public partial class frmCastas : Form
    {
        private DataBase db;
        public frmCastas(DataBase db)
        {
            InitializeComponent();
            this.db = db;
        }

        private void frmCastas_Load(object sender, EventArgs e)
        {
           // dataGridView1.DataSource = db.MostarTudo("Casta");
        }

        private void btnAddCasta_Click(object sender, EventArgs e)
        {

            frmCasta addcasta = new frmCasta(db);
            Hide();
            addcasta.ShowDialog();
            
           
        }

        private void btnVoltarMenuProduto_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem a certeza que pretende sair?", "Sair?"
                , MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
               

                frmTProduto voltaMenu = new frmTProduto(db);
                Close();
                voltaMenu.Show();
               
            }
           
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
