using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula2302_Contas
{
    public partial class FrmConta : Form
    {
        //Atributo para a conta
        protected Conta cc;

        public FrmConta()
        {
            InitializeComponent();
            cc = new Conta();
        }

        private void txtContaCorrente_Leave(object sender, EventArgs e)
        {
            txtNomeCorrentista.Enabled = false;
            txtContaCorrente.Enabled = false;
            //Desabilitei as caixa de texto
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            Application.Exit();
            //Fecha a aplicação
        }

        private void btnDepositar_Click(object sender, EventArgs e)
        {
            cc.nomeCorrentista = txtNomeCorrentista.Text;
            cc.contaCorrente = int.Parse(txtContaCorrente.Text);
            double valorTransacao = Double.Parse(txtValorTransacao.Text);
            bool r = cc.depositar(valorTransacao);
            if (r)
            {
                MessageBox.Show("Deposito efetuado com sucesso");
            }
            else {
                MessageBox.Show("Valor deve ser positivo");
            }
        }

        private void btnSacar_Click(object sender, EventArgs e)
        {
            double valorTransacao = Double.Parse(txtValorTransacao.Text);
            bool r = cc.sacar(valorTransacao);
            if (r)
            {
                MessageBox.Show("Saque efetuado com sucesso");
            }
            else
            {
                MessageBox.Show("Valor deve ser positivo / ou não possui saldo");
            }
        }

        private void btnExibirSaldo_Click(object sender, EventArgs e)
        {
            txtSaldo.Text = cc.exibirSaldo().ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 tela = new Form2(cc);
            tela.Show();
        }
    }
}
