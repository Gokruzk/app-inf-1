using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinAppCalculadora
{
    internal class ClOperaciones
    {
        double num1;
        double num2;
        
        public ClOperaciones(double n1)
        {
            this.num1 = n1;
            this.num2 = 0;
        }
        public ClOperaciones(double n1, double n2)
        {
            this.num1 = n1;
            this.num2 = n2;
        }
        public double Suma()
        {
            return num1 + num2;
        }
        public double Resta()
        {
            return num1 - num2;
        }
        public double Multiplicacion()
        {
            return num1 * num2;
        }
        public double Division()
        {
            return num1 / num2;
        }
        public double Seno()
        {
            return Math.Sin(num1);
        }
        public double Coseno()
        {
            return Math.Cos(num1);
        }
        public double Tangente()
        {
            return Math.Tan(num1);
        }
        public double Logaritmo()
        {
            return Math.Log10(num1);
        }
        public double LogaritmoNatural()
        {
            return Math.Log(num1);
        }
        public double Raiz()
        {
            return Math.Sqrt(num1);
        }
        public double Potencia()
        {
            return Math.Pow(num1, num2);
        }
        public double Absoluto()
        {
            return Math.Abs(num1);
        }
        public double Minimo()
        {
            return Math.Min(num1, num2);
        }
        public double Maximo()
        {
            return Math.Max(num1, num2);
        }
        public void sets(double n1, double n2)
        {
            num1 = n1;
            num2 = n2;
        }
        public void set(double n1)
        {
            num1 = n1;
        }
    }
}
