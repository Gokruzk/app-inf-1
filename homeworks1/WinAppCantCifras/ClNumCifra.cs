using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinAppCantCifras
{
    internal class ClNumCifra
    {
        int num;
        public ClNumCifra(int n)
        {
            num = n;
        }
        public int CalCifra()
        {
            int cifra = 0;
            cifra = Convert.ToInt32(Math.Log(num) / Math.Log(10)) + 1;
            return cifra;
        }
    }
}
