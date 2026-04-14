// Clase que representa un préstamo de un libro a un usuario
class Prestamo
{
    // Libro que se presta
    private Libro libroPrestado { get; set; }

    // Usuario que realiza el préstamo
    private Usuario usuario { get; set; }

    // Constructor: recibe el libro y el usuario
    public Prestamo(Libro libroPrestado, Usuario usuario)
    {
        this.libroPrestado = libroPrestado;
        this.usuario = usuario;
    }

    // Método para mostrar la información del préstamo
    public void MostrarPrestamo()
    {
        Console.WriteLine("Préstamo realizado:");

        // Se muestra el nombre del usuario que tomó el libro
        Console.WriteLine(this.usuario.Nombre + " tomó prestado el libro");
    }
}
