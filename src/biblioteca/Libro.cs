// Clase que representa un libro
class Libro
{
    // Atributos privados (encapsulados)
    private string titulo { get; set; }
    private string autor { get; set; }
    private bool disponible { get; set; }

    // Constructor: inicializa los datos del libro
    public Libro(string titulo, string autor)
    {
        this.titulo = titulo;
        this.autor = autor;

        // Por defecto el libro está disponible
        this.disponible = true;
    }

    // Método para mostrar la información del libro
    public void MostrarLibro()
    {
        Console.WriteLine("Título: " + this.titulo);
        Console.WriteLine("Autor: " + this.autor);
        Console.WriteLine("Disponible: " + this.disponible);
    }
}
