using System;

namespace ConsoleAppEjercicio5
{
    class Program
    {
        static void Main(string[] args)
        {//titulo del programa
            Console.Title = "Perimetro y Superficie de una circunferencia";
            Console.WriteLine("Se desea calcular el Perimetro y Superficie de una circunferencia");
            Console.WriteLine("Acontinuacion inserte los valores a calcular");

            //definicion de las variables
            double perimetro;
            double superficie;
            double radio;
            //inserte valor
            Console.Write("Radio:");
            radio = double.Parse(Console.ReadLine());

            //proceso
            perimetro = 2 * radio * Math.PI;
            superficie = Math.Pow(radio, 2) * Math.PI;

            //info final
            Console.WriteLine($"La circunferencia con el Radio:{radio}");
            Console.WriteLine($"tiene como Perimetro:{perimetro:N2}");
            Console.WriteLine($"y su Superficie es:{superficie:N2}");


            //fin

        }
    }
}
