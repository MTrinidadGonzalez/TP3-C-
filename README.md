Sistema de Reservación de Vuelos
Esta aplicación en C# simula un sistema simple de reservación de vuelos. Los usuarios pueden realizar varias operaciones como crear un vuelo, reservar asientos, cancelar reservaciones y visualizar la disponibilidad de los asientos.

Funcionalidades
El sistema permite a los usuarios realizar las siguientes acciones:

-Crear un vuelo: Inicializa un nuevo vuelo (aunque esta funcionalidad es mínima en este caso).
-Reservar un asiento: Los usuarios pueden reservar un asiento específico ingresando su número.
-Cancelar una reservación: Cancela una reservación especificando el número de asiento.
-Ver asientos disponibles y ocupados: Muestra el estado de cada asiento (disponible u ocupado).
-Contar asientos disponibles y ocupados: Muestra el total de asientos disponibles y ocupados.
-Consultar disponibilidad de un asiento: Verifica si un asiento específico está disponible o ocupado.
-Cancelar la operación: Salir de la aplicación o cancelar cualquier operación en curso.


Al ejecutar el programa, el usuario debe seleccionar una opción ingresando un número del 1 al 7.
Dependiendo de la opción elegida, el programa realizará las siguientes acciones:
Opción 1: Crea un vuelo (muestra un mensaje de confirmación).
Opción 2: Reserva un asiento solicitando al usuario que ingrese un número de asiento (entre 0 y 59).
Opción 3: Cancela una reservación solicitando al usuario que ingrese el número de asiento.
Opción 4: Muestra el estado de todos los asientos (disponibles u ocupados).
Opción 5: Muestra el total de asientos disponibles y ocupados.
Opción 6: Permite al usuario verificar la disponibilidad de un asiento específico.
Opción 7: Cancela la operación actual y sale del programa.


 Código: 
int[] vuelo: Un arreglo que representa los asientos del vuelo, donde cada índice corresponde a un asiento. 0 significa disponible, 1 significa reservado.
Método Principal (Main): Muestra el menú y toma la entrada del usuario para seleccionar una acción.
Métodos:
CreateAirplaneFlight(): Método placeholder que imprime un mensaje de confirmación cuando se crea un vuelo.
MakeAreservation(int[] vuelo): Gestiona la reservación de asientos verificando si un asiento está disponible o ya reservado.
CancelFlight(int[] vuelo): Cancela una reservación configurando un asiento como disponible (0).
ShowOccupiedAvailableSeats(int[] vuelo): Recorre los asientos y muestra si están disponibles u ocupados.
OccupiedAvailableSeatsCount(int[] vuelo): Cuenta y muestra el total de asientos disponibles y ocupados.
SearchSeat(int[] vuelo): Permite a los usuarios verificar el estado (disponible u ocupado) de un asiento específico.
Requisitos
Tener instalado .NET Core o .NET Framework en tu sistema.
Un conocimiento básico sobre cómo ejecutar aplicaciones de consola en C#.
Ejecutar el Programa
Compila el programa usando el compilador de C#.
Ejecuta el programa desde la línea de comandos o desde tu IDE.
Sigue las instrucciones para interactuar con el sistema de reservación de vuelos.
