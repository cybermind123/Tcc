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
    public partial class frmRelatorio : Form
    {
        public frmRelatorio()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal tela = new frmMenuPrincipal();
            tela.Show();
            this.Hide();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmRelatorio_Load(object sender, EventArgs e)
        {
            frmRelatorio tela = new frmRelatorio();
            tela.Show();
            this.Hide();
        }
    }
}
