using System;

class Programa
{
    static void Main(string[] args)
    {
        // Crear lista enlazada
        ListaEnlazada lista = new ListaEnlazada();

        // Agregar datos manualmente (puede ser aleatorio también)
        int[] datos = { 3, 7, 5, 2, 5, 1, 5, 8 };
        foreach (int d in datos)
            lista.AgregarFinal(d);

        Console.WriteLine("Lista enlazada:");
        lista.Mostrar();

        // Solicitar al usuario el valor a buscar
        Console.Write("\nIngrese el número a buscar: ");
        int valor = Convert.ToInt32(Console.ReadLine());

        // Buscar cuántas veces aparece el valor
        int veces = lista.ContarOcurrencias(valor);

        // Mostrar resultado
        if (veces > 0)
            Console.WriteLine($"El número {valor} aparece {veces} veces.");
        else
            Console.WriteLine($"El número {valor} no fue encontrado en la lista.");
    }
}
