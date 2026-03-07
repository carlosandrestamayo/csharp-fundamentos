class Biblioteca
{
    private List<Libro> libros { get; set; }

    public Biblioteca()
    {
        this.libros = new List<Libro>();
    }

    public void AgregarLibro(Libro libro)
    {
        this.libros.Add(libro);
    }

    public void MostrarLibros()
    {
        foreach (Libro libro in this.libros)
        {
            libro.MostrarLibro();
            Console.WriteLine("----------------");
        }
    }
}