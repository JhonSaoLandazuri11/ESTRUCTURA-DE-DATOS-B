using System;

namespace RegistroEstudiante
{
    // Clase auxiliar que contiene métodos para leer datos desde consola
    public static class Utilidades
    {
        // Lee y valida un número entero
        public static int LeerEntero(string mensaje)
        {
            int valor;
            Console.Write(mensaje);
            while (!int.TryParse(Console.ReadLine(), out valor))
            {
                Console.Write("Entrada inválida. Intente de nuevo: ");
            }
            return valor;
        }

        // Lee la cadena de texto
        public static string LeerTexto(string mensaje)
        {
            Console.Write(mensaje);
            return Console.ReadLine();
        }
    }
}
