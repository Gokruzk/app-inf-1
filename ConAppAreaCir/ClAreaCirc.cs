using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppAreaCir
{
    public class ClAreaCirc
    {
        int radio;
        public ClAreaCirc(int r)
        {
            radio = r;
        }
        public double CalcArea()
        {
            double area = Math.PI * Math.Pow(radio, 2);
            return area;
        }
    }
}
