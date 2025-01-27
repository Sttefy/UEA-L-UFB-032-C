using System;
using System.Collections.Generic;

namespace AsignaturasNotas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> asignaturas = new List<string>
            {
                "Emprendimiento",
                "Inglés",
                "Investigación",
                "Cultura Física",
                "ECA",
                "Sociales",
                "Geografía",
                "Informática",
                "Naturales"
            };

            List<int> notas = new List<int>();

            Console.WriteLine("Introduce las notas para las siguientes asignaturas:");

            foreach (string asignatura in asignaturas)
            {
                Console.Write($"Nota para {asignatura}: ");
                int nota;

                while (!int.TryParse(Console.ReadLine(), out nota) || nota < 0 || nota > 10)
                {
                    Console.WriteLine("Por favor, introduce una nota válida entre 0 y 10.");
                    Console.Write($"Nota para {asignatura}: ");
                }

                notas.Add(nota);
            }

            Console.WriteLine("\nResultados:");
            for (int i = 0; i < asignaturas.Count; i++)
            {
                Console.WriteLine($"En {asignaturas[i]} has sacado {notas[i]}.");
            }

            Console.WriteLine("\nFinalizar");
            Console.ReadKey();
        }
    }
}
