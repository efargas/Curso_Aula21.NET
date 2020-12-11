using System;

namespace Login
{
    class Program
    {
        static void Main(string[] args)
        {
            //La contraseña será el nombre del usuario en Mayúsculas
            string user="";
            
            Console.WriteLine("Inicia sesión en el Sistema para continuar\n");
            Console.WriteLine("Introduce tu nombre de Usuario: ");
            user = Console.ReadLine();
            if (Login(user) != true)
            {
                Console.WriteLine("Demasiados intentos fallidos, Saliendo del Sistema");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine($"\nBienvenido {user}");
                Console.ReadKey();
            }
        }

        private static bool Login(string user)
        {
            for(int i = 1; i < 4; i++)
            {
                Console.WriteLine($"\nIntroduce tu contraseña {user}: ");
                if (Console.ReadLine() == user.ToUpper()){
                    return true;
                }
                else
                {
                    Console.WriteLine($"\nContraseña incorrecta, te quedan {3-i} intentos\n");
                }
            }
            return false;
        }
    }
}
