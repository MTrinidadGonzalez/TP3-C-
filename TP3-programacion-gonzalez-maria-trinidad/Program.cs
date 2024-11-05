using System;

class Program
{
    static void Main()
    {
        int[,] vuelos = new int[5, 60]; 

        int userOption;
        do
        {
            Console.WriteLine("\nPresione:" +
                "\n- 1 Para crear un vuelo." +
                "\n- 2 para reservar un vuelo." +
                "\n- 3 Para cancelar un vuelo." +
                "\n- 4 Para ver asientos disponibles y ocupados." +
                "\n- 5 Para ver cantidad de asientos disponibles y ocupados." +
                "\n- 6 Para ver disponibilidad de un asiento en particular." +
                "\n- 7 Para salir.");

            userOption = int.Parse(Console.ReadLine());

            switch (userOption)
            {
                case 1:
                    CreateAirplaneFlight(vuelos);
                    break;
                case 2:
                    vuelos = MakeAReservation(vuelos);
                    break;
                case 3:
                    vuelos = CancelFlight(vuelos);
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
                    Console.WriteLine("Operación finalizada.");
                    break;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }

        } while (userOption != 7);
    }


    static void CreateAirplaneFlight(int[,] vuelos)
    {
        Console.WriteLine("Vuelo creado exitosamente.");
    }


    static int[,] MakeAReservation(int[,] vuelos)
    {
        Console.WriteLine("Ingrese el número de vuelo (0 a 4):");
        int numVuelo = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el número del asiento (0 a 59):");
        int numAsiento = int.Parse(Console.ReadLine());

        if (numVuelo >= 0 && numVuelo < vuelos.GetLength(0) && numAsiento >= 0 && numAsiento < vuelos.GetLength(1))
        {
            if (vuelos[numVuelo, numAsiento] == 0)
            {
                vuelos[numVuelo, numAsiento] = 1;
                Console.WriteLine("Asiento reservado exitosamente.");
            }
            else
            {
                Console.WriteLine("El asiento ya está ocupado.");
            }
        }
        else
        {
            Console.WriteLine("Número de vuelo o asiento no válido.");
        }
        return vuelos;
    }

    static int[,] CancelFlight(int[,] vuelos)
    {
        Console.WriteLine("Ingrese el número de vuelo (0 a 4):");
        int numVuelo = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el número del asiento a cancelar (0 a 59):");
        int numAsiento = int.Parse(Console.ReadLine());

        if (numVuelo >= 0 && numVuelo < vuelos.GetLength(0) && numAsiento >= 0 && numAsiento < vuelos.GetLength(1))
        {
            if (vuelos[numVuelo, numAsiento] == 1)
            {
                vuelos[numVuelo, numAsiento] = 0;
                Console.WriteLine("Asiento cancelado exitosamente.");
            }
            else
            {
                Console.WriteLine("El asiento ya está libre.");
            }
        }
        else
        {
            Console.WriteLine("Número de vuelo o asiento no válido.");
        }
        return vuelos;
    }

    static void ShowOccupiedAvailableSeats(int[,] vuelos)
    {
        for (int i = 0; i < vuelos.GetLength(0); i++)
        {
            Console.WriteLine("\nEstado de los asientos en el vuelo " + i + ":");
            for (int j = 0; j < vuelos.GetLength(1); j++)
            {
                string estado = vuelos[i, j] == 0 ? "disponible" : "ocupado";
                Console.WriteLine("Asiento " + j + ": " + estado);
            }
        }
    }

    static void OccupiedAvailableSeatsCount(int[,] vuelos)
    {
        for (int i = 0; i < vuelos.GetLength(0); i++)
        {
            int disponibles = 0;
            int ocupados = 0;

            for (int j = 0; j < vuelos.GetLength(1); j++)
            {
                if (vuelos[i, j] == 0)
                    disponibles++;
                else
                    ocupados++;
            }

            Console.WriteLine("\nVuelo " + i + ":");
            Console.WriteLine("Asientos disponibles: " + disponibles);
            Console.WriteLine("Asientos ocupados: " + ocupados);
        }
    }

    static void SearchSeat(int[,] vuelos)
    {
        Console.WriteLine("Ingrese el número de vuelo (0 a 4):");
        int numVuelo = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el número del asiento (0 a 59):");
        int numAsiento = int.Parse(Console.ReadLine());

        if (numVuelo >= 0 && numVuelo < vuelos.GetLength(0) && numAsiento >= 0 && numAsiento < vuelos.GetLength(1))
        {
            string estado = vuelos[numVuelo, numAsiento] == 0 ? "disponible" : "ocupado";
            Console.WriteLine("El asiento " + numAsiento + " en el vuelo " + numVuelo + " está " + estado + ".");
        }
        else
        {
            Console.WriteLine("Número de vuelo o asiento no válido.");
        }
    }
}
