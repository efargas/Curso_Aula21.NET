using System;
using System.IO;
using System.Collections.Generic;

namespace ListaDirectorios
{
    class Program    {

        static void Main(string[] args)
        {
            string path;
            Console.WriteLine("Introduce un directorio para mostrar su conenido\n");
            Console.Write(">>> ");
            path = Console.ReadLine();

            try
            {
                DirectoryInfo di = new DirectoryInfo(path);
                FileInfo[] fiArr = di.GetFiles();

                Console.WriteLine($"El directorio {di.Name} contiene los siguientes archivos:\n");
                foreach (FileInfo fi in fiArr)
                    Console.WriteLine($"{fi.Name} \t {fi.Length} bytes \t {fi.CreationTime}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Entrada inválida. {e.Message}");
            }

            Console.ReadKey();
        }

    }

}
