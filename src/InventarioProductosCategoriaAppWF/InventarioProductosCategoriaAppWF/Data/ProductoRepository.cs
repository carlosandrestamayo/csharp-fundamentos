using InventarioProductosCategoriaAppWF.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace InventarioProductosCategoriaAppWF.Data
{
    internal class ProductoRepository
    {
        // 📁 Archivo donde se guardan los productos
        private string ruta = "productos.txt";

        // 💾 Guardar producto
        public void Guardar(Producto producto)
        {
            using (StreamWriter writer = new StreamWriter(ruta, true))
            {
                writer.WriteLine(producto.ToString()); // guarda en formato texto
            }
        }

        // 📖 Obtener todos los productos
        public List<Producto> ObtenerTodos()
        {
            List<Producto> lista = new List<Producto>();

            // Si el archivo no existe, retorna lista vacía
            if (!File.Exists(ruta))
                return lista;

            using (StreamReader reader = new StreamReader(ruta))
            {
                string linea;

                // Leer línea por línea
                while ((linea = reader.ReadLine()) != null)
                {
                    // Convertir cada línea en objeto Producto
                    lista.Add(Producto.FromString(linea));
                }
            }

            return lista;
        }
    }
}
