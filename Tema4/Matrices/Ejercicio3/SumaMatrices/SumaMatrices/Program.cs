using System;

namespace SumaMatrices
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] tabla1 = new int[3, 3];
            int[,] tabla2 = new int[3, 3];
            int[,] tabla3 = new int[3, 3];
            Random random = new Random();

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++) { 
                    tabla1[i, j] = random.Next(0, 1000);
                }
            }
            Console.WriteLine("\nMatriz 1:");
            for (int i = 0; i < 3; i++)
            {
                Console.Write("\n");
                for (int j = 0; j < 3; j++) { Console.Write("{0}\t", tabla1[i, j]); }
            }
            Console.Write("\n");

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++) { 
                    tabla2[i, j] = random.Next(0, 1000);
                }
            }
            Console.WriteLine("\nMatriz 2:");
            for (int i = 0; i < 3; i++)
            {
                Console.Write("\n");
                for (int j = 0; j < 3; j++) { Console.Write("{0}\t", tabla2[i, j]); }
            }
            Console.Write("\n");

            Console.WriteLine("\nMatriz 1 + Matriz 2:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++) { 
                    tabla3[i, j] = tabla1[i,j] + tabla2[i,j]; 
                }
            }
            for (int i = 0; i < 3; i++)
            {
                Console.Write("\n");
                for (int j = 0; j < 3; j++) { Console.Write("{0}\t", tabla3[i, j]); }
            }
            Console.Write("\n");
            Console.ReadKey();
        }
    }
}

