using System;
using System.Collections.Generic;

namespace ParqueDiversiones.Models
{
    public class Atraccion
    {
        private Queue<string> colaPersonas;
        private List<Asiento> asientosAsignados;

        public Atraccion()
        {
            colaPersonas = new Queue<string>();
            asientosAsignados = new List<Asiento>();
        }

        // Registra una persona en la cola solo si no se supera la capacidad total (cola + asignados)
        public void IngresarPersona(string nombre)
        {
            int totalPersonasEnSistema = colaPersonas.Count + asientosAsignados.Count;

            if (totalPersonasEnSistema < 30)
            {
                colaPersonas.Enqueue(nombre);
                Console.WriteLine($"Se agregó a la cola: {nombre}");
            }
            else
            {
                Console.WriteLine($"[!] Atracción llena: {nombre} no pudo ingresar.");
            }
        }

        // Asigna asientos en orden a las personas de la cola
        public void AsignarAsientos()
        {
            int numeroAsiento = asientosAsignados.Count + 1;

            while (colaPersonas.Count > 0 && asientosAsignados.Count < 30)
            {
                string persona = colaPersonas.Dequeue();
                asientosAsignados.Add(new Asiento(numeroAsiento++, persona));
            }
        }

        // Muestra el reporte de asientos asignados con formato tabla
        public void MostrarReporte()
        {
            Console.Clear();
            Console.WriteLine(new string('=', 45));
            Console.WriteLine("         REPORTE DE ASIENTOS ASIGNADOS        ");
            Console.WriteLine(new string('=', 45));
            Console.WriteLine("{0,-10} | {1,-25}", "Asiento", "Nombre de Persona");
            Console.WriteLine(new string('-', 45));

            foreach (var asiento in asientosAsignados)
            {
                Console.WriteLine("{0,-10} | {1,-25}", asiento.Numero, asiento.Persona);
            }

            Console.WriteLine(new string('=', 45));
            Console.WriteLine($"Total de asientos asignados: {asientosAsignados.Count}");
            Console.WriteLine(new string('=', 45));
        }
    }
}
