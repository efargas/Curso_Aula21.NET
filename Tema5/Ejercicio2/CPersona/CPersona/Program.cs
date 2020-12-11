using System;

namespace CPersona
{
    class Persona
    {
        private string nombre;
        private int edad;

        public string Nombre
        {
            get { return nombre; }
            set
            {
                if (value == null)
                    nombre = "desconocido";
                else nombre = value;
            }
        }

        public int Edad
        {
            get { return edad; }
            set
            {
                edad = value;
            }
        }

        public void imprimirDatos()
        {
            Console.Write($"\nNombre: {nombre}");
            Console.Write($"\nEdad: {edad}");
        }

    }

    class Empleado : Persona
    {
        private int sueldo;


        public int Sueldo
        {
            get { return sueldo; }
            set
            {
                sueldo = value;
            }
        }

        public void imprimirSueldo()
        {
            Console.Write($"\nSueldo: {sueldo}");           
        }
    }
    
  class Program
    {
        static void Main(string[] args)
        {
            Persona Persona1 = new Persona();
            Empleado Empleado1 = new Empleado();
            Persona1.Edad = 32;
            Persona1.Nombre = "Erik";
            Persona1.imprimirDatos();
            Console.Write("\n");
            Empleado1.Nombre = "Miguel";
            Empleado1.Edad = 47;
            Empleado1.Sueldo = 4500;
            Empleado1.imprimirDatos();
            Empleado1.imprimirSueldo();
            Console.Write("\n");
            Console.ReadKey();

        }
    }
    
}
