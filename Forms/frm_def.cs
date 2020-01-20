using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace banco_class
{
    public partial class frm_def : Form
    {
        public frm_def()
        {
            InitializeComponent();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            label3.Visible = true;
            label3.Text = "Introduza um novo número";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text;
            label1.Visible = true;
            textBox1.Visible = false;
            label3.Visible = false;
            textBox1.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label5.Visible = true;
            label5.Text = textBox1.Text;
            label3.Visible = false;
            textBox1.Visible = false;
            textBox1.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label5.Visible = true;
            textBox1.Visible = true;
            label3.Visible = true;
            label3.Text = "Introduza um novo e-mail";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel1.BringToFront();
        }
    }
}
