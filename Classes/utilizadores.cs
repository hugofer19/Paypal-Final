using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banco_class
{
    class utilizadores
    {
        public bool login = false;
        public string user1 = "hugo@gmail.com";
        public string pass1 = "teste123";
        public string user2 = "miguel@sapo.pt";
        public string pass2 = "teste123";

        public string analisa
        {
            set
            {
                user1 = "hugo@gmail.com";
                pass1 = "teste123";
            }
        }
        public string resultado
        {
            get
            {
                return user1 + pass1
                    + user2 + pass2;
            }
        }
    }
}