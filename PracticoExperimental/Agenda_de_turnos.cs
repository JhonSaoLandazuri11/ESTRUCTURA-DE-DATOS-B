using System;
using AgendaTurnos.Models;

namespace AgendaTurnos.Services
{
    public class AgendaTurnos
    {
        private Paciente[] listaPacientes;
        private int contador;

        public AgendaTurnos(int capacidad)
        {
            listaPacientes = new Paciente[capacidad];
            contador = 0;
        }

        // Agrega un paciente si no existe otro con la misma cédula
        public void RegistrarPaciente(Paciente paciente)
        {
            if (contador >= listaPacientes.Length)
            {
                Console.WriteLine("Agenda llena. No se pueden registrar más pacientes.");
                return;
            }

            for (int i = 0; i < contador; i++)
            {
                if (listaPacientes[i].Cedula == paciente.Cedula)
                {
                    Console.WriteLine("Este paciente ya tiene un turno registrado.");
                    return;
                }
            }

            listaPacientes[contador++] = paciente;
            Console.WriteLine("Turno registrado con éxito.");
        }

        // Muestra todos los turnos
        public void MostrarAgenda()
        {
            Console.WriteLine("\nAgenda de Turnos:");
            for (int i = 0; i < contador; i++)
            {
                listaPacientes[i].MostrarInfo();
            }

            if (contador == 0)
                Console.WriteLine("No hay turnos registrados.");
        }
    }
}
