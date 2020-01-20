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
    public partial class frm_resumo : Form
    {
        private string saldo_on;

        public frm_resumo()
        {
            InitializeComponent();
        }
        private void frm_resumo_Load(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            deposito D = new deposito();

            D.valor_princ = Convert.ToDouble(lbl_saldo.Text);
            D.valor_depos = Convert.ToDouble(textBox1.Text);
            timer1.Start();
            saldo_on = Convert.ToString(D.resultado_final);
            progressBar1.BringToFront();
            progressBar1.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            textBox1.Visible = true;
            textBox4.Visible = true;
            button5.Visible = true;

            panel2.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            button6.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            textBox1.Visible = false;
            button5.Visible = false;
            panel2.Visible = false;
            textBox2.Visible = false;
            button6.Visible = false;
            label2.Visible = false;
            label2.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            progressBar1.Visible = false;
            progressBar2.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            button6.Visible = true;

            panel1.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            textBox1.Visible = false;
            textBox4.Visible = false;
            button5.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            enviar E = new enviar();

            E.valor_princ = Convert.ToDouble(lbl_saldo.Text);
            E.valor_env = Convert.ToDouble(textBox1.Text);
            saldo_on = Convert.ToString(E.resultado_final);
            progressBar2.Visible = true;
            progressBar2.BringToFront();
            progressBar2.Value = 0;
            timer2.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(1);
            if (progressBar1.Value == 99)
            {
                MessageBox.Show(textBox1.Text + "€ foram recebidos com sucesso " + "\n" + " de " + textBox4.Text + ".", "Saldo Solicitado");
                lbl_saldo.Text = saldo_on;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            progressBar2.Increment(1);
            if (progressBar2.Value == 99)
            {
                MessageBox.Show(textBox2.Text + "€ foram enviados com sucesso " + "\n" + " para " + textBox3.Text + ".", "Saldo Enviado");
                lbl_saldo.Text = saldo_on;
            }
        }
    }
}
