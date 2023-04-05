// See https://aka.ms/new-console-template for more information
using ConAppAreaCir;

namespace ConAppAreaCirculo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CÁLCULAR ÁREA DE CÍRCULO");
            Console.Write("Ingrese radio círculo: ");
            int Radio = int.Parse(Console.ReadLine());  //Lectura de radio

            ClAreaCirc obj = new ClAreaCirc(Radio); //Instancia de objeto

            Console.WriteLine("El área calculada del círculo es: {0}", obj.CalcArea()); //Cálculo de área
            
        }
    }
}