## Taller: Calidad de Software  
## Código Limpio (Clean Code) y Técnicas de Refactorización

---

### Tema

- Código limpio (Clean Code)  
- Técnicas de refactorización  
- Mejora de calidad del software  

---

### Objetivos

Al finalizar este taller, el estudiante será capaz de:

- Identificar código mal estructurado  
- Aplicar principios de Clean Code  
- Refactorizar código existente  
- Justificar cambios realizados  
- Mejorar legibilidad y mantenibilidad  

---

## Instrucciones generales

Para cada ejercicio debes:

1. Analizar el código proporcionado  
2. Identificar problemas de calidad  
3. Refactorizar el código  
4. Escribir claramente:
   - Qué cambios realizaste  
   - Por qué los realizaste  

---

## Ejercicio 1: Nombres y legibilidad

### Enunciado

Analiza el siguiente código:

```csharp
class A
{
    public void f()
    {
        int x = 10;
        int y = 5;
        int z = x * y;

        Console.WriteLine(z);
    }
}
```

---

### Actividades

1. Identifica problemas de:
   - Nombres  
   - Legibilidad  

2. Refactoriza el código  

---

### Espacio para solución

```csharp

```

---

### Explicación obligatoria

```text
Cambios realizados:

Justificación:
```

---

## Ejercicio 2: Métodos con múltiples responsabilidades

### Enunciado

```csharp
class Sistema
{
    public void ProcesarPedido()
    {
        double precio = 100;
        int cantidad = 2;
        double total = precio * cantidad;

        if (total > 100)
        {
            total = total - (total * 0.1);
        }

        Console.WriteLine("Total: " + total);
    }
}
```

---

### Actividades

1. Identifica problemas de diseño  
2. Aplica:
   - Métodos pequeños  
   - Separación de responsabilidades  

---

### Espacio para solución

```csharp

```

---

### Explicación obligatoria

```text
Cambios realizados:

Justificación:
```

---

## Ejercicio 3: Código duplicado (DRY)

### Enunciado

```csharp
class Calculadora
{
    public void Calcular1()
    {
        int total = 10 * 2;
        Console.WriteLine(total);
    }

    public void Calcular2()
    {
        int total = 20 * 3;
        Console.WriteLine(total);
    }
}
```

---

### Actividades

1. Identifica duplicación de código  
2. Refactoriza aplicando DRY  

---

### Espacio para solución

```csharp

```

---

### Explicación obligatoria

```text
Cambios realizados:

Justificación:
```

---

## Ejercicio 4: Condicionales complejos

### Enunciado

```csharp
class Descuento
{
    public double Calcular(double total, string tipo)
    {
        if (tipo == "normal")
        {
            return total;
        }
        else if (tipo == "vip")
        {
            return total * 0.8;
        }
        else if (tipo == "premium")
        {
            return total * 0.7;
        }

        return total;
    }
}
```

---

### Actividades

1. Identifica problemas de:
   - Uso de condicionales  
   - Escalabilidad  

2. Refactoriza usando:
   - Clases  
   - Polimorfismo  

---

### Espacio para solución

```csharp

```

---

### Explicación obligatoria

```text
Cambios realizados:

Justificación:
```

---

## Ejercicio 5: Código poco expresivo

### Enunciado

```csharp
class Proceso
{
    public void Ejecutar()
    {
        int a = 5;
        int b = 10;

        if (a < b)
        {
            Console.WriteLine("ok");
        }
    }
}
```

---

### Actividades

1. Mejora:
   - Nombres  
   - Intención del código  

---

### Espacio para solución

```csharp

```

---

### Explicación obligatoria

```text
Cambios realizados:

Justificación:
```

---

## Criterios de evaluación

- Claridad del código refactorizado  
- Aplicación de principios de Clean Code  
- Eliminación de duplicación  
- Uso adecuado de métodos  
- Calidad de la justificación  

---

## Reglas importantes

- No cambiar la funcionalidad del programa  
- Solo mejorar la calidad del código  
- Explicar cada decisión tomada  

---

## Idea final

Un buen programador no solo escribe código que funciona, sino código que puede mantenerse y entenderse con facilidad.

---