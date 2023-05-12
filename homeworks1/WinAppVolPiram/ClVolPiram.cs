using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class ClVolPiram
    {
        double baseP, alturaP;
        public ClVolPiram(double b, double a)
        {
            baseP = b;
            alturaP = a;
        }
        public double CalcVol()
        {
            double Ab = Math.Pow(baseP,2);
            double vol = 0;
            vol = (Ab * alturaP) / 3;
            return vol;
        }
    }
}
