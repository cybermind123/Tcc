using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void eventoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmCadastroEvento tela = new frmCadastroEvento();
            tela.Show();
            this.Hide();
        }

        private void fornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroFornecedor tela = new frmCadastroFornecedor();
            tela.Show();
            this.Hide();
        }
    }
}
