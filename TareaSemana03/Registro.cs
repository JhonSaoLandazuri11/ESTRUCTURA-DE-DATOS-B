using System;

namespace RegistroEstudiante
{
    // Clase encargada de gestionar el proceso de registro del estudiante
    public class Registro
    {
        // Método donde se recopila los datos e instancia un estudiante
        public Estudiante RegistrarEstudiante()
        {
            Estudiante est = new Estudiante
            {
                Id = Utilidades.LeerEntero("Ingrese el ID: "),
                Nombres = Utilidades.LeerTexto("Ingrese los nombres: "),
                Apellidos = Utilidades.LeerTexto("Ingrese los apellidos: "),
                Direccion = Utilidades.LeerTexto("Ingrese la dirección: ")
            };

            // Solicita al usuario los tres teléfonos
            for (int i = 0; i < est.Telefonos.Length; i++)
            {
                est.Telefonos[i] = Utilidades.LeerTexto($"Ingrese el teléfono {i + 1}: ");
            }

            return est;
        }
    }
}

