using System;

namespace Suma
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1; double num2;
            Console.WriteLine("Programa que intercambia dos números");
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

            Console.Write($"\nEl primer número introducido es: {num1}");
            Console.Write($"\nEl segundo número introducido es: {num2}\n");

            num1 += num2;
            num2 = num1 - num2;
            num1 -= num2;

            Console.Write($"\nAhora el primer número es: {num1}");
            Console.Write($"\nAhora el segundo número es: {num2}\n");

            Console.ReadKey(true);

        }
    }
}
