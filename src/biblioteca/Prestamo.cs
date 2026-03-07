class Prestamo
{
    private Libro libroPrestado { get; set; }
    private Usuario usuario { get; set; }

    public Prestamo(Libro libroPrestado, Usuario usuario)
    {
        this.libroPrestado = libroPrestado;
        this.usuario = usuario;
    }

    public void MostrarPrestamo()
    {
        Console.WriteLine("Préstamo realizado:");
        Console.WriteLine(this.usuario.Nombre + " tomó prestado el libro.");
    }
}