using System.Collections.Generic;
using System.Linq;

namespace TorresHanoi
{
    public class Torre
    {
        public Stack<int> Discos { get; private set; }
        public string Nombre { get; private set; }

        public Torre(string nombre)
        {
            Nombre = nombre;
            Discos = new Stack<int>();
        }

        public void AgregarDisco(int disco)
        {
            Discos.Push(disco);
        }

        public int RemoverDisco()
        {
            return Discos.Pop();
        }

        public string Estado()
        {
            return string.Join(" ", Discos.Reverse());
        }
    }
}
