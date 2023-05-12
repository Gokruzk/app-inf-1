using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinAppTriang
{
    internal class ClTriang
    {
        double a, b, c;
        public ClTriang(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public int TypeTriangle()
        {
            int t = 1;
            //1:esclno 2:iscls 3: eqlto
            if(a == b && a == c)
                t = 3;
            else if (a == b || a == c || b == c)
                t = 2;
            return t;
        }
    }
}
