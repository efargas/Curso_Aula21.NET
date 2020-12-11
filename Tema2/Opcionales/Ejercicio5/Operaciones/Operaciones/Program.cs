using System;

namespace Suma
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1; double num2;
            Console.WriteLine("Programa que calcula varias operaciones con dos números");
            Console.WriteLine("=======================================================");
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

            Console.WriteLine($"\n{num1} + {num2} = {num1 + num2}\n");
            Console.WriteLine($"\n{num1} - {num2} = {num1 - num2}\n");
            Console.WriteLine($"\n{num1} x {num2} = {num1 * num2}\n");
            Console.WriteLine($"\n{num1} / {num2} = {num1 / num2}\n");            
            Console.WriteLine($"\n{num1} mod {num2} = {num1 % num2}\n");
        }
    }
}
