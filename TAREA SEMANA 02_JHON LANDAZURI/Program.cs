using System;

namespace FigurasGeometricas
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crear y probar un objeto de la clase Circulo
            Circulo miCirculo = new Circulo(5);
            Console.WriteLine("Círculo:");
            Console.WriteLine("Área: " + miCirculo.CalcularArea());
            Console.WriteLine("Perímetro: " + miCirculo.CalcularPerimetro());

            // Crear y probar un objeto de la clase Rectangulo
            Rectangulo miRectangulo = new Rectangulo(4, 6);
            Console.WriteLine("\nRectángulo:");
            Console.WriteLine("Área: " + miRectangulo.CalcularArea());
            Console.WriteLine("Perímetro: " + miRectangulo.CalcularPerimetro());
        }
    }
}