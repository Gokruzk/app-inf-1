// See https://aka.ms/new-console-template for more information
namespace conAppMensaje
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese radio: ");
            int radio = int.Parse(Console.ReadLine());
            Console.WriteLine("Radio: {0}", radio);
        }
    }
}
