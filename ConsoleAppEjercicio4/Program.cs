using System;

namespace ConsoleAppEjercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            //titulo
            Console.Title = "Ejercicio n4 perimetro y superficie";
            Console.WriteLine("Se desea calcular el perimetro y la superficie de un cuadrado");
            Console.WriteLine("Acontinuacion inserte los datos");


            //definicion de variables
            int lado;
            double perimetro;
            double superficie;
            Console.Write("ingrese el lado a calcular: ");
            lado = int.Parse(Console.ReadLine());


            //proceso en el que tomara la solucion
            perimetro = lado * 4;
            superficie = Math.Pow(lado,2);
            
            
            //resultados del proceso
            Console.WriteLine($"el cuadrago con lado :{lado}");
            Console.WriteLine($"tiene como perimetro :{perimetro}");
            Console.WriteLine($"y su suerfiecie es: {superficie}");

            //fin

        }
    }
}
