using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsExercicio.Model;

namespace WindowsExercicio
{
    public partial class Form1 : Form
    {

        List<Parcela> parcelas;

        public Form1()
        {
            InitializeComponent();
            parcelas = new List<Parcela>();
            dataParcelas.DataSource = parcelas;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            try
            {
                String nome = txtNome.Text;
                double valor = double.Parse(txtValor.Text);
                decimal numParc = numParcelas.Value;
                double valorParcela = valor / (double)numParc;
                List<Parcela> parcGeradas = new List<Parcela>();
                DateTime dataDaParcela = DateTime.Now;
                for (int i = 1; i <= numParc; i++)
                {
                    Parcela p = new Model.Parcela();
                    p.DataVencimento = dataDaParcela;
                    dataDaParcela = dataDaParcela.AddDays(30);
                    p.NumParcela = i;
                    p.Valor = valorParcela;
                    parcGeradas.Add(p);
                }
                dataParcelas.DataSource = null;
                dataParcelas.DataSource = parcGeradas;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Aconteceu um erro: " + ex.Message);
            }
        }
    }
}
