# Buenas Prácticas de Desarrollo en C#

## 📌 Introducción

Las buenas prácticas de desarrollo son un conjunto de principios y recomendaciones que permiten escribir código:

- Claro
- Mantenible
- Escalable
- Reutilizable

👉 No se trata solo de que el programa funcione, sino de que esté bien diseñado.

---

## 🧠 Principio fundamental

> El código se escribe una vez, pero se lee muchas veces.

---

# 🧩 1. Nombres significativos

Los nombres deben describir claramente su propósito.

### ❌ Incorrecto

```csharp
int x;
void f() { }
```

### ✅ Correcto

```csharp
int edadUsuario;
void CalcularSalario() { }
```

---

## 📌 Reglas

- Usar nombres descriptivos
- Evitar abreviaciones innecesarias
- Seguir convenciones de C#

---

# 🧩 2. Métodos pequeños

Un método debe hacer una sola cosa.

### ❌ Incorrecto

```csharp
void Procesar()
{
    // valida
    // calcula
    // guarda
    // imprime
}
```

### ✅ Correcto

```csharp
void Procesar()
{
    Validar();
    Calcular();
    Guardar();
    Imprimir();
}
```

---

## 📌 Regla

> Si un método hace muchas cosas, divídelo.

---

# 🧩 3. Evitar duplicación (DRY)

DRY = *Don't Repeat Yourself*

### ❌ Incorrecto

```csharp
int total1 = precio * cantidad;
int total2 = precio * cantidad;
```

### ✅ Correcto

```csharp
int CalcularTotal(int precio, int cantidad)
{
    return precio * cantidad;
}
```

---

## 📌 Regla

> Si repites código, crea una función.

---

# 🧩 4. Encapsulamiento

Los atributos deben ser privados y accederse mediante métodos.

### ❌ Incorrecto

```csharp
public double saldo;
```

### ✅ Correcto

```csharp
private double saldo;

public double GetSaldo()
{
    return saldo;
}
```

---

## 📌 Regla

> Protege los datos internos de la clase.

---

# 🧩 5. Bajo acoplamiento

Las clases deben depender lo menos posible entre sí.

### ❌ Incorrecto

```csharp
class Carro
{
    Motor motor = new Motor();
}
```

### ✅ Correcto

