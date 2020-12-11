using System;

namespace Array3x4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] tabla = new int[3, 4];
            Random random = new Random();

            for (int i = 0; i < 3; i++)
            {
                 for (int j = 0; j < 4; j++) { tabla[i, j] = random.Next(0, 1000); } 
            }

            Console.WriteLine("\nEl array generado es el siguiente : \n");
            for (int i = 0; i < 3; i++)
            {
                Console.Write("\n");
                for (int j = 0; j < 4; j++) { Console.Write("{0}\t", tabla[i, j]); }                   
            }
            Console.Write("\n");
            Console.ReadKey();
        }
    }
}
