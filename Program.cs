List<Tarea> tareas = new List<Tarea>();

while (true)
{
    Console.WriteLine("====Gestor de Tareas====");
    Console.WriteLine("1. Agregar una tarea");
    Console.WriteLine("2. Listar tareas");
    Console.WriteLine("3. Marcar tarea como completada");
    Console.WriteLine("4. Eliminar tarea");
    Console.WriteLine("5. Salir");

    Console.Write("Elige una opcion: ");
    string opcion = Console.ReadLine();
    
    switch (opcion)
    {
        case "1":
            Console.Write("Titulo de la tarea: ");
            string? titulo = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(titulo))
            {
                Console.WriteLine("El titulo no puede estar vacio.");
                break;
            }

            tareas.Add(new Tarea(titulo));
            Console.WriteLine($"Tarea agregada correctamente. Total de tareas: {tareas.Count}");
            break;

        case "2":
            if (tareas.Count == 0)
            {
                Console.WriteLine("No hay tareas registradas.");
                break;
            }

            Console.WriteLine("--- Lista de tareas ---");
            for (int i = 0; i < tareas.Count; i++)
            {
                string estado = tareas[i].Completada ? "[x]" : "[ ]";
                Console.WriteLine($"{i+1}. {estado} {tareas[i].Titulo}");
            }
            break;

        case "3":
            Console
            .WriteLine("Aqui ira: marcar tarea como completada");
            break;

        case "4":
            Console.WriteLine("Aqui ira: eliminar tarea");
            break;

        case "5":
            Console.WriteLine("¡Hasta luego!");
            return;
            
        default:
            Console.WriteLine("Opcion invalida. Elige un numero del 1 al 5. ");
            break;  
    }
}