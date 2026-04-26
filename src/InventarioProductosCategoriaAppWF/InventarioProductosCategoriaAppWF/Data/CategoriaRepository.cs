using InventarioProductosCategoriaAppWF.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace InventarioProductosCategoriaAppWF.Data
{
    internal class CategoriaRepository
    {
        // 📁 Ruta del archivo donde se guardan las categorías
        private string ruta = "categorias.txt";

        // 💾 Guarda una categoría en el archivo
        public void Guardar(Categoria categoria)
        {
            // true → modo append (no borra lo anterior)
            using (StreamWriter writer = new StreamWriter(ruta, true))
            {
                writer.WriteLine(categoria.ToString()); // Guarda como texto
            }
        }

        // 📖 Lee todas las categorías del archivo
        public List<Categoria> ObtenerTodas()
        {
            List<Categoria> lista = new List<Categoria>();

            // Si el archivo no existe, retorna lista vacía
            if (!File.Exists(ruta))
                return lista;

            using (StreamReader reader = new StreamReader(ruta))
            {
                string linea;

                // Lee línea por línea
                while ((linea = reader.ReadLine()) != null)
                {
                    // Convierte cada línea en objeto Categoria
                    lista.Add(Categoria.FromString(linea));
                }
            }

            return lista;
        }
    }
}
