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
    public partial class frmCasta: Form
    {
        private DataBase db;
        public frmCasta(DataBase db)
        {
            InitializeComponent();
            this.db = db;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmCasta_Load(object sender, EventArgs e)
        {

        }

        private void btnVoltarMenuCastas_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            frmCastas voltaCastas = new frmCastas();
             Close();
=======
            frmCastas voltaCastas = new frmCastas(db);
>>>>>>> master
            voltaCastas.Show();
           
            
        }
    }
}
