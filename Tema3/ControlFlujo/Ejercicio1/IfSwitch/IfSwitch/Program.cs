using System;

namespace IfSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa Control de flujo con If y Switch");
            Console.WriteLine("=========================================");
            Console.WriteLine("\nIntroduce un número entero entre 0 y 10 ");
            int num = 100;
            while (num < 0 || num >10) {

                try
                {
                    num = Convert.ToInt32(Console.ReadLine());
                }catch (FormatException e)
                {
                    Console.WriteLine($"{e.Message}\nIntroduce un valor numérico entre 0 y 10:");
                }

            }

            ControlIF(num);
            ControlSwitch(num);
        }

        static void ControlIF(int nota)
        {
            Console.WriteLine("Control Con If\n");
            if (nota <= 10 & nota > 8)
            {
                Console.WriteLine("Sobresaliente\n");
            } else if (nota <= 8 & nota > 6)
            {
                Console.WriteLine("Notable\n");
            } else if (nota == 6) 
            {
                Console.WriteLine("Bien\n");
            }
            else if (nota == 5)
            {
                Console.WriteLine("Aprobado\n");
            }else
            {
                Console.WriteLine("Suspenso\n");
            }
        }

        static void ControlSwitch(int nota)
        {
            Console.WriteLine("Control Con Switch\n");
            switch (nota)
            {
                case 10:
                case 9:
                    Console.WriteLine("Sobresaliente\n");
                    break;
                case 8:
                case 7:
                    Console.WriteLine("Notable\n");
                    break;
                case 6:
                    Console.WriteLine("Bien\n");
                    break;
                case 5:
                    Console.WriteLine("Aprobado\n");
                    break;
                default:
                    Console.WriteLine("Suspenso\n");
                    break;
            }
        }
    }
}
