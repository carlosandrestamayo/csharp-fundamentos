using InventarioProductosCategoriaAppWF.Data;
using InventarioProductosCategoriaAppWF.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace InventarioProductosCategoriaAppWF.Controllers
{
    internal class ProductoController
    {
        // 🔗 Conexión con el repositorio
        private ProductoRepository repository = new ProductoRepository();

        // ➕ Guardar producto con validación
        public void Guardar(Producto producto)
        {
            var lista = repository.ObtenerTodos();

            // 🔍 Validar que no exista el mismo código
            if (lista.Any(p => p.GetCodigo() == producto.GetCodigo()))
            {
                throw new System.Exception("El código ya existe");
            }

            repository.Guardar(producto);
        }

        // 📋 Listar productos ordenados por nombre
        public List<Producto> ListarOrdenado()
        {
            return repository.ObtenerTodos()
                .OrderBy(p => p.GetNombre())
                .ToList();
        }

        // ✏️ Editar producto
        public void Editar(Producto productoActualizado)
        {
            List<Producto> lista = repository.ObtenerTodos();

            // Buscar por código y reemplazar
            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i].GetCodigo() == productoActualizado.GetCodigo())
                {
                    lista[i] = productoActualizado;
                    break;
                }
            }

            // 🔄 Sobrescribir archivo completo
            using (StreamWriter writer = new StreamWriter("productos.txt", false))
            {
                foreach (Producto producto in lista)
                {
                    writer.WriteLine(producto.ToString());
                }
            }
        }
    }
}
