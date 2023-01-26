using System;

namespace ConsoleAppEjercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio n6 kilometros a millas";
            Console.WriteLine("Se desea convertir los kilometros a millas y yardas");
            Console.WriteLine("Acontinuacion indique los valores a calcular");

            //definicion de las variables
            double kms;
            double millas;
            double yardas;

            Console.Write("indique los kms: ");
            kms = double.Parse(Console.ReadLine());

            millas = kms * 0.621371192;
            yardas = kms * 1093.6133;

            Console.WriteLine($"los kilometros indicados {kms}");
            Console.WriteLine($"en millas equivalen: {millas:N2}");
            Console.WriteLine($"en yardas equivale :{yardas:N2}");
       }
    }
}
