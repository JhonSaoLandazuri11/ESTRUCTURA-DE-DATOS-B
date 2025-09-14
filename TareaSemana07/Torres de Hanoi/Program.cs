using System;

namespace TorresHanoi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el número de discos: ");
            int n = int.Parse(Console.ReadLine());

            Torre torreA = new Torre("Origen");
            Torre torreB = new Torre("Auxiliar");
            Torre torreC = new Torre("Destino");

            for (int i = n; i >= 1; i--)
                torreA.AgregarDisco(i);

            HanoiSolver solucionador = new HanoiSolver();
            solucionador.ConfigurarTorres(torreB);
            solucionador.Resolver(n, torreA, torreC, torreB);
        }
    }
}
