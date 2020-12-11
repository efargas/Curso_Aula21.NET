using System;

namespace Bucles
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa que imprime la tabla de multiplicar con diferentes bucles\n");
            Console.WriteLine("==================================================================\n");
            int num;
            Console.WriteLine("\nIntroduce un número entero :");

            while (!int.TryParse(Console.ReadLine(), out num))
            {
                Console.Write("\nLa entrada no es válida. Introduce de nuevo el número: ");
            }
            BucleWhile(num);
            BucleDoWhhile(num);
            BucleFor(num);
        }
        static void BucleWhile(int num)
        {
            Console.WriteLine($"\nTabla del {num} con Bucle While\n");
            int i = 1;
            while (i <= 15)
            {
                Console.WriteLine($"{i} x {num} = {i*num}");
                i++;
            }
        }

        static void BucleDoWhhile(int num)
        {
            Console.WriteLine($"\nTabla del {num} con Bucle Do While\n");
            int i = 1;
            do
            {
                Console.WriteLine($"{i} x {num} = {i * num}");
                i++;
            } while (i < 16);
        }

        static void BucleFor(int num)
        {
            Console.WriteLine($"\nTabla del {num} con Bucle For\n");

            for (int i = 1; i < 16; i++)
            {
                Console.WriteLine($"{i} x {num} = {i * num}");
            }
        }

    }
 }
