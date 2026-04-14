// Se crea una instancia de la clase Biblioteca
// Esta clase probablemente gestiona una colección de libros
Biblioteca biblioteca = new Biblioteca();

// Se crean dos objetos de tipo Libro con título y autor
Libro libro1 = new Libro("C# Básico", "Juan Pérez");
Libro libro2 = new Libro("Programación Orientada a Objetos", "Ana Gómez");

// Se agregan los libros creados a la biblioteca
// Aquí la biblioteca almacena internamente estos objetos
biblioteca.AgregarLibro(libro1);
biblioteca.AgregarLibro(libro2);

// Se muestran todos los libros registrados en la biblioteca
// Probablemente recorre una lista interna e imprime cada libro
biblioteca.MostrarLibros();

// Se crea un usuario que realizará un préstamo
Usuario usuario = new Usuario("Carlos");

// Se crea un préstamo asociando un libro con un usuario
// Esto representa que el usuario toma prestado el libro1
Prestamo prestamo = new Prestamo(libro1, usuario);

// Se muestra la información del préstamo
// Ejemplo: qué libro fue prestado y a quién
prestamo.MostrarPrestamo();






