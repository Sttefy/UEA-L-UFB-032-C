using System;
using System.Collections.Generic;

namespace AsignaturasCurso
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<string> asignaturas = new List<string>
            {
                "Emprendimiento",
                "Ingles",
                "Investigación",
                "Cultura Fisica",
                "ECA",
                "Sociales",
                "Geografia",
                "Informatica",
                "Naturales",
            };

            Console.WriteLine("Asignaturas del curso:");
            foreach (string asignatura in asignaturas)
            {
                Console.WriteLine($"- {asignatura}");
            }
        }
    }
}
