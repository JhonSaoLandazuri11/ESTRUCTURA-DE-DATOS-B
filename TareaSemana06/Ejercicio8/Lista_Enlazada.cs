using System;
using System.Collections.Generic;

public class ListaEnlazada
{
    private Nodo cabeza;

    // Agregar nodo al final
    public void AgregarFinal(double dato)
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

    // Mostrar la lista
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

    // Obtener datos como lista normal para procesamiento
    public List<double> ObtenerDatos()
    {
        List<double> lista = new List<double>();
        Nodo actual = cabeza;
        while (actual != null)
        {
            lista.Add(actual.Dato);
            actual = actual.Siguiente;
        }
        return lista;
    }

    // Calcular promedio
    public double CalcularPromedio()
    {
        var datos = ObtenerDatos();
        if (datos.Count == 0) return 0;
        double suma = 0;
        foreach (var d in datos) suma += d;
        return suma / datos.Count;
    }
}
