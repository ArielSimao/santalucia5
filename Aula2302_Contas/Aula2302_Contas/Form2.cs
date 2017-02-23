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
    public partial class Form2 : Form
    {
        protected Conta contaRecebedora;
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(Conta cc)
        {
            InitializeComponent();
            this.contaRecebedora = cc;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nome " + contaRecebedora.nomeCorrentista + "\n" +
                "Conta: " + contaRecebedora.contaCorrente);
        }
    }
}
