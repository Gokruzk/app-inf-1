using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace WinAppDiagSuperiorInferior
{
    internal class ClArreglo
    {
        int[,] Mat = new int[3, 3];
        int sz = 0;
        public ClArreglo(int[,] Mat1, int tam)
        {
            Mat = Mat1;
            sz = tam;
        }
        public int SumD()
        {
            int s = 0;
            for (int i = 0; i < sz; i++)
            {
                s += Mat[i, i];
            }
            return s;
        }
        public int SumDS()
        {
            int s = 0;
            for (int i = 0; i < sz; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    s += Mat[j, i];
                }
            }
            return s;
        }
        public int SumDI()
        {
            int s = 0;
            for (int i = 0; i < sz; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    s += Mat[i, j];
                }
            }
            return s;
        }

        public int FinDMaxDS()
        {
            int may = Mat[0, 0];
            for (int i = 0; i < sz; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (Mat[j, i] > may)
                    {
                        may = Mat[j, i];
                    }
                }
            }
            return may;
        }
        public int FindMinD()
        {
            int min = Mat[0, 0];
            for (int i = 0; i < sz; i++)
            {
                if (Mat[i, i] < min)
                {
                    min = Mat[i, i];
                }
            }
            return min;
        }
    }
}
