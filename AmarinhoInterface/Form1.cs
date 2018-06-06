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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void area_EspecializacaoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.area_EspecializacaoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.amarinhoDataSet);

        }

        private void area_EspecializacaoBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.area_EspecializacaoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.amarinhoDataSet);

        }
    }
}
