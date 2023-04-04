
using ConAppAreaTrian;

Console.WriteLine("CÁLCULAR ÁREA DE TRIÁNGULO");
int baseT, altura;
Console.Write("Ingrese la base: ");
baseT = int.Parse(Console.ReadLine());
Console.Write("Ingrese la altura: ");
altura  = int.Parse(Console.ReadLine());

ClAreaTrian obj = new ClAreaTrian(baseT, altura);

Console.WriteLine("El área del triángulo calculada es: {0}", obj.CalcArea());
