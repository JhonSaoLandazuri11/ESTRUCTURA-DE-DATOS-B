using System;

// Clase ListaEnlazada representa una lista enlazada simple
public class ListaEnlazada
{
    private Nodo cabeza;  // Nodo inicial (primero)

    // Método para agregar un nodo al final de la lista
    public void AgregarFinal(int dato)
    {
        Nodo nuevo = new Nodo(dato);
        if (cabeza == null)
        {
            cabeza = nuevo;
        }
        else
        {
            Nodo actual = cabeza;
            while (actual.Siguiente != null)
            {
                actual = actual.Siguiente;
            }
            actual.Siguiente = nuevo;
        }
    }

    // Método para contar cuántas veces aparece un valor en la lista
    public int ContarOcurrencias(int valor)
    {
        int contador = 0;
        Nodo actual = cabeza;
        while (actual != null)
        {
            if (actual.Dato == valor)
                contador++;
            actual = actual.Siguiente;
        }
        return contador;
    }

    // Método para mostrar los elementos de la lista
    public void Mostrar()
    {
        Nodo actual = cabeza;
        while (actual != null)
        {
            Console.Write(actual.Dato + " -> ");
            actual = actual.Siguiente;
        }
        Console.WriteLine("null");
    }
}
