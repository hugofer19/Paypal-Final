using System;
using System.Windows.Forms;

namespace banco_class
{
    public partial class frm_control : Form 
    {
        public frm_control()
        {
            InitializeComponent();

        }

        private void frm_control_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void abrirForm(Object form)
        {
            if (this.panel1.Controls.Count > 0)
                this.panel1.Controls.RemoveAt(0);
            Form fh = form as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(fh);
            this.panel1.Tag = fh;
            fh.Show();
        }


        private void button7_Click(object sender, EventArgs e)
        {
            abrirForm(new frm_resumo());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            abrirForm(new frm_atividade());
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            abrirForm(new frm_enviarEsolicitar());
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            abrirForm(new frm_carteira());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            abrirForm(new frm_ofertas());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "C:\\Users\\hugoy\\Desktop\\Paypal-master-master (1)\\Paypal-master-master\\help\\ajuda.chm");
        }

        private void button8_Click(object sender, EventArgs e)
        {
          
        }

        private void button9_Click(object sender, EventArgs e)
        {
            abrirForm(new frm_notifica());
        }

        private void button10_Click(object sender, EventArgs e)
        {
            abrirForm(new frm_def());
        }
    }
}
