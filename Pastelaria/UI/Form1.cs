using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pastelaria
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void fUNCIONÁRIOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UI.frmFuncionarios func = new UI.frmFuncionarios();
            func.MdiParent = this;
            func.Show();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void pRODUTOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UI.frmProdutos prod = new UI.frmProdutos();
            prod.MdiParent = this;
            prod.Show();
        }

        private void cLIENTESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UI.frmClientes cli = new UI.frmClientes();
            cli.MdiParent = this;
            cli.Show();
        }
    }
}
