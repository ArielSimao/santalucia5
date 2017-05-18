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
    public partial class frmLivrosConsulta : MetroFramework.Forms.MetroForm
    {
        public frmLivrosConsulta()
        {
            InitializeComponent();
        }

        private void frmLivrosConsulta_Load(object sender, EventArgs e)
        {
            //Expressão Lambra para ordenar a lista de editoras 
            using (var context = new BibliotecaContext())
            {
                var listaLivros = context.Livros.OrderBy(x => x.Titulo).ToList();
                gridEditoras.DataSource = listaLivros;
                gridEditoras.Columns["Editora"].Visible = false;
            }
            
        }

        private void txtLivro_TextChanged(object sender, EventArgs e)
        {
            gridEditoras.DataSource = null;
            using (var context = new BibliotecaContext())
            {
                var listaLivro = context
                    .Livros.Where(x => x.Titulo.Contains(txtLivro.Text))
                    .ToList<Livro>();
                gridEditoras.DataSource = listaLivro;
                gridEditoras.Columns["Editora"].Visible = false;

            }
        }
    }
}
