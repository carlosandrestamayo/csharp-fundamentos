using InventarioProductosAppWF.models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.Generic;
using System.IO;

namespace InventarioProductosAppWF.data
{
    internal class ProductoRepository
    {
        private string ruta = "productos.txt";

        public void Guardar(Producto producto)
        {
            using (StreamWriter writer = new StreamWriter(ruta, true))
            {
                writer.WriteLine(producto.ToString());
            }
        }

        public List<Producto> ObtenerTodos()
        {
            List<Producto> lista = new List<Producto>();

            if (!File.Exists(ruta))
                return lista;

            using (StreamReader reader = new StreamReader(ruta))
            {
                string linea;
                while ((linea = reader.ReadLine()) != null)
                {
                    lista.Add(Producto.FromString(linea));
                }
            }

            return lista;
        }
    }
}
