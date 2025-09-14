using System;

namespace RegistroEstudiante
{
    class Program
    {
        // Punto de entrada principal del programa
        static void Main(string[] args)
        {
            Console.WriteLine("=== REGISTRO DE ESTUDIANTE ===");

            // Crea un objeto controlador y registrar estudiante
            Registro registro = new Registro();
            Estudiante estudiante = registro.RegistrarEstudiante();

            // Muestra los datos que el usuario registro
            estudiante.Mostrar();
        }
    }
}
