# Diagramas de Clase y Relaciones entre Clases (UML)

---

## 📌 ¿Qué es un diagrama de clase?

Un **diagrama de clase** es una representación gráfica utilizada en UML (Lenguaje de Modelado Unificado) que permite visualizar:

- Clases
- Atributos
- Métodos
- Relaciones entre clases

👉 Es una herramienta fundamental para diseñar software antes de programar.

---

## 🎯 ¿Para qué sirve?

- Entender la estructura del sistema
- Diseñar soluciones antes de codificar
- Comunicar ideas entre desarrolladores
- Detectar errores de diseño

---

# 🧩 Estructura de una clase en UML

Una clase se representa en tres partes:

```
+----------------------+
| NombreClase          |
+----------------------+
| - atributo1: tipo    |
| - atributo2: tipo    |
+----------------------+
| + metodo(): tipo     |
+----------------------+
```

---

## 🔐 Visibilidad

| Símbolo | Significado |
|--------|------------|
| `+`    | public     |
| `-`    | private    |
| `#`    | protected  |

---

# 🧠 Ejemplo

```
+----------------------+
| Persona              |
+----------------------+
| - nombre: string     |
| - edad: int          |
+----------------------+
| + Saludar(): void    |
+----------------------+
```

---

# 🔗 Relaciones entre clases

Las relaciones permiten conectar clases y modelar el comportamiento del sistema.

---

## 🔹 1. Asociación

### 📌 Definición

Relación donde una clase usa o conoce a otra.

---

### Ejemplo

Un `Estudiante` pertenece a un `Curso`.

```
Estudiante -------- Curso
```

---

### En C#

```csharp
class Curso { }

class Estudiante
{
    public Curso curso;
}
```

---

## 🔹 2. Agregación

### 📌 Definición

Relación "tiene un", pero las clases pueden existir por separado.

---

### Ejemplo

Un `Equipo` tiene `Jugadores`, pero los jugadores pueden existir sin el equipo.

```
Equipo ◇------ Jugador
```

---

### En C#

```csharp
class Jugador { }

class Equipo
{
    public List<Jugador> jugadores;
}
```

---

## 🔹 3. Composición

### 📌 Definición

Relación fuerte donde una clase depende totalmente de otra.

👉 Si la clase principal se elimina, las otras también.

---

### Ejemplo

Una `Casa` tiene `Habitaciones`.

```
Casa ◆------ Habitacion
```

---

### En C#

```csharp
class Habitacion { }

class Casa
{
    private List<Habitacion> habitaciones = new List<Habitacion>();
}
```

---

## 🔹 4. Herencia

### 📌 Definición

Relación "es un".

---

### Ejemplo

`Perro` es un `Animal`.

```
Perro ------|> Animal
```

---

### En C#

```csharp
class Animal { }

class Perro : Animal { }
```

---

## 🔹 5. Dependencia

### 📌 Definición

Una clase usa temporalmente otra.

---

### Ejemplo

Un `Servicio` usa un `Logger`.

```
Servicio ---> Logger
```

---

### En C#

```csharp
class Logger
{
    public void Log(string mensaje) { }
}

class Servicio
{
    public void Ejecutar(Logger logger)
    {
        logger.Log("Ejecutando");
    }
}
```

---

# 📊 Resumen de relaciones

| Relación     | Tipo          | Ejemplo              |
|-------------|--------------|---------------------|
| Asociación  | Uso general  | Estudiante-Curso    |
| Agregación  | Tiene (débil)| Equipo-Jugador      |
| Composición | Tiene (fuerte)| Casa-Habitación    |
| Herencia    | Es un        | Perro-Animal        |
| Dependencia | Uso temporal | Servicio-Logger     |

---

# 🧠 Buenas prácticas

- No abusar de la herencia
- Preferir composición sobre herencia
- Mantener bajo acoplamiento
- Usar relaciones claras
- Diseñar antes de programar

---

# 🎯 Ejemplo integrador

Sistema académico:

- `Persona`
- `Estudiante`
- `Curso`
- `Profesor`

Relaciones:

- Herencia: Estudiante → Persona
- Asociación: Estudiante → Curso
- Dependencia: Profesor → Curso

---

# 💡 Idea final

> Un buen diagrama evita muchos errores antes de escribir una sola línea de código.

---

# 🧩 Diagramas UML Completos + Código en C#

---

# 🔹 1. Asociación

## 📌 Diagrama UML

```
+----------------------+
|       Curso          |
+----------------------+
| -Nombre: string      |
+----------------------+
| +GetNombre(): string |
+----------------------+

        ▲
        |
        |
+--------------------------+
|       Estudiante         |
+--------------------------+
| -Nombre: string          |
| -Curso: Curso            |
+--------------------------+
| +Inscribirse(c: Curso)   |
+--------------------------+
```

---

## 💻 Código

```csharp
class Curso
{
    public string Nombre { get; set; }

    public string GetNombre()
    {
        return Nombre;
    }
}

class Estudiante
{
    public string Nombre { get; set; }
    public Curso Curso { get; set; }

    public void Inscribirse(Curso c)
    {
        Curso = c;
    }
}
```

---

# 🔹 2. Agregación

## 📌 Diagrama UML

```
+---------------------------+
|        Jugador            |
+---------------------------+
| -Nombre: string           |
+---------------------------+
| +GetNombre(): string      |
+---------------------------+

        ◇
        |
        |
+------------------------------+
|           Equipo             |
+------------------------------+
| -Jugadores: List<Jugador>    |
+------------------------------+
| +AgregarJugador(j: Jugador)  |
+------------------------------+
```

