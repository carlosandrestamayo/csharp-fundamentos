# 🧪 ComboBox en C# - Ejercicio Pedagógico (Windows Forms)

## 📌 Descripción

Este proyecto es una aplicación sencilla desarrollada en **C# con Windows Forms** que tiene como objetivo enseñar el uso del control **ComboBox** de manera práctica e interactiva.

El ejercicio demuestra cómo un ComboBox puede utilizarse no solo para mostrar opciones, sino como un **control que dirige la lógica del programa** mediante eventos.

---

## 🎯 Objetivo de aprendizaje

- Comprender el funcionamiento del **ComboBox**
- Manejar eventos, especialmente `SelectedIndexChanged`
- Utilizar propiedades como:
  - `Items`
  - `Text`
  - `SelectedItem`
- Aplicar métodos como:
  - `Items.Add()`
  - `Items.Clear()`
- Entender la interacción **usuario → evento → respuesta del sistema**

---

## ⚙️ ¿Qué hace el programa?

Al ejecutar la aplicación:

1. Se carga un **ComboBox** con varias opciones:
   - Mostrar cantidad  
   - Mostrar seleccionado  
   - Agregar elemento  
   - Limpiar lista  

2. Cuando el usuario selecciona una opción:

   - 🔢 **Mostrar cantidad**  
     → Muestra cuántos elementos tiene el ComboBox  

   - 📌 **Mostrar seleccionado**  
     → Muestra el elemento seleccionado  

   - ➕ **Agregar elemento**  
     → Añade un nuevo ítem al ComboBox  

   - 🧹 **Limpiar lista**  
     → Elimina todos los elementos  

3. Además, un botón permite mostrar el valor actual del ComboBox en un mensaje emergente.

---

## 🧠 Concepto clave

> 💡 *Este ejercicio convierte el ComboBox en un menú de decisiones que controla el comportamiento del programa.*

---

## 🖥️ Tecnologías utilizadas

- Lenguaje: **C#**
- Framework: **.NET (Windows Forms)**

---

## 📂 Estructura básica

- `Form1.cs` → Lógica principal del programa  
- `Form1.Designer.cs` → Diseño de la interfaz  
- `Program.cs` → Punto de entrada de la aplicación  

---