using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsNotepad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
        }

        private void salvarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextWriter escritor;
            saveFileDialog1.Filter = "Arquivos Texto | *.txt";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK &&
                saveFileDialog1.FileName.Length > 0)
            {
                escritor = new StreamWriter(saveFileDialog1.FileName);
                escritor.WriteLine(richTextBox1.Text);
                escritor.Close();
                MessageBox.Show("Arquivo salvo com sucesso");
            }
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextReader leitor;
            openFileDialog1.Filter = "Arquivos Texto | *.txt";
            if (openFileDialog1.ShowDialog() == DialogResult.OK &&
                openFileDialog1.FileName.Length > 0)
            {
                leitor = new StreamReader(openFileDialog1.FileName);
                richTextBox1.Text = leitor.ReadToEnd();
                leitor.Close();
            }
        }

        private void fonteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Font = fontDialog1.Font;
            }
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
            //Falta uma logica para tratar o salvamento.
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Sobre: ");
            sb.AppendLine("Aplicativo Bloco de Notas");
            sb.AppendLine("Feito em: " + DateTime.Now.ToShortDateString());
            sb.AppendLine("By Zezinho");
            MessageBox.Show(null, sb.ToString(),
                "Aplicativo", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}
