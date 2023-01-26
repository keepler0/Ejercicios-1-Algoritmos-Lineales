using System;

namespace ConsoleAppEjercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Sumatoria de los Primeros numeros reales";
            Console.WriteLine("Se desea calcular los primeros numeros reales");
            Console.Write("inserte el digito: ");
            int n1;
            int sumatoria;
            n1 = int.Parse(Console.ReadLine());
            sumatoria = (n1 * (n1 + 1)) / 2;
            Console.WriteLine($"la sumatoria total de:{n1} es: {sumatoria}");
        }
    }
}
