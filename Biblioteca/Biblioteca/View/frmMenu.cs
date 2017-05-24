using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca.View
{
    public partial class frmMenu : MetroFramework.Forms.MetroForm
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void livrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var fc = Application.OpenForms;
            //Abrir apenas uma instância do formulário
            foreach (Form item in fc)
            {
                //Se encontrar o frmLivros aberto, não procede nova abertura
                if (item.Name.ToString().Equals("frmLivros")) return;
            }
            var telaLivros = new frmLivros();
            telaLivros.MdiParent = this;
            telaLivros.Theme = MetroFramework.MetroThemeStyle.Dark;
            telaLivros.StartPosition = FormStartPosition.CenterScreen;
            telaLivros.Show();
        }

        private void editoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var fc = Application.OpenForms;
            //Abrir apenas uma instância do formulário
            foreach (Form item in fc)
            {
                //Se encontrar o frmEditoras aberto, não procede nova abertura
                if (item.Name.ToString().Equals("frmEditoras")) return;
            }
            var telaEditora = new frmEditoras();
            telaEditora.MdiParent = this;
            telaEditora.StartPosition = FormStartPosition.CenterScreen;
            telaEditora.Show();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StringBuilder mensagem = new StringBuilder();
            mensagem.AppendLine("Sistema desenvolvido na Facudade Santa Lúcia");
            mensagem.AppendLine("Aula de Laboratório de Programação III");
            mensagem.AppendLine("Aluno: ");
            mensagem.AppendLine("Professor Maromo");
            mensagem.AppendLine();
            mensagem.AppendLine("Versão Beta 1");
            MessageBox.Show(null, mensagem.ToString(),"Sobre o Sistema...",  
                MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
