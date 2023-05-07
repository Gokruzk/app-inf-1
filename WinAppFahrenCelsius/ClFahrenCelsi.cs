using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinAppFahrenCelsius
{
    internal class ClFahrenCelsi
    {
        double gradosF;
        public ClFahrenCelsi(double grad)
        {
            this.gradosF = (grad);
        }
        public double CalCelsius()
        {
            double celsius = 0;
            celsius = (gradosF - 32) * 5 / 9;
            return celsius;
        }
    }
}
