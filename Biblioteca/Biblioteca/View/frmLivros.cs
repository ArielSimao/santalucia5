using Biblioteca.Model;
using Biblioteca.Utils;
using System;
using System.Collections;
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
    public partial class frmLivros : MetroFramework.Forms.MetroForm
    {
        public frmLivros()
        {
            InitializeComponent();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            using (var context = new BibliotecaContext())
            {
                if (txtLivroId.Text.Equals("")) return;
                int id = int.Parse(txtLivroId.Text);
                var livro = context.Livros.FirstOrDefault(l => l.LivroId == id);
                if (livro != null)
                {
                    context.Livros.Remove(livro);
                    context.SaveChanges();
                    MessageBox.Show(null, "Excluído com sucesso", "Mensagem",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            Util.limparForm(this);
            Util.liberarBotoes(this);
        }

        private void frmLivros_Load(object sender, EventArgs e)
        {
            using (var context = new BibliotecaContext())
            {
                //Expressão Lambra para ordenar a lista de editoras 
                List<Editora> listaEditoras = context.Editoras.OrderBy(x=> x.Descricao).ToList<Editora>();

                comboEditora.DataSource = listaEditoras;
                comboEditora.DisplayMember = "Descricao";
                comboEditora.ValueMember = "EditoraId";
                comboEditora.Invalidate();
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            
            var editora = (Editora) comboEditora.SelectedItem;
            //Gravar um novo Livro
            var livro = new Livro
            {
                Titulo = txtTitulo.Text,
                Autor = txtAutor.Text,
                EditoraId = editora.EditoraId
            };
            //Criar um novo contexto
            using (var context = new BibliotecaContext())
            {
                context.Livros.Add(livro);
                context.SaveChanges();
            }
            //Limpar o formulário
            Util.limparForm(this);
            Util.liberarBotoes(this);
            MessageBox.Show(null, "Gravado com sucesso", "Mensagem",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            var editora = (Editora)comboEditora.SelectedItem;

            using (var context = new BibliotecaContext())
            {
                if (txtLivroId.Text.Equals("")) return;
                int id = int.Parse(txtLivroId.Text);
                var livro = context.Livros.FirstOrDefault(l => l.LivroId == id);
                livro.Titulo = txtTitulo.Text;
                livro.Autor = txtAutor.Text;
                livro.EditoraId = editora.EditoraId;
                context.SaveChanges();
            }
            MessageBox.Show(null, "Gravado com sucesso", "Mensagem",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            //Liberar os botões e txtEditoraId para o padrão
            Util.limparForm(this);
            Util.liberarBotoes(this);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Util.limparForm(this);
            Util.liberarBotoes(this);
        }

        private void txtLivroId_Leave(object sender, EventArgs e)
        {
            //Ao perder o foco, procurar livro com 
            //o código especificado
            using (var context = new BibliotecaContext())
            {
                if (txtLivroId.Text.Equals("")) return;
                int id = int.Parse(txtLivroId.Text);
                var result = context.Livros.FirstOrDefault(l => l.LivroId == id);
                if (result == null)
                {
                    //Liberar Botão para Gravar
                    btnGravar.Enabled = true;
                    btnExcluir.Enabled = false;
                    btnAlterar.Enabled = false;
                    txtLivroId.Text = "<AUT>";
                }
                else
                {
                    //Liberar Botão Alterar
                    btnGravar.Enabled = false;
                    btnAlterar.Enabled = true;
                    txtLivroId.Text = result.LivroId.ToString();
                    //Trava o text txtEditoraId
                    txtLivroId.Enabled = false;
                    txtTitulo.Text = result.Titulo;
                    txtAutor.Text = result.Autor;
                    comboEditora.SelectedValue = result.Editora.EditoraId;

                }
            }
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            frmLivrosConsulta tela = new frmLivrosConsulta();
            tela.Text = "Lista de Livros";
            tela.Show();
        }
    }
}
