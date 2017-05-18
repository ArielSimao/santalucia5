using MetroFramework.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public int vez = 0;

        public Form1()
        {
            InitializeComponent();
            this.Text = "Jogo da Velha";
        }

        public void limparBotoes()
        {
            foreach (Control item in this.Controls)
            {
                if (item is MetroButton)
                {
                    if (!item.Name.Equals("btNovo"))
                    {
                        MetroButton x = (MetroButton)item;
                        x.Text = "";
                    }
                }
            }
        }

        private void btNovo_Click(object sender, EventArgs e)
        {
            limparBotoes();
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            //sender é o objeto que enviou o sinal (botão 
            //que você clicou.
            MetroButton bj = (MetroButton)sender;
            if (!bj.Text.Equals(""))
            {
                MessageBox.Show("casa já jogada");
                return;
            }
            vez++;
            if (vez % 2 == 1)
            {
                bj.Text = "X";
            }
            else
            {
                bj.Text = "0";
            }
            verificarVencedor();
        }

        private void verificarVencedor()
        {
            
        }
    }
}
