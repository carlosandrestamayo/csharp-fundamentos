using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using WpfAppProyectoIntegrador2026_1.Models;

namespace WpfAppProyectoIntegrador2026_1.Repositorys
{
    class MaterialRepository
    {
        private static readonly string folder = "Data";
        private static readonly string filePath = Path.Combine(folder, "material.json");

        JsonRepository<Material> jsonRepository = new JsonRepository<Material>(folder, filePath);

        public List<Material> Leer()
        {
            return jsonRepository.Leer();
        }


        public void Agregar(Material material)
        {
            List<Material> lista = jsonRepository.Leer();

            lista.Add(material);

            jsonRepository.Guardar(lista);
        }

        public void Editar(Material nuevoMaterial, string codigo)
        {
            //jsonRepository.Editar(nuevaMaterial, m => m.codigo == codigo);

        }

        public Material? Buscar(string codigo)
        {
            return null;
            //return jsonRepository.Buscar(m => m.codigo == codigo);
        }
    }
}
