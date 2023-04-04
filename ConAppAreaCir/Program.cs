// See https://aka.ms/new-console-template for more information
using ConAppAreaCir;

namespace ConAppAreaCirculo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CÁLCULO ÁREA CÍRCULO");
            Console.Write("Ingrese radio círculo: ");
            int Radio = int.Parse(Console.ReadLine());

            ClAreaCirc obj = new ClAreaCirc(Radio);
            

            Console.WriteLine("El área calculada del círculo es: {0}", obj.CalcArea());
            
        }
    }
}