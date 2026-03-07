## 3. Objetos e Instanciación en C#

En el paradigma de **Programación Orientada a Objetos**, los **objetos** representan las entidades concretas que interactúan dentro de un sistema de software. Mientras que una clase define la estructura y el comportamiento general, un objeto corresponde a una instancia específica creada a partir de dicha clase.

En el lenguaje C#, los **objetos** constituyen instancias de clases que se crean dinámicamente durante la ejecución del programa y que contienen tanto estado (datos) como comportamiento (métodos).

---

# 3.1 Concepto de objeto

Un objeto puede definirse como una entidad computacional que encapsula un conjunto de datos y operaciones asociadas a dichos datos.

De acuerdo con Grady Booch, un objeto se caracteriza por tres propiedades fundamentales:

### Estado

El estado de un objeto está determinado por los valores actuales de sus atributos. Estos valores pueden cambiar a lo largo del tiempo mediante la ejecución de métodos que modifican dichos datos.

Por ejemplo, si se modela un objeto que representa una cuenta bancaria, su estado podría estar determinado por atributos como:

- número de cuenta
- titular
- saldo

### Comportamiento

El comportamiento de un objeto está definido por el conjunto de operaciones o métodos que pueden ejecutarse sobre él.

Estos métodos permiten:

modificar el estado del objeto

realizar cálculos

interactuar con otros objetos dentro del sistema

Siguiendo el ejemplo de una cuenta bancaria, el objeto podría incluir métodos como:

- depositar dinero
- retirar dinero
- consultar saldo

### Identidad

La identidad es la propiedad que permite distinguir un objeto de otro, incluso cuando ambos contienen valores idénticos en sus atributos.

En los sistemas orientados a objetos, cada objeto ocupa una posición única en la memoria del sistema, lo que permite diferenciar instancias independientes de una misma clase.

---

## 3.2 Instanciación de objetos

La instanciación es el proceso mediante el cual se crea un objeto a partir de una clase. Durante este proceso, el sistema reserva espacio en memoria para almacenar los atributos del objeto y genera una referencia que permite acceder a dicho objeto.

En C#, la instanciación se realiza mediante el operador new, el cual crea una nueva instancia de la clase especificada.

Desde el punto de vista conceptual, la instanciación implica:

1. Reservar memoria para el objeto
2. Inicializar sus atributos
3. Devolver una referencia al objeto creado

Este mecanismo permite que una misma clase genere múltiples objetos independientes durante la ejecución del programa.

---

## 3.3 Objetos como tipos de referencia

En C#, las clases pertenecen a la categoría de **tipos de referencia**. Esto significa que las variables que almacenan objetos no contienen directamente los datos del objeto, sino una referencia a la dirección de memoria donde se encuentra almacenado.

Este modelo tiene varias implicaciones importantes:

múltiples variables pueden referenciar el mismo objeto

las modificaciones realizadas a través de una referencia afectan al mismo objeto en memoria

la memoria ocupada por los objetos es administrada automáticamente por el recolector de basura del sistema

El manejo automático de la memoria en **C#** se realiza mediante el **Garbage Collector**, el cual forma parte del entorno de ejecución del lenguaje .NET.

---

## 3.4 Ciclo de vida de un objeto

El ciclo de vida de un objeto dentro de un programa orientado a objetos puede describirse en varias etapas:

### Creación

El objeto es creado mediante el proceso de instanciación, normalmente utilizando el operador new.

### Inicialización

Durante la inicialización, los atributos del objeto reciben valores iniciales, generalmente mediante constructores.

### Uso

El objeto es utilizado por el programa mediante la invocación de sus métodos o la consulta de sus atributos.

### Destrucción

Cuando un objeto deja de ser accesible desde el programa, el sistema puede liberar la memoria que ocupa mediante el proceso de recolección de basura.

---

## 3.5 Relación entre clases y objetos

La relación entre clases y objetos puede entenderse como una relación entre **modelo** e **instancia**.

| Concepto  | Descripción                                    |
| --------- | ---------------------------------------------- |
| Clase     | definición abstracta de una entidad            |
| Objeto    | instancia concreta creada a partir de la clase |
| Atributos | variables que representan el estado del objeto |
| Métodos   | operaciones que definen su comportamiento      |

Una misma clase puede generar múltiples objetos independientes, cada uno con su propio estado.

Por ejemplo, una clase que represente estudiantes puede utilizarse para crear múltiples objetos, cada uno representando a un estudiante distinto dentro de un sistema académico.

---

## 3.6 Modelado orientado a objetos

En el proceso de diseño de software orientado a objetos, los objetos representan las entidades fundamentales del sistema. El modelado orientado a objetos consiste en identificar estas entidades y definir sus características y relaciones.

Este proceso suele apoyarse en herramientas de modelado como los diagramas de clases del **Unified Modeling Language**, los cuales permiten representar gráficamente:

- clases
- atributos
- métodos
- relaciones entre objetos

El modelado orientado a objetos constituye una etapa esencial en el desarrollo de software, ya que permite transformar los requisitos del sistema en una estructura conceptual que posteriormente puede implementarse en un lenguaje de programación.

---