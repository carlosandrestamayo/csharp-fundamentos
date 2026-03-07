# 1. Programación Orientada a Objetos

La Programación Orientada a Objetos (POO) es un paradigma de programación que propone estructurar el software mediante la definición e interacción de objetos, los cuales representan entidades con estado, comportamiento e identidad dentro de un sistema computacional.

Este paradigma surge como una evolución de los enfoques procedimentales tradicionales, con el objetivo de modelar sistemas complejos de manera más natural y modular, reflejando la estructura de los problemas del mundo real dentro del software.

En POO, los programas se construyen a partir de clases, que definen la estructura y el comportamiento de los objetos, y de objetos, que son instancias concretas de dichas clases.

---

## 1.1 Origen y evolución del paradigma

El paradigma orientado a objetos tiene sus raíces en el desarrollo del lenguaje **Simula** en la década de 1960, considerado el primer lenguaje que introdujo conceptos fundamentales como **clases y objetos**.

Posteriormente, estos conceptos fueron ampliados en lenguajes como **Smalltalk**, que consolidó el enfoque orientado a objetos como un modelo de programación completo.

En la actualidad, la POO constituye uno de los paradigmas dominantes en el desarrollo de software y es utilizada en lenguajes como **C#**, **Java**, **Python** y **C++**.

---

## 1.2 Concepto de objeto

Un objeto puede definirse como una entidad computacional que encapsula:

**Estado**: conjunto de valores almacenados en sus atributos.

**Comportamiento**: conjunto de operaciones o métodos que pueden actuar sobre su estado.

**Identidad**: característica que permite distinguir un objeto de otro, incluso si poseen los mismos valores en sus atributos.

Formalmente, un objeto puede representarse como una **estructura abstracta** compuesta por datos y operaciones asociadas a dichos datos.

Esta concepción permite representar entidades del dominio del problema dentro del sistema de software.

---

## 1.3 Concepto de clase

Una **clase** es una abstracción que define la estructura y el comportamiento común de un conjunto de objetos.

Desde el punto de vista conceptual, una clase especifica:

los **atributos** que describen el estado de los objetos

los **métodos** que determinan su comportamiento

las reglas de interacción entre los datos y las operaciones

En términos formales, una clase puede considerarse como un **tipo de dato abstracto** que permite crear múltiples instancias con la misma estructura lógica.

Las clases constituyen el mecanismo principal para **modelar entidades dentro de un sistema orientado a objetos.**

---

## 1.4 Principios fundamentales de la POO

La programación orientada a objetos se fundamenta en cuatro principios fundamentales:

### **Abstracción**

La abstracción consiste en identificar las características esenciales de una entidad y representar únicamente aquellas propiedades relevantes para el problema que se desea modelar.

Este proceso permite simplificar la complejidad de los sistemas al centrarse en los aspectos significativos de los objetos.

### Encapsulamiento

El encapsulamiento consiste en agrupar los datos y las operaciones que manipulan dichos datos dentro de una misma unidad estructural (la clase), restringiendo el acceso directo a los componentes internos.

Este principio promueve:

- protección de datos
- modularidad
- control del acceso a la información

### Herencia

La herencia es un mecanismo que permite definir nuevas clases a partir de clases existentes, reutilizando sus atributos y métodos.

Este mecanismo facilita:

- la reutilización de código
- la especialización de clases
- la organización jerárquica de modelos

### Polimorfismo

El polimorfismo se refiere a la capacidad de un mismo mensaje o método de adoptar diferentes comportamientos dependiendo del objeto que lo reciba.

Este principio permite diseñar sistemas más flexibles y extensibles.

---

## 1.5 Ventajas del paradigma orientado a objetos

El uso de la programación orientada a objetos aporta diversas ventajas en el desarrollo de software:

**Modularidad:** permite dividir sistemas complejos en componentes independientes.

**Reutilización de código:** facilita la creación de nuevas clases a partir de estructuras existentes.

**Mantenibilidad:** simplifica la modificación y evolución de sistemas.

**Modelado natural del dominio del problema:** permite representar entidades del mundo real dentro del software.

---

## 1.6 POO como modelo de diseño de software

Además de ser un paradigma de programación, la programación orientada a objetos constituye un enfoque metodológico para el diseño de sistemas de software.

En este contexto, el desarrollo orientado a objetos implica:

1. identificar las entidades del dominio del problema
2. definir las clases que representan dichas entidades
3. establecer las relaciones entre las clases
4. implementar el comportamiento mediante métodos

Este proceso suele apoyarse en herramientas de modelado como los diagramas de clases del **Unified Modeling Language**, ampliamente utilizados en ingeniería de software.

---