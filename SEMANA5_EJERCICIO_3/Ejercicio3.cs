using System;
using System.Collections.Generic;

namespace NumerosInversos
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            numeros.Reverse();

            Console.WriteLine("Números en orden inverso:");
            Console.WriteLine(string.Join(", ", numeros));

            Console.WriteLine("\nPresiona una tecla para salir...");
            Console.ReadKey();
        }
    }
}
