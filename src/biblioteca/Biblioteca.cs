// Clase que representa una biblioteca
// Se encarga de almacenar y gestionar una colección de libros
class Biblioteca
{
    // Lista privada de libros (encapsulamiento)
    // Solo la clase Biblioteca puede modificarla directamente
    private List<Libro> libros { get; set; }

    // Constructor: inicializa la lista de libros vacía
    public Biblioteca()
    {
        this.libros = new List<Libro>();
    }

    // Método para agregar un libro a la biblioteca
    public void AgregarLibro(Libro libro)
    {
        this.libros.Add(libro);
    }

    // Método para mostrar todos los libros almacenados
    public void MostrarLibros()
    {
        // Recorre cada libro de la lista
        foreach (Libro libro in this.libros)
        {
            // Llama al método del libro para mostrar su información
            libro.MostrarLibro();

            // Separador visual en consola
            Console.WriteLine("----------------");
        }
    }
}
