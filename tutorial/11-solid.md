# Arquitectura y Principios SOLID en C#

## 📌 ¿Qué es la arquitectura de software?

La arquitectura de software es la forma en que se organiza y estructura un sistema para que sea:

- Escalable
- Mantenible
- Comprensible
- Reutilizable

---

## ⚠️ Problema común en estudiantes

Muchos programas:

- Funcionan correctamente
- Pero están mal diseñados

Esto genera:

- Dificultad para modificar el código
- Errores frecuentes
- Baja reutilización

---

## 🧠 Buenas prácticas básicas

Antes de aplicar SOLID, es importante:

- Crear métodos pequeños
- Usar nombres claros
- Evitar duplicación de código (DRY)
- Separar responsabilidades

---

# 📦 Principios SOLID

SOLID es un conjunto de principios que ayudan a escribir código limpio, flexible y mantenible.

---

## S — Single Responsibility Principle (SRP)

### 📌 Definición

Una clase debe tener una sola responsabilidad.

---

### ❌ Ejemplo incorrecto

```csharp
class Reporte
{
    public void GenerarReporte() { }
    public void GuardarEnArchivo() { }
    public void EnviarPorCorreo() { }
}
```

👉 Problema:
- Hace demasiadas cosas

---

### ✅ Solución

```csharp
class Reporte
{
    public void Generar() { }
}

class ReporteArchivo
{
    public void Guardar() { }
}

class ReporteEmail
{
    public void Enviar() { }
}
```

---

### 🧠 Regla

> Una clase = una responsabilidad

---

## O — Open/Closed Principle (OCP)

### 📌 Definición

El código debe estar abierto a extensión pero cerrado a modificación.

---

### ❌ Ejemplo incorrecto

```csharp
class Calculadora
{
    public double Calcular(string tipo)
    {
        if (tipo == "suma") return 1 + 1;
        if (tipo == "resta") return 2 - 1;
        return 0;
    }
}
```

---

### ✅ Solución

```csharp
interface IOperacion
{
    double Calcular();
}

class Suma : IOperacion
{
    public double Calcular() => 1 + 1;
}

class Resta : IOperacion
{
    public double Calcular() => 2 - 1;
}
```
### Clase Calculadora desacoplada

```csharp
class Calculadora
{
    public double Calcular(IOperacion operacion)
    {
        return operacion.Calcular();
    }
}
```
### Uso
```csharp
class Program
{
    static void Main(string[] args)
    {
        var calculadora = new Calculadora();

        double resultado1 = calculadora.Calcular(new Suma());
        double resultado2 = calculadora.Calcular(new Resta());

        Console.WriteLine(resultado1);
        Console.WriteLine(resultado2);
    }
}
```
---

### 🧠 Regla

> No modificar código existente, extenderlo

---

## L — Liskov Substitution Principle (LSP)

### 📌 Definición

Las subclases deben poder reemplazar a la clase base sin romper el programa.

---

### ❌ Ejemplo incorrecto

```csharp
class Ave
{
    public virtual void Volar() { }
}

class Pinguino : Ave
{
    public override void Volar()
    {
        throw new Exception("No puede volar");
    }
}
```

---

### ✅ Solución

```csharp
class Ave { }

interface IVolador
{
    void Volar();
}

class Aguila : Ave, IVolador
{
    public void Volar() { }
}

class Pinguino : Ave
{
}
```

---

### 🧠 Regla

> No obligues a una clase a hacer algo que no puede

---

## I — Interface Segregation Principle (ISP)

### 📌 Definición

Es mejor tener muchas interfaces pequeñas que una grande.

---

### ❌ Ejemplo incorrecto

```csharp
interface ITrabajador
{
    void Trabajar();
    void Comer();
}
```

---

### ✅ Solución

```csharp
interface ITrabajador
{
    void Trabajar();
}

interface IComedor
{
    void Comer();
}
```

---

### 🧠 Regla

> No obligues a implementar lo que no se usa

---

## D — Dependency Inversion Principle (DIP)

### 📌 Definición

Las clases deben depender de abstracciones, no de implementaciones concretas.

---

### ❌ Ejemplo incorrecto

```csharp
class Motor
{
    public void Encender() { }
}

class Carro
{
    private Motor motor = new Motor();
}
```

---

### ✅ Solución

```csharp
interface IMotor
{
    void Encender();
}

class Motor : IMotor
{
    public void Encender() { }
}

class Carro
{
    private IMotor motor;

    public Carro(IMotor motor)
    {
        this.motor = motor;
    }
}
```

---

### 🧠 Regla

> Depende de interfaces, no de clases concretas