---

## 💻 Código

```csharp
class Jugador
{
    public string Nombre { get; set; }

    public string GetNombre()
    {
        return Nombre;
    }
}

class Equipo
{
    public List<Jugador> Jugadores { get; set; }

    public Equipo()
    {
        Jugadores = new List<Jugador>();
    }

    public void AgregarJugador(Jugador j)
    {
        Jugadores.Add(j);
    }
}
```

---

# 🔹 3. Composición

## 📌 Diagrama UML

```
+---------------------------+
|       Habitacion          |
+---------------------------+
| -Tipo: string             |
+---------------------------+
| +GetTipo(): string        |
+---------------------------+

        ◆
        |
        |
+----------------------------------+
|            Casa                  |
+----------------------------------+
| -Habitaciones: List<Habitacion>  |
+----------------------------------+
| +AgregarHabitacion(tipo: string) |
+----------------------------------+
```

---

## 💻 Código

```csharp
class Habitacion
{
    public string Tipo { get; set; }

    public string GetTipo()
    {
        return Tipo;
    }
}

class Casa
{
    private List<Habitacion> habitaciones;

    public Casa()
    {
        habitaciones = new List<Habitacion>();
    }

    public void AgregarHabitacion(string tipo)
    {
        habitaciones.Add(new Habitacion { Tipo = tipo });
    }
}
```

---

# 🔹 4. Herencia

## 📌 Diagrama UML

```
+---------------------------+
|        Animal             |
+---------------------------+
| -Nombre: string           |
+---------------------------+
| +Comer(): void            |
+---------------------------+
            ▲
            |
+---------------------------+
|         Perro             |
+---------------------------+
|                           |
+---------------------------+
| +Ladrar(): void           |
+---------------------------+
```

---

## 💻 Código

```csharp
class Animal
{
    public string Nombre { get; set; }

    public void Comer()
    {
        Console.WriteLine("El animal come");
    }
}

class Perro : Animal
{
    public void Ladrar()
    {
        Console.WriteLine("El perro ladra");
    }
}
```

---

# 🔹 5. Dependencia

## 📌 Diagrama UML

```
+-----------------------------+
|            Logger           |
+-----------------------------+
|                             |
+-----------------------------+
| +Log(mensaje: string): void |
+-----------------------------+

        <----------
        (usa)
+-------------------------------+
|           Servicio            |
+-------------------------------+
|                               |
+-------------------------------+
| +Ejecutar(l: Logger): void    |
+-------------------------------+
```

---

## 💻 Código

```csharp
class Logger
{
    public void Log(string mensaje)
    {
        Console.WriteLine(mensaje);
    }
}

class Servicio
{
    public void Ejecutar(Logger l)
    {
        l.Log("Ejecutando servicio");
    }
}
```

---

# 🚀 Ejemplo Integrador (Completo)

## 📌 Diagrama UML

```
+---------------------------+
|        Persona            |
+---------------------------+
| -Nombre: string           |
+---------------------------+
| +GetNombre(): string      |
+---------------------------+
            ▲
            |
+---------------------------+
|       Estudiante          |
+---------------------------+
| -Curso: Curso             |
+---------------------------+
| +Inscribirse(c: Curso)    |
+---------------------------+

+-------------------------------+
|             Curso             |
+-------------------------------+
| -Nombre: string               |
| -Estudiantes: List<Estudiante>|
+-------------------------------+
| +AgregarEstudiante(e)         |
+-------------------------------+

+---------------------------+
|         Silla             |
+---------------------------+
| -Numero: int              |
+---------------------------+
| +GetNumero(): int         |
+---------------------------+

        ◆
        |
+---------------------------+
|          Aula             |
+---------------------------+
| -Sillas: List<Silla>      |
+---------------------------+
| +CrearSillas(): void      |
+---------------------------+

+---------------------------+
|        Profesor           |
+---------------------------+
|                           |
+---------------------------+
| +DictarClase(c: Curso)    |
+---------------------------+
```

---

## 💻 Código

```csharp
class Persona
{
    public string Nombre { get; set; }

    public string GetNombre()
    {
        return Nombre;
    }
}

class Estudiante : Persona
{
    public Curso Curso { get; set; }

    public void Inscribirse(Curso c)
    {
        Curso = c;
    }
}

class Curso
{
    public string Nombre { get; set; }
    public List<Estudiante> Estudiantes { get; set; }

    public Curso()
    {
        Estudiantes = new List<Estudiante>();
    }

    public void AgregarEstudiante(Estudiante e)
    {
        Estudiantes.Add(e);
    }
}

class Silla
{
    public int Numero { get; set; }

    public int GetNumero()
    {
        return Numero;
    }
}

class Aula
{
    private List<Silla> sillas;

    public Aula()
    {
        sillas = new List<Silla>();
        CrearSillas();
    }

    public void CrearSillas()
    {
        for (int i = 1; i <= 5; i++)
        {
            sillas.Add(new Silla { Numero = i });
        }
    }
}

class Profesor
{
    public void DictarClase(Curso c)
    {
        Console.WriteLine("Dictando " + c.Nombre);
    }
}
```

---

# 🎯 Conclusión

- UML completo = atributos + métodos + relaciones  
- Cada relación tiene un significado distinto  
- El diagrama debe reflejar exactamente el código  

---

# 💡 Idea final

> Un buen ingeniero no empieza programando, empieza modelando.

---