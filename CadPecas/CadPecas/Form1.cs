using CadPecas.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadPecas
{
    public partial class Form1 : Form
    {
        //Definir um vetor de Objeto
        //A ideia é suportar até 10
        //peças cadastradas
        Peca[] vetPecas = new Peca[10];
        int posicao = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            //Verificar se há posicoes
            if (posicao < 10)
            {
                Peca peca = new Peca();
                peca.CodPeca = int.Parse(txtCodPeca.Text);
                peca.Descricao = txtDescricao.Text;
                peca.Valor = double.Parse(txtValor.Text);
                vetPecas[posicao++] = peca;
                MessageBox.Show("Cadastro efetuado");
                limparTextos();
            }
            else
            {
                MessageBox.Show("Não há espaço para inserir");
            }
        }

        private void limparTextos()
        {
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            foreach (Peca item in vetPecas)
            {
                if (item != null)
                {
                    if (item.CodPeca == int.Parse(txtProc.Text))
                    {
                        txtCodPeca.Text = item.CodPeca.ToString();
                        txtDescricao.Text = item.Descricao;
                        txtValor.Text = item.Valor.ToString();
                        MessageBox.Show("Item encontrado");
                        txtProc.Text = "";
                        break; //Interromper a busca
                    }
                }
            }
        }
    }
}
