# 5. Constructores en C#

En la **Programación Orientada a Objetos**, los objetos generalmente necesitan ser **inicializados** cuando son creados. Para este propósito, las clases utilizan **constructores**, que son métodos especiales encargados de establecer el estado inicial de los objetos.

En el lenguaje C#, un **constructor** es un método especial que se ejecuta automáticamente cuando se crea una instancia de una clase. Su función principal es inicializar los atributos del objeto y garantizar que el objeto comience su ciclo de vida en un estado válido.

---

## 5.1 Características de los constructores

Los constructores poseen las siguientes características:

- Tienen el mismo **nombre que la clase**
- **No poseen tipo de retorno**
- se ejecutan automáticamente cuando se crea un objeto
- Pueden recibir **parámetros**
- Permiten inicializar los atributos del objeto

Los constructores contribuyen a mejorar la consistencia del estado de los objetos, evitando que estos se creen con valores indefinidos o incorrectos.

---

## 5.2 Constructor por defecto

Un constructor por defecto es un constructor que no recibe parámetros.

Si el programador no define ningún constructor en una clase, el compilador de C# genera automáticamente un constructor vacío.

Ejemplo 5.1 Constructor por defecto

```
class Persona
{
    public string nombre;
    public int edad;

    public Persona()
    {
        nombre = "Sin nombre";
        edad = 0;
    }
}

```

En este ejemplo se define un constructor que inicializa los atributos con valores predeterminados.

**Uso del constructor**

```
class Program
{
    static void Main()
    {
        Persona p1 = new Persona();

        Console.WriteLine("Nombre: " + p1.nombre);
        Console.WriteLine("Edad: " + p1.edad);
    }
}
```

Cuando se crea el objeto `p1`, el constructor se ejecuta automáticamente.

---

## 5.3 Constructores con parámetros

En muchos casos es necesario inicializar los objetos con valores específicos al momento de su creación. Para ello se utilizan **constructores parametrizados.**

Estos constructores reciben valores como argumentos y los asignan a los atributos correspondientes.

Ejemplo 5.2 Constructor con parámetros

```
class Persona
{
    public string nombre;
    public int edad;

    public Persona(string nombre, int edad)
    {
        this.nombre = nombre;
        this.edad = edad;
    }
}
```

En este caso, el constructor recibe dos parámetros que se utilizan para inicializar los atributos del objeto.

La palabra clave `this` permite diferenciar los atributos de la clase de los parámetros del constructor.

**Uso del constructor con parámetros**

```
class Program
{
    static void Main()
    {
        Persona p1 = new Persona("Carlos", 22);
        Persona p2 = new Persona("Laura", 25);

        Console.WriteLine(p1.nombre);
        Console.WriteLine(p2.nombre);
    }
}

```
Cada objeto creado puede recibir valores distintos durante su inicialización.

---

## 5.4 Sobrecarga de constructores

La **sobrecarga de constructores** permite definir múltiples constructores dentro de una misma clase, siempre que tengan diferentes **listas de parámetros.**

Esto proporciona mayor flexibilidad al momento de crear objetos.

Ejemplo 5.3 Sobrecarga de constructores

```
class Estudiante
{
    public string nombre;
    public int edad;

    public Estudiante()
    {
        nombre = "No registrado";
        edad = 0;
    }

    public Estudiante(string nombre)
    {
        this.nombre = nombre;
        edad = 0;
    }

    public Estudiante(string nombre, int edad)
    {
        this.nombre = nombre;
        this.edad = edad;
    }
}
```

En este ejemplo se definen tres constructores distintos para inicializar los objetos de diferentes maneras.

**Uso de constructores sobrecargados**

```
class Program
{
    static void Main()
    {
        Estudiante e1 = new Estudiante();
        Estudiante e2 = new Estudiante("Ana");
        Estudiante e3 = new Estudiante("Pedro", 21);

        Console.WriteLine(e1.nombre);
        Console.WriteLine(e2.nombre);
        Console.WriteLine(e3.nombre);
    }
}
```
Cada constructor permite inicializar el objeto con distintos niveles de información.

---

## 5.5 Importancia de los constructores

El uso adecuado de constructores permite:

- Garantizar que los objetos se creen en un estado válido
- Inicializar atributos de manera consistente
- Simplificar la creación de objetos dentro del programa
- Mejorar la claridad del diseño de las clases

Los constructores constituyen un elemento fundamental en el diseño orientado a objetos, ya que controlan la fase inicial del ciclo de vida de los objetos.

---