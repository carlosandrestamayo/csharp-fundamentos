# 8. Ejemplo completo en C#

En esta sección se presenta un ejemplo completo de un pequeño **sistema de biblioteca** desarrollado en **C#**, aplicando conceptos de **Programación Orientada a Objetos.**

---

## 8.1 Clase Libro

La clase Libro representa un libro dentro de la biblioteca.

```
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
```

En esta clase:

- Los atributos se declaran como **propiedades privadas.**
- Se utiliza `this` para referirse a los atributos del objeto actual.

---

## 8.2 Clase Usuario

La clase Usuario representa a una persona registrada en la biblioteca.

```
class Usuario
{
    private string nombre;
    
    public string Nombre
    {
        get { return this.nombre; }
        set { this.nombre = value; }
    }

    public Usuario(string nombre)
    {
        this.nombre = nombre;
    }

    public void MostrarUsuario()
    {
        Console.WriteLine("Usuario: " + this.nombre);
    }
}
```

Cada usuario tiene un nombre que se almacena en una propiedad privada.

---

## 8.3 Clase Prestamo

La clase **Prestamo** representa el préstamo de un libro a un usuario.

```
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
```

Esta clase establece una **relación entre las clases Libro y Usuario**, representando el préstamo.

---

## 8.4 Clase Biblioteca

La clase **Biblioteca** administra los libros disponibles.

```
using System.Collections.Generic;

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
```

En esta clase se utiliza una **lista de libros** para almacenar múltiples objetos.

---

## 8.5 Programa principal

El programa principal utiliza todas las clases creadas anteriormente.

```
class Program
{
    static void Main()
    {
        Biblioteca biblioteca = new Biblioteca();

        Libro libro1 = new Libro("C# Básico", "Juan Pérez");
        Libro libro2 = new Libro("Programación Orientada a Objetos", "Ana Gómez");

        biblioteca.AgregarLibro(libro1);
        biblioteca.AgregarLibro(libro2);

        biblioteca.MostrarLibros();

        Usuario usuario = new Usuario("Carlos");

        Prestamo prestamo = new Prestamo(libro1, usuario);

        prestamo.MostrarPrestamo();
    }
}
```
---

## 8.6 Resultado

```
Título: C# Básico
Autor: Juan Pérez
Disponible: True
----------------
Título: Programación Orientada a Objetos
Autor: Ana Gómez
Disponible: True
----------------
Préstamo realizado:
Carlos tomó prestado el libro.
```
----

## 8.7 Conceptos aplicados

Este ejemplo permite observar varios conceptos fundamentales de la **Programación Orientada a Objetos:**

| Concepto                | Aplicación                           |
| ----------------------- | ------------------------------------ |
| Clases                  | Libro, Usuario, Prestamo, Biblioteca |
| Objetos                 | libro1, libro2, usuario              |
| Encapsulamiento         | propiedades privadas                 |
| `get` y `set`           | acceso controlado a atributos        |
| `this`                  | referencia al objeto actual          |
| Relaciones entre clases | préstamo entre usuario y libro       |
| Colecciones             | lista de libros                      |

Según **Grady Booch**, la interacción entre objetos bien definidos permite desarrollar sistemas más organizados, reutilizables y fáciles de mantener.

---