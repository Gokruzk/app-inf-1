using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinAppPrueba7046
{
    internal class ClOperaciones
    {
        int n1, n2;
        public ClOperaciones(int a, int b)
        {
            n1 = a;
            n2 = b;
        }

        public int Suma()
        {
            return n1 + n2;
        }
        public int Resta()
        {
            return n1 - n2;
        }
        public int Mult()
        {
            return n1 * n2;
        }
        public double Div()
        {
            double n11 = n1;
            double n22 = n2;
            return n11 / n22;
        }
    }
}
