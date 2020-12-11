using System;

namespace Operaciones
{
    class Program
    {
        static void Main(string[] args)
        {
            int res1 = -1 + 4 * 6;
            Console.WriteLine($"Operación 1: -1 + 4 * 6 = {res1}\n");

            int res2 = ( 35 + 5) % 7;
            Console.WriteLine($"Operación 2: ( 35 + 5) % 7 = {res2}\n");

            int res3 = 14 + -4 * 6 / 11;
            Console.WriteLine($"Operación 3: 14 + -4 * 6 / 11 = {res3}\n");

            int res4 = 2 +15 / 6 * 1 - 7 % 2;
            Console.WriteLine($"Operación 4: 2 +15 / 6 * 1 - 7 % 2 = {res4}\n");
        }
    }
}
