namespace ParqueDiversiones.Models
{
    public class Asiento
    {
        public int Numero { get; set; }
        public string Persona { get; set; }

        public Asiento(int numero, string persona)
        {
            Numero = numero;
            Persona = persona;
        }

        public override string ToString()
        {
            return $"Asiento {Numero}: {Persona}";
        }
    }
}
