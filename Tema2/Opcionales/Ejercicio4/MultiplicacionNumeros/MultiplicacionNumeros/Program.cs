using System;

namespace Suma
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1; double num2; double num3;
            Console.WriteLine("Programa que multiplica tres números");
            Console.WriteLine("====================================");
            Console.WriteLine("\nIntroduce el primer número: ");

            while (!double.TryParse(Console.ReadLine(), out num1))
            {
                Console.Write("\nLa entrada no es válida. Introduce de nuevo el número: ");
            }

            Console.WriteLine("\nIntroduce el segundo número: ");

            while (!double.TryParse(Console.ReadLine(), out num2))
            {
                Console.Write("\nLa entrada no es válida. Introduce de nuevo el número: ");
            }

            Console.WriteLine("\nIntroduce el tercer número: ");

            while (!double.TryParse(Console.ReadLine(), out num3))
            {
                Console.Write("\nLa entrada no es válida. Introduce de nuevo el número: ");
            }

            Console.Write($"\nEl resultado de multiplicar {num1} x {num2} x {num3} = {num1 * num2 * num3}\n");
            
            Console.ReadKey(true);

        }
    }
}
