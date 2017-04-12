using GerenciamentoContas.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciamentoContas
{
    public partial class Form1 : Form
    {
        //Criar atributo do tipo conta
        Conta c1 = new Conta();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnDepositar_Click(object sender, EventArgs e)
        {
            try
            {
                c1.NumConta = int.Parse(txtNumConta.Text);
                c1.NomeCliente = txtNomeCliente.Text;
                c1.depositar(double.Parse(txtValor.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Aconteceu o erro: " + ex.Message);
            }
            finally
            {
                MessageBox.Show("Saldo Atual: " + c1.Saldo);
            }
        }
    }
}
