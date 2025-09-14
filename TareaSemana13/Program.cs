using System;
using System.Collections.Generic;

namespace CatalogoRevistas
{
    class Program
    {
        // Lista que almacenará los títulos de revistas
        static List<string> catalogo = new List<string>()
        {
             "Muy Interesante",
            "National Geographic en Español",
            "Proceso",
            "Semana",
            "Caras",
            "Hola",
            "El Gráfico",
            "Rolling Stone en Español",
            "Vogue Latinoamérica",
            "Cromos",
            "Cosas",
            "Quo",
            "TVyNovelas",
            "Expansión",
            "Dinero",
            "Arqueología Mexicana",
            "Gatopardo",
            "Esquire Latinoamérica",
            "Marie Claire en Español",
            "Vanidades"
        };

        static void Main(string[] args)
        {
            int opcion;
            do
            {
                Console.Clear();
                Console.WriteLine("=== Catálogo de Revistas ===");
                Console.WriteLine("1. Mostrar catálogo");
                Console.WriteLine("2. Buscar revista (recursivo)");
                Console.WriteLine("3. Salir");
                Console.Write("Seleccione una opción: ");
                
                // Control de errores de entrada
                if (!int.TryParse(Console.ReadLine(), out opcion))
                {
                    Console.WriteLine("Opción inválida, presione una tecla...");
                    Console.ReadKey();
                    continue;
                }

                switch (opcion)
                {
                    case 1:
                        MostrarCatalogo();
                        break;
                    case 2:
                        Console.Write("Ingrese el título a buscar: ");
                        string titulo = Console.ReadLine();
                        bool encontrado = BuscarRevistaRecursivo(catalogo, titulo, 0);

                        if (encontrado)
                            Console.WriteLine("\nResultado: Encontrado");
                        else
                            Console.WriteLine("\nResultado: No encontrado");
                        Console.WriteLine("Presione una tecla para continuar...");
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.WriteLine("Saliendo del programa...");
                        break;
                    default:
                        Console.WriteLine("Opción inválida, presione una tecla...");
                        Console.ReadKey();
                        break;
                }

            } while (opcion != 3);
        }

        // Método para mostrar el catálogo de revistas
        static void MostrarCatalogo()
        {
            Console.WriteLine("\n--- Catálogo de Revistas ---");
            foreach (var revista in catalogo)
            {
                Console.WriteLine("- " + revista);
            }
            Console.WriteLine("\nPresione una tecla para continuar...");
            Console.ReadKey();
        }

        // Búsqueda recursiva en la lista
        static bool BuscarRevistaRecursivo(List<string> lista, string titulo, int indice)
        {
            // Caso base: si llegamos al final de la lista
            if (indice >= lista.Count)
                return false;

            // Comparación (ignorando mayúsculas/minúsculas)
            if (lista[indice].Equals(titulo, StringComparison.OrdinalIgnoreCase))
                return true;

            // Llamada recursiva al siguiente elemento
            return BuscarRevistaRecursivo(lista, titulo, indice + 1);
        }
    }
}
