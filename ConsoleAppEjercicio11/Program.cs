using System;

namespace ConsoleAppEjercicio11
{
    class Program
    {
        static void Main(string[] args)
        {
            //titulacion
            Console.WriteLine("Calculadora de Suerficie y Perimetro de un rectangulo.");
            Console.WriteLine("ingrese los datos: ");
            
            //definicion de las variables
            int perimetro, superficie, lado1, lado2;

            //asignacion de valores
            Console.Write("Lado Mayor: ");
            lado1 = int.Parse(Console.ReadLine());
            Console.Write("Lado Menor: ");
            lado2 = int.Parse(Console.ReadLine());

            //procesos
            perimetro = (2 * lado1) + (2 * lado2);
            superficie = lado1 * lado2;

            //muestra de la informacion
            Console.WriteLine($"El rectangulo con su Lado Mayor: {lado1} y su Lado Menor: {lado2}");
            Console.WriteLine($"Su Perimetro es: {perimetro}.");
            Console.WriteLine($"Tiene como Superficie: {superficie}");
            
        }
    }
}
