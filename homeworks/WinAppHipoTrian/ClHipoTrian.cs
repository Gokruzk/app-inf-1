using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinAppHipoTrian
{
    internal class ClHipoTrian
    {
        double opuesto, adyacente;
        public ClHipoTrian(double op, double ad)
        {
            this.opuesto = op;
            this.adyacente = ad;
        }
        public double CalcHipo()
        {
            double hipo = 0;
            hipo = Math.Sqrt(Math.Pow(opuesto, 2) + Math.Pow(adyacente, 2));
            return hipo;
        }
    }
}
