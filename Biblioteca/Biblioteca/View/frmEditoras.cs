using Biblioteca.Model;
using Biblioteca.Utils;
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
    public partial class frmEditoras : MetroFramework.Forms.MetroForm
    {

        public frmEditoras()
        {
            InitializeComponent();
        }
        private void frmEditoras_Load(object sender, EventArgs e)
        {
            
        }
        private void btnGravar_Click(object sender, EventArgs e)
        {
            //Gravar uma nova Editora
            var editora = new Editora
            {
                Descricao = txtDescricao.Text,
                Contato = txtContato.Text,
                Telefone = maskTelefone.Text
            };
            //Criar um novo contexto
            using (var context = new BibliotecaContext())
            {
                context.Editoras.Add(editora);
                context.SaveChanges();
            }
            //Limpar o formulário
            Util.limparForm(this);
            Util.liberarBotoes(this);
            MessageBox.Show(null, "Gravado com sucesso", "Mensagem",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtEditoraId_Leave(object sender, EventArgs e)
        {
            //Ao perder o foco, procurar produto com 
            //o código especificado
            using (var context = new BibliotecaContext())
            {
                if (txtEditoraId.Text.Equals("")) return;
                int id = int.Parse(txtEditoraId.Text);
                var result = context.Editoras.FirstOrDefault(a => a.EditoraId == id);
                if (result == null)
                {
                    //Liberar Botão para Gravar
                    btnGravar.Enabled = true;
                    btnExcluir.Enabled = false;
                    btnAlterar.Enabled = false;
                    txtEditoraId.Text = "<AUT>";
                }
                else
                {
                    //Liberar Botão Alterar
                    btnGravar.Enabled = false;
                    btnAlterar.Enabled = true;
                    txtEditoraId.Text = result.EditoraId.ToString();
                    //Trava o text txtEditoraId
                    txtEditoraId.Enabled = false;
                    txtDescricao.Text = result.Descricao;
                    txtContato.Text = result.Contato;
                    maskTelefone.Text = result.Telefone;
                }
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            using (var context = new BibliotecaContext())
            {
                if (txtEditoraId.Text.Equals("")) return;
                int id = int.Parse(txtEditoraId.Text);
                var editora = context.Editoras.FirstOrDefault(a => a.EditoraId == id);
                editora.Descricao = txtDescricao.Text;
                editora.Contato = txtContato.Text;
                editora.Telefone = maskTelefone.Text;
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

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            using (var context = new BibliotecaContext())
            {
                if (txtEditoraId.Text.Equals("")) return;
                int id = int.Parse(txtEditoraId.Text);
                var editora = context.Editoras.FirstOrDefault(a => a.EditoraId == id);
                if (editora != null)
                {
                    context.Editoras.Remove(editora);
                    context.SaveChanges();
                    MessageBox.Show(null, "Excluído com sucesso", "Mensagem",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            Util.limparForm(this);
            Util.liberarBotoes(this);
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            frmEditoraConsulta tela = new frmEditoraConsulta();
            tela.Show();
            tela.StartPosition = FormStartPosition.CenterScreen;
        }
    }
}