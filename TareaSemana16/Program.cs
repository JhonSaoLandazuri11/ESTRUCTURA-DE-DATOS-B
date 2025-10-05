using System;
using System.Collections.Generic;
using System.Linq;

namespace VuelosBaratos
{
    // ------------------------------
    // INTERFACES / ABSTRACCIONES
    // ------------------------------
    public interface IFlightRepository
    {
        List<Flight> GetAllFlights();
    }

    public interface IFlightSearcher
    {
        Flight FindCheapestFlight(string origin, string destination);
        List<string> GetAvailableDestinations();
    }

    // ------------------------------
    // CLASE DE MODELO
    // ------------------------------
    public class Flight
    {
        public string Origin { get; set; }
        public string Destination { get; set; }
        public string Airline { get; set; }
        public double Price { get; set; }
        public int Duration { get; set; } // en minutos

        public Flight(string origin, string destination, string airline, double price, int duration)
        {
            Origin = origin;
            Destination = destination;
            Airline = airline;
            Price = price;
            Duration = duration;
        }
    }

    // ------------------------------
    // IMPLEMENTACIÓN DE REPOSITORIO
    // ------------------------------
    public class InMemoryFlightRepository : IFlightRepository
    {
        private List<Flight> flights;

        public InMemoryFlightRepository()
        {
            flights = new List<Flight>()
            {
                new Flight("Quito", "Guayaquil", "AeroQ", 120, 60),
                new Flight("Quito", "Guayaquil", "FlyEcuador", 100, 70),
                new Flight("Guayaquil", "Quito", "AeroQ", 110, 60),
                new Flight("Quito", "Cuenca", "FlyEcuador", 150, 80),
                new Flight("Cuenca", "Quito", "AeroQ", 140, 80)
            };
        }

        public List<Flight> GetAllFlights()
        {
            return flights;
        }
    }

    // ------------------------------
    // IMPLEMENTACIÓN DE BÚSQUEDA
    // ------------------------------
    public class FlightSearcher : IFlightSearcher
    {
        private readonly IFlightRepository repository;

        public FlightSearcher(IFlightRepository repository)
        {
            this.repository = repository;
        }

        public Flight FindCheapestFlight(string origin, string destination)
        {
            var matchingFlights = repository.GetAllFlights()
                                            .Where(f => f.Origin.Equals(origin, StringComparison.OrdinalIgnoreCase)
                                                     && f.Destination.Equals(destination, StringComparison.OrdinalIgnoreCase))
                                            .ToList();

            if (matchingFlights.Count == 0)
                return null;

            return matchingFlights.OrderBy(f => f.Price).First();
        }

        public List<string> GetAvailableDestinations()
        {
            // Obtiene todos los destinos únicos
            var flights = repository.GetAllFlights();
            var routes = flights.Select(f => $"{f.Origin} -> {f.Destination}")
                                .Distinct()
                                .ToList();
            return routes;
        }
    }

    // ------------------------------
    // INTERFAZ DE USUARIO EN CONSOLA
    // ------------------------------
    public class ConsoleInterface
    {
        private readonly IFlightSearcher searcher;

        public ConsoleInterface(IFlightSearcher searcher)
        {
            this.searcher = searcher;
        }

        public void ShowMenu()
        {
            while (true)
            {
                Console.WriteLine("\n=== Búsqueda de Vuelos Baratos ===");
                Console.WriteLine("1. Consultar vuelo más barato");
                Console.WriteLine("2. Ver rutas disponibles");
                Console.WriteLine("3. Salir");
                Console.Write("Ingrese su opción: ");
                string option = Console.ReadLine();

                if (option == "1")
                {
                    Console.Write("Ingrese ciudad de origen: ");
                    string origin = Console.ReadLine();

                    Console.Write("Ingrese ciudad de destino: ");
                    string destination = Console.ReadLine();

                    Flight cheapest = searcher.FindCheapestFlight(origin, destination);

                    if (cheapest != null)
                    {
                        Console.WriteLine("\n=== Vuelo más barato ===");
                        Console.WriteLine($"Origen: {cheapest.Origin}");
                        Console.WriteLine($"Destino: {cheapest.Destination}");
                        Console.WriteLine($"Aerolínea: {cheapest.Airline}");
                        Console.WriteLine($"Precio: ${cheapest.Price}");
                        Console.WriteLine($"Duración: {cheapest.Duration} minutos");
                    }
                    else
                    {
                        Console.WriteLine("\nNo se encontraron vuelos para esta ruta.");
                    }
                }
                else if (option == "2")
                {
                    Console.WriteLine("\n=== Rutas disponibles ===");
                    var routes = searcher.GetAvailableDestinations();
                    foreach (var route in routes)
                    {
                        Console.WriteLine(route);
                    }
                }
                else if (option == "3")
                {
                    Console.WriteLine("¡Gracias por usar el buscador de vuelos!");
                    break;
                }
                else
                {
                    Console.WriteLine("Opción inválida. Intente nuevamente.");
                }
            }
        }
    }

    // ------------------------------
    // PROGRAMA PRINCIPAL
    // ------------------------------
    class Program
    {
        static void Main(string[] args)
        {
            IFlightRepository repository = new InMemoryFlightRepository();
            IFlightSearcher searcher = new FlightSearcher(repository);
            ConsoleInterface ui = new ConsoleInterface(searcher);

            ui.ShowMenu();
        }
    }
}
