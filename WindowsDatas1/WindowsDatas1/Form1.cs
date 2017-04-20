using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsDatas1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(System.DateTime.Now.AddDays(5).ToShortDateString());
            listBox1.Items.Add(System.DateTime.Now.AddHours(6).ToShortTimeString());
            DateTime dataHoje = System.DateTime.Now;
            string dataVcto = "04/01/2015";
            CultureInfo provider = CultureInfo.InvariantCulture;
            DateTime result = DateTime.Parse(dataVcto, provider, DateTimeStyles.AssumeLocal);
            listBox1.Items.Add(result);

        //Mais sobre
        //https://msdn.microsoft.com/pt-br/library/w2sa9yss(v=vs.110).aspx

        }
    }
}
