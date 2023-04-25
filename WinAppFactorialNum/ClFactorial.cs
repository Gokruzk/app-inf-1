using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinAppFactorialNum
{
    internal class ClFactorial
    {
        int a;
        public ClFactorial(int a)
        {
            this.a = a;
        }
        public int CalcFactorial()
        {
            int f = 1;
            for (int i = 1; i <= a; i++)
            {
                f *= i;
            }
            return f;
        }
    }
}
