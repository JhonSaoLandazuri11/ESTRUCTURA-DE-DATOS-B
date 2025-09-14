using System;

namespace TorresHanoi
{
    public class HanoiSolver
    {
        public void Resolver(int n, Torre origen, Torre destino, Torre auxiliar)
        {
            MoverDiscos(n, origen, destino, auxiliar);
            Console.WriteLine("¡Todos los discos se han movido exitosamente!");
        }

        private void MoverDiscos(int n, Torre origen, Torre destino, Torre auxiliar)
        {
            if (n == 1)
            {
                MoverDisco(origen, destino);
            }
            else
            {
                MoverDiscos(n - 1, origen, auxiliar, destino);
                MoverDisco(origen, destino);
                MoverDiscos(n - 1, auxiliar, destino, origen);
            }
        }

        private void MoverDisco(Torre origen, Torre destino)
        {
            int disco = origen.RemoverDisco();
            destino.AgregarDisco(disco);

            Console.WriteLine("\n-------------------------------");
            Console.WriteLine($"Mover disco {disco} de {origen.Nombre} a {destino.Nombre}\n");

            Console.WriteLine("Estado de las torres:");
            Console.WriteLine($"{origen.Nombre}: {origen.Estado()}");
            Console.WriteLine($"{auxiliar.Nombre}: {auxiliar.Estado()}");
            Console.WriteLine($"{destino.Nombre}: {destino.Estado()}");
        }

        private Torre auxiliar;

        public void ConfigurarTorres(Torre auxiliar)
        {
            this.auxiliar = auxiliar;
        }
    }
}
