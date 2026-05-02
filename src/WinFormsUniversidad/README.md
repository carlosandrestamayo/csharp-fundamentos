# 🎓 WinForms Universidad - Sistema Básico de Gestión Académica

## 📌 Descripción

Este proyecto es una aplicación de escritorio desarrollada en **C# con Windows Forms** que permite gestionar información básica de una universidad.

El sistema implementa una arquitectura simple por capas:

- **View (Form)** → Interfaz gráfica  
- **Controller** → Lógica de aplicación  
- **Data (Repositorio)** → Persistencia en archivos JSON  
- **Model** → Entidades del sistema  

---

## 🚀 Funcionalidades

### 📘 Gestión de Materias
- Crear nuevas materias
- Listar materias registradas

### 👨‍🏫 Gestión de Profesores
- Crear profesores
- Asociar una materia a cada profesor
- Listar profesores

### 🎓 Gestión de Estudiantes
- Crear estudiantes
- Asociar múltiples materias mediante `CheckedListBox`
- Listar estudiantes

---

## 🧠 Conceptos implementados

Este proyecto integra:

- ✔ Programación orientada a objetos (POO)
- ✔ Manejo de listas (`List<T>`)
- ✔ Serialización y deserialización con JSON (`System.Text.Json`)
- ✔ Arquitectura por capas
- ✔ Uso de controles WinForms:
  - `TextBox`
  - `ComboBox`
  - `ListBox`
  - `CheckedListBox`
- ✔ Relaciones entre objetos (uno a muchos)

---

## 🗂️ Estructura del proyecto

WinFormsUniversidad/
│
├── Models/
│ ├── Materia.cs
│ ├── Profesor.cs
│ └── Estudiante.cs
│
├── Data/
│ ├── MateriaRepositorio.cs
│ ├── ProfesorRepositorio.cs
│ ├── JsonRepositorio.cs
│ └── EstudianteRepositorio.cs
│
├── Controllers/
│ ├── MateriaController.cs
│ ├── ProfesorController.cs
│ └── EstudianteController.cs
│
├── Views/
│ └── FormMain.cs
│
└── *.json

---

## 💾 Persistencia de datos

Los datos se almacenan en archivos JSON:

- `materia.json`
- `profesor.json`
- `estudiante.json`

### 📄 Ejemplo de estudiante almacenado

```json
{
  "id": "1",
  "nombre": "Carlos",
  "telefono": "123",
  "listaMaterias": [
    {
      "codigo": "MAT01",
      "nombre": "Matemáticas"
    }
  ]
}
```