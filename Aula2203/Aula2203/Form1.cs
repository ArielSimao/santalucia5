﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula2203
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.Text = "Não";
            button2.Text = "Sim";
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.Text = "Sim";
            button2.Text = "Não";
        }

        
    }
}
