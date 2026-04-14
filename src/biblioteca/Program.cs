// Punto de entrada del programa
// Aquí se ejecuta toda la lógica principal del sistema
class Program
{
    static void Main(string[] args)
    {
        // Se crea una instancia de la biblioteca
        // Esta contendrá y gestionará los libros
        Biblioteca biblioteca = new Biblioteca();

        // Se crean dos libros con su título y autor
        Libro libro1 = new Libro("C# Básico", "Juan Pérez");
        Libro libro2 = new Libro("Programación Orientada a Objetos", "Ana Gómez");

        // Se agregan los libros a la biblioteca
        // Internamente se almacenan en una lista
        biblioteca.AgregarLibro(libro1);
        biblioteca.AgregarLibro(libro2);

        // Se muestran todos los libros disponibles en la biblioteca
        // Recorre la lista e imprime cada uno
        biblioteca.MostrarLibros();

        // Se crea un usuario que realizará un préstamo
        Usuario usuario = new Usuario("Carlos");

        // Se crea un préstamo asociando un libro con un usuario
        // Representa que el usuario toma prestado el libro1
        Prestamo prestamo = new Prestamo(libro1, usuario);

        // Se muestra la información del préstamo realizado
        prestamo.MostrarPrestamo();
    }
}
