using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsSorte
{
    public partial class Form1 : Form
    {
        int[] nums = new int[6];
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            //Limpar o combo
            comboNumeros.Items.Clear();
            //variavel local
            int maximo = int.Parse(txtMax.Text);
            //Gerar o randominco
            Random r = new Random();
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = r.Next(maximo);
            }
            alimentarCombo();
        }

        private void alimentarCombo()
        {
            for (int i = 0; i < nums.Length; i++)
            {
                comboNumeros.Items.Add(nums[i]);
            }
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            comboNumeros.Items.Clear();
            Array.Sort(nums);
            alimentarCombo();
            
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            //Varrer a coleção de controles dentro do 
            //formulário
            foreach (Control item in this.Controls)
            {
                if (item is TextBox) {
                    item.Text = "";
                }
                if (item is ComboBox) {
                    ComboBox x = (ComboBox)item;
                    x.Items.Clear();
                }
            }
        }
    }
}
