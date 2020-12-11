using System;

namespace COrddenador
{
    class cOrdenador
    {
        //definimos los atributos
        private string marca;
        private string procesador;
        private float peso;
        private bool encendido = false;
        private bool pantalla = false;

        public void EncencerOrdenador()
        {
            if (encendido == true)
            {
                Console.WriteLine("El ordenador ya está encendido");
            }
            else
            {
                encendido = true;
                pantalla = true;
                Console.WriteLine("El ordenador ha sido encendido");
            }
        }

        public void Estado()
        {
            Console.Write("\nEl estado del ordenador es el siguiente:");
            Console.Write("\nMarca: " + marca);
            Console.Write("\nProcesador: " + procesador);
            Console.Write("\nPeso: " + peso + "kq");

            if (encendido == true) Console.WriteLine("\nEl ordenador está encendido");
            else Console.WriteLine("\nEl ordenador está apagado");

            if (pantalla == true) Console.WriteLine("\nLa pantalla esta activada");
            else Console.WriteLine("\nLa pantalla esta desactivada");

            Console.Write("\n");
        }

        public string Marca
        {
            get { return marca; }
            set
            {
                if (value == null)
                    marca = "desconocida";
                else marca = value;
            }
        }

        public string Procesador
        {
            get { return procesador; }
            set
            {
                if (value == null)
                    procesador = "desconocido";
                else procesador = value;
            }
        }

        public float Peso
        {
            get { return peso; }
            set
            {
                peso = value;
            }
        }

        static void Main(string[] args)
        {
            cOrdenador miOrdenador = new cOrdenador();
            miOrdenador.Marca = "Toshiba";
            miOrdenador.Peso = 2.5F;
            miOrdenador.Procesador = "Intel";
            miOrdenador.EncencerOrdenador();
            miOrdenador.Estado();
        }

    }



}
