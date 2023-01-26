using System;

namespace ConsoleAppEjercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            //titulo
            Console.Title = "Ejercicio 7 Pesos a USD";
            Console.WriteLine("acontinuacion se calculara el monto en esos a usd oficial y paralelo");
            //definicion de variables
            double pesos;
            double usdOficial;
            double usdParalelo;
            //introduccion de valores
            Console.Write("indique el monto en Pesos: ");
            pesos = int.Parse(Console.ReadLine());
           //proceso
            usdOficial = pesos / 120.52;
            usdParalelo = pesos / 205;
            //fin
            Console.WriteLine($"{pesos} pesos");
            Console.WriteLine($"equivalen en Dolar oficial: {usdOficial:N2}");
            Console.WriteLine($"en Dolar paralelo:{usdParalelo:N2}");
        }
    }
}
