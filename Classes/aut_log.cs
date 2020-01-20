using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace banco_class
{
    class aut_log
    {
        //declarar variaveis
        public string user;
        public string pass;

        //import class utilizadores
        utilizadores U = new utilizadores();

        //import formulário de painel de controlo
        frm_control frm = new frm_control();

        //função verifica
        public void verifica()
        {
            if (user == U.user1 & pass == U.pass1)
            {
                frm.Show();
            }
            else
            {
                MessageBox.Show("Erro na conexão", "Erro");
            }
        }
    }
}

