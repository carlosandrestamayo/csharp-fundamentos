# 6. Encapsulamiento en C#

El **encapsulamiento** es uno de los principios fundamentales de la **Programación Orientada a Objetos** (POO). Este principio establece que los datos de un objeto deben mantenerse **protegidos y accesibles únicamente a través de mecanismos controlados**, evitando el acceso directo desde otras partes del programa.

En el lenguaje C#, el encapsulamiento se implementa mediante el uso de **modificadores de acceso y propiedades**, que permiten controlar cómo se accede y se modifica la información almacenada en los atributos de una clase.

El objetivo principal del encapsulamiento es **garantizar la integridad de los datos**, restringiendo las modificaciones directas y proporcionando métodos controlados para interactuar con el estado del objeto.

## 6.1 Modificadores de acceso

Los modificadores de acceso permiten definir el nivel de visibilidad de los atributos y métodos de una clase. Estos determinan desde qué partes del programa es posible acceder a dichos elementos.

En C#, los modificadores más utilizados son:

| Modificador | Descripción                                        |
| ----------- | -------------------------------------------------- |
| public      | accesible desde cualquier parte del programa       |
| private     | accesible únicamente dentro de la clase            |
| protected   | accesible dentro de la clase y en clases derivadas |
| internal    | accesible dentro del mismo ensamblado              |

En el diseño orientado a objetos se recomienda que los atributos sean **privados**, permitiendo su acceso únicamente mediante métodos o propiedades.

---

## 6.2 Problema del acceso directo a los atributos

Cuando los atributos de una clase se definen como **públicos**, cualquier parte del programa puede modificarlos libremente, lo que puede provocar inconsistencias en el estado del objeto.

Ejemplo 6.1 Clase sin encapsulamiento

```
class CuentaBancaria
{
    public double saldo;
}

```
Uso de la clase:

```
class Program
{
    static void Main()
    {
        CuentaBancaria cuenta = new CuentaBancaria();

        cuenta.saldo = -5000;

        Console.WriteLine(cuenta.saldo);
    }
}
```
En este caso, el programa permite asignar un valor negativo al saldo, lo cual podría ser inválido dentro de la lógica del sistema.

Este tipo de situaciones evidencia la necesidad de **proteger los atributos mediante encapsulamiento.**

---

## 6.3 Uso de atributos privados

El encapsulamiento se logra definiendo los atributos como privados y proporcionando métodos que controlen el acceso a dichos datos.

Ejemplo 6.3 Encapsulamiento mediante métodos

```
class CuentaBancaria
{
    private double saldo;

    public void Depositar(double cantidad)
    {
        this.saldo += cantidad;
    }

    public double ConsultarSaldo()
    {
        return this.saldo;
    }
}
```

Uso de la clase:

```
class Program
{
    static void Main()
    {
        CuentaBancaria cuenta = new CuentaBancaria();

        cuenta.Depositar(1000);

        Console.WriteLine("Saldo: " + cuenta.ConsultarSaldo());
    }
}
```

En este ejemplo, el atributo saldo no puede ser modificado directamente desde el exterior, lo que garantiza un mayor control sobre su valor.

---

## 6.4 Propiedades (Properties)

En C#, el encapsulamiento se implementa comúnmente mediante propiedades, que permiten controlar el acceso a los atributos mediante los métodos especiales `get` y `set.`

Las propiedades permiten:

- Leer el valor de un atributo
- Modificar su valor bajo ciertas condiciones

Ejemplo 6.4 Propiedad con `get` y `set.`

```
class Persona
{
    private int edad;

    public int Edad
    {
        get { return this.edad; }
        set
        {
            if (value >= 0)
            {
                this.edad = value;
            }
        }
    }
}
```

Uso de la propiedad:

```
class Program
{
    static void Main()
    {
        Persona p = new Persona();

        p.Edad = 25;

        Console.WriteLine("Edad: " + p.Edad);
    }
}
```

En este caso, la propiedad `Edad` controla la asignación del atributo, evitando valores negativos.

---

## 6.5 Propiedades automáticas

El lenguaje C# también permite utilizar propiedades automáticas, las cuales simplifican la definición de atributos encapsulados.

Ejemplo 6.5 Propiedad automática

```
class Estudiante
{
    public string Nombre { get; set; }
    public int Edad { get; set; }
}
```

Uso de la clase:

```
class Program
{
    static void Main()
    {
        Estudiante e = new Estudiante();

        e.Nombre = "Ana";
        e.Edad = 20;

        Console.WriteLine(e.Nombre);
    }
}
```
Las propiedades automáticas permiten mantener el encapsulamiento con una sintaxis más sencilla.

---

## 6.6 Beneficios del encapsulamiento

El uso del encapsulamiento aporta diversas ventajas en el diseño de software:

- Protege la integridad de los datos
- Evita modificaciones incorrectas en el estado de los objetos
- Mejora la modularidad del sistema
- Facilita el mantenimiento del software

Según Bertrand Meyer, el encapsulamiento constituye uno de los mecanismos fundamentales para garantizar la robustez y confiabilidad de los sistemas orientados a objetos.

---