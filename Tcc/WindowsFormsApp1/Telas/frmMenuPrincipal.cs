using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Classes.Program.UserSession;

namespace WindowsFormsApp1
{
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void VerificarPemissoes()
        {
            if (UserSession.UsuarioLogado.PermissaoADM == false)
            {
                if (UserSession.UsuarioLogado.PermissaoEvento == false)
                {
                    eventoToolStripMenuItem.Enabled = false;
                }

                if (UserSession.UsuarioLogado.PermissaoRelatorio == false)
                {
                    relatorioToolStripMenuItem.Enabled = false;
                }
            }
        }

        private void eventoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroEvento tela = new frmCadastroEvento();
            tela.Show();
            this.Hide();
        }

        private void funcionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroFuncionario tela = new frmCadastroFuncionario();
            tela.Show();
            this.Hide();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastrarCliente tela = new frmCadastrarCliente();
            tela.Show();
            this.Hide();
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

        private void clientesCadastradosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRelatórioCliente tela = new frmRelatórioCliente();
            tela.Show();
            this.Hide();
        }

        private void fornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRelatórioCliente tela = new frmRelatórioCliente();
            tela.Show();
            this.Hide();
        }

        private void eventosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
