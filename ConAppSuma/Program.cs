// See https://aka.ms/new-console-template for more information

Console.WriteLine("El numero de argumentos es: {0} ", args.Length);
if (args.Length == 2)
{
    int val1 = int.Parse(args[0]);
    int val2 = Convert.ToInt32(args[1]);
    int suma = val1 + val2;
    Console.WriteLine("La suma de los 2 números es: {0}", suma);
}
else
{
    Console.WriteLine("Ud debe ingresar sólo 2 números");
}
