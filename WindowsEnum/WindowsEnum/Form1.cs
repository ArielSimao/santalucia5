using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsEnum
{
    public partial class Form1 : Form
    {
        public enum Volume
        {
            Baixo,
            Médio,
            Alto
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (Volume v in Enum.GetValues(typeof(Volume)))
            {
                comboBox1.Items.Add(v);
            }
            comboBox1.SelectedIndex = 0;

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = trackBar1.Value;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            trackBar1.Value = comboBox1.SelectedIndex;
        }
    }
}
