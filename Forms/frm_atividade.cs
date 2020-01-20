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
    public partial class frm_atividade : Form
    {
        public frm_atividade()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "Nayorken")
            {
                panel1.Visible = true;
                panel2.Visible = true;
                panel4.Visible = false;
                panel3.Visible = false;
                panel5.Visible = false;
                panel6.Visible = false;
                panel7.Visible = false;
                panel8.Visible = false;
            }

            if(textBox1.Text == "Novo Banco")
            {
                panel1.Visible = true;
                panel4.Visible = true;
                panel2.Visible = false;
                panel3.Visible = false;
                panel5.Visible = false;
                panel6.Visible = false;
                panel7.Visible = false;
                panel8.Visible = false;
            }

            if (textBox1.Text == "Cirt-net")
            {
                panel5.Visible = true;
                panel4.Visible = true;
                panel1.Visible = false;
                panel2.Visible = false;
                panel3.Visible = false;
                panel6.Visible = false;
                panel7.Visible = false;
                panel8.Visible = false;
            }

            if (textBox1.Text == "Hike Strada")
            {
                panel2.Visible = true;
                panel6.Visible = true;
                panel1.Visible = false;
                panel3.Visible = false;
                panel4.Visible = false;
                panel5.Visible = false;
                panel7.Visible = false;
                panel8.Visible = false;
            }

            if (textBox1.Text == "Gonçalo Braga")
            {
                panel7.Visible = true;
                panel6.Visible = true;
                panel5.Visible = false;
                panel4.Visible = false;
                panel3.Visible = false;
                panel2.Visible = false;
                panel1.Visible = false;
                panel8.Visible = false;
            }

            if (textBox1.Text == "Pedro Oliveira")
            {
                panel8.Visible = true;
                panel7.Visible = true;
                panel6.Visible = false;
                panel5.Visible = false;
                panel4.Visible = false;
                panel3.Visible = false;
                panel2.Visible = false;
                panel1.Visible = false;
            }
        }
    }
}
