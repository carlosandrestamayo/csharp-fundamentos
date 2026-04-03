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