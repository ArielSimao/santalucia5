using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrjSuporteCorrecao
{
    public partial class FrmSuporte : Form
    {
        public FrmSuporte()
        {
            InitializeComponent();
        }

        private void FrmSuporte_Load(object sender, EventArgs e)
        {
            GrauSatisfacao g = (GrauSatisfacao)trackBar1.Value;
            lblSatisfacao.Text = g.ToString();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            GrauSatisfacao g =(GrauSatisfacao)trackBar1.Value;
            lblSatisfacao.Text = g.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            limparForm();
        }

        private void limparForm()
        {
            foreach (var item in this.Controls)
            {
                if (item is TextBox)
                {
                    TextBox t = (TextBox)item;
                    t.Text = "";
                }
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            try
            {
                bool preechido = verificaPreenchimento();
                if (preechido)
                {
                    preparaGravacao();
                    MessageBox.Show("Gravado com sucesso");
                    limparForm();
                }
                else
                {
                    MessageBox.Show("Favor Preencher os campos corretamente");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Aconteceu o erro: " + ex.Message);
            }
            
        }

        private void preparaGravacao()
        {
            var suporte = new Suporte()
            {
                NumMaquina = long.Parse(txtNumMaquina.Text),
                NomeEquipamento = txtNomeEquipamento.Text,
                DescricaoProblema = txtDescricaoProblema.Text,
                Grau = (GrauSatisfacao)trackBar1.Value
            };
            StringBuilder nomeAquivoSugerido = new StringBuilder();
            nomeAquivoSugerido.Append(DateTime.Now.Day);
            nomeAquivoSugerido.Append(DateTime.Now.Month);
            nomeAquivoSugerido.Append(DateTime.Now.Year);
            nomeAquivoSugerido.Append("h");
            nomeAquivoSugerido.Append(DateTime.Now.Hour);
            nomeAquivoSugerido.Append(DateTime.Now.Minute);
            nomeAquivoSugerido.Append("n");
            nomeAquivoSugerido.Append(suporte.NumMaquina);
            saveArquivo.FileName = nomeAquivoSugerido.ToString();
            saveArquivo.Filter = "Arquivos Textos | *.txt";
            if (saveArquivo.ShowDialog() == DialogResult.OK && saveArquivo.FileName != "")
            {
                try
                {
                    suporte.gravarArquivo(saveArquivo.FileName);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            
        }

        private bool verificaPreenchimento()
        {
            bool status = true;
            foreach (var item in this.Controls)
            {
                if (item is TextBox)
                {
                    TextBox t = (TextBox)item;
                    if (t.Text.Length == 0) status = false;
                }
            }
            return status;
        }
    }
}
