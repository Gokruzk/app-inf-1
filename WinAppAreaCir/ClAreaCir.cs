using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinAppAreaCir
{
    internal class ClAreaCir
    {
        double radio;
        public ClAreaCir(double r) { radio = r; }
        public double CalcArea()
        {
            double area;
            area = Math.PI * Math.Pow(radio,2);
            return area;
        }
    }
}
