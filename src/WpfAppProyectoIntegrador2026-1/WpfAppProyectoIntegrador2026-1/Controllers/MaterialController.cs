using System;
using System.Collections.Generic;
using System.Text;
using WpfAppProyectoIntegrador2026_1.Models;
using WpfAppProyectoIntegrador2026_1.Repositorys;

namespace WpfAppProyectoIntegrador2026_1.Controllers
{
    class MaterialController
    {
        private MaterialRepository materialRepository;

        public MaterialController()
        {
            materialRepository = new MaterialRepository();
        }

        // LISTAR
        public List<Material> ObtenerMateriales()
        {
            return materialRepository.Leer();
        }

        // AGREGAR
        public void AgregarMaterial(Material material)
        {
            materialRepository.Agregar(material);
        }

        // EDITAR
        public void EditarMaterial(Material material)
        {
            //repository.Editar(cliente, cliente.Id);
        }

        // ELIMINAR
        public void EliminarMaterial(Guid id)
        {
            //repository.Eliminar(id);
        }

        // BUSCAR
        public Material? BuscarMaterial(Guid id)
        {
            return null;
            //return repository.Buscar(id);
        }
    }
}
