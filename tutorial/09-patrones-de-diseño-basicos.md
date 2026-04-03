# Fundamentos de Ingeniería en C#  
## OOP Avanzado y Patrones de Diseño (Singleton y Factory)

---

## 📌 Introducción

En niveles avanzados de programación, no basta con que el código funcione.

👉 Se requiere:

- Buen diseño
- Bajo acoplamiento
- Alta cohesión
- Escalabilidad

Esto se logra mediante:
- Principios de Programación Orientada a Objetos (OOP)
- Patrones de diseño

---

# 🧠 OOP Avanzado

## 🔹 1. Abstracción

Permite trabajar con conceptos generales sin depender de implementaciones concretas.

```csharp
interface INotificacion
{
    void Enviar(string mensaje);
}
```

---

## 🔹 2. Encapsulamiento

Protege los datos internos de una clase.

```csharp
class Cuenta
{
    private double saldo;

    public void Depositar(double monto)
    {
        saldo += monto;
    }
}
```

---

## 🔹 3. Herencia

Permite reutilizar código entre clases.

```csharp
class Animal
{
    public void Comer() { }
}

class Perro : Animal
{
}
```

---

## 🔹 4. Polimorfismo

Permite que una misma interfaz tenga múltiples comportamientos.

```csharp
INotificacion n = new EmailNotificacion();
n.Enviar("Hola");
```

---

## 🎯 Idea clave

> OOP no es solo estructura, es diseño.

---

# 🏗️ Introducción a Patrones de Diseño

Los patrones de diseño son soluciones reutilizables a problemas comunes en software.

👉 No son código, son **formas de pensar**.

---

# 🧩 Patrón Singleton

## 📌 Definición

Garantiza que una clase tenga **una única instancia** y proporciona un punto de acceso global.

---

## 🎯 ¿Cuándo usarlo?

- Configuración del sistema
- Conexión a base de datos
- Logs

---

## ❌ Problema sin Singleton

```csharp
class Configuracion
{
    public string NombreApp = "MiApp";
}
```

👉 Se pueden crear múltiples instancias innecesarias.

---

## ✅ Implementación Singleton

```csharp
class Configuracion
{
    private static Configuracion instancia;

    private Configuracion() { }

    public static Configuracion ObtenerInstancia()
    {
        if (instancia == null)
        {
            instancia = new Configuracion();
        }
        return instancia;
    }

    public string NombreApp = "MiApp";
}
```

---

## 🔄 Uso

```csharp
Configuracion config1 = Configuracion.ObtenerInstancia();
Configuracion config2 = Configuracion.ObtenerInstancia();

Console.WriteLine(config1 == config2); // true
```

---

## 🧠 Idea clave

> Solo existe una instancia en todo el sistema.

---

# 🧩 Patrón Factory

## 📌 Definición

Permite crear objetos sin especificar la clase exacta que se va a instanciar.

---

## 🎯 ¿Cuándo usarlo?

- Cuando hay múltiples tipos de objetos
- Cuando quieres desacoplar la creación
- Cuando el sistema crece

---

## ❌ Problema sin Factory

```csharp
class Programa
{
    void Ejecutar()
    {
        EmailNotificacion email = new EmailNotificacion();
        email.Enviar("Hola");
    }
}
```

👉 Alto acoplamiento

---

## ✅ Implementación Factory

### Interfaz

```csharp
interface INotificacion
{
    void Enviar(string mensaje);
}
```

---

### Implementaciones

```csharp
class EmailNotificacion : INotificacion
{
    public void Enviar(string mensaje)
    {
        Console.WriteLine("Email: " + mensaje);
    }
}

class SmsNotificacion : INotificacion
{
    public void Enviar(string mensaje)
    {
        Console.WriteLine("SMS: " + mensaje);
    }
}
```

---

### Factory

```csharp
class NotificacionFactory
{
    public static INotificacion Crear(string tipo)
    {
        if (tipo == "email")
            return new EmailNotificacion();

        if (tipo == "sms")
            return new SmsNotificacion();

        throw new Exception("Tipo no válido");
    }
}
```

---

### Uso

```csharp
INotificacion notificacion = NotificacionFactory.Crear("email");
notificacion.Enviar("Hola mundo");
```

---

## 🧠 Mejora lograda

- Bajo acoplamiento
- Código extensible
- Separación de responsabilidades

---

# ⚠️ Comparación: Singleton vs Factory

| Patrón     | Propósito |
|------------|----------|
| Singleton  | Controlar una única instancia |
| Factory    | Crear objetos de forma flexible |

---

# 🎯 Buenas prácticas aplicadas

- Programar contra interfaces
- Separar creación de uso
- Evitar acoplamiento
- Reutilización de código

---

# 🧠 Conclusión

Los patrones de diseño permiten:

- Escribir código profesional
- Resolver problemas comunes
- Escalar sistemas correctamente

---

# 💡 Idea final

> Un buen ingeniero no solo programa, diseña soluciones.

---