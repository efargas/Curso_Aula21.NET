using System;

namespace CuadradoCubo
{
    class Program
    {
        static void Main(string[] args)
        {
            double num;
            Console.WriteLine("Programa que calcula el cuadrado y el cubo de un número");
            Console.WriteLine("=======================================================");
            Console.WriteLine("\nIntroduce el número para calcular su cuadrado y cubo: ");

            while (!double.TryParse(Console.ReadLine(), out num))
            {
                Console.Write("\nLa entrada no es válida. Introduce de nuevo el número: ");
            }

            Console.Write($"\nEl cuadrado de {num} = {CalculaCuadrado(num)}\n");
            Console.Write($"\nEl cubo de {num} = {CalculaCubo(num)}\n");
            Console.ReadKey(true);
        }

        static double CalculaCuadrado(double num) => Math.Pow(num, 2);
        static double CalculaCubo(double num) => Math.Pow(num, 3);

    }
}