```csharp
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

## 📌 Regla

> Usa interfaces para reducir dependencias.

---

# 🧩 6. Alta cohesión

Una clase debe tener responsabilidades relacionadas.

### ❌ Incorrecto

```csharp
class Sistema
{
    void Calcular() { }
    void EnviarCorreo() { }
    void Imprimir() { }
}
```

### ✅ Correcto

```csharp
class Calculadora { }
class ServicioEmail { }
class Impresora { }
```

---

## 📌 Regla

> Agrupa lo que está relacionado.

---

# 🧩 7. Uso adecuado de comentarios

Los comentarios deben explicar el "por qué", no el "qué".

### ❌ Incorrecto

```csharp
// suma dos números
int suma = a + b;
```

### ✅ Correcto

```csharp
// Se usa este cálculo para aplicar el descuento del cliente VIP
```

---

## 📌 Regla

> El código debe ser autoexplicativo.

---

# 🧩 8. Validación de datos

Siempre validar entradas.

### ❌ Incorrecto

```csharp
saldo -= monto;
```

### ✅ Correcto

```csharp
if (monto > saldo)
{
    throw new Exception("Saldo insuficiente");
}
```

---

## 📌 Regla

> Nunca confíes en los datos de entrada.

---

# 🧩 9. Manejo de errores

Usar excepciones correctamente.

```csharp
try
{
    // código
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
```

---

## 📌 Regla

> Maneja errores de forma controlada.

---

# 🧩 10. Código legible

Un buen código debe poder leerse como si fuera texto.

### Ejemplo

```csharp
if (usuario.Edad >= 18)
{
    PermitirAcceso();
}
```

---

## 📌 Regla

> Si cuesta leerlo, está mal escrito.

---

# 🧩 11. Consistencia

Mantener un estilo uniforme en todo el código.

- Nombres
- Identación
- Estructura

---

## 📌 Regla

> El código debe verse uniforme.

---

# 🧩 12. Separación de responsabilidades

Evitar clases que hagan demasiado.

---

## 📌 Regla

> Divide el sistema en partes claras.

---

# 🎯 Conclusión

Aplicar buenas prácticas permite:

- Reducir errores
- Facilitar mantenimiento
- Mejorar el trabajo en equipo
- Crear software profesional

---

# 💡 Idea final

> Programar no es solo hacer que funcione, es hacer que sea entendible, mantenible y escalable.

---

# 🧩 Ejercicio Resuelto: Buenas Prácticas en C# (Paso a paso)

## 📌 Contexto

Se desea desarrollar un sistema simple para calcular el total de una compra y mostrar el resultado.

---

# ❌ Paso 1: Código inicial (mal diseñado)

```csharp
class Programa
{
    public void Procesar()
    {
        double p = 100;
        int c = 2;
        double t = p * c;

        if (t > 100)
        {
            t = t - (t * 0.1);
        }

        Console.WriteLine("Total: " + t);
    }
}
```

---

## ⚠️ Problemas detectados

- Nombres poco claros (`p`, `c`, `t`)
- Método hace demasiadas cosas
- Lógica mezclada (cálculo + impresión)
- No reutilizable
- No escalable

---

# 🧠 Paso 2: Mejorar nombres

```csharp
double precio = 100;
int cantidad = 2;
double total = precio * cantidad;
```

---

## ✅ Mejora lograda

- Código más legible
- Intención clara

---

# 🧠 Paso 3: Extraer método (responsabilidad única)

```csharp
double CalcularTotal(double precio, int cantidad)
{
    return precio * cantidad;
}
```

---

## Uso

```csharp
double total = CalcularTotal(precio, cantidad);
```

---

## ✅ Mejora lograda

- Método reutilizable
- Separación de lógica

---

# 🧠 Paso 4: Aplicar DRY (evitar duplicación)

Extraemos el descuento:

```csharp
double AplicarDescuento(double total)
{
    if (total > 100)
    {
        return total - (total * 0.1);
    }
    return total;
}
```

---

## Uso

```csharp
total = AplicarDescuento(total);
```

---

## ✅ Mejora lograda

- Lógica separada
- Fácil de modificar

---

# 🧠 Paso 5: Separar responsabilidades

```csharp
void MostrarTotal(double total)
{
    Console.WriteLine("Total: " + total);
}
```

---

## Uso completo

```csharp
double total = CalcularTotal(precio, cantidad);
total = AplicarDescuento(total);
MostrarTotal(total);
```

---

## ✅ Mejora lograda

- Cada método hace una sola cosa

---

# 🧠 Paso 6: Encapsular en una clase

```csharp
class CalculadoraCompra
{
    public double CalcularTotal(double precio, int cantidad)
    {
        return precio * cantidad;
    }

    public double AplicarDescuento(double total)
    {
        if (total > 100)
        {
            return total - (total * 0.1);
        }
        return total;
    }

    public void MostrarTotal(double total)
    {
        Console.WriteLine("Total: " + total);
    }
}
```

---

# 🧠 Paso 7: Uso final (limpio y profesional)

```csharp
class Program
{
    static void Main()
    {
        CalculadoraCompra calculadora = new CalculadoraCompra();

        double total = calculadora.CalcularTotal(100, 2);
        total = calculadora.AplicarDescuento(total);

        calculadora.MostrarTotal(total);
    }
}
```

---

# 🎯 Resultado final

✔ Código legible  
✔ Métodos pequeños  
✔ Separación de responsabilidades  
✔ Reutilizable  
✔ Fácil de mantener  

---

# 🧠 Comparación

## Antes ❌

- Código desordenado
- Difícil de entender
- Todo en un solo método

## Después ✅

- Código modular
- Claro
- Escalable

---

# 💡 Buenas prácticas aplicadas

- Nombres significativos
- Métodos pequeños
- DRY
- Encapsulamiento
- Separación de responsabilidades

---

# 🚀 Idea clave final

> El código limpio no se escribe de una vez, se construye paso a paso.

---