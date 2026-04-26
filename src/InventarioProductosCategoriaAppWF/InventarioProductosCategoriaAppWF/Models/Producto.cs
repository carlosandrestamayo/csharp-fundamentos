using System;
using System.Collections.Generic;
using System.Text;

namespace InventarioProductosCategoriaAppWF.Models
{
    internal class Producto
    {
        // 🔒 Atributos privados
        private string codigo;
        private string nombre;
        private int cantidad;
        private double precio;

        // 🔗 Asociación: un producto tiene una categoría
        private Categoria categoria;

        // 🏗️ Constructor vacío
        public Producto() { }

        // 🏗️ Constructor con parámetros
        public Producto(string codigo, string nombre, int cantidad, double precio, Categoria categoria)
        {
            // Se usan los SET para validar
            this.SetCodigo(codigo);
            this.SetNombre(nombre);
            this.SetCantidad(cantidad);
            this.SetPrecio(precio);

            this.categoria = categoria; // Asigna la categoría
        }

        public string GetCodigo()
        {
            return this.codigo;
        }

        public string GetNombre()
        {
            return this.nombre;
        }

        public int GetCantidad()
        {
            return this.cantidad;
        }

        public double GetPrecio()
        {
            return this.precio;
        }

        public Categoria GetCategoria()
        {
            return this.categoria;
        }

        // 🔐 SET con validaciones

        public void SetCodigo(string codigo)
        {
            if (string.IsNullOrWhiteSpace(codigo))
                throw new Exception("El código no puede estar vacío");

            this.codigo = codigo;
        }

        public void SetNombre(string nombre)
        {
            if (string.IsNullOrWhiteSpace(nombre))
                throw new Exception("El nombre no puede estar vacío");

            this.nombre = nombre;
        }

        public void SetCantidad(int cantidad)
        {
            if (cantidad < 0)
                throw new Exception("La cantidad no puede ser negativa");

            this.cantidad = cantidad;
        }

        public void SetPrecio(double precio)
        {
            if (precio < 0)
                throw new Exception("El precio no puede ser negativo");

            this.precio = precio;
        }

        // 📄 Convertir el objeto a texto para guardar en archivo
        // Formato: codigo;nombre;cantidad;precio;idCategoria;nombreCategoria
        public override string ToString()
        {
            return this.codigo + ";" +
                   this.nombre + ";" +
                   this.cantidad + ";" +
                   this.precio + ";" +
                   this.categoria.GetId() + ";" +
                   this.categoria.GetNombre();
        }

        // 📥 Convertir texto en objeto Producto
        public static Producto FromString(string linea)
        {
            // Divide la línea usando ;
            string[] datos = linea.Split(';');

            // 🔹 Reconstruir la categoría
            Categoria categoria = new Categoria(
                int.Parse(datos[4]), // id
                datos[5]             // nombre
            );

            // 🔹 Crear el producto con todos los datos
            Producto producto = new Producto(
                datos[0],                 // codigo
                datos[1],                 // nombre
                int.Parse(datos[2]),      // cantidad
                double.Parse(datos[3]),   // precio
                categoria                // objeto categoria
            );

            return producto;
        }

    }
}
