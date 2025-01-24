using System;
using System.Collections.Generic;

namespace EstructuraDeDatos
{
    class Program
    {
        private static void Main(string[] args)
        {
            LinkedList<int> listaNumeros = new LinkedList<int>();
            Random random = new Random();

            // Generar una lista con 50 números aleatorios
            for (int i = 0; i < 50; i++)
            {
                listaNumeros.AddLast(random.Next(1, 800));
            }

            Console.WriteLine("Lista original:");
            MostrarLista(listaNumeros);

            // Solicitar rango al usuario
            Console.Write("Ingresar el primer valor del rango: ");
            int min = ValidarEntrada();

            Console.Write("Ingrese el último valor del rango: ");
            int max = ValidarEntrada();

            // Eliminar elementos fuera del rango
            LinkedListNode<int>? current = listaNumeros.First;
            while (current != null)
            {
                LinkedListNode<int>? next = current.Next;
                if (current.Value < min || current.Value > max)
                {
                    listaNumeros.Remove(current);
                }
                current = next;
            }

            Console.WriteLine("\nLista después de eliminar los valores fuera del rango indicado:");
            MostrarLista(listaNumeros);
        }

        static void MostrarLista(LinkedList<int> listaNumeros)
        {
            foreach (int numero in listaNumeros)
            {
                Console.Write(numero + " ");
            }
            Console.WriteLine();
        }

        static int ValidarEntrada()
        {
            while (true)
            {
                string? entrada = Console.ReadLine();
                if (int.TryParse(entrada, out int numero))
                {
                    return numero;
                }
                Console.WriteLine("Entrada inválida. Por favor, ingrese un número entero.");
            }
        }
    }
}
