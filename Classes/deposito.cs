using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banco_class
{
    class deposito
    {
        public double valor_princ;
        public double valor_depos;

        public double resultado_final
        {
            get
            {
                return valor_princ + valor_depos;
            }
        }
    }

}
