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
            if (bt1.Text == "X" && bt2.Text == "X" && bt3.Text == "X")
            {
                MessageBox.Show("X Ganhou");
                btNovo_Click(null, null);
                return;
            }
            if (bt4.Text == "X" && bt5.Text == "X" && bt6.Text == "X")
            {
                MessageBox.Show("X Ganhou");
                btNovo_Click(null, null);
                return;
            }
            if (bt7.Text == "X" && bt8.Text == "X" && bt9.Text == "X")
            {
                MessageBox.Show("X Ganhou");
                btNovo_Click(null, null);
                return;
            }
            if (bt1.Text == "X" && bt4.Text == "X" && bt7.Text == "X")
            {
                MessageBox.Show("X Ganhou");
                btNovo_Click(null, null);
                return;
            }
            if (bt2.Text == "X" && bt5.Text == "X" && bt8.Text == "X")
            {
                MessageBox.Show("X Ganhou");
                btNovo_Click(null, null);
                return;
            }
            if (bt3.Text == "X" && bt6.Text == "X" && bt9.Text == "X")
            {
                MessageBox.Show("X Ganhou");
                btNovo_Click(null, null);
                return;
            }
            if (bt1.Text == "X" && bt5.Text == "X" && bt9.Text == "X")
            {
                MessageBox.Show("X Ganhou");
                btNovo_Click(null, null);
                return;
            }
            if (bt3.Text == "X" && bt5.Text == "X" && bt7.Text == "X")
            {
                MessageBox.Show("X Ganhou");
                btNovo_Click(null, null);
                return;
            }

            /////Jogador 0
            if (bt1.Text == "0" && bt2.Text == "0" && bt3.Text == "0")
            {
                MessageBox.Show("0 Ganhou");
                btNovo_Click(null, null);
                return;
            }
            if (bt4.Text == "0" && bt5.Text == "0" && bt6.Text == "0")
            {
                MessageBox.Show("0 Ganhou");
                btNovo_Click(null, null);
                return;
            }
            if (bt7.Text == "0" && bt8.Text == "0" && bt9.Text == "0")
            {
                MessageBox.Show("0 Ganhou");
                btNovo_Click(null, null);
                return;
            }
            if (bt1.Text == "0" && bt4.Text == "0" && bt7.Text == "0")
            {
                MessageBox.Show("0 Ganhou");
                btNovo_Click(null, null);
                return;
            }
            if (bt2.Text == "0" && bt5.Text == "0" && bt8.Text == "0")
            {
                MessageBox.Show("0 Ganhou");
                btNovo_Click(null, null);
                return;
            }
            if (bt3.Text == "0" && bt6.Text == "0" && bt9.Text == "0")
            {
                MessageBox.Show("0 Ganhou");
                btNovo_Click(null, null);
                return;
            }
            if (bt1.Text == "0" && bt5.Text == "0" && bt9.Text == "0")
            {
                MessageBox.Show("0 Ganhou");
                btNovo_Click(null, null);
                return;
            }
            if (bt3.Text == "0" && bt5.Text == "0" && bt7.Text == "0")
            {
                MessageBox.Show("0 Ganhou");
                btNovo_Click(null, null);
                return;
            }
            if (vez == 9) {
                MessageBox.Show("Empate");
                btNovo_Click(null, null);
                return;
            }
        }
    }
}
