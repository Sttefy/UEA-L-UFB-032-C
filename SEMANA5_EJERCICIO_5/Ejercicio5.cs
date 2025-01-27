using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese una palabra: ");
        string? input = Console.ReadLine();
        string palabra = input?.ToLower() ?? string.Empty;

        Dictionary<char, int> conteoVocales = new Dictionary<char, int>
        {
            {'a', 0},
            {'e', 0},
            {'i', 0},
            {'o', 0},
            {'u', 0}
        };

        foreach (char letra in palabra)
        {
            if (conteoVocales.ContainsKey(letra))
            {
                conteoVocales[letra]++;
            }
        }

        Console.WriteLine("\nEl número de veces que aparece cada vocal es:");
        foreach (var vocal in conteoVocales)
        {
            Console.WriteLine($"{vocal.Key}: {vocal.Value}");
        }
    }
}
