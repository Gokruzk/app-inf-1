using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppAreaTrian
{
    internal class ClAreaTrian
    {
        int baseT, altura;
        public ClAreaTrian(int baseT, int altura)
        {
            this.baseT = baseT;
            this.altura = altura;
        }
        public double CalcArea()
        {
            double area = (baseT * altura)/2;
            return area;
        }
    }
}
