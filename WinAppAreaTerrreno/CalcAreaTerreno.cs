using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinAppAreaTerrreno
{
    internal class CalcAreaTerreno
    {
        double a, b, c;
        public CalcAreaTerreno(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public double CalcTriangle()
        {
            double A = a - c;
            return (b * A)/2;
        }
        public double CalcRectangle()
        {
            return b * c;
        }
    }
}
