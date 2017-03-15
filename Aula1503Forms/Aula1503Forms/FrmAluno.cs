using Aula1503Forms.Model;
using Aula1503Forms.Persistence;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula1503Forms
{
    public partial class FrmAluno : Form
    {
        //Lista publica de alunos
        public List<Aluno> lista;
        //Criei atributo para persistencia (agregado)
        AlunoBus alunoBus;

        //inicializei a lista vazia
        public FrmAluno()
        {
            InitializeComponent();
            lista = new List<Aluno>();
            dataAlunos.DataSource = lista;
            //instancie o atributo de persistencia criado
            alunoBus = new AlunoBus();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            //Criei um objeto aluno
            Aluno aluno = new Aluno();
            aluno.Nome = txtNomeAluno.Text.ToUpper();
            aluno.Email = txtEmail.Text.ToLower();
            aluno.Telefone = txtTelefone.Text;
            if (radioMasculino.Checked)
            {
                aluno.Sexo = "Masculino";
            }
            else {
                aluno.Sexo = "Feminino";
            }
            
            //Chamei o método adicionar do objeto de persistencia
            //responsavel por adicionar aluno na lsita
            alunoBus.adicionar(aluno);
            dataAlunos.DataSource = null;
            dataAlunos.DataSource = alunoBus.exibirLista();
            //Varredura do formulário para a limpeza dos
            //objetos TextBox.
            foreach (Control item in this.Controls)
            {
                if (item is TextBox) {
                    item.Text = "";
                }
            }
            radioFeminino.Checked = false;
            radioMasculino.Checked = true;

        }
    }
}
