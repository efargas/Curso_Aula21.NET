using System;
using System.IO;

namespace ListaDirectoriosArchivos
{
    class Program
    {
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
                DirectoryInfo[] diArr = di.GetDirectories();
                Console.WriteLine($"El directorio {di.Name} contiene los siguientes archivos:\n");

                Console.WriteLine($"{"Nombre Archivo",-40} {"Fecha creación",20} {"Tamaño",20}\n");
                foreach (FileInfo fi in fiArr)
                {
                    if (fi.Length < 1024)
                    {
                        Console.WriteLine($"{fi.Name,-40} {fi.CreationTime,20:dd/MM/yyyy HH:mm:ss} {fi.Length,20} bytes ");
                    }
                    else
                    {
                        Console.WriteLine($"{fi.Name,-40} {fi.CreationTime,20:dd/MM/yyyy HH:mm:ss} {fi.Length / 1024,20} KB ");
                    }
                }

                foreach (DirectoryInfo dir in diArr)
                {
                    Console.WriteLine($"{dir.Name,-40} {dir.CreationTime,20:dd/MM/yyyy HH:mm:ss}");
                }

            }
            catch (Exception e)
            {
                Console.WriteLine($"Entrada inválida. {e.Message}");
            }

            Console.ReadKey();
        }
    }
}
