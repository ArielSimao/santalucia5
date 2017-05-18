using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExemploSobrescrita
{
    public partial class Form1 : Form
    {
        //Definir atributo do tipo Funcionario
        Funcionario func = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioGerente_CheckedChanged(object sender, EventArgs e)
        {
            if (radioGerente.Checked)
            {
                lblValor.Text = "Autonomia: ";
            }
        }

        private void radioOperador_CheckedChanged(object sender, EventArgs e)
        {
            if (radioOperador.Checked)
            {
                lblValor.Text = "Quantidade de Horas: ";
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

            //Verificação do tipo de funcionário
            if (radioGerente.Checked)
            {
                func = new Gerente();
            }
            if (radioOperador.Checked)
            {
                func = new Operador();
                
            }
            func.RegFunc = int.Parse(txtRegFunc.Text);
            func.Nome = txtNome.Text;
            func.Email = txtEmail.Text;
            func.Salario = double.Parse(txtSalario.Text);
            if (radioGerente.Checked)
            {
                Gerente copia = (Gerente)func;
                copia.Autonomia = txtValor.Text;
                MessageBox.Show("Gerente: \n" + copia.toPrint());
            }
            if (radioOperador.Checked)
            {
                Operador copia = (Operador)func;
                copia.QuantidadeHoras = int.Parse(txtValor.Text);
                MessageBox.Show("Operador: \n" + copia.toPrint());
            }
            

        }
    }
}
