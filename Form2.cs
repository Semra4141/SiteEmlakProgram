using System;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.Text=="Güneş  Sitesi"){
                btnGunes.BackColor = Color.Pink;
                btnAydın.BackColor = Color.Purple;
                btnZambak.BackColor = Color.Purple;
                btnAbant.BackColor = Color.Purple;
            }
            if (comboBox1.Text == "Aydın Sitesi")
            {
                btnGunes.BackColor = Color.Purple;
                btnAydın.BackColor = Color.Pink;
                btnZambak.BackColor = Color.Purple;
                btnAbant.BackColor = Color.Purple;
            }
            if (comboBox1.Text == "Zambak Sitesi")
            {
                btnGunes.BackColor = Color.Purple;
                btnAydın.BackColor = Color.Purple;
                btnZambak.BackColor = Color.Pink;
                btnAbant.BackColor = Color.Purple;
            }
            if (comboBox1.Text == "Abant Sitesi")
            {
                btnGunes.BackColor = Color.Purple;
                btnAydın.BackColor = Color.Purple;
                btnZambak.BackColor = Color.Purple;
                btnAbant.BackColor = Color.Pink;
            }
        }
    }
}
