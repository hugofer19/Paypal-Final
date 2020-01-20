using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banco_class
{
    class enviar
    {
        public double valor_princ;
        public double valor_env;

        public double resultado_final
        {
            get
            {
                return valor_princ - valor_env;
            }
        }
    }
}
