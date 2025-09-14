using System;

namespace AgendaTurnos.Models
{
    // Clase que representa un paciente
    public class Paciente
    {
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string Especialidad { get; set; }
        public string HoraTurno { get; set; }

        // Constructor del paciente
        public Paciente(string cedula, string nombre, string especialidad, string horaTurno)
        {
            Cedula = cedula;
            Nombre = nombre;
            Especialidad = especialidad;
            HoraTurno = horaTurno;
        }

        // Mostrar información del paciente
        public void MostrarInfo()
        {
            Console.WriteLine($"Cédula: {Cedula}, Nombre: {Nombre}, Especialidad: {Especialidad}, Hora: {HoraTurno}");
        }
    }
}