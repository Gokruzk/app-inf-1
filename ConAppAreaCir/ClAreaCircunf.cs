﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppAreaCir
{
    internal class ClAreaCircunf
    {
        int radio;

        public ClAreaCircunf(int r)
        {
            this.radio = r;
        }
        public double CalcArea()
        {
            double area = Math.PI * Math.Pow(radio, 2);
            return area;
        }
    }
}
