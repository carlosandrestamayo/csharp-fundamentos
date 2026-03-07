class Libro
{
    private string titulo { get; set; }
    private string autor { get; set; }
    private bool disponible { get; set; }

    public Libro(string titulo, string autor)
    {
        this.titulo = titulo;
        this.autor = autor;
        this.disponible = true;
    }

    public void MostrarLibro()
    {
        Console.WriteLine("Título: " + this.titulo);
        Console.WriteLine("Autor: " + this.autor);
        Console.WriteLine("Disponible: " + this.disponible);
    }
}