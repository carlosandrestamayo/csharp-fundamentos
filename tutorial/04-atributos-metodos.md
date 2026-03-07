# 4. Atributos y Métodos en C#

En el paradigma de **Programación Orientada a Objetos**, los **objetos** se caracterizan por poseer **estado** y comportamiento. Dentro de una clase, el estado se representa mediante **atributos**, mientras que el comportamiento se define a través de **métodos**.

En el lenguaje C#, los atributos y métodos constituyen los componentes fundamentales que permiten describir la estructura y funcionalidad de los objetos.

---

## 4.1 Atributos

Los **atributos** (también denominados campos) son variables definidas dentro de una clase que permiten almacenar la información asociada al estado de un objeto.

Cada objeto creado a partir de una clase posee su propio conjunto de atributos, cuyos valores pueden variar entre diferentes instancias de la misma clase.

Por ejemplo, si se modela una clase que representa estudiantes dentro de un sistema académico, algunos atributos podrían ser:

- nombre
- código
- edad
- programa académico

Estos atributos describen las características del objeto dentro del sistema.

Definición de atributos en una clase

El siguiente ejemplo muestra una clase que define los atributos de un estudiante.

```java
class Estudiante
{
    public string nombre;
    public int edad;
    public string codigo;
}

```

### 4.1.1 Características de los atributos

Los atributos presentan las siguientes características:

- Se declaran dentro de una clase
- Poseen un tipo de dato específico
- Almacenan información sobre el estado del objeto
- Pueden ser accedidos o modificados mediante métodos o propiedades

Desde el punto de vista del diseño orientado a objetos, los atributos deben representar **propiedades relevantes de la entidad que se está modelando.**

### 4.1.2 Visibilidad de los atributos

El acceso a los atributos puede controlarse mediante **modificadores de acceso**, los cuales determinan desde qué partes del programa pueden ser utilizados.

En **C#**, los modificadores más comunes son:

| Modificador | Descripción                                        |
| ----------- | -------------------------------------------------- |
| public      | accesible desde cualquier parte del programa       |
| private     | accesible únicamente dentro de la clase            |
| protected   | accesible dentro de la clase y en clases derivadas |
| internal    | accesible dentro del mismo ensamblado              |

En el diseño orientado a objetos se recomienda que los atributos sean **privados**, permitiendo su acceso únicamente a través de métodos o propiedades, con el fin de preservar el principio de **encapsulamiento**.

---

## 4.2 Métodos

Los métodos son funciones definidas dentro de una clase que describen las operaciones o acciones que pueden realizar los objetos.

Los métodos permiten manipular el estado de los objetos y ejecutar comportamientos asociados a la entidad que representa la clase.

En términos generales, un método está compuesto por:

- Un **modificador de acceso**
- Un **tipo de retorno**
- Un **nombre**
- Una **lista de parámetros**
- Un **bloque de instrucciones**

Los métodos pueden realizar diversas tareas, tales como:

- Modificar atributos
- Realizar cálculos
- Interactuar con otros objetos
- Generar resultados

Definición de un método

El siguiente ejemplo muestra un método que permite mostrar la información de un estudiante.

```c#
class Estudiante
{
    public string nombre;
    public int edad;

    public void MostrarInformacion()
    {
        Console.WriteLine("Nombre: " + nombre);
        Console.WriteLine("Edad: " + edad);
    }
}

```

---

## 4.3 Métodos de instancia

Los **métodos de instancia** son aquellos que operan sobre un objeto específico de una clase.

Estos métodos pueden acceder directamente a los atributos del objeto al que pertenecen, permitiendo modificar o consultar su estado.

Cada objeto puede ejecutar estos métodos de manera independiente, lo que permite que diferentes instancias de una misma clase tengan comportamientos basados en su propio estado.

Ejemplo: Uso de métodos de instancia

```c#
class Estudiante
{
    public string nombre;
    public int edad;

    public void Saludar()
    {
        Console.WriteLine("Hola, soy " + nombre);
    }
}

class Program
{
    static void Main()
    {
        Estudiante e1 = new Estudiante();

        e1.nombre = "Carlos";
        e1.edad = 21;

        e1.Saludar();
    }
}

```
En este caso, el objeto `e1` ejecuta el método `Saludar()`, el cual utiliza el valor almacenado en el atributo `nombre`.

---

## 4.4 Métodos estáticos

Además de los métodos de instancia, C# permite definir **métodos estáticos**, los cuales pertenecen a la clase en lugar de pertenecer a una instancia específica.

Los métodos estáticos se utilizan cuando la operación que se desea realizar no depende del **estado de un objeto**, sino que corresponde a una funcionalidad general asociada con la clase.

Este tipo de métodos puede invocarse directamente utilizando el nombre de la clase, sin necesidad de crear un objeto.

Ejemplo: Método estático

```c#
class Calculadora
{
    public static int Sumar(int a, int b)
    {
        return a + b;
    }
}

class Program
{
    static void Main()
    {
        int resultado = Calculadora.Sumar(5, 3);
        Console.WriteLine("Resultado: " + resultado);
    }
}
```
En este ejemplo, el método `Sumar()` se invoca directamente utilizando el nombre de la clase.

---

## 4.5 Parámetros y retorno de valores

Los métodos pueden recibir parámetros, los cuales representan datos de entrada que permiten modificar el comportamiento de la operación.

Asimismo, un método puede devolver un valor de retorno, que corresponde al resultado de la operación realizada.

Desde el punto de vista conceptual, los parámetros permiten establecer comunicación entre el programa y los métodos, mientras que los valores de retorno permiten obtener resultados del procesamiento realizado.

Ejemplo: Método con parámetros y valor de retorno

```
class Rectangulo
{
    public double baseRect;
    public double altura;

    public double CalcularArea()
    {
        return baseRect * altura;
    }
}

class Program
{
    static void Main()
    {
        Rectangulo r = new Rectangulo();

        r.baseRect = 5;
        r.altura = 4;

        double area = r.CalcularArea();

        Console.WriteLine("Área: " + area);
    }
}

```
En este ejemplo, el método `CalcularArea()` utiliza los atributos del objeto para calcular y retornar el área del rectángulo.

---

## 4.6 Relación entre atributos y métodos

Dentro de una clase, los atributos y los métodos se encuentran estrechamente relacionados.

Mientras que los atributos almacenan el estado del objeto, los métodos permiten:

- Consultar dicho estado
- Modificarlo
- Realizar operaciones basadas en sus valores

Este modelo constituye uno de los principios fundamentales de la programación orientada a objetos, ya que permite encapsular los datos junto con las operaciones que los manipulan.

Según Bertrand Meyer, esta integración entre datos y operaciones es uno de los elementos clave que diferencia la programación orientada a objetos de otros paradigmas de programación.

---

## 4.7 Buenas prácticas en el diseño de atributos y métodos

En el diseño orientado a objetos se recomienda seguir algunas prácticas que contribuyen a mejorar la calidad del software:

- Definir atributos que representen propiedades relevantes del dominio del problema
- Evitar la exposición directa de los atributos mediante acceso público
- Implementar métodos que representen comportamientos significativos del objeto
- Mantener una alta cohesión entre los atributos y métodos de una clase

Estas prácticas favorecen la construcción de sistemas más modulares, mantenibles y reutilizables.

---