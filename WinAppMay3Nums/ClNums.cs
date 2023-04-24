using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppMay3Nums
{
    internal class ClNums
    {
        int a, b, c;
        public ClNums(int a, int b, int c) 
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public int may3()
        {
            int may = 0;
            if (a > b && a > c)
            {
                may = a;
            }
            else if (b > a && b > c)
            {
                may = b;
            }
            else if (c > a && c > b)
            {
                may =  c;
            }
            return may;
        }
        public int may_comodin()
        {
            int may = ((a > b) && (a > c)) ? a : (b > a) && (b > c) ? b : c;
            return may;
        }

    }
}
