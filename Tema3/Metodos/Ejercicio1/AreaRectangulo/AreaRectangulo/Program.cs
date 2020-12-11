using System;

namespace AreaRectangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            double l; double h;
            Console.WriteLine("Programa que calcula el área de un rectángulo");
            Console.WriteLine("=============================================");
            Console.WriteLine("\nIntroduce la longitud en metros: ");

            while (!double.TryParse(Console.ReadLine(), out l))
            {
                Console.Write("\nLa entrada no es válida. Introduce de nuevo la longitud: ");
            }

            Console.WriteLine("\nIntroduce la altura en metros: ");

            while (!double.TryParse(Console.ReadLine(), out h))
            {
                Console.Write("\nLa entrada no es válida. Introduce de nuevo la altura: ");
            }

            Console.Write($"\nEl área del rectángulo de longitud {l}m y altura {h}m = {CalculaArea(l,h)}m\n");
            Console.ReadKey(true);
        }

        static double CalculaArea(double longitud, double altura) => longitud * altura;

    }
}
