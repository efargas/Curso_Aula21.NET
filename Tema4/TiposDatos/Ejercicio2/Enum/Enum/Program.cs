using System;

namespace Enum
{
    class Program
    {
        public enum month { jan, feb, mar, apr, may, jun, jul, aug, sep, oct, nov, dec }
        static void Main(string[] args)
        {

            Array values = System.Enum.GetValues(typeof(month));

            foreach (month val in values)
            {
                Console.WriteLine($"{val}: {(int)val}");
            }
        }
    }
}
