using System;
using System.Collections.Generic;

class Traductor
{
    static void Main(string[] args)
    {
        // Diccionario base con traducciones (Inglés -> Español y Español -> Inglés)
        Dictionary<string, string> diccionario = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
        {
            {"time", "tiempo"},
            {"person", "persona"},
            {"year", "año"},
            {"way", "camino"},
            {"day", "día"},
            {"thing", "cosa"},
            {"man", "hombre"},
            {"world", "mundo"},
            {"life", "vida"},
            {"hand", "mano"},
            {"part", "parte"},
            {"child", "niño"},
            {"eye", "ojo"},
            {"woman", "mujer"},
            {"place", "lugar"},
            {"work", "trabajo"},
            {"week", "semana"},
            {"case", "caso"},
            {"point", "punto"},
            {"government", "gobierno"},
            {"company", "empresa"}
        };

        // También añadimos la inversa (Español -> Inglés)
        var claves = new List<string>(diccionario.Keys);
        foreach (var key in claves)
        {
            string valor = diccionario[key];
            if (!diccionario.ContainsKey(valor))
            {
                diccionario[valor] = key;
            }
        }

        int opcion;
        do
        {
            Console.WriteLine("\n==================== MENÚ ====================");
            Console.WriteLine("1. Traducir una frase");
            Console.WriteLine("2. Agregar palabras al diccionario");
            Console.WriteLine("0. Salir");
            Console.Write("Seleccione una opción: ");

            if (!int.TryParse(Console.ReadLine(), out opcion))
            {
                Console.WriteLine("⚠️ Opción inválida. Intente nuevamente.");
                continue;
            }

            switch (opcion)
            {
                case 1:
                    Console.Write("\nIngrese la frase a traducir: ");
                    string frase = Console.ReadLine();
                    string traduccion = TraducirFrase(frase, diccionario);
                    Console.WriteLine($"Traducción: {traduccion}");
                    break;

                case 2:
                    Console.Write("\nIngrese la palabra en inglés o español: ");
                    string palabra = Console.ReadLine().Trim();

                    Console.Write("Ingrese su traducción: ");
                    string traduccionPalabra = Console.ReadLine().Trim();

                    if (!diccionario.ContainsKey(palabra))
                    {
                        diccionario[palabra] = traduccionPalabra;
                        if (!diccionario.ContainsKey(traduccionPalabra))
                            diccionario[traduccionPalabra] = palabra;

                        Console.WriteLine("Palabra agregada correctamente.");
                    }
                    else
                    {
                        Console.WriteLine("Esa palabra ya existe en el diccionario.");
                    }
                    break;

                case 0:
                    Console.WriteLine("Saliendo del programa...");
                    break;

                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }

        } while (opcion != 0);
    }

    // Función para traducir frase
    static string TraducirFrase(string frase, Dictionary<string, string> diccionario)
    {
        string[] palabras = frase.Split(new char[] { ' ', ',', '.', ';', '!', '?' }, StringSplitOptions.None);
        string[] delimitadores = { " ", ",", ".", ";", "!", "?" };
        string resultado = frase;

        foreach (var palabra in palabras)
        {
            if (diccionario.ContainsKey(palabra.ToLower()))
            {
                string traduccion = diccionario[palabra.ToLower()];
                resultado = ReplaceWord(resultado, palabra, traduccion);
            }
        }
        return resultado;
    }

    // Reemplaza palabra manteniendo mayúsculas/minúsculas originales
    static string ReplaceWord(string texto, string original, string traduccion)
    {
        if (char.IsUpper(original[0]))
        {
            traduccion = char.ToUpper(traduccion[0]) + traduccion.Substring(1);
        }
        return texto.Replace(original, traduccion);
    }
}
