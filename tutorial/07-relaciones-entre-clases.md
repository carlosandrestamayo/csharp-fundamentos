# 7. Relaciones entre clases en Programación Orientada a Objetos

En la **Programación Orientada a Objetos** (POO), las clases rara vez existen de forma aislada. En la mayoría de los sistemas, las clases interactúan y se relacionan entre sí para modelar situaciones del mundo real.

Las relaciones entre clases permiten representar cómo los objetos **colaboran, dependen o forman parte unos de otros** dentro de un sistema de software. En el lenguaje **C#**, estas relaciones se implementan mediante referencias entre objetos.

Entre las relaciones más comunes se encuentran:

- Asociación
- Agregación
- Composición
- Dependencia

Estas relaciones también se representan gráficamente mediante **diagramas UML**, ampliamente utilizados en el diseño de software.

## 7.1 Asociación

La **asociación** es una relación básica entre dos clases donde un objeto **utiliza o interactúa con otro**, pero ambos pueden existir de manera independiente.

Por ejemplo, un **estudiante** puede estar asociado a un **curso**, pero ambos pueden existir por separado.

Ejemplo 7.1 Asociación entre clases

```
class Curso
{
    public string Nombre { get; set; }
}

class Estudiante
{
    public string Nombre { get; set; }
    public Curso CursoInscrito { get; set; }
}
```

Uso de las clases:

```
class Program
{
    static void Main()
    {
        Curso curso = new Curso();
        curso.Nombre = "Programación Orientada a Objetos";

        Estudiante estudiante = new Estudiante();
        estudiante.Nombre = "Carlos";
        estudiante.CursoInscrito = curso;

        Console.WriteLine(estudiante.Nombre + " está inscrito en " + estudiante.CursoInscrito.Nombre);
    }
}
```

En este ejemplo, la clase **Estudiante** mantiene una referencia a la clase **Curso**, representando una asociación entre ambas.

## 7.2 Agregación

La **agregación** es una forma especial de asociación en la que una clase **contiene o agrupa objetos de otra clase**, pero estos pueden existir de forma independiente.

Por ejemplo, un **departamento** puede tener varios **profesores**, pero los profesores pueden existir sin pertenecer necesariamente a ese departamento.

Ejemplo 7.2 Agregación

```
using System.Collections.Generic;

class Profesor
{
    public string Nombre { get; set; }
}

class Departamento
{
    public List<Profesor> Profesores { get; set; }

    public Departamento()
    {
        Profesores = new List<Profesor>();
    }
}
```

Uso de las clases:

```
class Program
{
    static void Main()
    {
        Profesor p1 = new Profesor { Nombre = "Ana" };
        Profesor p2 = new Profesor { Nombre = "Luis" };

        Departamento departamento = new Departamento();

        departamento.Profesores.Add(p1);
        departamento.Profesores.Add(p2);

        foreach (Profesor p in departamento.Profesores)
        {
            Console.WriteLine(p.Nombre);
        }
    }
}
```

En este caso, el **Departamento** contiene profesores, pero los objetos **Profesor** pueden existir independientemente.

---

## 7.3 Composición

La **composición** es una relación más fuerte que la agregación. En este caso, una clase **posee completamente a otra**, y la existencia del objeto contenido depende del objeto principal.

Si el objeto principal se destruye, los objetos que lo componen también desaparecen.

Un ejemplo común es **una casa y sus habitaciones**.

Ejemplo 7.3 Composición

```
class Motor
{
    public void Encender()
    {
        Console.WriteLine("Motor encendido");
    }
}

class Auto
{
    private Motor motor;

    public Auto()
    {
        motor = new Motor();
    }

    public void EncenderAuto()
    {
        motor.Encender();
    }
}
```

Uso de las clases:

```
class Program
{
    static void Main()
    {
        Auto auto = new Auto();

        auto.EncenderAuto();
    }
}
```

En este ejemplo, el **Motor** se crea dentro de la clase **Auto**, lo que significa que su existencia depende directamente del objeto **Auto.**

---

## 7.4 Dependencia

La **dependencia** ocurre cuando una clase **utiliza temporalmente otra clase**, generalmente como parámetro de un método.

Esto indica que un cambio en una clase podría afectar a la otra.

Ejemplo 7.4 Dependencia

```
class Calculadora
{
    public int Sumar(int a, int b)
    {
        return a + b;
    }
}

class Reporte
{
    public void MostrarResultado(Calculadora calc)
    {
        int resultado = calc.Sumar(5, 3);
        Console.WriteLine("Resultado: " + resultado);
    }
}
```

Uso de las clases:

```
class Program
{
    static void Main()
    {
        Calculadora calculadora = new Calculadora();

        Reporte reporte = new Reporte();
        reporte.MostrarResultado(calculadora);
    }
}
```

En este caso, la clase **Reporte** depende de **Calculadora** para realizar una operación específica.

---

## 7.5 Importancia de las relaciones entre clases

Las relaciones entre clases permiten construir sistemas complejos mediante la interacción de múltiples objetos. Su correcta aplicación facilita:

- Modelar situaciones del mundo real
- Mejorar la organización del código
- Promover la reutilización de componentes
- Facilitar el mantenimiento del software

Según **Grady Booch**, el diseño adecuado de las relaciones entre clases es un elemento clave en la construcción de sistemas orientados a objetos robustos y escalables.

---