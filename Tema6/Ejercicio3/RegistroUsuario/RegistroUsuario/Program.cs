using System;
using System.IO;

namespace RegistroUsuario
{
    class Program
    {
        static void Main(string[] args)
        {
            string finish = "fin";
            StreamWriter fichero = new StreamWriter("registroDeUsuario.txt",true);
            Console.WriteLine("Introduce texto para guardar en el archivo\n");
            Console.WriteLine("Para finalizar escriba fin y presione ENTER\n");
            Console.Write(">>>: ");
            do
            {
                string line = Console.ReadLine();
                if (line == finish)
                {
                    fichero.Close();
                    Console.Write("\nFichero Guardado con éxito\n");
                    return;
                }
                fichero.WriteLine(line);
                Console.Write(">>>: ");
            } while (true);
            Console.ReadKey();
        }
    }
}
