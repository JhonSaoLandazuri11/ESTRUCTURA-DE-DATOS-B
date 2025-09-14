using System;
using System.Collections.Generic;

namespace AnalisisPrecios
{
    // Clase que gestiona una lista de precios
    public class Precios
    {
        public List<int> ListaPrecios { get; set; }

        // Constructor que inicializa la lista con los precios dados
        public Precios()
        {
            ListaPrecios = new List<int> { 50, 75, 46, 22, 80, 65, 8 };
        }

        // Método para obtener el precio mínimo
        public int ObtenerMinimo()
        {
            int minimo = ListaPrecios[0];
            foreach (int precio in ListaPrecios)
            {
                if (precio < minimo)
                    minimo = precio;
            }
            return minimo;
        }

        // Método para obtener el precio máximo
        public int ObtenerMaximo()
        {
            int maximo = ListaPrecios[0];
            foreach (int precio in ListaPrecios)
            {
                if (precio > maximo)
                    maximo = precio;
            }
            return maximo;
        }

        // Método para mostrar los resultados
        public void MostrarResultados()
        {
            Console.WriteLine("El precio mínimo es: " + ObtenerMinimo());
            Console.WriteLine("El precio máximo es: " + ObtenerMaximo());
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Precios misPrecios = new Precios();
            misPrecios.MostrarResultados();
        }
    }
}
