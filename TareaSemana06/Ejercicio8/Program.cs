using System;

class Programa
{
    static void Main(string[] args)
    {
        ListaEnlazada listaPrincipal = new ListaEnlazada();

        // Cargar lista con datos reales
        double[] datos = { 8.5, 7.2, 10.0, 9.3, 11.5, 6.8 };
        foreach (double d in datos)
            listaPrincipal.AgregarFinal(d);

        Console.WriteLine("Lista principal:");
        listaPrincipal.Mostrar();

        // Calcular promedio
        double promedio = listaPrincipal.CalcularPromedio();
        Console.WriteLine($"\nPromedio: {promedio:F2}");

        // Crear listas para menores/iguales y mayores al promedio
        ListaEnlazada menores = new ListaEnlazada();
        ListaEnlazada mayores = new ListaEnlazada();

        foreach (var d in listaPrincipal.ObtenerDatos())
        {
            if (d <= promedio)
                menores.AgregarFinal(d);
            else
                mayores.AgregarFinal(d);
        }

        Console.WriteLine("\nDatos menores o iguales al promedio:");
        menores.Mostrar();

        Console.WriteLine("Datos mayores al promedio:");
        mayores.Mostrar();
    }
}
