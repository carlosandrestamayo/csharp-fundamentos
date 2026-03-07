# 2. Clases en C#

En el paradigma de **Programación Orientada a Objetos**, una **clase** constituye el mecanismo fundamental para definir nuevos tipos de datos que representan entidades del dominio de un problema. En términos generales, una clase describe la estructura y el comportamiento común de un conjunto de objetos, proporcionando un modelo a partir del cual se pueden crear múltiples instancias durante la ejecución de un programa.

En el lenguaje C#, una clase es una construcción sintáctica que permite encapsular datos y operaciones dentro de una unidad lógica denominada **tipo de referencia**. Esto significa que las instancias de una clase son administradas mediante referencias a posiciones de memoria donde se almacena el objeto correspondiente.

---

## 2.1 Definición formal de una clase

Desde una perspectiva conceptual, una clase puede definirse como una abstracción que especifica:

- los **atributos** que describen el estado de los objetos
- los **métodos** que determinan su comportamiento
- las **reglas** de acceso a los datos
- las **relaciones** con otras clases

En este sentido, las clases permiten modelar entidades del dominio del problema mediante estructuras que integran datos y operaciones relacionadas.

Según Grady Booch, una clase representa una **descripción de un conjunto de objetos que comparten las mismas propiedades, comportamiento y relaciones con otras clases dentro de un sistema.**

---

## 2.2 Sintaxis básica de una clase en C#

En C#, una clase se define mediante la palabra reservada class, seguida del identificador que representa el nombre de la clase.

La estructura general es la siguiente:

```c#
class NombreClase
{
    // atributos
    // constructores
    // métodos
}

```

Los elementos que pueden formar parte de una clase incluyen:

- atributos o campos
- propiedades
- constructores
- métodos
- clases internas

En el contexto introductorio de la programación orientada a objetos, los componentes más relevantes son los **atributos, constructores y métodos**.

### Definición simple de una clase

El siguiente ejemplo muestra la definición de una clase que representa una persona.
```c#
class Persona
{
    public string nombre;
    public int edad;
}

```
En este ejemplo, la clase Persona define dos atributos:

- `nombre`
- `edad`

Estos atributos representan el **estado de los objetos** que serán creados a partir de esta clase.

### Clase con atributos y métodos

Las clases no solo almacenan datos, sino que también definen el comportamiento de los objetos mediante métodos.

El siguiente ejemplo muestra una clase que incluye atributos y un método.

```c#
class Persona
{
    public string nombre;
    public int edad;

    public void Saludar()
    {
        Console.WriteLine("Hola, mi nombre es " + nombre);
    }
}
```

En este caso, el método `Saludar()` permite que el objeto muestre un mensaje utilizando el valor almacenado en el atributo `nombre.`

### Uso de la clase para crear objetos

Una vez definida la clase, es posible crear objetos a partir de ella.

```c#
class Program
{
    static void Main()
    {
        Persona p1 = new Persona();

        p1.nombre = "Ana";
        p1.edad = 25;

        p1.Saludar();
    }
}
```

En este ejemplo se realiza lo siguiente:

1. Se crea un objeto de la clase `Persona`.
2. Se asignan valores a los atributos del objeto.
3. Se invoca el método `Saludar().`

### 2.5 Múltiples objetos a partir de una clase

Una característica fundamental de las clases es que permiten crear múltiples objetos independientes.

```
class Program
{
    static void Main()
    {
        Persona p1 = new Persona();
        Persona p2 = new Persona();

        p1.nombre = "Carlos";
        p2.nombre = "Laura";

        p1.Saludar();
        p2.Saludar();
    }
}
```
En este ejemplo, aunque ambos objetos pertenecen a la misma clase, cada uno posee su propio estado.

----

## 2.3 Clases como tipos de datos

En C#, las clases permiten definir tipos de datos definidos por el usuario. A diferencia de los tipos primitivos (como `int`, `double` o `bool`), una clase puede contener múltiples variables y operaciones relacionadas entre sí.

Por ejemplo, una clase puede representar una entidad como:

- un estudiante
- una cuenta bancaria
- un vehículo
- un producto

Cada una de estas entidades puede describirse mediante atributos que representan su estado y métodos que definen su comportamiento.

Desde el punto de vista del modelo de memoria, las clases en C# pertenecen a la categoría de **tipos de referencia**, lo que implica que las variables que almacenan objetos contienen referencias a las direcciones de memoria donde se encuentra almacenado el objeto.

---

## 2.4 Componentes de una clase

Una clase en C# está compuesta por diferentes elementos que permiten definir tanto la estructura como el comportamiento de los objetos.

### Atributos

Los atributos (también llamados campos) representan las variables que almacenan el estado de un objeto.

Estos atributos describen las características de la entidad modelada por la clase.

Ejemplo conceptual:

```text
Clase: Estudiante

Atributos:
nombre
edad
codigo

```

### Métodos

Los métodos son funciones definidas dentro de una clase que describen el comportamiento de los objetos.

A través de los métodos es posible:

- modificar el estado de un objeto
- realizar cálculos
- ejecutar acciones asociadas con la entidad representada

### Constructores

Los constructores son métodos especiales que se utilizan para inicializar los objetos en el momento de su creación.

Un constructor tiene las siguientes características:

- posee el mismo nombre que la clase
- no tiene tipo de retorno
- se ejecuta automáticamente cuando se crea una instancia de la clase

---

## 2.5 Visibilidad y modificadores de acceso

Las clases y sus miembros pueden controlar el nivel de acceso mediante modificadores de acceso, los cuales determinan desde qué partes del programa se pueden utilizar.

Los modificadores más comunes en C# son:

| Modificador | Descripción                                        |
| ----------- | -------------------------------------------------- |
| public      | accesible desde cualquier parte del programa       |
| private     | accesible únicamente dentro de la clase            |
| protected   | accesible dentro de la clase y en clases derivadas |
| internal    | accesible dentro del mismo ensamblado              |

El uso adecuado de estos modificadores permite implementar el principio de **encapsulamiento**, protegiendo la integridad de los datos y controlando su manipulación.

---

## 2.6 Clases como mecanismo de modelado

En el contexto del diseño de software, las clases constituyen una herramienta fundamental para representar las entidades del dominio del problema.

El proceso de diseño orientado a objetos generalmente implica:

1. Identificar las entidades relevantes del sistema
2. Definir las clases que representan dichas entidades
3. Establecer los atributos que describen su estado
4. Definir los métodos que modelan su comportamiento

Este proceso suele apoyarse en herramientas de modelado como los diagramas de clases del **Unified Modeling Language**, ampliamente utilizados en la ingeniería de software para representar estructuras orientadas a objetos.

---