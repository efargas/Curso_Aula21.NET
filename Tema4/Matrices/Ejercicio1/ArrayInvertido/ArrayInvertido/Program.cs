using System;

namespace ArrayInvertido
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa que imprime un array en orden inverso");
            Console.WriteLine("==============================================\n");
            Console.WriteLine("Introduce 5 números: ");
            int[] numeros = new int[5];
            for (int i = 0; i < 5; i++) {
                Console.WriteLine($"\nIntroduce el número {i+1}: ");
                try
                {
                    numeros[i] = Convert.ToInt32(Console.ReadLine());
                } catch (Exception e)
                {
                    Console.WriteLine($"Entrada no válida. {e.Message}" );
                    i--;
                }                
            }

            Console.WriteLine($"\nLos números introducios en orden inverso:\n");

            for (int i = (numeros.Length-1) ; i >= 0; i--)
            {
                Console.WriteLine($"{numeros[i]}");
            }
        }
    }
}