---

## 🎯 Conclusión

Los principios SOLID permiten:

- Reducir el acoplamiento
- Mejorar la escalabilidad
- Facilitar el mantenimiento
- Escribir código profesional

---

## 💡 Idea final

> El código que funciona no siempre es buen código.  
> El buen código está bien diseñado.

---

# 🧩 Ejercicio Resuelto: Aplicando SOLID paso a paso (C#)

## 📌 Contexto

Vamos a construir un sistema de notificaciones.

El sistema debe enviar mensajes por:
- Correo
- SMS

---

# ❌ Paso 1: Diseño incorrecto (Código inicial)

```csharp
class Notificador
{
    public void Enviar(string tipo, string mensaje)
    {
        if (tipo == "email")
        {
            Console.WriteLine("Enviando email: " + mensaje);
        }
        else if (tipo == "sms")
        {
            Console.WriteLine("Enviando SMS: " + mensaje);
        }
    }
}
```

---

## ⚠️ Problemas detectados

- Viola **OCP** (hay que modificar la clase para agregar otro tipo)
- Alto acoplamiento
- Difícil de escalar
- No reutilizable

---

# 🧠 Paso 2: Aplicando OCP (Open/Closed Principle)

👉 Creamos una interfaz

```csharp
interface INotificacion
{
    void Enviar(string mensaje);
}
```

---

## Implementaciones

```csharp
class EmailNotificacion : INotificacion
{
    public void Enviar(string mensaje)
    {
        Console.WriteLine("Enviando email: " + mensaje);
    }
}

class SmsNotificacion : INotificacion
{
    public void Enviar(string mensaje)
    {
        Console.WriteLine("Enviando SMS: " + mensaje);
    }
}
```

---

## Nueva clase Notificador

```csharp
class Notificador
{
    public void Enviar(INotificacion notificacion, string mensaje)
    {
        notificacion.Enviar(mensaje);
    }
}
```

---

## ✅ Mejora lograda

- No modificamos código existente
- Solo agregamos nuevas clases

---

# 🧠 Paso 3: Aplicando DIP (Dependency Inversion Principle)

👉 Inyección de dependencias

```csharp
class Notificador
{
    private readonly INotificacion _notificacion;

    public Notificador(INotificacion notificacion)
    {
        _notificacion = notificacion;
    }

    public void Enviar(string mensaje)
    {
        _notificacion.Enviar(mensaje);
    }
}
```

---

## Uso en el programa principal

```csharp
class Program
{
    static void Main()
    {
        INotificacion servicio = new EmailNotificacion();
        Notificador notificador = new Notificador(servicio);

        notificador.Enviar("Hola mundo");
    }
}
```

---

## ✅ Mejora lograda

- Bajo acoplamiento
- Mayor flexibilidad
- Fácil de probar

---

# 🧠 Paso 4: Aplicando SRP (Single Responsibility Principle)

👉 Separar responsabilidades

Ahora cada clase tiene un rol claro:

- `EmailNotificacion` → enviar email
- `SmsNotificacion` → enviar SMS
- `Notificador` → coordinar envío

---

## ✅ Resultado

Cada clase tiene una única responsabilidad.

---

# 🧠 Paso 5: Aplicando ISP (Interface Segregation Principle)

En este caso, la interfaz ya es pequeña y específica:

```csharp
interface INotificacion
{
    void Enviar(string mensaje);
}
```

👉 No hay necesidad de dividirla.

---

# 🧠 Paso 6: Aplicando LSP (Liskov Substitution Principle)

Todas las implementaciones pueden sustituirse:

```csharp
INotificacion servicio = new SmsNotificacion();
```

👉 El sistema sigue funcionando correctamente.

---

# 🚀 Paso 7: Extensión del sistema (SIN modificar código)

Agregamos un nuevo tipo:

```csharp
class WhatsAppNotificacion : INotificacion
{
    public void Enviar(string mensaje)
    {
        Console.WriteLine("Enviando WhatsApp: " + mensaje);
    }
}
```

---

## Uso

```csharp
INotificacion servicio = new WhatsAppNotificacion();
Notificador notificador = new Notificador(servicio);

notificador.Enviar("Nuevo mensaje");
```

---

## 🎯 Resultado final

✔ Sistema flexible  
✔ Escalable  
✔ Bajo acoplamiento  
✔ Cumple SOLID  

---

# 🧠 Conclusión

Pasamos de:

❌ Código rígido y difícil de mantener  

A:

✅ Código limpio, extensible y profesional  

---

# 💡 Idea clave final

> SOLID no es teoría, es una forma de transformar código malo en buen diseño.

---
