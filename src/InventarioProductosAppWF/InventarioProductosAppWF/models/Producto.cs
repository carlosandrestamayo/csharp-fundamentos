using System;
using System.Collections.Generic;
using System.Text;

namespace InventarioProductosAppWF.models
{
    internal class Producto
    {
        // 🔒 Atributos privados
        private string codigo;
        private string nombre;
        private int cantidad;
        private double precio;

        // 🏗️ Constructor vacío
        public Producto() { }

        // 🏗️ Constructor con parámetros
        public Producto(string codigo, string nombre, int cantidad, double precio)
        {
            this.SetCodigo(codigo);
            this.SetNombre(nombre);
            this.SetCantidad(cantidad);
            this.SetPrecio(precio);
        }

        // 🔓 GET
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

        // 🔐 SET con validaciones

        public void SetCodigo(string codigo)
        {
            if (string.IsNullOrWhiteSpace(codigo))
            {
                throw new Exception("El código no puede estar vacío");
            }
            this.codigo = codigo;
        }

        public void SetNombre(string nombre)
        {
            if (string.IsNullOrWhiteSpace(nombre))
            {
                throw new Exception("El nombre no puede estar vacío");
            }
            this.nombre = nombre;
        }

        public void SetCantidad(int cantidad)
        {
            if (cantidad < 0)
            {
                throw new Exception("La cantidad no puede ser negativa");
            }
            this.cantidad = cantidad;
        }

        public void SetPrecio(double precio)
        {
            if (precio < 0)
            {
                throw new Exception("El precio no puede ser negativo");
            }
            this.precio = precio;
        }

        // 📄 Convertir a texto (archivo plano)
        public override string ToString()
        {
            return this.codigo + ";" + this.nombre + ";" + this.cantidad + ";" + this.precio;
        }

        // 📥 Convertir desde texto
        public static Producto FromString(string linea)
        {
            string[] datos = linea.Split(';');

            Producto producto = new Producto();
            producto.SetCodigo(datos[0]);
            producto.SetNombre(datos[1]);
            producto.SetCantidad(int.Parse(datos[2]));
            producto.SetPrecio(double.Parse(datos[3]));

            return producto;
        }
    }
}
