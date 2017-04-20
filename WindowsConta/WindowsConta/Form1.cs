using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsConta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            DateTime vcto = dataVencimento.Value;
            DateTime hoje = System.DateTime.Now;
            TimeSpan dif = hoje - vcto;
            int diasAtraso = dif.Days;
            label4.Text = "Dias em Atraso: " + diasAtraso.ToString();

            DateTime futuro = hoje.AddDays(30);
        }
    }
}
