using System;

namespace Balanceador
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la expresión matemática:");
            string entrada = Console.ReadLine();

            if (ExpresionBalanceada.EstaBalanceado(entrada))
                Console.WriteLine("Fórmula balanceada.");
            else
                Console.WriteLine("Fórmula no balanceada.");
        }
    }
}
