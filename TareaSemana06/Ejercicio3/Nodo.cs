// Clase Nodo representa un nodo de una lista enlazada
public class Nodo
{
    public int Dato { get; set; }         // Dato almacenado
    public Nodo Siguiente { get; set; }   // Referencia al siguiente nodo

    public Nodo(int dato)
    {
        Dato = dato;
        Siguiente = null;
    }
}
