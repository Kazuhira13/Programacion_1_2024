internal class program
{
class Program
{
    static List<string> tareas = new List<string>();

    static void Main(string[] args)
    {
        bool continuar = true;

        while (continuar)
        {
            Console.WriteLine("\nLista de Tareas");
            Console.WriteLine("1. Mostrar tareas");
            Console.WriteLine("2. Agregar tarea");
            Console.WriteLine("3. Eliminar tarea");
            Console.WriteLine("4. Salir");
            Console.Write("Ingrese su opción: ");

            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    MostrarTareas();
                    break;
                case 2:
                    AgregarTarea();
                    break;
                case 3:
                    EliminarTarea();
                    break;
                case 4:
                    continuar = false;
                    break;
                default:
                    Console.WriteLine("Opción inválida. Intente de nuevo.");
                    break;
            }
        }
    }

    static void MostrarTareas()
    {
        Console.WriteLine("\nLista de tareas:");
        if (tareas.Count == 0)
        {
            Console.WriteLine("No hay tareas en la lista.");
        }
        else
        {
            for (int i = 0; i < tareas.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {tareas[i]}");
            }
        }
        Console.WriteLine();
    }

    static void AgregarTarea()
    {
        Console.Write("\nIngrese la nueva tarea: ");
        string tarea = Console.ReadLine();
        tareas.Add(tarea);
        Console.WriteLine("Tarea agregada correctamente.");
    }

    static void EliminarTarea()
    {
        MostrarTareas();

        if (tareas.Count > 0)
        {
            Console.Write("Ingrese el número de la tarea a eliminar: ");
            int indice = int.Parse(Console.ReadLine()) - 1;

            if (indice >= 0 && indice < tareas.Count)
            {
                tareas.RemoveAt(indice);
                Console.WriteLine("Tarea eliminada correctamente.");
            }
            else
            {
                Console.WriteLine("Opción inválida. Intente de nuevo.");
            }
        }
    }
}
}