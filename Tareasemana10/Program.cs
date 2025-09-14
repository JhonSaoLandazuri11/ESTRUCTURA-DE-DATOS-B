using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("Tarea Semana 10");
        Console.WriteLine(" Campaña de Vacunación COVID-19 ");

        // 1. Conjunto de 500 ciudadanos
        HashSet<string> conjuntoU = new HashSet<string>();
        for (int i = 1; i <= 500; i++)
        {
            conjuntoU.Add("Ciudadano " + i);
        }

        // 2. Conjunto ficticio de 75 vacunados con Pfizer
        HashSet<string> conjuntoPfizer = GenerarVacunados(75);

        // 3. Conjunto ficticio de 75 vacunados con AstraZeneca
        HashSet<string> conjuntoAstra = GenerarVacunados(75);

        // 4. Operaciones de conjuntos
        // vacunados = (Pfizer ∪ AstraZeneca)
        var vacunados = new HashSet<string>(conjuntoPfizer);
        vacunados.UnionWith(conjuntoAstra);

        // no vacunados = U - vacunados
        var noVacunados = new HashSet<string>(conjuntoU);
        noVacunados.ExceptWith(vacunados);

        // ambas dosis = Pfizer ∩ AstraZeneca
        var ambasDosis = new HashSet<string>(conjuntoPfizer);
        ambasDosis.IntersectWith(conjuntoAstra);

        // solo Pfizer = Pfizer - AstraZeneca
        var soloPfizer = new HashSet<string>(conjuntoPfizer);
        soloPfizer.ExceptWith(conjuntoAstra);

        // solo AstraZeneca = AstraZeneca - Pfizer
        var soloAstra = new HashSet<string>(conjuntoAstra);
        soloAstra.ExceptWith(conjuntoPfizer);

        // 5. Resultados
        Console.WriteLine("\n--- Estadísticas ---");
        Console.WriteLine("Total ciudadanos: " + conjuntoU.Count);
        Console.WriteLine("Vacunados con Pfizer: " + conjuntoPfizer.Count);
        Console.WriteLine("Vacunados con AstraZeneca: " + conjuntoAstra.Count);
        Console.WriteLine("No vacunados: " + noVacunados.Count);
        Console.WriteLine("Ambas dosis: " + ambasDosis.Count);
        Console.WriteLine("Solo Pfizer: " + soloPfizer.Count);
        Console.WriteLine("Solo AstraZeneca: " + soloAstra.Count);
    }

    // Método para generar ciudadanos vacunados de manera aleatoria
    static HashSet<string> GenerarVacunados(int cantidad)
    {
        HashSet<string> conjunto = new HashSet<string>();
        Random random = new Random();
        while (conjunto.Count < cantidad)
        {
            int numero = random.Next(1, 501); // 1 a 500
            conjunto.Add("Ciudadano " + numero);
        }
        return conjunto;
    }

    // Imprimir listados
    static void MostrarListado(string titulo, HashSet<string> conjunto)
    {
        Console.WriteLine($"\n-- {titulo} ({conjunto.Count}) --");
        foreach (var c in conjunto) Console.WriteLine(c);
    }
}
