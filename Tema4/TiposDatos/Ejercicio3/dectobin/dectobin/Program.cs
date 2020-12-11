using System;

namespace dectobin
{
    class Program
    {
        static void Main(string[] args)
        {
            string finish = "";
            do
            {                
                string binario = "";
                Console.WriteLine("Introduce un número para ver su equivalente en Binario:");
                int num = Convert.ToInt32(Console.ReadLine());
                while (num > 0)
                {
                    int resto = num % 2;
                    num = num / 2;
                    binario = resto + binario;
                }
                Console.WriteLine($"\n {binario}");
                Console.WriteLine("Para salir introduzca fin o pulse Enter para continuar:");
                finish = Console.ReadLine();
            } while (finish != "fin");

        }
    }
}
