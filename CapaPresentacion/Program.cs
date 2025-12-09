//Nombre: Cesar Alexis Peñuelas Cardenas
//NumControl: 22210335
//Examen Unidad 4 y 5 – Patrones de Diseño (Object Pool, Singleton, State, Facade)

using EquiposObjectPool.CapaAplicacion; 

namespace EquiposObjectPool.CapaPresentacion 
{
    class Program
    {
        static void Main(string[] args)
        {
            var sistema = new SistemaEquiposFacade();
            bool salir = false;

            while (!salir)
            {
                sistema.MostrarEstatus();

                Console.WriteLine("Seleccione una opción:");
                Console.WriteLine("1. Ocupar equipo");
                Console.WriteLine("2. Liberar equipo");
                Console.WriteLine("3. Salir");
                Console.Write("Opción: ");

                string opcion = Console.ReadLine();
                Console.WriteLine();

                switch (opcion)
                {
                    case "1":
                        Console.Write("Número de equipo a ocupar: ");
                        int num1 = int.Parse(Console.ReadLine());
                        Console.Write("Nombre de persona: ");
                        string cliente = Console.ReadLine();
                        sistema.OcuparEquipo(num1, cliente);
                        break;

                    case "2":
                        Console.Write("Número de equipo a liberar: ");
                        int num2 = int.Parse(Console.ReadLine());
                        sistema.LiberarEquipo(num2);
                        break;

                    case "3":
                        salir = true;
                        break;

                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }

                Console.WriteLine("\nPresione una tecla para continuar...");
                Console.ReadKey();
                Console.Clear();
            }

            Console.WriteLine("Saliendo del sistema...");
        }
    }
}
