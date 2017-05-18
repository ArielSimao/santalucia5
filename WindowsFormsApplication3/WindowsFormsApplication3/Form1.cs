using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    enum GrauSatisfacao
    {
        ruim,
        regular,
        bom,
        otimo,
        excelente
    }
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GrauSatisfacao g = (GrauSatisfacao)0;
            label1.Text = g.ToString();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            GrauSatisfacao g = (GrauSatisfacao)trackBar1.Value;
            label1.Text = g.ToString();
        }
    }
}
