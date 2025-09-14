using System;
using System.Collections.Generic;

namespace ProductoEscalar
{
    // Clase Vector
    public class Vector
    {
        public List<int> Componentes { get; set; }

        // Constructor
        public Vector(List<int> componentes)
        {
            Componentes = componentes;
        }

        // Método para calcular el producto escalar con otro vector
        public int ProductoEscalar(Vector otro)
        {
            if (Componentes.Count != otro.Componentes.Count)
                throw new ArgumentException("Los vectores deben tener la misma dimensión.");

            int resultado = 0;
            for (int i = 0; i < Componentes.Count; i++)
            {
                resultado += Componentes[i] * otro.Componentes[i];
            }
            return resultado;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Crear los vectores
            Vector vector1 = new Vector(new List<int> { 1, 2, 3 });
            Vector vector2 = new Vector(new List<int> { -1, 0, 2 });

            // Calcular el producto escalar
            int producto = vector1.ProductoEscalar(vector2);

            // Mostrar el resultado
            Console.WriteLine("El producto escalar de los vectores es: " + producto);
        }
    }
}
