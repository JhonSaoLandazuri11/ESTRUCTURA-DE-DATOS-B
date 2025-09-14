using System;
using System.Collections.Generic;

namespace NumerosLoteria
{
    // Clase que representa una lotería
    public class Loteria
    {
        // Lista de números ganadores
        public List<int> NumerosGanadores { get; set; }

        // Constructor
        public Loteria()
        {
            NumerosGanadores = new List<int>();
        }

        // Método para pedir los números ganadores al usuario
        public void IngresarNumeros()
        {
            Console.WriteLine("Ingrese 6 números ganadores de la lotería:");
            for (int i = 0; i < 6; i++)
            {
                Console.Write($"Número {i + 1}: ");
                if (int.TryParse(Console.ReadLine(), out int numero))
                {
                    NumerosGanadores.Add(numero);
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Ingrese un número entero.");
                    i--; // Reintenta el mismo índice
                }
            }
        }

        // Método para mostrar los números ordenados
        public void MostrarNumerosOrdenados()
        {
            NumerosGanadores.Sort();
            Console.WriteLine("Los números ganadores ordenados son:");
            foreach (int numero in NumerosGanadores)
            {
                Console.Write(numero + " ");
            }
            Console.WriteLine(); // Salto de línea final
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Loteria loteria = new Loteria();
            loteria.IngresarNumeros();
            loteria.MostrarNumerosOrdenados();
        }
    }
}
