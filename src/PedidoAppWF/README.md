# 🧪 CheckBox y RadioButton en C# - Ejercicio Pedagógico (Windows Forms)

## 📌 Descripción

Este proyecto es una aplicación desarrollada en **C# con Windows Forms** que tiene como objetivo enseñar el uso de los controles **CheckBox** y **RadioButton** de manera práctica e interactiva.

El ejercicio demuestra cómo estos controles permiten gestionar decisiones del usuario y cómo el programa responde automáticamente mediante eventos, sin necesidad de botones.

---

## 🎯 Objetivo de aprendizaje

- Comprender el funcionamiento de **CheckBox** y **RadioButton**
- Manejar eventos, especialmente `CheckedChanged`
- Aplicar lógica condicional (`if`)
- Diferenciar entre:
  - Selección única (RadioButton)
  - Selección múltiple (CheckBox)
- Entender la interacción **usuario → evento → respuesta del sistema**

---

## ⚙️ ¿Qué hace el programa?

Al ejecutar la aplicación:

1. El usuario selecciona un tamaño (RadioButton):
   - Pequeño ($10.000)  
   - Mediano ($15.000)  
   - Grande ($20.000)  

2. Puede agregar extras (CheckBox):
   - Queso (+$2.000)  
   - Tocineta (+$3.000)  
   - Papas (+$4.000)  

3. Cada vez que el usuario cambia una selección:

   👉 El sistema recalcula automáticamente el total  

4. El resultado se muestra en tiempo real en un Label.

---

## 🧠 Concepto clave

> 💡 *RadioButton permite una sola selección dentro de un grupo*  
> 💡 *CheckBox permite múltiples selecciones simultáneas*  
> 💡 *El programa reacciona automáticamente mediante eventos*

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

## 🚀 Cómo funciona internamente

- Todos los controles (`RadioButton` y `CheckBox`) están conectados al mismo método:
  
  `CalcularTotal(object sender, EventArgs e)`

  
- Este método:
1. Evalúa qué opciones están seleccionadas  
2. Calcula el total  
3. Actualiza el resultado en pantalla  

---

## 📚 Uso educativo

Este proyecto está diseñado para:

- Estudiantes que inician en interfaces gráficas
- Comprender programación orientada a eventos
- Clases prácticas de lógica condicional en C#

---

## 🔥 Posibles mejoras

- Validar que el usuario seleccione un tamaño  
- Mostrar desglose del pedido  
- Guardar resultados en archivo (`.json`)  
- Implementar clases (`Pedido`)  
- Migrar a arquitectura más estructurada  

---
