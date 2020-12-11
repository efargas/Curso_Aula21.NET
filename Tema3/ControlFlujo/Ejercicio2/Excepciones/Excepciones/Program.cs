using System;

namespace Excepciones
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5, b = 0, c;
            try
            {
                c = a / b;
                Console.Write("c=" + a + "/" + b + "=" + c);
            } catch (DivideByZeroException e)
            {
                Console.WriteLine("No se puede dividir por 0\n" + e.Message);
            }

            Console.ReadKey();
        }
    }
}
