using System;

namespace ConsoleAppEjercicio10
{
    class Program
    {
        static void Main(string[] args)
        {
            //titulacion
            Console.Title = "ejercicio 10: conversor celsius a reaumur y fahrenheit";
            Console.WriteLine("Se desea convertir los Grados Celsius a Reaumur y a Fahrenheit");
            Console.Write("Acontinuacion inserte el valor a convertir C°=");
            
            
            //definicion de las variables
            double celsius, reaumur, fahrenheit;
            
            //introduccion de datos
            celsius = double.Parse(Console.ReadLine());

            //proceso
            reaumur = celsius * 0.8;
            fahrenheit = 1.8 * celsius + 32;

            Console.Write($"{celsius}C° equivalen en Reaumur: {reaumur}° y en Fahrenheit: {fahrenheit}°");
        }
    }
}
