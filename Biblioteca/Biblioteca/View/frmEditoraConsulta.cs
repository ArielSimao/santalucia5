using Biblioteca.Model;
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
    public partial class frmEditoraConsulta : MetroFramework.Forms.MetroForm
    {
        public frmEditoraConsulta()
        {
            InitializeComponent();
        }

        private void frmEditoraConsulta_Load(object sender, EventArgs e)
        {
            //Expressão Lambra para ordenar a lista de editoras 
            using (var context = new BibliotecaContext())
            {
                var listaEditoras = context.Editoras.OrderBy(x => x.Descricao).ToList<Editora>();
                gridEditoras.DataSource = listaEditoras;
                gridEditoras.Columns["Livros"].Visible = false;

                var listaLivros = context.Livros.OrderBy(x => x.Titulo).ToList();
                gridLivros.DataSource = listaLivros;
                gridLivros.Columns["Editora"].Visible = false;
            }

        }

        private void txtEditora_TextChanged(object sender, EventArgs e)
        {
            using (var context = new BibliotecaContext())
            {
                var listaEditoras = context
                    .Editoras.Where(x => x.Descricao.Contains(txtEditora.Text))
                    .ToList<Editora>();
                gridEditoras.DataSource = listaEditoras;
                gridEditoras.Columns["Livros"].Visible = false;

            }
        }

        private void txtEditora_Click(object sender, EventArgs e)
        {

        }

       

        private void gridEditoras_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void gridEditoras_SelectionChanged(object sender, EventArgs e)
        {
            int editoraIdFiltrada = 0;
            if (gridEditoras.CurrentRow != null)
                editoraIdFiltrada = Convert.ToInt16(gridEditoras.CurrentRow.Cells["EditoraId"].Value);
            using (var context = new BibliotecaContext())
            {
                var listaLivros = context
                    .Livros.Where(x => x.EditoraId == editoraIdFiltrada)
                    .ToList();
                gridLivros.DataSource = listaLivros;
                gridLivros.Columns["Editora"].Visible = false;
                metroLabel2.Text = "Lista de Livros da Editora: " + gridEditoras.CurrentRow.Cells["Descricao"].Value.ToString();
            }
        }
    }
}
