using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsMedia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            //alimentar o list com o dado do usuário
            int valor;
            if (txtNum.Text != "")
            {
                valor = int.Parse(txtNum.Text);
                listBox1.Items.Add(valor);
                txtNum.Text = "";
                txtNum.Focus();
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int[] vetor;
            if (listBox1.Items.Count > 0) {
                vetor = new int[listBox1.Items.Count];
                //alimentar o vetor
                int soma = 0;
                for (int i = 0; i < vetor.Length; i++)
                {
                    vetor[i] = int.Parse(listBox1.Items[i].ToString());
                    soma += vetor[i];
                }
                float media = (float)soma / vetor.Length;
                Array.Sort(vetor);
                lblMaior.Text = "Maior é: " + vetor[vetor.Length - 1];
                lblMenor.Text = "Menor é: " + vetor[0];
                lblMedia.Text = "Média é: " + media;
            }
        }
    }
}
