using System;
using System.Collections.Generic;

namespace AbecedarioModificado
{
    class Program
    {
        static void Main(string[] args)
        {
            List<char> abecedario = new List<char>
            {
                'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L',
                'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z'
            };

            for (int i = abecedario.Count; i >= 1; i--)
            {
                if (i % 3 == 0)
                {
                    abecedario.RemoveAt(i - 1);
                }
            }

            Console.WriteLine("Abecedario después de eliminar posiciones múltiplos de 3:");
            Console.WriteLine(string.Join(", ", abecedario));

            Console.WriteLine("\nSalir...");
            Console.ReadKey();
        }
    }
}
