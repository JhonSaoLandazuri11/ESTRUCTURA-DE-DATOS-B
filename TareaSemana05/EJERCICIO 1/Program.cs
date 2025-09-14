using System;
using System.Collections.Generic;

namespace ListaAsignaturas
{
    // Clase que representa un curso con asignaturas
    public class Curso
    {
        // Propiedad que almacena las asignaturas
        public List<string> Asignaturas { get; set; }

        // Constructor
        public Curso()
        {
            Asignaturas = new List<string>
            {
                "Matemáticas",
                "Física",
                "Química",
                "Historia",
                "Lengua"
            };
        }

        // Método para mostrar las asignaturas
        public void MostrarAsignaturas()
        {
            Console.WriteLine("Asignaturas del curso:");
            foreach (string asignatura in Asignaturas)
            {
                Console.WriteLine("- " + asignatura);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Crear objeto curso
            Curso miCurso = new Curso();

            // Mostrar las asignaturas
            miCurso.MostrarAsignaturas();
        }
    }
}
