using System;

namespace FigurasGeometricas
{
    // Clase Circulo representa un círculo y contiene métodos para calcular su área y perímetro
    public class Circulo
    {
        private double radio; // Atributo privado para el radio

        // Constructor para inicializar el radio
        public Circulo(double radio)
        {
            this.radio = radio;
        }

        // Método para calcular el área del círculo
        public double CalcularArea()
        {
            return Math.PI * radio * radio;
        }

        // Método para calcular el perímetro del círculo
        public double CalcularPerimetro()
        {
            return 2 * Math.PI * radio;
        }
    }
}
