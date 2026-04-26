using InventarioProductosAppWF.data;
using InventarioProductosAppWF.models;
using System;
using System.Collections.Generic;
using System.Text;

namespace InventarioProductosAppWF.controllers
{
    internal class ProductoController
    {
        private ProductoRepository repository = new ProductoRepository();

        public void Guardar(Producto producto)
        {
            // Validar código duplicado
            var lista = repository.ObtenerTodos();

            if (lista.Any(p => p.GetCodigo() == producto.GetCodigo()))
            {
                throw new System.Exception("El código ya existe");
            }

            repository.Guardar(producto);
        }

        public List<Producto> ListarOrdenado()
        {
            return repository.ObtenerTodos()
                .OrderBy(p => p.GetNombre())
                .ToList();
        }

        public void Editar(Producto producto)
        {
            var lista = repository.ObtenerTodos();

            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i].GetCodigo() == producto.GetCodigo())
                {
                    lista[i] = producto;
                    break;
                }
            }

            using (StreamWriter writer = new StreamWriter("productos.txt", false))
            {
                foreach (var p in lista)
                {
                    writer.WriteLine(p.ToString());
                }
            }
        }
    }
}
