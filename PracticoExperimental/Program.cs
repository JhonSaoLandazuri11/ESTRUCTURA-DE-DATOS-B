using System;
using AgendaTurnos.Models;
using AgendaTurnos.Services;

namespace AgendaTurnos
{
    class Program
    {
        static void Main(string[] args)
        {
            AgendaTurnos.Services.AgendaTurnos agenda = new AgendaTurnos.Services.AgendaTurnos(100);
            int opcion;

            do
            {
                Console.WriteLine("\n--- Menú de Agenda de Turnos ---");
                Console.WriteLine("1. Registrar turno");
                Console.WriteLine("2. Mostrar agenda");
                Console.WriteLine("3. Salir");
                Console.Write("Seleccione una opción: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.Write("Ingrese Cédula: ");
                        string cedula = Console.ReadLine();
                        Console.Write("Ingrese sus Nombres completos: ");
                        string nombre = Console.ReadLine();
                        Console.Write("Ingrese que Especialista necesita: ");
                        string especialidad = Console.ReadLine();
                        Console.Write("Ingrese Hora del Turno (HH:mm): ");
                        string hora = Console.ReadLine();

                        Paciente nuevo = new Paciente(cedula, nombre, especialidad, hora);
                        agenda.RegistrarPaciente(nuevo);
                        break;

                    case 2:
                        agenda.MostrarAgenda();
                        break;

                    case 3:
                        Console.WriteLine("Saliendo del sistema...");
                        break;

                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }

            } while (opcion != 3);
        }
    }
}