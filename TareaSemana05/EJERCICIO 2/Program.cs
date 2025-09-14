using System;
using System.Collections.Generic;

namespace AsignaturasEstudio
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

        // Método para mostrar el mensaje personalizado por cada asignatura
        public void MostrarAsignaturasEstudio()
        {
            foreach (string asignatura in Asignaturas)
            {
                Console.WriteLine("Yo estudio " + asignatura);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Crear un objeto de tipo Curso
            Curso miCurso = new Curso();

            // Mostrar las asignaturas con el mensaje "Yo estudio ..."
            miCurso.MostrarAsignaturasEstudio();
        }
    }
}
