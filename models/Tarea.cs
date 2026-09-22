public class Tarea
{
    public string Titulo { get; set; }
    public bool Completada { get; set; }

    public Tarea(string titulo)
    {
        Titulo = titulo;
        Completada = false;
    }
}   