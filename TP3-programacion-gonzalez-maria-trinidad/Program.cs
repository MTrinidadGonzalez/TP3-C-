using System;

class Program 
{
    static void Main() 
    {


        Console.WriteLine("Presione:" +
            "\n- 1 Para crear un vuelo." +
            "\n- 2 para reservar un vuelo." +
            "\n- 3 Para cancelar un vuelo." +
            "\n- 4 Para ver asientos disponibles y ocupados." +
            "\n- 5 Para ver cantidad de asientos disponibles y ocupados." +
            "\n- 6 Para ver disponibilidad de un asiento en particular." +
            "\n- 7 Para cancelar la operación.");

        int user_option = int.Parse(Console.ReadLine());

        int[] vuelo = new int[60];

        switch (user_option)
        {
            case 1:
                CreateAirplaneFlight();
                break;
            case 2:
                MakeAreservation(vuelo);
                break;
            case 3:
                CancelFlight(vuelo);
                break;
            case 4:
                ShowOccupiedAvailableSeats(vuelo);
                break;
            case 5:
                OccupiedAvailableSeatsCount(vuelo);
                break;
            case 6:
                SearchSeat(vuelo);
                break;
            case 7:
                Console.WriteLine("Cancelar operación.");
                break;
            default:
                Console.WriteLine("Opción no válida.");
                break;
        }

        //cierre del main function
    }

    static void CreateAirplaneFlight()
    {
        Console.WriteLine("Vuelo creado");
        // cierre de create airplane flight
    }

    static void MakeAreservation(int[] vuelo)
    {

        Console.WriteLine(" Ingrese el número del asiento (0 a 59):");
        int numeroVuelo = int.Parse(Console.ReadLine());

    //Console.WriteLine("El valor de ese vuelo" + vuelo[numeroVuelo]);

        if (numeroVuelo >= 0 && numeroVuelo < vuelo.Length)
        {
            if (vuelo[numeroVuelo] == 0) 
            {
                vuelo[numeroVuelo] = 1;
                Console.WriteLine("El vuelo en la posición " + numeroVuelo + " ha sido reservado exitosamente!");
           //   Console.WriteLine("El valor de ese vuelo" + vuelo[numeroVuelo]);
            }
            else if (vuelo[numeroVuelo] == 1)
            {
                Console.WriteLine("El asiento en la posición " + numeroVuelo + " ya está ocupado,"
                + " los espacios disponibles son en las butacas: ");
                for(int i = 0; i < vuelo.Length; i++)
                {
                   if (vuelo[i] == 0)
                    {
                        Console.WriteLine("Butaca " + vuelo[i] + "disponible");

                    }
                }
                Console.WriteLine(" En base a la información dada, ingrese un núevo número de reserva");
                int numeroNuevo = int.Parse(Console.ReadLine());
                if (vuelo[numeroVuelo] == 0)
                {
                    vuelo[numeroVuelo] = 1;
                    Console.WriteLine("El vuelo en la posición " + numeroVuelo + " ha sido reservado exitosamente");
                    //   Console.WriteLine("El valor de ese vuelo" + vuelo[numeroVuelo]);
                }
            }
        }
        else
        {
            Console.WriteLine("Número de asiento no válido. Ingrese un número entre 0 y 59.");
        }


        // cierre de MakeAreservation
    }

    static void CancelFlight(int[] vuelo)
    {
        Console.WriteLine("Ingrese el número de butaca que desea cancelar");
        int butacaAcancelar = int.Parse(Console.ReadLine());
        vuelo[butacaAcancelar] = 0;
        Console.WriteLine("Cancelo su vuelo exitosamente.");
        // cierre de  CancelFlight
    }

    static void ShowOccupiedAvailableSeats(int[] vuelo)
    {
        for (int i = 0; i <vuelo.Length ; i++)
        {
            if (vuelo[i] == 0 )
            {
                Console.WriteLine("Asiento: " + i+ " disponible.");
            }
            else if (vuelo[i] == 1 )
            {
                Console.WriteLine("Asiento: " + i+ " ocupado.");
            }
        }

        // cierre de ShowOccupiedAvailableSeats
    }

    static void OccupiedAvailableSeatsCount(int[] vuelo)
    {
        int asientosDisponibles = 0;
        int asientosOcupados = 0;

        for (int i = 0; i <vuelo.Length ;i++) 
        {
             if (vuelo[i] == 0)
                 {
                     asientosDisponibles++;
                 }
             else if (vuelo[i] == 1) 
                 {
                     asientosOcupados++;
                 }
        }
        Console.WriteLine("Asientos disponibles: " + asientosDisponibles);
        Console.WriteLine("Cantidad de asientos ocupados: " + asientosOcupados);
        // cierre de  OccupiedAvailableSeatsCount
    }

    static void SearchSeat(int[] vuelo)
    {
        Console.WriteLine("Ingrese el número de butaca que desea conocer su disponibilidad.");
        int searchUserSeat = int.Parse(Console.ReadLine());

        if (vuelo[searchUserSeat] == 0)
        {

            Console.WriteLine("Butaca disponible.");
        }
        else if (vuelo[searchUserSeat] == 1)
        {

            Console.WriteLine("Butaca ocupada.");
        }
        //cierre del SearchSeat
    }

    //cierre de la clase program
}