using InventarioProductosCategoriaAppWF.Data;
using InventarioProductosCategoriaAppWF.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace InventarioProductosCategoriaAppWF.Controllers
{
    internal class CategoriaController
    {
        // 🔗 Conecta con el repositorio
        private CategoriaRepository repository = new CategoriaRepository();

        // ➕ Guarda una categoría con validación
        public void Guardar(Categoria categoria)
        {
            var lista = repository.ObtenerTodas();

            // Validar que no exista una categoría con el mismo nombre
            if (lista.Any(c => c.GetNombre().ToLower() == categoria.GetNombre().ToLower()))
            {
                throw new System.Exception("La categoría ya existe");
            }

            // Si pasa la validación, guarda
            repository.Guardar(categoria);
        }

        // Lista todas las categorías
        public List<Categoria> Listar()
        {
            return repository.ObtenerTodas();
        }
    }
}
