﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiteEmlakProgramı
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "siteAdmin" && textBox2.Text == "1234")
            {
                Form2 emlakkayıt = new Form2();
                emlakkayıt.Show();
                this.Hide();



            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
