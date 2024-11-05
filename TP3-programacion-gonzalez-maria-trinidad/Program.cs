using System;

class Program
{
    static void Main()
    {
        int[,] vuelos = new int[5, 60]; 
        int userOption;

        do
        {
            Console.WriteLine("\nSeleccione una opción:" +
                "\n1. Crear un vuelo" +
                "\n2. Reservar un asiento" +
                "\n3. Cancelar un vuelo" +
                "\n4. Ver asientos disponibles y ocupados" +
                "\n5. Contar asientos disponibles y ocupados" +
                "\n6. Ver disponibilidad de un asiento específico" +
                "\n7. Salir");

            userOption = int.Parse(Console.ReadLine());

            switch (userOption)
            {
                case 1:
                    CreateAirplaneFlight();
                    break;
                case 2:
                    MakeAReservation(vuelos);
                    break;
                case 3:
                    CancelFlight(vuelos);
                    break;
                case 4:
                    ShowOccupiedAvailableSeats(vuelos);
                    break;
                case 5:
                    OccupiedAvailableSeatsCount(vuelos);
                    break;
                case 6:
                    SearchSeat(vuelos);
                    break;
                case 7:
                    Console.WriteLine("Operación cancelada.");
                    break;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }
        } while (userOption != 7);
    }

    static void CreateAirplaneFlight()
    {
        Console.WriteLine("Nuevo vuelo creado exitosamente.");
    }

    static int[,] MakeAReservation(int[,] vuelos)
    {
        Console.WriteLine("Ingrese el número de vuelo (0-4): ");
        int flightNumber = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el número de asiento (0 a 59):");
        int seatNumber = int.Parse(Console.ReadLine());

        if (flightNumber >= 0 && flightNumber < vuelos.GetLength(0) && seatNumber >= 0 && seatNumber < vuelos.GetLength(1))
        {
            if (vuelos[flightNumber, seatNumber] == 0)
            {
                vuelos[flightNumber, seatNumber] = 1;
                Console.WriteLine("El asiento " + seatNumber + " en el vuelo " + flightNumber + " ha sido reservado.");
            }
            else
            {
                Console.WriteLine("Asiento ocupado. Asientos disponibles:");
                for (int i = 0; i < vuelos.GetLength(1); i++)
                {
                    if (vuelos[flightNumber, i] == 0)
                    {
                        Console.WriteLine("Asiento " + i + " disponible.");
                    }
                }
            }
        }
        else
        {
            Console.WriteLine("Número de asiento o vuelo inválido.");
        }
        return vuelos;
    }

    static int[,] CancelFlight(int[,] vuelos)
    {
        Console.WriteLine("Ingrese el número de vuelo (0-4): ");
        int flightNumber = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el número de asiento que desea cancelar (0-59): ");
        int seatNumber = int.Parse(Console.ReadLine());

        if (flightNumber >= 0 && flightNumber < vuelos.GetLength(0) && seatNumber >= 0 && seatNumber < vuelos.GetLength(1))
        {
            vuelos[flightNumber, seatNumber] = 0;
            Console.WriteLine("Asiento cancelado exitosamente.");
        }
        else
        {
            Console.WriteLine("Número de asiento o vuelo inválido.");
        }
        return vuelos;
    }

    static void ShowOccupiedAvailableSeats(int[,] vuelos)
    {
        Console.WriteLine("Ingrese el número de vuelo (0-4) para ver su estado de asientos:");
        int flightNumber = int.Parse(Console.ReadLine());

        if (flightNumber >= 0 && flightNumber < vuelos.GetLength(0))
        {
            for (int i = 0; i < vuelos.GetLength(1); i++)
            {
                string status = vuelos[flightNumber, i] == 0 ? "disponible" : "ocupado";
                Console.WriteLine("Asiento " + i + ": " + status);
            }
        }
        else
        {
            Console.WriteLine("Número de vuelo inválido.");
        }
    }

    static void OccupiedAvailableSeatsCount(int[,] vuelos)
    {
        Console.WriteLine("Ingrese el número de vuelo (0-4): ");
        int flightNumber = int.Parse(Console.ReadLine());

        if (flightNumber >= 0 && flightNumber < vuelos.GetLength(0))
        {
            int asientosDisponibles = 0;
            int asientosOcupados = 0;

            for (int i = 0; i < vuelos.GetLength(1); i++)
            {
                if (vuelos[flightNumber, i] == 0)
                    asientosDisponibles++;
                else
                    asientosOcupados++;
            }

            Console.WriteLine("Vuelo " + flightNumber + " - Asientos disponibles: " + asientosDisponibles + ", Asientos ocupados: " + asientosOcupados);
        }
        else
        {
            Console.WriteLine("Número de vuelo inválido.");
        }
    }

    static void SearchSeat(int[,] vuelos)
    {
        Console.WriteLine("Ingrese el número de vuelo (0-4): ");
        int flightNumber = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el número de asiento para verificar su disponibilidad (0-59): ");
        int seatNumber = int.Parse(Console.ReadLine());

        if (flightNumber >= 0 && flightNumber < vuelos.GetLength(0) && seatNumber >= 0 && seatNumber < vuelos.GetLength(1))
        {
            string status = vuelos[flightNumber, seatNumber] == 0 ? "disponible" : "ocupado";
            Console.WriteLine("Asiento " + seatNumber + " en vuelo " + flightNumber + " está " + status + ".");
        }
        else
        {
            Console.WriteLine("Número de asiento o vuelo inválido.");
        }
    }
}
