using System;

namespace Suma
{
    class Program
    {
        static void Main(string[] args)
        {
           double num1; double num2; 
            Console.WriteLine("Programa que suma dos números");
            Console.WriteLine("===============================");
            Console.WriteLine("\nIntroduce el primer número: ");

            while (!double.TryParse(Console.ReadLine(), out num1))
            {
                Console.Write("La entrada no es válida. Introduce de nuevo el número: ");
            }

            Console.WriteLine("\nIntroduce el segundo número: ");

            while (!double.TryParse(Console.ReadLine(), out num2))
            {
                Console.Write("La entrada no es válida. Introduce de nuevo el número: ");
            }

            //Console.WriteLine($"\nEl resultado de sumar {num1:0.####} + {num2:0.####} = {num1 + num2}");
            Console.WriteLine($"\nEl resultado de sumar {num1} + {num2} = {num1 + num2}");
        }
    }
}
