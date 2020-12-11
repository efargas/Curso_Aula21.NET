using System;

namespace ConversionDivisas
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1€ -> 1,21$
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            const double ratio = 0.8264462809917355;
            double eur; double doll;
            Console.WriteLine("Programa que convierte Euros a Dólares y viceversa");
            Console.WriteLine("=================================================");
            Console.WriteLine("\nIntroduce la cantidad de Euros a convertir a Dólares: ");

            while (!double.TryParse(Console.ReadLine(), out eur))
            {
                Console.Write("\nLa entrada no es válida. Introduce de nuevo la cantidad: ");
            }

            Console.WriteLine("\nIntroduce la cantidad de Dólares a convertir en Euros: ");

            while (!double.TryParse(Console.ReadLine(), out doll))
            {
                Console.Write("\nLa entrada no es válida. Introduce de nuevo la cantidad: ");
            }
            
            Console.WriteLine($"\n{eur}€ = {CalculaEURtoUSD(eur, ratio):0.##}$\n");
            Console.WriteLine($"\n{doll}$ = {CalculaUSDtoEUR(doll, ratio):0.##}€\n");

            Console.ReadKey(true);

        }

        static double CalculaUSDtoEUR(double num, double ratio) => num * ratio;
        static double CalculaEURtoUSD(double num, double ratio) => num / ratio;

    }
}
