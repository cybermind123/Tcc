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
    public partial class frmCadastrarCliente : Form
    {
        public frmCadastrarCliente()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {


                frmMenuPrincipal tela = new frmMenuPrincipal();
                tela.Show();
                this.Hide();
            }
            catch
            {
                MessageBox.Show("Ocorreu um erro");
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
