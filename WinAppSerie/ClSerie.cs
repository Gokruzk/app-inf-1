using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinAppSerie
{
    internal class ClSerie
    {
        int n;
        public ClSerie(int n)
        { this.n = n; }
        public int Factorial(int num)
        {
            if (num == 1)
            {
                return 1;
            }
            return num *= Factorial(num - 1);
        }
        public double Serie(int num)
        {
            double resultado = 0;
            
            for (int i = 1; i <= num; i++)
            {
                if (i % 2 == 0)
                {
                    resultado -= Factorial(2 * i) / Math.Pow(2 * i - 1, i);
                }
                else
                {
                    resultado += Math.Pow(2 * i - 1, i) / Factorial(2 * i);
                }
            }
            return resultado;
        }
        public double SerieRecursiva(int num, double resultado, int i)
        {
            if (i <= num)
            {
                if (i % 2 == 0)
                {
                    resultado -= Factorial(2 * i) / Math.Pow(2 * i - 1, i);
                }
                else
                {
                    resultado += Math.Pow(2 * i - 1, i) / Factorial(2 * i);
                }
                resultado = SerieRecursiva(num, resultado, i + 1);

            }
            return resultado;
        }
    }

}
