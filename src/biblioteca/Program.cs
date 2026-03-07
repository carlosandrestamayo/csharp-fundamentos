Biblioteca biblioteca = new Biblioteca();

Libro libro1 = new Libro("C# Básico", "Juan Pérez");
Libro libro2 = new Libro("Programación Orientada a Objetos", "Ana Gómez");

biblioteca.AgregarLibro(libro1);
biblioteca.AgregarLibro(libro2);

biblioteca.MostrarLibros();

Usuario usuario = new Usuario("Carlos");
Prestamo prestamo = new Prestamo(libro1, usuario);

prestamo.MostrarPrestamo();






