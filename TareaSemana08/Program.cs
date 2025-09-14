using System;
using ParqueDiversiones.Models;

namespace ParqueDiversiones
{
    class Program
    {
        static void Main(string[] args)
        {
            Atraccion atraccion = new Atraccion();

            // Simulación de ingreso de 35 personas (más de la capacidad)
            for (int i = 1; i <= 35; i++)
            {
                atraccion.IngresarPersona($"Persona {i}");
            }

            Console.WriteLine("\nPresione ENTER para asignar asientos...");
            Console.ReadLine();

            // Asignación de asientos
            atraccion.AsignarAsientos();

            // Mostrar reporte final
            atraccion.MostrarReporte();

            Console.WriteLine("\nPresione ENTER para salir...");
            Console.ReadLine();
        }
    }
}
