# 📦 InventarioProductosCategoriasAppWF

Aplicación de escritorio desarrollada en C# con Windows Forms, que implementa un sistema de gestión de productos y categorías utilizando arquitectura MVC y persistencia en archivos planos.

---

## 🎯 Descripción

Este proyecto permite administrar un inventario básico de productos, donde cada producto pertenece a una categoría.  
Está diseñado con fines educativos para aplicar conceptos de:

- Programación Orientada a Objetos (POO)
- Arquitectura MVC
- Manejo de archivos con StreamReader y StreamWriter
- Validaciones de datos
- Interfaces gráficas con Windows Forms

---

## 🧱 Arquitectura del proyecto

El sistema está organizado bajo el patrón MVC:

- Models → Entidades (Producto, Categoria)
- Data → Acceso a datos (archivos .txt)
- Controllers → Lógica del sistema
- Views → Interfaz gráfica (Forms)


---

## ⚙️ Funcionalidades

### 📦 Productos
- Agregar productos
- Editar productos
- Listar productos ordenados alfabéticamente
- Validar datos (campos obligatorios, valores no negativos)
- Asociación con categorías

### 🏷️ Categorías
- Crear categorías
- Listar categorías
- Evitar duplicados
- Persistencia en archivo plano

---

## 🔗 Relación entre clases

- Un Producto pertenece a una Categoria
- Implementación mediante asociación en el modelo

---

## 💾 Persistencia de datos

El sistema utiliza archivos planos:

- productos.txt
- categorias.txt

Formato de almacenamiento:

- Producto:
> codigo;nombre;cantidad;precio;idCategoria;nombreCategoria

- Categoria:
> id;nombre


---

## 🖥️ Interfaz de usuario

### FormMain
- Gestión de productos
- Selección de categoría mediante ComboBox
- Listado en ListBox

### FormCategoria
- Creación y listado de categorías

---

## 🚀 Cómo ejecutar el proyecto

1. Clonar el repositorio:

git clone [https://github.com/tu_usuario/InventarioProductosApp.git](https://github.com/carlosandrestamayo/csharp-fundamentos/tree/main/src/InventarioProductosCategoriaAppWF)

2. Abrir el archivo:

📋 InventarioProductosSolution.sln


3. Ejecutar en Visual Studio (F5)

---

## 📚 Tecnologías utilizadas

- C#
- .NET
- Windows Forms
- Arquitectura MVC
- System.IO

---

## 🎓 Objetivo académico

Este proyecto está orientado a estudiantes que desean:

- Comprender la separación de responsabilidades
- Implementar persistencia sin base de datos
- Modelar relaciones entre clases
- Construir aplicaciones de escritorio funcionales

---

## 🔮 Posibles mejoras

- Validación avanzada de datos (TryParse)
- Eliminación de productos y categorías
- Uso de DataGridView
- Migración a base de datos (SQL Server)
- Versión web (React + FastAPI)

---

## 📌 Nota

Este proyecto puede ser usado como base para prácticas, talleres o evaluaciones en cursos de programación.

