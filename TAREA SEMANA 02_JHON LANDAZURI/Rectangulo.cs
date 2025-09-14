using System;

namespace FigurasGeometricas
{
    // Clase Rectangulo representa un rectángulo y contiene métodos para calcular su área y perímetro
    public class Rectangulo
    {
        private double baseRect;
        private double altura;

        // Constructor para inicializar base y altura
        public Rectangulo(double baseRect, double altura)
        {
            this.baseRect = baseRect;
            this.altura = altura;
        }

        // Método para calcular el área del rectángulo
        public double CalcularArea()
        {
            return baseRect * altura;
        }

        // Método para calcular el perímetro del rectángulo
        public double CalcularPerimetro()
        {
            return 2 * (baseRect + altura);
        }
    }
}