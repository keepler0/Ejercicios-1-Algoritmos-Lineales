using System;

namespace ConsoleAppEjercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            //titulacion del programa
            Console.Title="Ejercicio 8 notas parciales de alumnos";
            Console.WriteLine("se desea calcular la media aritmetica y ponderada de las notas de los alumnos");
            Console.WriteLine("introduzca los valores a calcular:");
            
            //variables
            double MediaAritmetica;
            double Ponderada;
            double nota1;
            double nota2;
            double nota3;
            
            
            //imput
            Console.Write("primera nota: ");
            nota1 = double.Parse(Console.ReadLine());
            Console.Write("segunda nota: ");
            nota2 = double.Parse(Console.ReadLine());
            Console.Write("tercera nota: ");
            nota3 = double.Parse(Console.ReadLine());
            MediaAritmetica = (nota1 + nota2 + nota3) / 3;
            Ponderada = (nota1 * 0.4) + (nota2 * 0.2) + (nota3 * 0.4) / (0.4 + 0.2 + 0.4);
            
                
            //procesos
            MediaAritmetica = (nota1 + nota2 + nota3) / 3;
            Ponderada = nota1 * (0.35) + nota2 * (0.45) + nota3 * (0.20);
            Console.WriteLine($"la nota media aritmetica es: {MediaAritmetica}");
            Console.WriteLine($"y su media ponderada es: {Ponderada}");
        
        }
    }
}
