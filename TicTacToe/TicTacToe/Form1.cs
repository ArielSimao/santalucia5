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
        public int vencedorX = 0;
        public int vencedor0 = 0;

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
            vez = 0;
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
            String vlr = "";

            for (int i = 0; i < 2; i++)
            {
                if (i == 0)
                {
                    vlr = "X";
                }
                else
                {
                    vlr = "0";
                }
                if (bt1.Text == vlr && bt2.Text == vlr && bt3.Text == vlr)
                {
                    mensagem("Jogador " + vlr + " Venceu");

                }
                if (bt4.Text == vlr && bt5.Text == vlr && bt6.Text == vlr)
                {
                    mensagem("Jogador " + vlr + " Venceu");
                }
                if (bt7.Text == vlr && bt8.Text == vlr && bt9.Text == vlr)
                {
                    mensagem("Jogador " + vlr + " Venceu");
                }
                if (bt1.Text == vlr && bt4.Text == vlr && bt7.Text == vlr)
                {
                    mensagem("Jogador " + vlr + " Venceu");
                }
                if (bt2.Text == vlr && bt5.Text == vlr && bt8.Text == vlr)
                {
                    mensagem("Jogador " + vlr + " Venceu");
                }
                if (bt3.Text == vlr && bt6.Text == vlr && bt9.Text == vlr)
                {
                    mensagem("Jogador " + vlr + " Venceu");
                }
                if (bt1.Text == vlr && bt5.Text == vlr && bt9.Text == vlr)
                {
                    mensagem("Jogador " + vlr + " Venceu");
                }
                if (bt3.Text == vlr && bt5.Text == vlr && bt7.Text == vlr)
                {
                    mensagem("Jogador " + vlr + " Venceu");
                }


                if (vez == 9)
                {
                    MessageBox.Show("Empate");
                    btNovo_Click(null, null);
                    return;
                }


            }

        }

        private void mensagem(string v)
        {
            String r = v.Substring(8, 1);
            if (r == "X")
            {
                vencedorX++;
                metroLabel1.Text = "Jogador X Total: " + vencedorX;
            }
            else
            {
                vencedor0++;
                metroLabel2.Text = "Jogador 0 Total: " + vencedor0;
            }
            MessageBox.Show(v);
            btNovo_Click(null, null);
            return;
        }
    }
}
