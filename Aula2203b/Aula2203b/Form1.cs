using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula2203b
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            Random r = new Random();
            int alpha = r.Next(254);
            int red = r.Next(254);
            int green = r.Next(254);
            int blue = r.Next(254);
            f.BackColor = Color.FromArgb(red, green, blue);
            f.Visible = true;
        }
    }
}
