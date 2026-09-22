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
            Console.WriteLine("Aqui ira: agregar tarea");
            break;

        case "2":
            Console.WriteLine("Aqui ira: Listar tareas");
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