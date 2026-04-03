## Taller: Arquitectura, SOLID y Buenas Prácticas en C#

---

### Tema

- Principios SOLID
- Buenas prácticas de desarrollo
- Diseño orientado a objetos

---

### Objetivos

Al finalizar este taller, el estudiante será capaz de:

- Identificar problemas de diseño en código
- Aplicar principios SOLID
- Mejorar la estructura de un sistema
- Reducir el acoplamiento
- Diseñar código limpio y mantenible

---

## Ejercicio 1: Análisis de código (Detección de errores)

### Enunciado

Analiza el siguiente código:

```csharp
class Notificador
{
    public void Enviar(string tipo, string mensaje)
    {
        if (tipo == "email")
        {
            Console.WriteLine("Email: " + mensaje);
        }
        else if (tipo == "sms")
        {
            Console.WriteLine("SMS: " + mensaje);
        }
        else if (tipo == "whatsapp")
        {
            Console.WriteLine("WhatsApp: " + mensaje);
        }
    }
}
```

---

### Actividades

1. Identifica al menos 3 problemas de diseño  
2. Indica qué principios SOLID se están violando  
3. Explica por qué este código es difícil de mantener  

---

### Pistas

- ¿Qué pasa si agregamos otro tipo?
- ¿Se está modificando código existente?
- ¿Hay acoplamiento?

---

## Ejercicio 2: Refactorización con SOLID

### Enunciado

Reestructura el código anterior aplicando:

- Open/Closed Principle  
- Dependency Inversion Principle  

---

### Requisitos

- Crear una interfaz  
- Crear al menos 2 implementaciones  
- Modificar la clase principal  
- Evitar uso de `if` o `switch`  

---


## Ejercicio 3: Buenas prácticas

### Enunciado

Analiza el siguiente código:

```csharp
class Sistema
{
    public void Ejecutar()
    {
        double x = 100;
        double y = 2;
        double z = x * y;

        if (z > 100)
        {
            z = z - (z * 0.1);
        }

        Console.WriteLine(z);
    }
}
```

---

### Actividades

1. Identifica problemas de buenas prácticas  
2. Mejora:
   - Nombres  
   - Estructura  
   - Responsabilidades  
3. Divide el código en métodos  

---

## Ejercicio 4: Diseño (Nivel ingeniería)

### Enunciado

Diseña un sistema de pagos que soporte:

- Pago con tarjeta  
- Pago en efectivo  
- Pago con transferencia  

---

### Requisitos

1. Aplicar principios SOLID  
2. Usar interfaces  
3. Permitir agregar nuevos métodos de pago sin modificar código existente  
4. Implementar al menos 3 clases  

---

### Preguntas clave

- ¿Dónde usarías interfaces?  
- ¿Cómo evitarías condicionales?  
- ¿Cómo harías el sistema escalable?  

---

## Ejercicio 5: Análisis conceptual

### Enunciado

Responde:

1. ¿Qué es bajo acoplamiento?  
2. ¿Qué es alta cohesión?  
3. ¿Por qué es importante programar contra interfaces?  
4. ¿Qué principio SOLID consideras más importante y por qué?  

---

## Criterios de evaluación

- Aplicación correcta de SOLID  
- Claridad en el diseño  
- Uso de buenas prácticas  
- Capacidad de análisis  
- Código limpio y estructurado  

---

## Reto adicional

Diseña un sistema de notificaciones que:

- Soporte múltiples canales  
- Sea extensible  
- No requiera modificar código existente  

---

## Idea final

El verdadero nivel de un programador no se mide por lo que escribe, sino por cómo diseña.

---