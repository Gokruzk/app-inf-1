using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppRestoDividendo
{
    internal class ClDivision
    {
        double a, b;
        public ClDivision(double a, double b)
        {
            this.a = a;
            this.b = b;
        }

        public void Division(ref double resto, ref double cociente)
        {
            if (resto >= b)
            {
                resto -= b;
                cociente += 1;
                Division(ref resto, ref cociente);
            }
        }
    }
}
